using UnityEngine;
using System;
using System.Collections.Generic;
using Scorpio;
public class ScriptComponentBase : MonoBehaviour
{
    public string Name = "";            //脚本Table名称，删除脚本时根据此字段做关键字
    public ScriptInstance Table { get; protected set; }
    public ScriptValue Value { get; protected set; }
    public virtual ScriptInstance Initialize(ScriptInstance table, string name) {
        Table = table;
        Name = name;
        Value = new ScriptValue(table);
        return table;
    }
    public object Call(string funcName, params object[] args) {
        if (ScriptManager.Instance.Ended) { return null; }
        var func = Table == null ? ScriptValue.Null : Table.GetValue(funcName);
        if (func.valueType == ScriptValue.scriptValueType) {
            try {
                func.call(Value, args);
            } catch (Exception e) {
                UnityEngine.Debug.LogError($"ScriptComponent.Call is error func:{funcName}  {e.ToString()}");
            }
        }
        return null;
    }
}
