using System;
using System.Collections.Generic;
using Scorpio;
using UnityEngine;
public class ScriptComponent : ScriptComponentBase
{
    public bool IsDestroy { get; private set; } = false;
    public override ScriptInstance Initialize (ScriptInstance table, string name) {
        base.Initialize (table, name);
        if (table.GetValue (ScriptComponentUpdate.StringUpdate).IsScriptObject) {
            gameObject.AddComponent<ScriptComponentUpdate> ().Initialize (table, name);
        }
        if (table.GetValue (ScriptComponentFixedUpdate.StringFixedUpdate).IsScriptObject) {
            gameObject.AddComponent<ScriptComponentFixedUpdate> ().Initialize (table, name);
        }
        table.SetValue ("gameObject", ScriptValue.CreateValue (this.gameObject));
        table.SetValue ("transform", ScriptValue.CreateValue (this.transform));
        table.SetValue ("com", ScriptValue.CreateValue (this));
        // SetObjects(gameObject.GetComponent<ScriptComponentObjects>());
        FindChild (Table.GetValue ("Objects").Get<ScriptMap> ());
        RegisterButtonClick (Table.GetValue ("Buttons").Get<ScriptArray> ());
        OnStart ();
        return table;
    }
    // void SetObjects(ScriptComponentObjects objects) {
    //     if (objects == null) { return; }
    //     foreach (var value in objects.values) {
    //         if (!string.IsNullOrEmpty(value.name) && value.value != null) {
    //             Table.SetValue(value.name, ScriptValue.CreateValue(value.value));
    //         }
    //     }
    //     foreach (var click in objects.clicks) {
    //         if (!string.IsNullOrEmpty(click.click) && click.button != null) {
    //             var clickFunc = Table.GetValue (click.click).Get<ScriptFunction> ();
    //             if (clickFunc == null) { continue; }
    //             ScriptUtil.RegisterOnClick(click.button, clickFunc, !click.keepClick, Value, click.mute, new ScriptValue(click.args));
    //         }
    //     }
    // }
    void FindChild (ScriptMap objects) {
        if (objects == null) { return; }
        foreach (var info in objects) {
            var component = info.Value.GetValue ("Component").Get<ScriptObject> ();
            var path = info.Value.GetValue ("Path").ToString ();
            Table.SetValue (info.Key.ToString (), ScriptValue.CreateValue (component == null ? EngineUtil.FindChild (gameObject, path) : EngineUtil.FindChild (gameObject, path, component.Type)));
        }
    }
    void RegisterButtonClick (ScriptArray buttons) {
        if (buttons == null) { return; }
        foreach (var pair in buttons) {
            var info = pair.Get<ScriptMap> ();
            if (info == null) { continue; }
            var click = Table.GetValue (info.GetValue ("Click").ToString ()).Get<ScriptFunction> ();
            if (click == null) { continue; }
            ScriptUtil.RegisterOnClick (EngineUtil.FindChild (gameObject, info.GetValue ("Path").ToString ()), 
                click, 
                !info.GetValue ("Keep").IsTrue, 
                Value, 
                info.GetValue("Mute").IsTrue,
                info.GetValue("Args"));
        }
    }
    void OnStart () {
        Call ("Awake");
    }
    void Start() {
        Call ("Start");
    }
    void OnTriggerEnter (Collider collider) {
        Call ("OnTriggerEnter", collider);
    }
    void OnTriggerExit (Collider collider) {
        Call ("OnTriggerExit", collider);
    }
    void OnTriggerEnter2D (Collider2D collider) {
        Call ("OnTriggerEnter2D", collider);
    }
    void OnTriggerExit2D (Collider2D collider) {
        Call ("OnTriggerExit2D", collider);
    }
    void OnEnable () {
        Call ("OnEnable");
    }
    void OnDisable () {
        Call ("OnDisable");
    }
    void OnDestroy()
    {
        this.IsDestroy = true;
        Call ("OnDestroy");
    }
    void OnSpawn () {
        Call ("OnSpawn");
    }
    void OnDespawn () {
        Call ("OnDespawn");
    }
    void OnCall (ScriptMap table) {
        Call (table.GetValue ("Func").ToString (), table.GetValue ("Args"));
    }
}
public static class ScriptComponentExtension {
    public static void CallScript (this Component component, string func, params object[] args) {
        if (component == null) { return; }
        CallScript (component.gameObject, func, args);
    }
    public static void CallScript (this GameObject obj, string func, params object[] args) {
        if (obj == null) { return; }
        var coms = obj.GetComponents<ScriptComponent> ();
        foreach (var com in coms) {
            com.Call (func, args);
        }
    }
}