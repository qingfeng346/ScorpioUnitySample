using UnityEngine;
using System;
using System.Collections.Generic;
public enum TimerType {
    /// <summary> 引擎真实时间 </summary>
    Real,
    /// <summary> 游戏时间 游戏加速此计时器有影响 </summary>
    Game,
	/// <summary> 本地时钟时间 </summary>
	Clock,
}
/// <summary> 计时器回调 </summary>
public delegate void TimerCallBack(Timer timeCallBack, object args);
public class Timer {
    private static readonly DateTime BaseTime = new DateTime(1970, 1, 1);	//时间起始时间
    private static long mStartTime = BaseTime.Ticks;						//开始时间
    /// <summary> 计时器时间类型 (游戏时间或者真实时间) </summary>
    public TimerType TimerType { get; private set; }
    /// <summary> 计时器时长 </summary>
    public float Length { get; private set; }
    /// <summary> 计时器回调 </summary>
    public TimerCallBack CallBack { get; set; }
    /// <summary> 计时器是否已经结束 </summary>
    public bool IsOver { get; private set; }
    private object m_Args;              //计时器参数
    private float m_StartTime;      	//计时器开始时间
	private long m_RealStartTime;		//计时器开始时间 本地时间
	private float m_PauseTime;			//计时器暂停的时间
	private long m_RealPauseTime;		//计时器暂停时间
	public bool IsPause { get; private set; }
    public Timer(TimerType timeType, TimerCallBack callBack) {
        this.TimerType = timeType;
        this.CallBack = callBack;
        this.IsPause = false;
        this.IsOver = true;
    }
	public float NowTime { get { return TimerType == TimerType.Game ? TimerManager.GetInstance().GameTime : TimerManager.GetInstance().RealTime; } }
	public long RealNowTime { get { return Decimal.ToInt64(Decimal.Divide(DateTime.UtcNow.Ticks - mStartTime, 10000)); } }
    /// <summary> 重置计时器时间 可以设置剩余时间 </summary>
    public Timer ResetLastLength(float length, float lastTime) {
        return ResetLastLength(length, lastTime, null);
    }
    /// <summary> 重置计时器时间 可以设置剩余时间 </summary>
    public Timer ResetLastLength(float length, float lastTime, object args) {
        return ResetPassLength(length, length - lastTime, args);
    }
    /// <summary> 重置计时器时间 可以设置已过时间 </summary>
    public Timer ResetPassLength(float length, float passTime) {
        return ResetPassLength(length, passTime, null);
    }
    /// <summary> 重置计时器时间 可以设置已过时间 </summary>
    /// <param name="length">总时长</param>
    /// <param name="passTime">已过的时长</param>
    /// <param name="args">参数</param>
    public Timer ResetPassLength(float length, float passTime, object args) {
        if (TimerType == TimerType.Clock) {
            this.m_RealStartTime = RealNowTime - Convert.ToInt64(passTime * 1000);
        } else {
            this.m_StartTime = NowTime - passTime;
        }
        this.Length = length;
        this.m_Args = args;
		this.IsPause = false;
        this.IsOver = false;
        TimerManager.GetInstance().AddTimer(this);
        return this;
    }
    /// <summary> 重置计时器时间 如果时间小于等于0 则不调用 </summary>
    public Timer ResetCheckLength(float length) {
        return ResetCheckLength(length, null);
    }
    /// <summary> 重置计时器时间 如果时间小于等于0 则不调用 </summary>
    public Timer ResetCheckLength(float length, object args) {
        if (length <= 0) return this;
        return ResetLength(length, args);
    }
    /// <summary> 重置计时器时间 不检测时间长度 </summary>
    public Timer ResetLength(float length) {
        return ResetLength(length, null);
    }
    /// <summary> 重置计时器时间 不检测时间长度 </summary>
    public Timer ResetLength(float length, object args) {
        if (TimerType == TimerType.Clock) {
            this.m_RealStartTime = RealNowTime;
        } else {
            this.m_StartTime = NowTime;
        }
        this.Length = length;
        this.m_Args = args;
        this.IsPause = false;
        this.IsOver = false;
        TimerManager.GetInstance().AddTimer(this);
        return this;
    }
    /// <summary> 删除计时器 </summary>
    public void Shutdown() {
        IsOver = true;
        TimerManager.GetInstance().DelTimer(this);
    }
	/// <summary> 暂停计时器 </summary>
	public void Pause() {
		if (IsPause == false) {
            IsPause = true;
			m_PauseTime = NowTime;
			m_RealPauseTime = RealNowTime;
		}
	}
	/// <summary> 计时器继续 </summary>
	public void Play() {
		if (IsPause == true) {
            IsPause = false;
			m_StartTime += (NowTime - m_PauseTime);
			m_RealStartTime += (RealNowTime - m_RealPauseTime);
		}
	}
    /// <summary> 计时器持续时间 </summary>
    public float LastTime {  
		get { 
			if (TimerType == TimerType.Clock) {
				return Convert.ToSingle(IsPause ? m_RealPauseTime - m_RealStartTime : RealNowTime - m_RealStartTime) / 1000f;
			} else {
				return IsPause ? m_PauseTime - m_StartTime : NowTime - m_StartTime; 
			}
		} 
	}
    /// <summary> 剩余时间 </summary>
    public float SurplusTime { get { return Length - LastTime; } }
    /// <summary> 持续时间百分比 </summary>
    public float LastPercent { get { return LastTime / Length; } }
    /// <summary> 剩余时间百分比 </summary>
    public float SurplusPercent { get { return SurplusTime / Length; } }
    private void Call() {
        try {
            if (IsOver) return;
            IsOver = true;
            TimerManager.GetInstance().DelTimer(this);
            if (CallBack != null) CallBack(this, m_Args);
        } catch (Exception ex) {
            if (CallBack != null) {
#if UNITY_EDITOR
                string target = CallBack.Target != null ? CallBack.Target.GetType().Name : "";
                string method = CallBack.Method != null ? CallBack.Method.ToString() : "";
				Debug.LogError(string.Format("TimeCallBack is error {0} - {1} stack : {2}{3}", target, method, ScriptManager.GetInstance().GetStackInfo(), ex.ToString()));
#else
				Debug.LogError(string.Format("TimeCallBack is error stack : {0}{1}", ScriptManager.GetInstance().GetStackInfo(), ex.ToString()));
#endif
            } else {
                Debug.LogError(string.Format("TimeCallBack is error : {0}", ex.ToString()));
            }
        }
    }
    /// <summary> 计时器更新 </summary>
    public void OnUpdate() {
        if (SurplusTime < 0) {
            Call();
        }
    }
}
