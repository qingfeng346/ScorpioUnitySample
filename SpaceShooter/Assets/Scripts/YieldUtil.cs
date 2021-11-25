using UnityEngine;
using System.Collections;

public delegate void YieldCallback();
public class YieldUtil : MonoBehaviour {
	public static void Start(System.Object obj, YieldCallback call) {
		new GameObject ().AddComponent<YieldUtil> ().StartYield (obj, call);
	}
	void StartYield(System.Object obj, YieldCallback back) {
		StartCoroutine (StartYield_impl(obj, back));
	}
	IEnumerator StartYield_impl(System.Object obj, YieldCallback back) {
		yield return obj;
        Destroy(gameObject);
        if (back != null) back ();
	}
}
