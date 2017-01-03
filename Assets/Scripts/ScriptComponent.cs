using UnityEngine;
using System;
using System.Collections.Generic;
using Scorpio;
public class ScriptComponent : MonoBehaviour {
    public string Name = "";            //脚本Table名称，删除脚本时根据此字段做关键字
    private Script m_Script;            //脚本引擎
    public ScriptTable Table { get; private set; }
    public bool IsDestroy { get; private set; }
    public void Initialize(Script script, ScriptTable table, string name) {
        m_Script = script;
        Table = table;
        Name = name;
        table.SetValue("gameObject", script.CreateUserdata(this.gameObject));
        table.SetValue("transform", script.CreateUserdata(this.transform));
        table.SetValue("com", script.CreateUserdata(this));
		FindChild(Table.GetValue("Objects") as ScriptTable);
        OnStart();
    }
    public void FindChild(ScriptTable objects) {
        if (objects == null) { return; }
        var itor = objects.GetIterator();
        while (itor.MoveNext()) {
            var info = itor.Current.Value as ScriptTable;
            var component = info.GetValue("Component").ObjectValue as Type;
            Table.SetValue(itor.Current.Key,
                component == null ?
                m_Script.CreateObject(EngineUtil.FindChild(gameObject, info.GetValue("Path").ToString())) :
                m_Script.CreateObject(EngineUtil.FindChild(gameObject, info.GetValue("Path").ToString(), component)));
        }
    }
    public void OnStart() {
		Call("Awake");
    }
    void Start() {
		Call("Start");
    }
    void OnEnable() {
		Call("OnEnable");
    }
    void OnDisable() {
		Call("OnDisable");
    }
	void OnSpawn() {
		Call ("OnSpawn");
	}
	void OnDespawn() {
		Call ("OnDespawn");
	}
	void OnTriggerEnter(Collider collider) {
		Call ("OnTriggerEnter", collider);
	}
	void OnTriggerExit(Collider collider) {
		Call ("OnTriggerExit", collider);
	}
	void OnTriggerEnter2D(Collider2D collider) {
		Call ("OnTriggerEnter2D", collider);
	}
	void OnTriggerExit2D(Collider2D collider) {
		Call ("OnTriggerExit2D", collider);
	}
	void OnMouseDown() {
		Call ("OnMouseDown");
	}
	void OnMouseEnter() {
		Call ("OnMouseEnter");
	}
	void OnMouseExit() {
		Call ("OnMouseExit");
	}
	void OnMouseUp() {
		Call ("OnMouseUp");
	}
	void OnMouseUpAsButton() {
		Call ("OnMouseUpAsButton");
	}
    void OnDestroy() {
        this.IsDestroy = true;
    }
    void OnCall(ScriptTable table) {
        Call((string)table.GetValue("Func").ObjectValue, table.GetValue("Args"));
    }
    protected void Call(string func, params object[] args) {
        if (Table != null && Table.HasValue(func)) {
            try {
                ((ScriptFunction)Table.GetValue(func)).call(args);
            } catch (Exception e) {
                Debug.LogError(string.Format("ScriptComponent.Call is error func:{0}  {1}{2}", func, Table.Script.GetStackInfo(), e.ToString()));
            }
        }
    }
}
