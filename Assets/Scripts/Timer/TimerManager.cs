using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
public class TimerManager
{
    private static TimerManager instance = null;
    public static TimerManager GetInstance() { return instance ?? (instance = new TimerManager()); }
    private List<Timer> m_Timers = new List<Timer>();                       //当前正在运行的所有计时器
    private List<Timer> m_AddTimers = new List<Timer>();					//要添加的计时器数组 下一帧统一添加
    private List<Timer> m_DelTimers = new List<Timer>();					//要删除的计时器数组 下一帧统一删除
	private GameObject m_TimerGameObject = null;							//计时器GameObject
	public float GameTime { get; private set; }
	public float RealTime { get; private set; }
	/// <summary> 初始化单例时调用函数 </summary>
	private TimerManager() {
		m_TimerGameObject = new GameObject("__Timer");
		m_TimerGameObject.AddComponent<TimerBehaviour> ();
	}
    /// <summary> 普通循环 </summary>
    public void OnUpdate() {
		GameTime = Time.time;
		RealTime = Time.realtimeSinceStartup;
        int count = m_DelTimers.Count;
        if (count > 0) {
            for (var i = 0;i < count; ++i) {
                m_Timers.Remove(m_DelTimers[i]);
            }
        }
        count = m_AddTimers.Count;
        if (count > 0) {
            for (var i = 0; i < count; ++i) {
                Timer timer = m_AddTimers[i];
                if (!m_Timers.Contains(timer)) m_Timers.Add(timer);
            }
        }
        m_AddTimers.Clear();
        m_DelTimers.Clear();
        count = m_Timers.Count;
        for (var i = 0; i< count;++i) {
            m_Timers[i].OnUpdate();
        }
    }
    public void AddTimer(Timer timer) {
        //此处不判断 m_Timers.Contains(timer) 是因为 如果一个计时器 在Callback回调里 ResetLength  m_Timer里面还没有删除此计时器
        if (!m_AddTimers.Contains(timer))
            m_AddTimers.Add(timer);
    }
    public void DelTimer(Timer timer) {
        if (!m_DelTimers.Contains(timer))
            m_DelTimers.Add(timer);
    }
    /// <summary> 添加游戏时间计时器 </summary>
    public Timer AddGameTimer(float length, TimerCallBack callBack) {
		return AddGameTimer (length, callBack, null);
	}
    /// <summary> 添加游戏时间计时器 </summary>
    public Timer AddGameTimer(float length, TimerCallBack callBack, object args) {
        return new Timer(TimerType.Game, callBack).ResetLength(length, args);
    }
	/// <summary> 添加真实时间计时器 </summary>
	public Timer AddRealTimer(float length, TimerCallBack callBack) {
		return AddRealTimer (length, callBack, null);
	}
    /// <summary> 添加真实时间计时器 </summary>
    public Timer AddRealTimer(float length, TimerCallBack callBack, object args) {
        return new Timer(TimerType.Real, callBack).ResetLength(length, args);
    }
	/// <summary> 暂停计时器 </summary>
	public void Pause(TimerType type) {
		foreach (Timer timer in m_Timers) {
			if (timer.TimerType == type)
				timer.Pause();
		}
	}
	/// <summary> 继续计时器 </summary>
	public void Play(TimerType type) {
		foreach (Timer timer in m_Timers) {
			if (timer.TimerType == type)
				timer.Play();
		}
	}
	/// <summary> 暂停所有计时器 </summary>
	public void Pause() {
		foreach (Timer timer in m_Timers) {
			timer.Pause();
		}
	}
	/// <summary> 继续所有计时器 </summary>
	public void Play() {
		foreach (Timer timer in m_Timers) {
			timer.Play();
		}
	}
	/// <summary> 清除计时器 </summary>
	public void Shutdown(TimerType type) {
		foreach (var timer in m_Timers) {
			if (timer.TimerType == type)
                timer.Shutdown();
		}
	}
    /// <summary> 清除计时器 </summary>
    public void Shutdown() {
        foreach (var timer in m_Timers) {
			timer.Shutdown();
        }
    }
}
