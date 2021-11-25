using System;
public class ScriptUpdateComponent : ScriptComponent {
    void Update() {
        Call("Update");
    }
    void FixedUpdate() {
        Call("FixedUpdate");
    }
}
