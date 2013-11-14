using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {
	
	float y_min = 0.5f;
	float x_min = -24.5f;
	float x_max = 24.5f;
	float z_min = -49.5f;
	float z_max = 49.5f;
	
	bool spawned = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if ((rigidbody.velocity.y > 0f) && !spawned){
			finishSpawn();
			spawned = true;
		}
		//maintain constant speed
		rigidbody.velocity = 35 * rigidbody.velocity.normalized;
		
		//No 0 Velocity
		if (spawned && rigidbody.velocity.magnitude == 0){
			float x_dir = Random.Range(-100, 100)/100f;
			float z_dir = Random.Range(-100, 100)/100f;
			
			Vector3 v = new Vector3(x_dir, 0, z_dir) * 50f;
			rigidbody.AddForce(v);
		}
			
			
		
		//Keep it in arena
		if (transform.position.y < y_min){
			transform.position = new Vector3( transform.position.x, y_min, transform.position.z);
		}
		
		if (transform.position.x < x_min){
			transform.position = new Vector3( x_min, transform.position.y, transform.position.z);
		}
		
		if (transform.position.x > x_max){
			//Debug.Log("x" + transform.position.x);
			transform.position = new Vector3( x_max, transform.position.y, transform.position.z);
		}
		
		
		if (transform.position.x < z_min){
			transform.position = new Vector3( transform.position.x, transform.position.y, z_min);
		}
		if (transform.position.x > z_max){
			transform.position = new Vector3( transform.position.x, transform.position.y, z_max);
		}
		
	}
	
	void finishSpawn()
	{
		transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
		//rigidbody.AddForce(0, 0, 50f);
		rigidbody.constraints = RigidbodyConstraints.FreezePositionY;
		
	}
	
}
