using UnityEngine;
using System.Collections;

public class Player1Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(35f * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);	
	}
	
	void OnCollisionEnter (Collision col){
		transform.Translate(-25f * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);	
	}
}
