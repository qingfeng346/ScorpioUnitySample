using UnityEngine;
using UnityEngine.Events;
using UnityEditor;
using System;
public class BuildScorpioDelegate {
	[MenuItem("Assets/生成sco DelegateFactory", false, -89)]
	public static void Build() {
        var types = new Type[] {
            typeof(System.Action),
            typeof(System.Action<string>),                          //Connection连接服务器回调
            typeof(UnityAction),                                    //UGUI控件事件
			typeof(UnityAction<bool>),                              //UGUI控件事件
			typeof(UnityAction<float>),                             //UGUI控件事件
			typeof(UnityAction<int>),                               //UGUI控件事件
			typeof(UnityAction<string>),                            //UGUI控件事件
			typeof(UnityAction<Vector2>),                           //UGUI控件事件
            typeof(UnityEngine.Networking.NetworkMessageDelegate),  //unet消息回调
			typeof(Comparison<Transform>),                          //Transform排序
			typeof(Application.LogCallback),                        //系统日志
			typeof(YieldCallback),                                  //yield回调
			typeof(TimerCallBack),                                  //计时器回调
		};
		var generate = new Scorpio.ScorpioReflect.GenerateScorpioDelegate();
		foreach (var type in types) {
			generate.AddType(type);
		}
        System.IO.File.WriteAllBytes(Application.dataPath + "/Scripts/" + generate.ClassName + ".cs", System.Text.Encoding.UTF8.GetBytes(generate.Generate()));
		AssetDatabase.Refresh();
	}
}
