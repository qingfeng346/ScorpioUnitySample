using UnityEngine;
using System;
using System.Collections;
public class ScriptLaunch : MonoBehaviour {
    [Serializable]
    public class Value {
        public string name;
        public GameObject obj;
    }
    public Value[] values;
    void Start() {
        ScriptManager.GetInstance().Start(values);
    }
}
