using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.AddForce(5f, 0, 50f);
		//rigidbody.velocity = 100 * Vector3.right;
	}
	
	// Update is called once per frame
	void Update () {
		//maintain constant speed
		rigidbody.velocity = 35 * rigidbody.velocity.normalized;
	}
	
	void onCollisionEnter (Collision col) {
		
		foreach (ContactPoint contact in col.contacts) {
			if (contact.otherCollider == collider) {
				// this is the paddle's contact point
				float english = contact.point.x - contact.otherCollider.transform.position.x;
				contact.thisCollider.rigidbody.AddForce(300f * english, 0, 0);
				
		
			}
		}
		
	}
}
