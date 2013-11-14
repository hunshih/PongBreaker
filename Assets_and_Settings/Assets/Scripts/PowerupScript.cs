using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 0.5f, 0.5f * Time.deltaTime );	
	
	}
}
