using UnityEngine;
using System.Collections;
using Scorpio;
public class ScriptManager {
    private static ScriptManager instance = null;
    public static ScriptManager GetInstance() { return instance ?? (instance = new ScriptManager());  }
    private Script m_Script = null;         //脚本引擎
    public ScriptManager() {
        ScorpioDelegate.ScorpioDelegateFactory.Initialize();
        m_Script = new Script();
        m_Script.LoadLibrary();
        m_Script.PushAssembly(typeof(System.Action).GetTypeInfo().Assembly);                        //System.Core.dll
        m_Script.PushAssembly(typeof(GameObject).GetTypeInfo().Assembly);                           //UnityEngine.dll
        m_Script.PushAssembly(typeof(UnityEngine.UI.CanvasScaler).GetTypeInfo().Assembly);          //UnityEngine.UI.dll
        m_Script.PushAssembly(typeof(UnityEngine.Networking.MsgType).GetTypeInfo().Assembly);       //UnityEngine.Networking.dll
        m_Script.SetObject("print", m_Script.CreateFunction(new ScriptPrint()));                    //载入print函数
        m_Script.SetObject("loadfile", m_Script.CreateFunction(new ScriptLoadScript(m_Script)));    //载入loadfile函数  根据自己需求自己修改，如果是普通路径可以查看 require 函数
    }
    public Script GetScript() { return m_Script; }
    public string GetStackInfo() { return m_Script != null ? m_Script.GetStackInfo() : ""; }
    public void Start(ScriptLaunch.Value[] values) {
        ScriptTable objs = m_Script.CreateTable();
        foreach (var val in values) {
            objs.SetValue(val.name, m_Script.CreateObject(val.obj));
        }
        m_Script.SetObject("objs", objs);
        LoadFile("main");
    }
    public ScriptObject LoadFile(string file) {
        //Resource文件后缀改成txt  否则Unity不能识别TextAsset
        TextAsset text = Resources.Load<TextAsset>("Scripts/" + file);
        if (text != null) {
            //第一个参数是脚本摘要 有需求可以自己定义
            return m_Script.LoadBuffer(file, text.bytes);
        }
        Debug.LogError("找不到File : " + file);
        return null;
    }

    public ScriptTable AddComponent(Component component, string name) {
        if (component == null || string.IsNullOrEmpty(name)) return null;
        return AddComponent(component.gameObject, name);
    }
    public ScriptTable AddComponent(GameObject gameObject, string name) {
        if (gameObject == null || string.IsNullOrEmpty(name)) return null;
        var table = m_Script.GetValue(name) as ScriptTable;
        if (table == null) return null;
        return AddComponent(gameObject, table, name);
    }
    public ScriptTable AddComponent(Component component, ScriptTable table) {
        if (component == null || table == null) return null;
        return AddComponent(component.gameObject, table, "");
    }
    public ScriptTable AddComponent(GameObject gameObject, ScriptTable table) {
        if (gameObject == null || table == null) return null;
        return AddComponent(gameObject, table, "");
    }
    public ScriptTable AddComponent(Component component, ScriptTable table, string name) {
        if (component == null || table == null) return null;
        return AddComponent(component.gameObject, table, name);
    }
    public ScriptTable AddComponent(GameObject gameObject, ScriptTable table, string name) {
        if (gameObject == null || table == null) return null;
        if (table.HasValue("Update") || table.HasValue("FixedUpdate"))
            gameObject.AddComponent<ScriptUpdateComponent>().Initialize(m_Script, table, name);
        else
            gameObject.AddComponent<ScriptComponent>().Initialize(m_Script, table, name);
        return table;
    }
    public ScriptTable GetComponent(Component component) {
        if (component == null) return null;
        return GetComponent(component.gameObject);
    }
    public ScriptTable GetComponent(GameObject gameObject) {
        if (gameObject == null) return null;
        ScriptComponent component = gameObject.GetComponent<ScriptComponent>();
        if (component == null) return null;
        return component.Table;
    }
    public ScriptTable GetComponent(Component component, string name) {
        if (component == null) return null;
        return GetComponent(component.gameObject, name);
    }
    public ScriptTable GetComponent(GameObject gameObject, string name) {
        if (gameObject == null) return null;
        ScriptComponent[] components = gameObject.GetComponents<ScriptComponent>();
        foreach (ScriptComponent component in components) {
            if (component.Name == name)
                return component.Table;
        }
        return null;
    }

    public void DelComponent(Component component) {
        if (component == null) return;
        DelComponent(component.gameObject);
    }
    public void DelComponent(GameObject gameObject) {
        if (gameObject == null) return;
        ScriptComponent component = gameObject.GetComponent<ScriptComponent>();
        if (component == null) return;
        Object.Destroy(component);
    }
    public void DelComponent(Component component, string name) {
        if (component == null) return;
        DelComponent(component.gameObject, name);
    }
    public void DelComponent(GameObject gameObject, string name) {
        if (gameObject == null) return;
        ScriptComponent[] components = gameObject.GetComponents<ScriptComponent>();
        foreach (ScriptComponent component in components) {
            if (component.Name == name) {
                Object.Destroy(component);
                return;
            }
        }
    }
}
