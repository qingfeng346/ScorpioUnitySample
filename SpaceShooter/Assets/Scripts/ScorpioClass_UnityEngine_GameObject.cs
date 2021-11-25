using System;
using System.Collections.Generic;
using System.Reflection;
using Scorpio;
using Scorpio.Userdata;
using Scorpio.Tools;
using Scorpio.Exception;
public class ScorpioClass_UnityEngine_GameObject : ScorpioFastReflectClass {
    public UserdataMethodFastReflect GetConstructor() {
        return ScorpioClass_UnityEngine_GameObject_Constructor.GetInstance();
    }
    public Type GetVariableType(string name) {
        switch (name) {
            case "activeInHierarchy": return typeof(System.Boolean);
            case "activeSelf": return typeof(System.Boolean);
            case "gameObject": return typeof(UnityEngine.GameObject);
            case "hideFlags": return typeof(UnityEngine.HideFlags);
            case "isStatic": return typeof(System.Boolean);
            case "layer": return typeof(System.Int32);
            case "name": return typeof(System.String);
            case "scene": return typeof(UnityEngine.SceneManagement.Scene);
            case "tag": return typeof(System.String);
            case "transform": return typeof(UnityEngine.Transform);
            case "AddComponent": return typeof(UnityEngine.Component);
            case "CompareTag": return typeof(System.Boolean);
            case "CreatePrimitive": return typeof(UnityEngine.GameObject);
            case "Equals": return typeof(System.Boolean);
            case "Find": return typeof(UnityEngine.GameObject);
            case "FindGameObjectsWithTag": return typeof(UnityEngine.GameObject[]);
            case "FindGameObjectWithTag": return typeof(UnityEngine.GameObject);
            case "FindObjectOfType": return typeof(UnityEngine.Object);
            case "FindObjectsOfType": return typeof(UnityEngine.Object[]);
            case "FindWithTag": return typeof(UnityEngine.GameObject);
            case "get_activeInHierarchy": return typeof(System.Boolean);
            case "get_activeSelf": return typeof(System.Boolean);
            case "get_gameObject": return typeof(UnityEngine.GameObject);
            case "get_hideFlags": return typeof(UnityEngine.HideFlags);
            case "get_isStatic": return typeof(System.Boolean);
            case "get_layer": return typeof(System.Int32);
            case "get_name": return typeof(System.String);
            case "get_scene": return typeof(UnityEngine.SceneManagement.Scene);
            case "get_tag": return typeof(System.String);
            case "get_transform": return typeof(UnityEngine.Transform);
            case "GetComponent": return typeof(UnityEngine.Component);
            case "GetComponentInChildren": return typeof(UnityEngine.Component);
            case "GetComponentInParent": return typeof(UnityEngine.Component);
            case "GetComponents": return typeof(UnityEngine.Component[]);
            case "GetComponentsInChildren": return typeof(UnityEngine.Component[]);
            case "GetComponentsInParent": return typeof(UnityEngine.Component[]);
            case "GetHashCode": return typeof(System.Int32);
            case "GetInstanceID": return typeof(System.Int32);
            case "GetType": return typeof(System.Type);
            case "Instantiate": return typeof(UnityEngine.Object);
            case "op_Equality": return typeof(System.Boolean);
            case "op_Implicit": return typeof(System.Boolean);
            case "op_Inequality": return typeof(System.Boolean);
            case "ReferenceEquals": return typeof(System.Boolean);
            case "ToString": return typeof(System.String);
            default: throw new ExecutionException("UnityEngine.GameObject [GetVariableType] 找不到变量 : " + name);
        }
    }
    public UserdataMethod GetMethod(string name) {
        switch (name) {
            case "AddComponent": return ScorpioClass_UnityEngine_GameObject_AddComponent.GetInstance();
            case "BroadcastMessage": return ScorpioClass_UnityEngine_GameObject_BroadcastMessage.GetInstance();
            case "CompareTag": return ScorpioClass_UnityEngine_GameObject_CompareTag.GetInstance();
            case "CreatePrimitive": return ScorpioClass_UnityEngine_GameObject_CreatePrimitive.GetInstance();
            case "Destroy": return ScorpioClass_UnityEngine_GameObject_Destroy.GetInstance();
            case "DestroyImmediate": return ScorpioClass_UnityEngine_GameObject_DestroyImmediate.GetInstance();
            case "DontDestroyOnLoad": return ScorpioClass_UnityEngine_GameObject_DontDestroyOnLoad.GetInstance();
            case "Equals": return ScorpioClass_UnityEngine_GameObject_Equals.GetInstance();
            case "Find": return ScorpioClass_UnityEngine_GameObject_Find.GetInstance();
            case "FindGameObjectsWithTag": return ScorpioClass_UnityEngine_GameObject_FindGameObjectsWithTag.GetInstance();
            case "FindGameObjectWithTag": return ScorpioClass_UnityEngine_GameObject_FindGameObjectWithTag.GetInstance();
            case "FindObjectOfType": return ScorpioClass_UnityEngine_GameObject_FindObjectOfType.GetInstance();
            case "FindObjectsOfType": return ScorpioClass_UnityEngine_GameObject_FindObjectsOfType.GetInstance();
            case "FindWithTag": return ScorpioClass_UnityEngine_GameObject_FindWithTag.GetInstance();
            case "get_activeInHierarchy": return ScorpioClass_UnityEngine_GameObject_get_activeInHierarchy.GetInstance();
            case "get_activeSelf": return ScorpioClass_UnityEngine_GameObject_get_activeSelf.GetInstance();
            case "get_gameObject": return ScorpioClass_UnityEngine_GameObject_get_gameObject.GetInstance();
            case "get_hideFlags": return ScorpioClass_UnityEngine_GameObject_get_hideFlags.GetInstance();
            case "get_isStatic": return ScorpioClass_UnityEngine_GameObject_get_isStatic.GetInstance();
            case "get_layer": return ScorpioClass_UnityEngine_GameObject_get_layer.GetInstance();
            case "get_name": return ScorpioClass_UnityEngine_GameObject_get_name.GetInstance();
            case "get_scene": return ScorpioClass_UnityEngine_GameObject_get_scene.GetInstance();
            case "get_tag": return ScorpioClass_UnityEngine_GameObject_get_tag.GetInstance();
            case "get_transform": return ScorpioClass_UnityEngine_GameObject_get_transform.GetInstance();
            case "GetComponent": return ScorpioClass_UnityEngine_GameObject_GetComponent.GetInstance();
            case "GetComponentInChildren": return ScorpioClass_UnityEngine_GameObject_GetComponentInChildren.GetInstance();
            case "GetComponentInParent": return ScorpioClass_UnityEngine_GameObject_GetComponentInParent.GetInstance();
            case "GetComponents": return ScorpioClass_UnityEngine_GameObject_GetComponents.GetInstance();
            case "GetComponentsInChildren": return ScorpioClass_UnityEngine_GameObject_GetComponentsInChildren.GetInstance();
            case "GetComponentsInParent": return ScorpioClass_UnityEngine_GameObject_GetComponentsInParent.GetInstance();
            case "GetHashCode": return ScorpioClass_UnityEngine_GameObject_GetHashCode.GetInstance();
            case "GetInstanceID": return ScorpioClass_UnityEngine_GameObject_GetInstanceID.GetInstance();
            case "GetType": return ScorpioClass_UnityEngine_GameObject_GetType.GetInstance();
            case "Instantiate": return ScorpioClass_UnityEngine_GameObject_Instantiate.GetInstance();
            case "op_Equality": return ScorpioClass_UnityEngine_GameObject_op_Equality.GetInstance();
            case "op_Implicit": return ScorpioClass_UnityEngine_GameObject_op_Implicit.GetInstance();
            case "op_Inequality": return ScorpioClass_UnityEngine_GameObject_op_Inequality.GetInstance();
            case "ReferenceEquals": return ScorpioClass_UnityEngine_GameObject_ReferenceEquals.GetInstance();
            case "SendMessage": return ScorpioClass_UnityEngine_GameObject_SendMessage.GetInstance();
            case "SendMessageUpwards": return ScorpioClass_UnityEngine_GameObject_SendMessageUpwards.GetInstance();
            case "set_hideFlags": return ScorpioClass_UnityEngine_GameObject_set_hideFlags.GetInstance();
            case "set_isStatic": return ScorpioClass_UnityEngine_GameObject_set_isStatic.GetInstance();
            case "set_layer": return ScorpioClass_UnityEngine_GameObject_set_layer.GetInstance();
            case "set_name": return ScorpioClass_UnityEngine_GameObject_set_name.GetInstance();
            case "set_tag": return ScorpioClass_UnityEngine_GameObject_set_tag.GetInstance();
            case "SetActive": return ScorpioClass_UnityEngine_GameObject_SetActive.GetInstance();
            case "TestFunc": return ScorpioClass_UnityEngine_GameObject_TestFunc.GetInstance();
            case "ToString": return ScorpioClass_UnityEngine_GameObject_ToString.GetInstance();
            default: return null;
        }
    }
    public bool GetValue(object obj, string name, out object value) {
        switch (name) {
            case "activeInHierarchy": value = ((UnityEngine.GameObject)obj).activeInHierarchy; return true;
            case "activeSelf": value = ((UnityEngine.GameObject)obj).activeSelf; return true;
            case "gameObject": value = ((UnityEngine.GameObject)obj).gameObject; return true;
            case "hideFlags": value = ((UnityEngine.GameObject)obj).hideFlags; return true;
            case "isStatic": value = ((UnityEngine.GameObject)obj).isStatic; return true;
            case "layer": value = ((UnityEngine.GameObject)obj).layer; return true;
            case "name": value = ((UnityEngine.GameObject)obj).name; return true;
            case "scene": value = ((UnityEngine.GameObject)obj).scene; return true;
            case "tag": value = ((UnityEngine.GameObject)obj).tag; return true;
            case "transform": value = ((UnityEngine.GameObject)obj).transform; return true;
            case "AddComponent": value = ScorpioClass_UnityEngine_GameObject_AddComponent.GetInstance(); return true;
            case "BroadcastMessage": value = ScorpioClass_UnityEngine_GameObject_BroadcastMessage.GetInstance(); return true;
            case "CompareTag": value = ScorpioClass_UnityEngine_GameObject_CompareTag.GetInstance(); return true;
            case "CreatePrimitive": value = ScorpioClass_UnityEngine_GameObject_CreatePrimitive.GetInstance(); return true;
            case "Destroy": value = ScorpioClass_UnityEngine_GameObject_Destroy.GetInstance(); return true;
            case "DestroyImmediate": value = ScorpioClass_UnityEngine_GameObject_DestroyImmediate.GetInstance(); return true;
            case "DontDestroyOnLoad": value = ScorpioClass_UnityEngine_GameObject_DontDestroyOnLoad.GetInstance(); return true;
            case "Equals": value = ScorpioClass_UnityEngine_GameObject_Equals.GetInstance(); return true;
            case "Find": value = ScorpioClass_UnityEngine_GameObject_Find.GetInstance(); return true;
            case "FindGameObjectsWithTag": value = ScorpioClass_UnityEngine_GameObject_FindGameObjectsWithTag.GetInstance(); return true;
            case "FindGameObjectWithTag": value = ScorpioClass_UnityEngine_GameObject_FindGameObjectWithTag.GetInstance(); return true;
            case "FindObjectOfType": value = ScorpioClass_UnityEngine_GameObject_FindObjectOfType.GetInstance(); return true;
            case "FindObjectsOfType": value = ScorpioClass_UnityEngine_GameObject_FindObjectsOfType.GetInstance(); return true;
            case "FindWithTag": value = ScorpioClass_UnityEngine_GameObject_FindWithTag.GetInstance(); return true;
            case "get_activeInHierarchy": value = ScorpioClass_UnityEngine_GameObject_get_activeInHierarchy.GetInstance(); return true;
            case "get_activeSelf": value = ScorpioClass_UnityEngine_GameObject_get_activeSelf.GetInstance(); return true;
            case "get_gameObject": value = ScorpioClass_UnityEngine_GameObject_get_gameObject.GetInstance(); return true;
            case "get_hideFlags": value = ScorpioClass_UnityEngine_GameObject_get_hideFlags.GetInstance(); return true;
            case "get_isStatic": value = ScorpioClass_UnityEngine_GameObject_get_isStatic.GetInstance(); return true;
            case "get_layer": value = ScorpioClass_UnityEngine_GameObject_get_layer.GetInstance(); return true;
            case "get_name": value = ScorpioClass_UnityEngine_GameObject_get_name.GetInstance(); return true;
            case "get_scene": value = ScorpioClass_UnityEngine_GameObject_get_scene.GetInstance(); return true;
            case "get_tag": value = ScorpioClass_UnityEngine_GameObject_get_tag.GetInstance(); return true;
            case "get_transform": value = ScorpioClass_UnityEngine_GameObject_get_transform.GetInstance(); return true;
            case "GetComponent": value = ScorpioClass_UnityEngine_GameObject_GetComponent.GetInstance(); return true;
            case "GetComponentInChildren": value = ScorpioClass_UnityEngine_GameObject_GetComponentInChildren.GetInstance(); return true;
            case "GetComponentInParent": value = ScorpioClass_UnityEngine_GameObject_GetComponentInParent.GetInstance(); return true;
            case "GetComponents": value = ScorpioClass_UnityEngine_GameObject_GetComponents.GetInstance(); return true;
            case "GetComponentsInChildren": value = ScorpioClass_UnityEngine_GameObject_GetComponentsInChildren.GetInstance(); return true;
            case "GetComponentsInParent": value = ScorpioClass_UnityEngine_GameObject_GetComponentsInParent.GetInstance(); return true;
            case "GetHashCode": value = ScorpioClass_UnityEngine_GameObject_GetHashCode.GetInstance(); return true;
            case "GetInstanceID": value = ScorpioClass_UnityEngine_GameObject_GetInstanceID.GetInstance(); return true;
            case "GetType": value = ScorpioClass_UnityEngine_GameObject_GetType.GetInstance(); return true;
            case "Instantiate": value = ScorpioClass_UnityEngine_GameObject_Instantiate.GetInstance(); return true;
            case "op_Equality": value = ScorpioClass_UnityEngine_GameObject_op_Equality.GetInstance(); return true;
            case "op_Implicit": value = ScorpioClass_UnityEngine_GameObject_op_Implicit.GetInstance(); return true;
            case "op_Inequality": value = ScorpioClass_UnityEngine_GameObject_op_Inequality.GetInstance(); return true;
            case "ReferenceEquals": value = ScorpioClass_UnityEngine_GameObject_ReferenceEquals.GetInstance(); return true;
            case "SendMessage": value = ScorpioClass_UnityEngine_GameObject_SendMessage.GetInstance(); return true;
            case "SendMessageUpwards": value = ScorpioClass_UnityEngine_GameObject_SendMessageUpwards.GetInstance(); return true;
            case "set_hideFlags": value = ScorpioClass_UnityEngine_GameObject_set_hideFlags.GetInstance(); return true;
            case "set_isStatic": value = ScorpioClass_UnityEngine_GameObject_set_isStatic.GetInstance(); return true;
            case "set_layer": value = ScorpioClass_UnityEngine_GameObject_set_layer.GetInstance(); return true;
            case "set_name": value = ScorpioClass_UnityEngine_GameObject_set_name.GetInstance(); return true;
            case "set_tag": value = ScorpioClass_UnityEngine_GameObject_set_tag.GetInstance(); return true;
            case "SetActive": value = ScorpioClass_UnityEngine_GameObject_SetActive.GetInstance(); return true;
            case "TestFunc": value = ScorpioClass_UnityEngine_GameObject_TestFunc.GetInstance(); return true;
            case "ToString": value = ScorpioClass_UnityEngine_GameObject_ToString.GetInstance(); return true;
            default: value = null; return false;
        }
    }
    public void SetValue(object obj, string name, ScriptValue value) {
        switch (name) {
            case "hideFlags": { ((UnityEngine.GameObject)obj).hideFlags = (UnityEngine.HideFlags)(Util.ChangeType(value, typeof(UnityEngine.HideFlags))); return; }
            case "isStatic": { ((UnityEngine.GameObject)obj).isStatic = (System.Boolean)(Util.ChangeType(value, typeof(System.Boolean))); return; }
            case "layer": { ((UnityEngine.GameObject)obj).layer = (System.Int32)(Util.ChangeType(value, typeof(System.Int32))); return; }
            case "name": { ((UnityEngine.GameObject)obj).name = (System.String)(Util.ChangeType(value, typeof(System.String))); return; }
            case "tag": { ((UnityEngine.GameObject)obj).tag = (System.String)(Util.ChangeType(value, typeof(System.String))); return; }
            default: throw new ExecutionException("UnityEngine.GameObject [SetValue] 找不到变量 : " + name);
        }
    }

    public class ScorpioClass_UnityEngine_GameObject_Constructor : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String)}, new bool[]{false}, null, 0));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 1));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String),typeof(System.Type[])}, new bool[]{false,false}, typeof(System.Type), 2));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "Constructor", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_Constructor()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return new UnityEngine.GameObject((System.String)args[0]); }
                case 1: { return new UnityEngine.GameObject(); }
                case 2: { return new UnityEngine.GameObject((System.String)args[0], (System.Type[])args[1]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : Constructor    type : " + methodIndex);
            }
        }
    }

    public class ScorpioClass_UnityEngine_GameObject_AddComponent : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Type)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "AddComponent", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_AddComponent()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).AddComponent((System.Type)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : AddComponent    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_BroadcastMessage : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String),typeof(System.Object),typeof(UnityEngine.SendMessageOptions)}, new bool[]{false,false,false}, null, 0));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String)}, new bool[]{false}, null, 1));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String),typeof(System.Object)}, new bool[]{false,false}, null, 2));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String),typeof(UnityEngine.SendMessageOptions)}, new bool[]{false,false}, null, 3));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "BroadcastMessage", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_BroadcastMessage()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { ((UnityEngine.GameObject)obj).BroadcastMessage((System.String)args[0], (System.Object)args[1], (UnityEngine.SendMessageOptions)args[2]); return null; }
                case 1: { ((UnityEngine.GameObject)obj).BroadcastMessage((System.String)args[0]); return null; }
                case 2: { ((UnityEngine.GameObject)obj).BroadcastMessage((System.String)args[0], (System.Object)args[1]); return null; }
                case 3: { ((UnityEngine.GameObject)obj).BroadcastMessage((System.String)args[0], (UnityEngine.SendMessageOptions)args[1]); return null; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : BroadcastMessage    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_CompareTag : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "CompareTag", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_CompareTag()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).CompareTag((System.String)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : CompareTag    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_CreatePrimitive : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.PrimitiveType)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "CreatePrimitive", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_CreatePrimitive()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return UnityEngine.GameObject.CreatePrimitive((UnityEngine.PrimitiveType)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : CreatePrimitive    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_Destroy : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object),typeof(System.Single)}, new bool[]{false,false}, null, 0));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object)}, new bool[]{false}, null, 1));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "Destroy", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_Destroy()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { UnityEngine.GameObject.Destroy((UnityEngine.Object)args[0], (System.Single)args[1]); return null; }
                case 1: { UnityEngine.GameObject.Destroy((UnityEngine.Object)args[0]); return null; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : Destroy    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_DestroyImmediate : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object)}, new bool[]{false}, null, 0));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object),typeof(System.Boolean)}, new bool[]{false,false}, null, 1));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "DestroyImmediate", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_DestroyImmediate()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { UnityEngine.GameObject.DestroyImmediate((UnityEngine.Object)args[0]); return null; }
                case 1: { UnityEngine.GameObject.DestroyImmediate((UnityEngine.Object)args[0], (System.Boolean)args[1]); return null; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : DestroyImmediate    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_DontDestroyOnLoad : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "DontDestroyOnLoad", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_DontDestroyOnLoad()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { UnityEngine.GameObject.DontDestroyOnLoad((UnityEngine.Object)args[0]); return null; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : DontDestroyOnLoad    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_Equals : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(System.Object),typeof(System.Object)}, new bool[]{false,false}, null, 0));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Object)}, new bool[]{false}, null, 1));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "Equals", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_Equals()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return UnityEngine.GameObject.Equals((System.Object)args[0], (System.Object)args[1]); }
                case 1: { return ((UnityEngine.GameObject)obj).Equals((System.Object)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : Equals    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_Find : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(System.String)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "Find", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_Find()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return UnityEngine.GameObject.Find((System.String)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : Find    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_FindGameObjectsWithTag : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(System.String)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "FindGameObjectsWithTag", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_FindGameObjectsWithTag()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return UnityEngine.GameObject.FindGameObjectsWithTag((System.String)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : FindGameObjectsWithTag    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_FindGameObjectWithTag : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(System.String)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "FindGameObjectWithTag", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_FindGameObjectWithTag()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return UnityEngine.GameObject.FindGameObjectWithTag((System.String)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : FindGameObjectWithTag    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_FindObjectOfType : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(System.Type)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "FindObjectOfType", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_FindObjectOfType()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return UnityEngine.GameObject.FindObjectOfType((System.Type)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : FindObjectOfType    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_FindObjectsOfType : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(System.Type)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "FindObjectsOfType", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_FindObjectsOfType()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return UnityEngine.GameObject.FindObjectsOfType((System.Type)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : FindObjectsOfType    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_FindWithTag : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(System.String)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "FindWithTag", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_FindWithTag()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return UnityEngine.GameObject.FindWithTag((System.String)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : FindWithTag    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_get_activeInHierarchy : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "get_activeInHierarchy", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_get_activeInHierarchy()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).activeInHierarchy; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : get_activeInHierarchy    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_get_activeSelf : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "get_activeSelf", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_get_activeSelf()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).activeSelf; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : get_activeSelf    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_get_gameObject : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "get_gameObject", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_get_gameObject()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).gameObject; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : get_gameObject    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_get_hideFlags : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "get_hideFlags", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_get_hideFlags()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).hideFlags; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : get_hideFlags    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_get_isStatic : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "get_isStatic", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_get_isStatic()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).isStatic; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : get_isStatic    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_get_layer : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "get_layer", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_get_layer()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).layer; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : get_layer    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_get_name : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "get_name", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_get_name()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).name; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : get_name    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_get_scene : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "get_scene", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_get_scene()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).scene; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : get_scene    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_get_tag : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "get_tag", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_get_tag()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).tag; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : get_tag    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_get_transform : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "get_transform", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_get_transform()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).transform; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : get_transform    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_GetComponent : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Type)}, new bool[]{false}, null, 0));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String)}, new bool[]{false}, null, 1));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "GetComponent", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_GetComponent()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).GetComponent((System.Type)args[0]); }
                case 1: { return ((UnityEngine.GameObject)obj).GetComponent((System.String)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : GetComponent    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_GetComponentInChildren : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Type),typeof(System.Boolean)}, new bool[]{false,false}, null, 0));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Type)}, new bool[]{false}, null, 1));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "GetComponentInChildren", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_GetComponentInChildren()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).GetComponentInChildren((System.Type)args[0], (System.Boolean)args[1]); }
                case 1: { return ((UnityEngine.GameObject)obj).GetComponentInChildren((System.Type)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : GetComponentInChildren    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_GetComponentInParent : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Type)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "GetComponentInParent", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_GetComponentInParent()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).GetComponentInParent((System.Type)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : GetComponentInParent    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_GetComponents : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Type)}, new bool[]{false}, null, 0));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Type),typeof(System.Collections.Generic.List<UnityEngine.Component>)}, new bool[]{false,false}, null, 1));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "GetComponents", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_GetComponents()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).GetComponents((System.Type)args[0]); }
                case 1: { ((UnityEngine.GameObject)obj).GetComponents((System.Type)args[0], (System.Collections.Generic.List<UnityEngine.Component>)args[1]); return null; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : GetComponents    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_GetComponentsInChildren : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Type)}, new bool[]{false}, null, 0));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Type),typeof(System.Boolean)}, new bool[]{false,false}, null, 1));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "GetComponentsInChildren", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_GetComponentsInChildren()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).GetComponentsInChildren((System.Type)args[0]); }
                case 1: { return ((UnityEngine.GameObject)obj).GetComponentsInChildren((System.Type)args[0], (System.Boolean)args[1]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : GetComponentsInChildren    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_GetComponentsInParent : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Type),typeof(System.Boolean)}, new bool[]{false,false}, null, 0));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Type)}, new bool[]{false}, null, 1));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "GetComponentsInParent", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_GetComponentsInParent()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).GetComponentsInParent((System.Type)args[0], (System.Boolean)args[1]); }
                case 1: { return ((UnityEngine.GameObject)obj).GetComponentsInParent((System.Type)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : GetComponentsInParent    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_GetHashCode : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "GetHashCode", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_GetHashCode()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).GetHashCode(); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : GetHashCode    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_GetInstanceID : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "GetInstanceID", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_GetInstanceID()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).GetInstanceID(); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : GetInstanceID    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_GetType : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "GetType", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_GetType()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).GetType(); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : GetType    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_Instantiate : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object)}, new bool[]{false}, null, 0));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object),typeof(UnityEngine.Transform),typeof(System.Boolean)}, new bool[]{false,false,false}, null, 1));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object),typeof(UnityEngine.Transform)}, new bool[]{false,false}, null, 2));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object)}, new bool[]{false}, null, 3));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.Transform)}, new bool[]{false,false,false,false}, null, 4));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion)}, new bool[]{false,false,false}, null, 5));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object),typeof(UnityEngine.Transform),typeof(System.Boolean)}, new bool[]{false,false,false}, null, 6));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion),typeof(UnityEngine.Transform)}, new bool[]{false,false,false,false}, null, 7));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object),typeof(UnityEngine.Vector3),typeof(UnityEngine.Quaternion)}, new bool[]{false,false,false}, null, 8));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object),typeof(UnityEngine.Transform)}, new bool[]{false,false}, null, 9));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "Instantiate", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_Instantiate()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return UnityEngine.GameObject.Instantiate((UnityEngine.Object)args[0]); }
                case 1: { return UnityEngine.GameObject.Instantiate((UnityEngine.Object)args[0], (UnityEngine.Transform)args[1], (System.Boolean)args[2]); }
                case 2: { return UnityEngine.GameObject.Instantiate((UnityEngine.Object)args[0], (UnityEngine.Transform)args[1]); }
                case 3: { return UnityEngine.GameObject.Instantiate((UnityEngine.Object)args[0]); }
                case 4: { return UnityEngine.GameObject.Instantiate((UnityEngine.Object)args[0], (UnityEngine.Vector3)args[1], (UnityEngine.Quaternion)args[2], (UnityEngine.Transform)args[3]); }
                case 5: { return UnityEngine.GameObject.Instantiate((UnityEngine.Object)args[0], (UnityEngine.Vector3)args[1], (UnityEngine.Quaternion)args[2]); }
                case 6: { return UnityEngine.GameObject.Instantiate((UnityEngine.Object)args[0], (UnityEngine.Transform)args[1], (System.Boolean)args[2]); }
                case 7: { return UnityEngine.GameObject.Instantiate((UnityEngine.Object)args[0], (UnityEngine.Vector3)args[1], (UnityEngine.Quaternion)args[2], (UnityEngine.Transform)args[3]); }
                case 8: { return UnityEngine.GameObject.Instantiate((UnityEngine.Object)args[0], (UnityEngine.Vector3)args[1], (UnityEngine.Quaternion)args[2]); }
                case 9: { return UnityEngine.GameObject.Instantiate((UnityEngine.Object)args[0], (UnityEngine.Transform)args[1]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : Instantiate    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_op_Equality : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object),typeof(UnityEngine.Object)}, new bool[]{false,false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "op_Equality", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_op_Equality()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return (UnityEngine.Object)args[0] == (UnityEngine.Object)args[1]; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : op_Equality    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_op_Implicit : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "op_Implicit", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_op_Implicit()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return (System.Boolean)((UnityEngine.Object)args[0]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : op_Implicit    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_op_Inequality : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(UnityEngine.Object),typeof(UnityEngine.Object)}, new bool[]{false,false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "op_Inequality", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_op_Inequality()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return (UnityEngine.Object)args[0] != (UnityEngine.Object)args[1]; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : op_Inequality    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_ReferenceEquals : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(true, new Type[]{typeof(System.Object),typeof(System.Object)}, new bool[]{false,false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "ReferenceEquals", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_ReferenceEquals()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return UnityEngine.GameObject.ReferenceEquals((System.Object)args[0], (System.Object)args[1]); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : ReferenceEquals    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_SendMessage : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String),typeof(UnityEngine.SendMessageOptions)}, new bool[]{false,false}, null, 0));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String),typeof(System.Object),typeof(UnityEngine.SendMessageOptions)}, new bool[]{false,false,false}, null, 1));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String),typeof(System.Object)}, new bool[]{false,false}, null, 2));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String)}, new bool[]{false}, null, 3));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "SendMessage", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_SendMessage()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { ((UnityEngine.GameObject)obj).SendMessage((System.String)args[0], (UnityEngine.SendMessageOptions)args[1]); return null; }
                case 1: { ((UnityEngine.GameObject)obj).SendMessage((System.String)args[0], (System.Object)args[1], (UnityEngine.SendMessageOptions)args[2]); return null; }
                case 2: { ((UnityEngine.GameObject)obj).SendMessage((System.String)args[0], (System.Object)args[1]); return null; }
                case 3: { ((UnityEngine.GameObject)obj).SendMessage((System.String)args[0]); return null; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : SendMessage    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_SendMessageUpwards : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String),typeof(UnityEngine.SendMessageOptions)}, new bool[]{false,false}, null, 0));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String),typeof(System.Object),typeof(UnityEngine.SendMessageOptions)}, new bool[]{false,false,false}, null, 1));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String),typeof(System.Object)}, new bool[]{false,false}, null, 2));
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String)}, new bool[]{false}, null, 3));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "SendMessageUpwards", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_SendMessageUpwards()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { ((UnityEngine.GameObject)obj).SendMessageUpwards((System.String)args[0], (UnityEngine.SendMessageOptions)args[1]); return null; }
                case 1: { ((UnityEngine.GameObject)obj).SendMessageUpwards((System.String)args[0], (System.Object)args[1], (UnityEngine.SendMessageOptions)args[2]); return null; }
                case 2: { ((UnityEngine.GameObject)obj).SendMessageUpwards((System.String)args[0], (System.Object)args[1]); return null; }
                case 3: { ((UnityEngine.GameObject)obj).SendMessageUpwards((System.String)args[0]); return null; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : SendMessageUpwards    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_set_hideFlags : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(UnityEngine.HideFlags)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "set_hideFlags", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_set_hideFlags()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { ((UnityEngine.GameObject)obj).hideFlags = (UnityEngine.HideFlags)args[0]; return null; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : set_hideFlags    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_set_isStatic : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Boolean)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "set_isStatic", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_set_isStatic()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { ((UnityEngine.GameObject)obj).isStatic = (System.Boolean)args[0]; return null; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : set_isStatic    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_set_layer : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Int32)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "set_layer", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_set_layer()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { ((UnityEngine.GameObject)obj).layer = (System.Int32)args[0]; return null; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : set_layer    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_set_name : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "set_name", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_set_name()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { ((UnityEngine.GameObject)obj).name = (System.String)args[0]; return null; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : set_name    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_set_tag : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.String)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "set_tag", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_set_tag()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { ((UnityEngine.GameObject)obj).tag = (System.String)args[0]; return null; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : set_tag    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_SetActive : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{typeof(System.Boolean)}, new bool[]{false}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "SetActive", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_SetActive()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { ((UnityEngine.GameObject)obj).SetActive((System.Boolean)args[0]); return null; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : SetActive    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_TestFunc : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "TestFunc", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_TestFunc()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { ((UnityEngine.GameObject)obj).TestFunc(); return null; }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : TestFunc    type : " + methodIndex);
            }
        }
    }
    public class ScorpioClass_UnityEngine_GameObject_ToString : ScorpioFastReflectMethod {
        private static UserdataMethodFastReflect _instance = null;
        public static UserdataMethodFastReflect GetInstance() {
            if (_instance != null) { return _instance; }
            var methodInfos = new List<ScorpioFastReflectMethodInfo>();
            methodInfos.Add(new ScorpioFastReflectMethodInfo(false, new Type[]{}, new bool[]{}, null, 0));
            return _instance = new UserdataMethodFastReflect(typeof(UnityEngine.GameObject), "ToString", methodInfos.ToArray(), new ScorpioClass_UnityEngine_GameObject_ToString()); 
        }
        public object Call(object obj, int methodIndex, object[] args) {
            switch (methodIndex) {
                case 0: { return ((UnityEngine.GameObject)obj).ToString(); }
                default: throw new ExecutionException("UnityEngine.GameObject 找不到合适的函数 : ToString    type : " + methodIndex);
            }
        }
    }
}