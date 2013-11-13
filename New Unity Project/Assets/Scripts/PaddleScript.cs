using UnityEngine;
using System.Collections;

public class PaddleScript : MonoBehaviour {
	
	public float paddleSpeed = 35f;
	
	public float maxPos = 19.5f;
	public float minPos = -19.5f;
	string axisName;
	// Use this for initialization
	void Start () {
		
		axisName = rigidbody.position.z < 0 ? "Vertical" : "Vertical2";	
		
		Debug.Log("z: " + rigidbody.position.z + " " + axisName);
	}
	
	
	
	// Update is called once per frame
	void Update () {
		
		
		
		transform.Translate(paddleSpeed * Time.deltaTime * Input.GetAxis(axisName), 0, 0);	
		

		if (transform.position.x > maxPos){
			//Debug.Log("x" + transform.position.x);
			transform.position = new Vector3( maxPos, transform.position.y, transform.position.z);
			
		}
		
		if (transform.position.x < minPos){
			//Debug.Log("x" + transform.position.x);
			transform.position = new Vector3( minPos, transform.position.y, transform.position.z);
		}
	
	}
	
	void OnCollisionEnter(Collision col){
		foreach (ContactPoint contact in col.contacts){
			if (contact.thisCollider == collider){
				float offset = contact.point.x - transform.position.x;
				contact.otherCollider.rigidbody.AddForce( 1500f * offset, 0, 0);
			}
		}
	}
	
}
