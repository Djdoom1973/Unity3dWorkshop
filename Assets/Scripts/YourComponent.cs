using UnityEngine;
using System.Collections;

public class YourComponent : MonoBehaviour {
	void Start () {
		Debug.Log ("Start");
	}

	void Update(){
		Debug.LogFormat ("Time={0}", Time.time);
	}
}