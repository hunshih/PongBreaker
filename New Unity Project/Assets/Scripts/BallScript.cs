using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.AddForce(0, 0, 50f);
		//rigidbody.velocity = 100 * Vector3.right;
	}
	
	// Update is called once per frame
	void Update () {
		//maintain constant speed
		rigidbody.velocity = 35 * rigidbody.velocity.normalized;
	}
	
}
