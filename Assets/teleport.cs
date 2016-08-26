using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {
	public Transform target;
	public Vector3 position;
	public void jump(){
		target.position = position;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
