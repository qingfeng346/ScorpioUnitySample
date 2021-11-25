using System;
public class ScriptComponentFixedUpdate : ScriptComponentBase {
    public const string StringFixedUpdate = "FixedUpdate";
    void FixedUpdate() {
        Call(StringFixedUpdate);
    }
}
