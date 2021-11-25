using UnityEngine;
using Scorpio;
using System.Text;

public class ScriptPrint : ScorpioHandle {
    public ScriptValue Call(ScriptValue thisObject, ScriptValue[] args, int length)
    {
        var builder = new StringBuilder();
        var stackInfo = ScriptManager.Instance.GetScript().GetStackInfo();
        builder.Append ($"{stackInfo.Breviary}:{stackInfo.Line} ");
        var prefix = stackInfo.Breviary + ":" + stackInfo.Line + " : ";
        for (int i = 0; i < length; ++i) {
            if (i != 0) { builder.Append ("    "); }
            builder.Append (args[i].ToString ());
        }
        Debug.Log(builder.ToString());
        return ScriptValue.Null;
    }
}
public class ScriptLoadScript : ScorpioHandle {
    public ScriptValue Call(ScriptValue thisObject, ScriptValue[] args, int length) {
        return ScriptManager.Instance.LoadFile(args[0].ToString());
    }
}