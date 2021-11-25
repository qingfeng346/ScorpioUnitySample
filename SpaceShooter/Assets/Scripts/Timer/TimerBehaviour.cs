using UnityEngine;
using System.Collections;

public class TimerBehaviour : MonoBehaviour {
	void FixedUpdate () {
		TimerManager.GetInstance ().OnUpdate ();
	}
}
