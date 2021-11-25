using System;
using System.Reflection;
using System.Text;
using System.IO;
using Scorpio.ScorpioReflect;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class BuildScorpioClass {
    class Filter : ClassFilter {
        public bool Check (GenerateScorpioClass generate, Type type, FieldInfo fieldInfo) {
            if (fieldInfo.IsDefined (typeof (ObsoleteAttribute), true)) {
                return false;
            }
            return true;
        }
        public bool Check (GenerateScorpioClass generate, Type type, EventInfo eventInfo) {
            if (eventInfo.IsDefined (typeof (ObsoleteAttribute), true) ) {
                return false;
            }
            return true;
        }
        public bool Check (GenerateScorpioClass generate, Type type, PropertyInfo propertyInfo) {
            if (propertyInfo.IsDefined (typeof (ObsoleteAttribute), true) ) {
                return false;
            } else if (type.IsSubclassOf (typeof (MonoBehaviour)) && propertyInfo.Name == "runInEditMode") {
                return false;
            } else if (type == typeof (Texture2D) && propertyInfo.Name == "alphaIsTransparency") {
                return false;
            } else if (type.IsSubclassOf (typeof (Texture)) && propertyInfo.Name == "imageContentsHash") {
                return false;
            } else if (type == typeof (System.Threading.Thread) && propertyInfo.Name == "CurrentContext") {
                return false;
            } else if (type == typeof (UnityEngine.Input) && propertyInfo.Name == "location") {
                return false;
            }
            return true;
        }
        public bool Check (GenerateScorpioClass generate, Type type, MethodInfo methodInfo) {
            if (methodInfo.IsDefined (typeof (ObsoleteAttribute), true)) {
                return false;
            } else if (type == typeof (Input) && methodInfo.Name == "IsJoystickPreconfigured") {
                return false;
            } else if (type.IsSubclassOf (typeof (Graphic)) && methodInfo.Name == "OnRebuildRequested") {
                return false;
            } else if (type == typeof (Rigidbody2D) && (methodInfo.Name == "OverlapCollider" || methodInfo.Name == "GetAttachedColliders")) {
                return false;
            } else if (type == typeof (AssetBundle) && (methodInfo.Name == "SetAssetBundleDecryptKey")) {
                return false;
            }
            return true;
        }
    }

    [MenuItem ("Assets/Developer/create sco fast class", false, 0)]
    public static void Build () {
        var types = new Type[] {
            //Unity基础类
            typeof (UnityEngine.GameObject),
        };
        var builder = new StringBuilder ();
        builder.Append (@"using Scorpio.Userdata;
public class ScorpioClassManager {
    public static void Initialize(Scorpio.Script script) {
");
        foreach (var type in types) {
            var generate = new Scorpio.ScorpioReflect.GenerateScorpioClass (type);
            generate.SetClassFilter (new Filter ());
            generate.AddExtensionType(typeof(EngineUtil));
            File.WriteAllBytes($"Assets/Scripts/{generate.ScorpioClassName}.cs", Encoding.UTF8.GetBytes(generate.Generate()));
            builder.AppendFormat ("        TypeManager.SetFastReflectClass(typeof({0}), new {1}());\n", ScorpioReflectUtil.GetFullName (type), generate.ScorpioClassName);
        }
        builder.Append (@"   }
}
");
        File.WriteAllText($"Assets/Scripts/ScorpioClassManager.cs", builder.ToString());
        AssetDatabase.Refresh ();
    }
}