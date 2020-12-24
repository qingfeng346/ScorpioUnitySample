using Scorpio.Userdata;
public class ScorpioClassManager {
    public static void Initialize(Scorpio.Script script) {
        TypeManager.SetFastReflectClass(typeof(UnityEngine.GameObject), new ScorpioClass_UnityEngine_GameObject());
   }
}
