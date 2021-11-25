using System;
using System.Collections.Generic;
using System.Reflection;
using Scorpio.ScorpioReflect;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Tilemaps;
public class BuildScorpioDelegate {
    [MenuItem ("Assets/Developer/create sco Delegate Factory", false, 0)]
    public static void Build () {
        var types = GetAllDelegateTypes ();
        var generate = new Scorpio.ScorpioReflect.GenerateScorpioDelegate ();
        foreach (var type in types) {
            generate.AddType (type);
        }
        System.IO.File.WriteAllBytes("Assets/Scripts/DelegateFactory.cs", System.Text.Encoding.UTF8.GetBytes(generate.Generate(1)));
        AssetDatabase.Refresh ();
    }
    public static Assembly UnityEditorAssembly => typeof (UnityEditor.EditorApplication).Assembly;
    public static Assembly EditorAssembly => typeof (BuildScorpioDelegate).Assembly;
    static Type[] GetAllDelegateTypes () {
        var types = new List<Type> ();
        AddAssemplyDelegate (typeof (EngineUtil).Assembly, types);
        AddAssemplyDelegate (typeof (TMPro.TMP_Text).Assembly, types);
        var assemblies = AppDomain.CurrentDomain.GetAssemblies ();
        foreach (var assembly in assemblies) {
            var fullName = assembly.FullName;
            if (assembly == UnityEditorAssembly || assembly == EditorAssembly) { continue; }
            if (fullName.Contains ("UnityEngine.VRModule") || fullName.Contains ("UnityEngine.UIElementsModule")) { continue; }
            if (fullName.StartsWith ("UnityEngine.")) {
                AddAssemplyDelegate (assembly, types);
            }
        }
        return types.ToArray ();
    }
    static void AddAssemplyDelegate (Assembly assembly, List<Type> types) {
        // UnityEngine.Debug.Log("添加程序集 : " + assembly.FullName);
        foreach (var type in assembly.GetTypes ()) {
            ParseType (type, types);
        }
    }
    static void ParseType (Type type, List<Type> types) {
        if (type.IsDefined (typeof (ObsoleteAttribute), true)) return;
        if (type.IsGenericType && type.IsGenericTypeDefinition) { return; }
        if (type.IsNotPublic) { return; }
        var binding = BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
        var events = type.GetEvents (binding);
        foreach (var eve in events) {
            if (eve.IsDefined (typeof (ObsoleteAttribute), true)) { continue; }
            AddDelegateType (eve.EventHandlerType, types, type);
        }
        var fields = type.GetFields (binding);
        foreach (var field in fields) {
            if (field.IsDefined (typeof (ObsoleteAttribute), true)) { continue; }
            AddDelegateType (field.FieldType, types, type);
        }
        var propertys = type.GetProperties (binding);
        foreach (var property in propertys) {
            if (property.IsDefined (typeof (ObsoleteAttribute), true)) { continue; }
            AddDelegateType (property.PropertyType, types, type);
        }
        var methods = type.GetMethods (binding);
        foreach (var method in methods) {
            if (method.IsDefined (typeof (ObsoleteAttribute), true)) { continue; }
            AddDelegateType (method.ReturnType, types, type);
            foreach (var par in method.GetParameters ()) {
                AddDelegateType (par.ParameterType, types, type);
            }
        }
    }
    static void AddDelegateType (Type type, List<Type> types, Type sourceType) {
        if (type.Assembly == UnityEditorAssembly) { return; }
        var ignore = new List<Type> () {
            typeof (UnityEngine.CanvasRenderer.OnRequestRebuild),
        };
        if (ignore.Contains (type))
            return;
        if (type.IsGenericType) {
            var genericTypes = type.GetGenericArguments ();
            foreach (var genericType in genericTypes) {
                if (genericType.IsNotPublic || genericType.IsDefined (typeof (ObsoleteAttribute), true) || genericType.Assembly == UnityEditorAssembly) {
                    return;
                }
            }
        }
        var name = type.GetFullName ();
        if (string.IsNullOrWhiteSpace (name) ||
            name.Contains ("UnityEngine.WSA") ||
            name.Contains ("UnityEngine.Windows") ||
            name.Contains ("UnityEngine.Apple") ||
            name.Contains("UnityEngine.Advertisements.Editor") ||
            name.Contains("UnityEngineInternal") ||
            type.IsNotPublic ||
            types.Contains (type) ||
            type == typeof (System.MulticastDelegate) ||
            !type.IsSubclassOf (typeof (Delegate))) { return; }

        types.Add (type);
    }
}