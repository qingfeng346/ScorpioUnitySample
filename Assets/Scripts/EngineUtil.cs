using System;
using UnityEngine;
public static class EngineUtil {
    public static GameObject FindChild(Component com, string str) {
        if (com == null) return null;
        return FindChild(com.gameObject, str);
    }
    public static GameObject FindChild(GameObject go, string str) {
        if (go == null) return null;
        if (string.IsNullOrEmpty(str)) return go;
        Transform trans = go.transform.FindChild(str);
        if (trans == null) return null;
        return trans.gameObject;
    }
    public static object FindChild(Component com, string str, Type type) {
        if (com == null) return null;
        return FindChild(com.gameObject, str, type);
    }
    public static object FindChild(GameObject go, string str, Type type) {
        GameObject obj = FindChild(go, str);
        if (obj == null) return null;
        return obj.GetComponent(type);
    }
    public static Component GetComponent(Component com, Type type) {
        if (com == null) return null;
        return GetComponent(com.gameObject, type);
    }
    public static Component GetComponent(GameObject obj, Type type) {
        if (obj == null) return null;
        return obj.GetComponent(type);
    }
    public static GameObject GetGameObject (UnityEngine.Object obj) { return obj is Component ? (obj as Component).gameObject : obj as GameObject; }
}
