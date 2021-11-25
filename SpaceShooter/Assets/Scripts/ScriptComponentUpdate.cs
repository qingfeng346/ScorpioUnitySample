using System;
public class ScriptComponentUpdate : ScriptComponentBase {
    public const string StringUpdate = "Update";
    void Update() {
        Call(StringUpdate);
    }
}
