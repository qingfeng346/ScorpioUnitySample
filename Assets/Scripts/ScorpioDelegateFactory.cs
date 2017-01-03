using System;
using Scorpio;
using Scorpio.Userdata;
namespace ScorpioDelegate {
    public class ScorpioDelegateFactory : DelegateTypeFactory {
        public static void Initialize() {
            ScriptUserdataDelegateType.SetFactory(new ScorpioDelegateFactory());
        }
        public Delegate CreateDelegate(Script script, Type type, ScriptFunction func) {
            if (type == typeof(System.Action))
                return new System.Action(() => { func.call(); });
            if (type == typeof(System.Action<System.String>))
                return new System.Action<System.String>((arg0) => { func.call(arg0); });
            if (type == typeof(System.Comparison<UnityEngine.Transform>))
                return new System.Comparison<UnityEngine.Transform>((arg0,arg1) => { return (System.Int32)Convert.ChangeType(script.CreateObject(func.call(arg0,arg1)).ObjectValue, typeof(System.Int32)); });
            if (type == typeof(TimerCallBack))
                return new TimerCallBack((arg0,arg1) => { func.call(arg0,arg1); });
            if (type == typeof(UnityEngine.Application.LogCallback))
                return new UnityEngine.Application.LogCallback((arg0,arg1,arg2) => { func.call(arg0,arg1,arg2); });
            if (type == typeof(UnityEngine.Events.UnityAction))
                return new UnityEngine.Events.UnityAction(() => { func.call(); });
            if (type == typeof(UnityEngine.Events.UnityAction<System.Boolean>))
                return new UnityEngine.Events.UnityAction<System.Boolean>((arg0) => { func.call(arg0); });
            if (type == typeof(UnityEngine.Events.UnityAction<System.Int32>))
                return new UnityEngine.Events.UnityAction<System.Int32>((arg0) => { func.call(arg0); });
            if (type == typeof(UnityEngine.Events.UnityAction<System.Single>))
                return new UnityEngine.Events.UnityAction<System.Single>((arg0) => { func.call(arg0); });
            if (type == typeof(UnityEngine.Events.UnityAction<System.String>))
                return new UnityEngine.Events.UnityAction<System.String>((arg0) => { func.call(arg0); });
            if (type == typeof(UnityEngine.Events.UnityAction<UnityEngine.Vector2>))
                return new UnityEngine.Events.UnityAction<UnityEngine.Vector2>((arg0) => { func.call(arg0); });
            if (type == typeof(UnityEngine.Networking.NetworkMessageDelegate))
                return new UnityEngine.Networking.NetworkMessageDelegate((arg0) => { func.call(arg0); });
            if (type == typeof(YieldCallback))
                return new YieldCallback(() => { func.call(); });
            throw new Exception("Delegate Type is not found : " + type + "  func : " + func);
        }
    }
}