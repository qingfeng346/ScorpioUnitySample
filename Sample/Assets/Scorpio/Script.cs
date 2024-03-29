using System;
using System.IO;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using Scorpio.Instruction;
using Scorpio.Exception;
using Scorpio.Function;
using Scorpio.Library;
using Scorpio.Runtime;
using Scorpio.Proto;
using Scorpio.Userdata;
using Scorpio.Serialize;
using Scorpio.Tools;
using Scorpio.Compile.Compiler;
namespace Scorpio {
    public partial class Script {
        /// <summary> 反射获取变量和函数的属性 </summary>
        public const BindingFlags BindingFlag = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
        private const string GLOBAL_NAME = "_G";                        //全局对象
        private const string GLOBAL_SCRIPT = "_SCRIPT";                 //Script对象
        private const string GLOBAL_VERSION = "_VERSION";               //版本号
        private const string GLOBAL_ARGS = "_ARGS";                     //命令行参数
        /// <summary> 按文本读取时,文本文件的编码 </summary>
        public static Encoding Encoding { get; set; } = Encoding.UTF8;


        /// <summary> request文件的搜索路径集合 </summary>
        private string[] m_SearchPaths;
        public string[] SearchPaths => m_SearchPaths;
        /// <summary> 所有类型的基类 </summary>
        public ScriptType TypeObject { get; private set; }
        public ScriptValue TypeObjectValue { get; private set; }

        /// <summary> 所有基础类型数据 </summary>
        private ScriptType m_TypeBool, m_TypeNumber, m_TypeString, m_TypeArray, m_TypeMap, m_TypeFunction, m_TypeStringBuilder, m_TypeHashSet;
        private ScriptValue m_TypeValueBool, m_TypeValueNumber, m_TypeValueString, m_TypeValueArray, m_TypeValueMap, m_TypeValueFunction, m_TypeValueStringBuilder, m_TypeValueHashSet;
        /// <summary> bool类型的原表 </summary>
        public ScriptType TypeBoolean => m_TypeBool;
        public ScriptValue TypeBooleanValue => m_TypeValueBool;

        /// <summary> number类型的原表 </summary>
        public ScriptType TypeNumber => m_TypeNumber;
        public ScriptValue TypeNumberValue => m_TypeValueNumber;

        /// <summary> string类型的原表 </summary>
        public ScriptType TypeString => m_TypeString;
        public ScriptValue TypeStringValue => m_TypeValueString;

        /// <summary> array类型的原表 </summary>
        public ScriptType TypeArray => m_TypeArray;
        public ScriptValue TypeArrayValue => m_TypeValueArray;

        /// <summary> map类型的原表 </summary>
        public ScriptType TypeMap => m_TypeMap;
        public ScriptValue TypeMapValue => m_TypeValueMap;

        /// <summary>  </summary>
        public ScriptType TypeHashSet => m_TypeHashSet;
        public ScriptValue TypeHashSetValue => m_TypeValueHashSet;

        /// <summary> function类型的原表 </summary>
        public ScriptType TypeFunction => m_TypeFunction;
        public ScriptValue TypeFunctionValue => m_TypeValueFunction;

        /// <summary> stringBuilder类型的原表 </summary>
        public ScriptType TypeStringBuilder => m_TypeStringBuilder;
        public ScriptValue TypeStringBuilderValue => m_TypeValueStringBuilder;

        /// <summary> 全局变量 </summary>
        public ScriptGlobal Global { get; private set; }

        public int MainThreadId { get; private set; }

        public Script() {
            m_SearchPaths = new string[0];
            Global = new ScriptGlobal();
            
            TypeObject = new ScriptTypeObject(this, "Object");
            TypeObjectValue = new ScriptValue(TypeObject);
            Global.SetValue(TypeObject.TypeName, TypeObjectValue);

            AddPrimitivePrototype("Bool", ref m_TypeBool, ref m_TypeValueBool);
            AddPrimitivePrototype("Number", ref m_TypeNumber, ref m_TypeValueNumber);
            AddPrimitivePrototype("String", ref m_TypeString, ref m_TypeValueString);
            AddPrimitivePrototype("Function", ref m_TypeFunction, ref m_TypeValueFunction);

            AddBasicPrototype(m_TypeArray = new ScriptTypeBasicArray(this, "Array", TypeObject), ref m_TypeValueArray);
            AddBasicPrototype(m_TypeMap = new ScriptTypeBasicMap(this, "Map", TypeObject), ref m_TypeValueMap);
            AddBasicPrototype(m_TypeStringBuilder = new ScriptTypeBasicStringBuilder(this, "StringBuilder", TypeObject), ref m_TypeValueStringBuilder);
            AddBasicPrototype(m_TypeHashSet = new ScriptTypeBasicHashSet(this, "HashSet", TypeObject), ref m_TypeValueHashSet);

            Global.SetValue(GLOBAL_NAME, new ScriptValue(Global));
            Global.SetValue(GLOBAL_SCRIPT, ScriptValue.CreateValue(this));
            Global.SetValue(GLOBAL_VERSION, ScriptValue.CreateValue(typeof(Version)));

            ProtoObject.Load(this, TypeObject);
            ProtoBoolean.Load(this, TypeBoolean);
            ProtoNumber.Load(this, TypeNumber);
            ProtoString.Load(this, TypeString);
            ProtoArray.Load(this, TypeArray);
            ProtoMap.Load(this, TypeMap);
            ProtoFunction.Load(this, TypeFunction);
            ProtoStringBuilder.Load(this, TypeStringBuilder);
            ProtoHashSet.Load(this, TypeHashSet);

            TypeManager.PushAssembly(typeof(object).Assembly);                        //mscorlib.dll
            TypeManager.PushAssembly(typeof(System.Net.Sockets.Socket).Assembly);     //System.dll
            TypeManager.PushAssembly(GetType().Assembly);                             //当前所在的程序集

            LibraryBasis.Load(this);
            LibraryJson.Load(this);
            LibraryMath.Load(this);
            LibraryUserdata.Load(this);
            LibraryIO.Load(this);
            LibraryCoroutine.Load(this);
            MainThreadId = System.Threading.Thread.CurrentThread.ManagedThreadId;
        }
        public void Shutdown() {
            Global.Shutdown();
            TypeObject = m_TypeBool = m_TypeNumber = m_TypeString = m_TypeArray = m_TypeMap = m_TypeFunction = m_TypeStringBuilder = null;
            TypeObjectValue = m_TypeValueBool = m_TypeValueNumber = m_TypeValueString = m_TypeValueArray = m_TypeValueMap = m_TypeValueFunction = m_TypeValueStringBuilder = default;
        }
        void AddPrimitivePrototype(string name, ref ScriptType type, ref ScriptValue typeValue) {
            type = new ScriptTypePrimitive(name, TypeObject);
            typeValue = new ScriptValue(type);
            Global.SetValue(name, typeValue);
        }
        void AddBasicPrototype(ScriptType type, ref ScriptValue typeValue) {
            typeValue = new ScriptValue(type);
            Global.SetValue(type.TypeName, typeValue);
        }
        /// <summary> 压入一个搜索路径,使用 require 时会搜索此路径 </summary>
        /// <param name="path">绝对路径</param>
        public void PushSearchPath(string path) {
            if (!Array.Exists(m_SearchPaths, _ => _ == path)) {
                Array.Resize(ref m_SearchPaths, m_SearchPaths.Length + 1);
                m_SearchPaths[m_SearchPaths.Length - 1] = path;
            }
        }
        public string SearchFile(string fileName) {
            if (File.Exists(fileName)) { 
                return fileName;
            }
            for (int i = 0; i < m_SearchPaths.Length; ++i) {
                string file = Path.Combine(m_SearchPaths[i], fileName);
                if (File.Exists(file)) {
                    return file;
                }
            }
            return null;
        }
        /// <summary> 设置一个全局变量 </summary>
        /// <param name="key">名字</param>
        /// <param name="value">值</param>
        public void SetGlobal(string key, ScriptValue value) {
            Global.SetValue(key, value);
        }
        /// <summary> 获得一个全局变量 </summary>
        /// <param name="key">名字</param>
        /// <returns>值</returns>
        public ScriptValue GetGlobal(string key) {
            return Global.GetValue(key);
        }
        /// <summary> 是否包含一个全局变量 </summary>
        /// <param name="key">名字</param>
        /// <returns>是否包含</returns>
        public bool HasGlobal(string key) {
            return Global.HasValue(key);
        }
        public void SetArgs(string[] args) {
            var array = CreateArray();
            for (var i = 0; i < args.Length; ++i) {
                array.Add(new ScriptValue(args[i]));
            }
            Global.SetValue(GLOBAL_ARGS, new ScriptValue(array));
        }
        /// <summary> 创建一个空的array </summary>
        public ScriptArray CreateArray() { return new ScriptArray(this); }
        /// <summary> 创建一个空的map </summary>
        public ScriptMap CreateMap() { return new ScriptMapObject(this); }
        /// <summary> 创建一个类 </summary>
        /// <param name="typeName">类名</param>
        /// <param name="parentType">类数据</param>
        public ScriptType CreateType(string typeName, ScriptType parentType) { return new ScriptType(typeName, parentType); }
        /// <summary> 创建一个Function </summary>
        /// <param name="value">ScorpioHandle</param>
        public ScriptValue CreateFunction(ScorpioHandle value) { return new ScriptValue(new ScriptHandleFunction(this, value)); }
        /// <summary> 创建一个 Instance </summary>
        public ScriptInstance CreateInstance() { return new ScriptInstance(ObjectType.Type, TypeObject); }
        /// <summary> 调用一个全局函数 </summary>
        /// <param name="name">函数名</param>
        /// <param name="args">参数</param>
        /// <returns>函数返回值</returns>
        public ScriptValue call(string name, params object[] args) {
            return Global.GetValue(name).call(ScriptValue.Null, args);
        }
        /// <summary> 调用一个全局函数 </summary>
        /// <param name="name">函数名</param>
        /// <param name="args">参数</param>
        /// <param name="length">参数个数</param>
        /// <returns>函数返回值</returns>
        public ScriptValue Call(string name, ScriptValue[] args, int length) {
            return Global.GetValue(name).Call(ScriptValue.Null, args, length);
        }

        /// <summary> 使用字符串方式加载文件 </summary>
        public ScriptValue LoadFileByString(string fileName) {
            return LoadFileByString(fileName, null);
        }
        /// <summary> 使用字符串方式加载文件 </summary>
        public ScriptValue LoadFileByString(string fileName, CompileOption compileOption) {
            var fullFileName = SearchFile(fileName);
            if (fullFileName == null) {
                throw new System.Exception($"can't found file : {fileName}");
            }
            using (var stream = File.OpenRead(fullFileName)) {
                return LoadStreamByString(fileName, stream, (int)stream.Length, compileOption);
            }
        }
        /// <summary> 使用字节码方式加载文件 </summary>
        public ScriptValue LoadFileByIL(string fileName) {
            var fullFileName = SearchFile(fileName);
            if (fullFileName == null) {
                throw new System.Exception($"can't found file : {fileName}");
            }
            using (var stream = File.OpenRead(fullFileName)) {
                return LoadStreamByIL(stream);
            }
        }
        /// <summary> 使用字符串方式二进制 </summary>
        public ScriptValue LoadBufferByString(string breviary, byte[] buffer) {
            return LoadBufferByString(breviary, buffer, 0, buffer.Length, null);
        }
        /// <summary> 使用字符串方式二进制 </summary>
        public ScriptValue LoadBufferByString(string breviary, byte[] buffer, CompileOption compileOption) {
            return LoadBufferByString(breviary, buffer, 0, buffer.Length, compileOption);
        }
        /// <summary> 使用字符串方式二进制 </summary>
        public ScriptValue LoadBufferByString(string breviary, byte[] buffer, int index, int count) {
            return LoadBufferByString(breviary, buffer, index, count, null);
        }
        /// <summary> 使用字符串方式二进制 </summary>
        public ScriptValue LoadBufferByString(string breviary, byte[] buffer, int index, int count, CompileOption compileOption) {
            return Execute(Serializer.Serialize(breviary, Encoding.GetString(buffer, index, count), m_SearchPaths, compileOption));
        }
        /// <summary> 使用字节码方式二进制 </summary>
        public ScriptValue LoadBufferByIL(byte[] buffer) {
            return LoadBufferByIL(buffer, 0, buffer.Length);
        }
        /// <summary> 使用字节码方式二进制 </summary>
        public ScriptValue LoadBufferByIL(byte[] buffer, int index, int count) {
            using (var stream = new MemoryStream(buffer, index, count)) {
                return LoadStreamByIL(stream);
            }
        }
        /// <summary> 使用字符串方式加载流 </summary>
        public ScriptValue LoadStreamByString(string breviary, Stream stream, int count) {
            return LoadStreamByString(breviary, stream, count, null);
        }
        /// <summary> 使用字符串方式加载流 </summary>
        public ScriptValue LoadStreamByString(string breviary, Stream stream, int count, CompileOption compileOption) {
            var buffer = new byte[count];
            Util.ReadBytes(stream, buffer);
            return Execute(Serializer.Serialize(breviary, Encoding.GetString(buffer), m_SearchPaths, compileOption));
        }
        /// <summary> 使用字节码方式加载流 </summary>
        public ScriptValue LoadStreamByIL(Stream stream) {
            return Execute(Deserializer.Deserialize(stream));
        }
        /// <summary> 加载一段文本 </summary>
        public ScriptValue LoadString(string buffer) {
            return LoadString(null, buffer, null);
        }
        /// <summary> 加载一段文本 </summary>
        public ScriptValue LoadString(string buffer, CompileOption compileOption) {
            return LoadString(null, buffer, compileOption);
        }
        /// <summary> 加载一段文本 </summary>
        public ScriptValue LoadString(string breviary, string buffer) {
            return LoadString(breviary, buffer, null);
        }
        /// <summary> 加载一段文本 </summary>
        public ScriptValue LoadString(string breviary, string buffer, CompileOption compileOption) {
            if (buffer == null || buffer.Length == 0) { return ScriptValue.Null; }
            return Execute(Serializer.Serialize(breviary, buffer, m_SearchPaths, compileOption));
        }

        /// <summary> 加载一个文件 </summary>
        public ScriptValue LoadFile(string fileName) {
            return LoadFile(fileName, null);
        }
        /// <summary> 加载一个文件 </summary>
        public ScriptValue LoadFile(string fileName, CompileOption compileOption) {
            var fullFileName = SearchFile(fileName);
            if (fullFileName == null) {
                throw new System.Exception($"can't found file : {fileName}");
            }
            using (var stream = File.OpenRead(fullFileName)) {
                var buffer = new byte[stream.Length];
                Util.ReadBytes(stream, buffer);
                return LoadBuffer(fileName, buffer, compileOption);
            }
        }
        /// <summary> 加载一段数据 </summary>
        public ScriptValue LoadBuffer(byte[] buffer) {
            return LoadBuffer(null, buffer, null);
        }
        /// <summary> 加载一段数据 </summary>
        public ScriptValue LoadBuffer(byte[] buffer, CompileOption compileOption) {
            return LoadBuffer(null, buffer, compileOption);
        }
        /// <summary> 加载一段数据 </summary>
        public ScriptValue LoadBuffer(string breviary, byte[] buffer) {
            return LoadBuffer(breviary, buffer, 0, buffer.Length, null);
        }
        /// <summary> 加载一段数据 </summary>
        public ScriptValue LoadBuffer(string breviary, byte[] buffer, CompileOption compileOption) {
            return LoadBuffer(breviary, buffer, 0, buffer.Length, compileOption);
        }
        /// <summary> 加载一段数据 </summary>
        public ScriptValue LoadBuffer(string breviary, byte[] buffer, int index, int count) {
            return LoadBuffer(breviary, buffer, index, count, null);
        }
        /// <summary> 加载一段数据 </summary>
        public ScriptValue LoadBuffer(string breviary, byte[] buffer, int index, int count, CompileOption compileOption) {
            if (count > 6 && buffer[index] == 0 && BitConverter.ToInt32(buffer, index + 1) == int.MaxValue) {
                using (var stream = new MemoryStream(buffer, index, count)) {
                    return Execute(Deserializer.Deserialize(stream));
                }
            } else if (buffer[index] == 0) {
                using (var stream = new MemoryStream(buffer, index, count)) {
                    return Execute(Deserializer.DeserializeV1(breviary, stream));
                }
            } else {
                return Execute(Serializer.Serialize(breviary, Encoding.GetString(buffer, index, count), m_SearchPaths, compileOption));
            }
        }
        /// <summary> 执行IL </summary>
        public ScriptValue Execute(SerializeData[] datas) {
            ScriptValue result = ScriptValue.Null;
            int length = datas.Length;
            for (var j = 0; j < length; ++j) {
                SerializeData data = datas[j];
                var contexts = new ScriptContext[data.Functions.Length];
                for (int i = 0; i < data.Functions.Length; ++i) {
                    contexts[i] = new ScriptContext(this, data.Breviary, data.Functions[i], data.ConstDouble, data.ConstLong, data.ConstString, contexts, data.Classes);
                }
                result = new ScriptContext(this, data.Breviary, data.Context, data.ConstDouble, data.ConstLong, data.ConstString, contexts, data.Classes).Execute(ScriptValue.Null, null, 0, null);
            }
            return result;
        }
        #if SCORPIO_DEBUG
        public ScriptValue Execute(SerializeData[] datas, ref List<ScriptContext[]> refContexts) {
            ScriptValue result = ScriptValue.Null;
            int length = datas.Length;
            for (var j = 0; j < length; ++j) {
                SerializeData data = datas[j];
                var contexts = new ScriptContext[data.Functions.Length];
                for (int i = 0; i < data.Functions.Length; ++i) {
                    contexts[i] = new ScriptContext(this, data.Breviary, data.Functions[i], data.ConstDouble, data.ConstLong, data.ConstString, contexts, data.Classes);
                }
                refContexts.Add(contexts);
                result = new ScriptContext(this, data.Breviary, data.Context, data.ConstDouble, data.ConstLong, data.ConstString, contexts, data.Classes).Execute(ScriptValue.Null, null, 0, null);
            }
            return result;
        }
        #endif
        public ScriptConst LoadConst(string fileName) {
            var keys = new HashSet<string>(Global.GetKeys());
            LoadFile(fileName);
            var scriptConst = new ScriptConst();
            foreach (var pair in Global) {
                if (keys.Contains(pair.Key)) { continue; }
                AddConst(scriptConst, pair.Key, pair.Value);
            }
            return scriptConst;
        }
        void AddConst(ScriptConst scriptConst, string key, ScriptValue value) {
            switch (value.valueType) {
                case ScriptValue.nullValueType:
                    scriptConst.Add(key, null);
                    break;
                case ScriptValue.trueValueType:
                    scriptConst.Add(key, true);
                    break;
                case ScriptValue.falseValueType:
                    scriptConst.Add(key, false);
                    break;
                case ScriptValue.doubleValueType:
                    scriptConst.Add(key, value.doubleValue);
                    break;
                case ScriptValue.longValueType:
                    scriptConst.Add(key, value.longValue);
                    break;
                case ScriptValue.stringValueType:
                    scriptConst.Add(key, value.stringValue);
                    break;
                case ScriptValue.scriptValueType:
                    var map = value.Get<ScriptMap>();
                    if (map != null) {
                        var con = new ScriptConst();
                        foreach (var pair in map) {
                            AddConst(con, pair.Key.ToString(), pair.Value);
                        }
                        scriptConst.Add(key, con);
                    } else {
                        throw new ExecutionException($"变量{key}不是基础常量:{value.ValueTypeName}");
                    }
                    break;
                default:
                    throw new ExecutionException($"变量{key}不是基础常量:{value.ValueTypeName}");
            }
        }
        #if SCORPIO_DEBUG || SCORPIO_STACK
        private StackInfo[] m_StackInfos = new StackInfo[128];          //堆栈信息
        private StackInfo m_Stack = new StackInfo();
        private int m_StackLength = 0;
        internal void PushStackInfo(string breviary, int line) {
            m_StackInfos[m_StackLength].Breviary = breviary;
            m_StackInfos[m_StackLength++].Line = line;
            m_Stack.Breviary = breviary;
            m_Stack.Line = line;
        }
        internal void PopStackInfo() {
            --m_StackLength;
        }
        /// <summary> 最近的堆栈调用 </summary>
        public StackInfo GetStackInfo() {
            return m_Stack;
        }
        /// <summary> 调用堆栈 </summary>
        public StackInfo[] GetStackInfos() {
            var stackInfos = new StackInfo[m_StackLength];
            for (var i = m_StackLength - 1; i >= 0; --i) {
                stackInfos[i] = m_StackInfos[i];
            }
            return stackInfos;
        }
        #else
        private readonly static StackInfo[] EmptyStackInfos = new StackInfo[0];
        /// <summary> 最近的堆栈调用 </summary>
        public StackInfo GetStackInfo() {
            return default;
        }
        /// <summary> 调用堆栈 </summary>
        public StackInfo[] GetStackInfos() {
            return EmptyStackInfos;
        }
        #endif
    }
}
