using Scorpio;
using UnityEngine;
using UnityEngine.UI;

public class ScriptUtil {
    private static Script m_Script = null;
    public static void Initialize (Script script) {
        m_Script = script;
    }
    public static ScriptInstance AddComponent (UnityEngine.Object obj, string name) {
        if (obj == null || string.IsNullOrEmpty (name)) return null;
        var value = m_Script.Global.GetValue (name).scriptValue;
        if (value is ScriptMap || value.IsInstance) {
            return AddComponent (obj, value as ScriptInstance, name);
        }
        return null;
    }
    public static ScriptInstance AddComponent (UnityEngine.Object obj, ScriptInstance instance) {
        if (obj == null || instance == null) return null;
        return AddComponent (obj, instance, "");
    }
    public static ScriptInstance AddComponent (UnityEngine.Object obj, ScriptInstance instance, string name) {
        if (obj == null || instance == null) return null;
        EngineUtil.GetGameObject (obj).AddComponent<ScriptComponent> ().Initialize (instance, name);
        return instance;
    }

    public static ScriptInstance GetComponent (UnityEngine.Object obj) {
        if (obj == null) return null;
        var component = EngineUtil.GetGameObject (obj).GetComponent<ScriptComponentBase> ();
        if (component == null) return null;
        return component.Table;
    }
    public static ScriptInstance GetComponent (UnityEngine.Object obj, string name) {
        if (obj == null) return null;
        var components = EngineUtil.GetGameObject (obj).GetComponents<ScriptComponentBase> ();
        foreach (var component in components) {
            if (component.Name == name)
                return component.Table;
        }
        return null;
    }

    public static ScriptInstance GetOrAddComponent(UnityEngine.Object obj, ScriptInstance instance, string name) {
        if (obj == null) return null;
        var gameObject = EngineUtil.GetGameObject(obj);
        var components = gameObject.GetComponents<ScriptComponentBase>();
        foreach (var component in components) {
            if (component.Name == name)
                return component.Table;
        }
        return gameObject.AddComponent<ScriptComponent>().Initialize(instance, name);
    }

    public static void DelComponent (UnityEngine.Object obj) {
        if (obj == null) return;
        var component = EngineUtil.GetGameObject (obj).GetComponent<ScriptComponentBase> ();
        if (component == null) return;
        Object.Destroy (component);
    }
    public static void DelComponent (UnityEngine.Object obj, string name) {
        if (obj == null) return;
        var components = EngineUtil.GetGameObject (obj).GetComponents<ScriptComponentBase> ();
        foreach (var component in components) {
            if (component.Name == name) {
                Object.Destroy (component);
            }
        }
    }
    public static void RegisterOnClick (UnityEngine.Object obj, ScriptFunction func, bool clear, ScriptValue thisObject) {
        RegisterOnClick(obj, func, clear, thisObject, false, ScriptValue.Null);
    }
    public static void RegisterOnClick (UnityEngine.Object obj, ScriptFunction func, bool clear, ScriptValue thisObject, bool mute, ScriptValue args) {
        if (obj == null) return;
        if (func == null) {
            return;
        }
        var gameObject = EngineUtil.GetGameObject(obj);
        var button = gameObject.GetComponent<Button>();
        if (button == null) {
            button = gameObject.AddComponent<Button>();
            var colorBlock = button.colors;
            var color = button.colors.disabledColor;
            color.a = 1;
            colorBlock.disabledColor = color;
            button.colors = colorBlock;
        }
        if (clear) { 
            button.onClick = new Button.ButtonClickedEvent ();
        }
        button.onClick.AddListener (() => {
            if (args.IsNull) {
                func.Call (thisObject, ScriptValue.EMPTY, 0); 
            } else {
                func.Call (thisObject, new[] { args }, 1);
            }
        });
    }
}