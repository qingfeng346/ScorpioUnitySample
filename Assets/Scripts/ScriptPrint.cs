using UnityEngine;
using Scorpio;

public class ScriptPrint : ScorpioHandle {
    public object Call(ScriptObject[] args) {
        var stackInfo = ScriptManager.GetInstance().GetScript().GetCurrentStackInfo();
        var prefix = stackInfo.Breviary + ":" + stackInfo.Line + " : ";
        string str = "";
        for (int i = 0; i < args.Length; ++i) {
            str += args[i].ToString() + " ";
        }
        Debug.Log(prefix + str);
        return null;
    }
}
public class ScriptLoadScript : ScorpioHandle {
    private Script m_script;
    public ScriptLoadScript(Script script) {
        m_script = script;
    }
    public object Call(ScriptObject[] args) {
        ScriptString str = args[0] as ScriptString;
        Util.Assert(str != null, m_script, "LoadScript 参数必须是 string");
        return ScriptManager.GetInstance().LoadFile(str.Value);
    }
}