using UnityEngine;
using System.Collections;

public class peddle_script : MonoBehaviour {
	
	float peddle_speed = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Vertical") > 0)
		{
			//Debug.Log("UP!");	
			transform.Translate(0, peddle_speed*Time.deltaTime,0);
		}
		if (Input.GetAxis("Vertical") < 0)
		{
			//Debug.Log("DOWN!");	
			transform.Translate(0, -peddle_speed*Time.deltaTime,0);
		}
	}
	
	void OnCollisionEnter(Collision col)
	{
		foreach (ContactPoint contact in col.contacts) 
		{
            if(contact.thisCollider == collider)
			{
				Debug.Log("HIT!");
				//PEDDLE'S CONTACT POINT
				float offset = contact.point.y - transform.position.y;
				
				contact.otherCollider.rigidbody.AddForce(0, 500f* offset, 0);
			}
        }
	}
}
