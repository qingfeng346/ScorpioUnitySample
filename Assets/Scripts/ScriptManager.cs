using UnityEngine;
using System.Collections;
using Scorpio;
using Scorpio.Userdata;
public class ScriptManager {
    private static ScriptManager instance = null;
    public static ScriptManager Instance => instance ?? (instance = new ScriptManager());
    private Script m_Script = null;         //脚本引擎
    public bool Ended = false;
    public ScriptManager() {
        m_Script = new Script();
        m_Script.LoadLibraryV1();
        TypeManager.PushAssembly(typeof(System.Action).Assembly);                       //System.Core.dll
        TypeManager.PushAssembly(typeof(GameObject).Assembly);                          //UnityEngine.CoreModule.dll
        TypeManager.PushAssembly(typeof(GUIText).Assembly);                             //UnityEngine.TextRenderingModule.dll
        TypeManager.PushAssembly(typeof(UnityEngine.UI.CanvasScaler).Assembly);         //UnityEngine.UI.dll
        TypeManager.PushAssembly(typeof(Rigidbody).Assembly);                           //UnityEngine.PhysicsModule.dll
        TypeManager.PushAssembly(typeof(AudioSource).Assembly);                         //UnityEngine.AudioModule.dll
        m_Script.SetGlobal("print", m_Script.CreateFunction(new ScriptPrint()));            //载入print函数
        m_Script.SetGlobal("loadfile", m_Script.CreateFunction(new ScriptLoadScript()));    //载入loadfile函数  根据自己需求自己修改，如果是普通路径可以查看 require 函数
        DelegateFactory.Initialize(m_Script);
    }
    public Script GetScript() { return m_Script; }
    public void Start(ScriptLaunch.Value[] values) {
        var objs = m_Script.CreateMap();
        foreach (var val in values) {
            objs.SetValue(val.name, ScriptValue.CreateValue(val.obj));
        }
        m_Script.SetGlobal("objs", new ScriptValue(objs));
        LoadFile("main");
    }
    public ScriptValue LoadFile(string file) {
        //Resource文件后缀改成txt  否则Unity不能识别TextAsset
        TextAsset text = Resources.Load<TextAsset>("Scripts/" + file);
        if (text != null)
        {
            try
            {
                return m_Script.LoadBuffer(file, text.bytes);
            }
            catch (System.Exception e)
            {
                Debug.LogError($"加载文件[{file}] 出错 : " + e.ToString());
            }
        }
        else
        {
            Debug.LogError("找不到File : " + file);
        }
        
        return ScriptValue.Null;
    }

    public ScriptInstance AddComponent(UnityEngine.Object obj, string name) {
        if (obj == null || string.IsNullOrEmpty(name)) return null;
        var value = m_Script.Global.GetValue (name).scriptValue;
        if (value is ScriptMap || value.IsInstance) {
            return AddComponent (obj, value as ScriptInstance, name);
        }
        return null;
    }
    public ScriptInstance AddComponent(UnityEngine.Object obj, ScriptInstance instance) {
        if (obj == null || instance == null) return null;
        return AddComponent (obj, instance, "");
    }
    public ScriptInstance AddComponent(UnityEngine.Object obj, ScriptInstance instance, string name) {
        if (obj == null || instance == null) return null;
        EngineUtil.GetGameObject (obj).AddComponent<ScriptComponent> ().Initialize (instance, name);
        return instance;
    }
    public ScriptInstance GetComponent(UnityEngine.Object obj) {
        if (obj == null) return null;
        var component = EngineUtil.GetGameObject (obj).GetComponent<ScriptComponentBase> ();
        if (component == null) return null;
        return component.Table;
    }
    public ScriptInstance GetComponent (UnityEngine.Object obj, string name) {
        if (obj == null) return null;
        var components = EngineUtil.GetGameObject (obj).GetComponents<ScriptComponentBase> ();
        foreach (var component in components) {
            if (component.Name == name)
                return component.Table;
        }
        return null;
    }
    public void DelComponent (UnityEngine.Object obj) {
        if (obj == null) return;
        var component = EngineUtil.GetGameObject (obj).GetComponent<ScriptComponentBase> ();
        if (component == null) return;
        Object.Destroy (component);
    }
    public void DelComponent (UnityEngine.Object obj, string name) {
        if (obj == null) return;
        var components = EngineUtil.GetGameObject (obj).GetComponents<ScriptComponentBase> ();
        foreach (var component in components) {
            if (component.Name == name) {
                Object.Destroy (component);
            }
        }
    }
}
