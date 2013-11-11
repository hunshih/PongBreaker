using UnityEngine;
using System.Collections;

public class ball_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.AddForce( -350f, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
}
