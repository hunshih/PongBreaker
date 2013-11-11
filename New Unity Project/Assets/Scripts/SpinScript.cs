using UnityEngine;
using System.Collections;

public class SpinScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.R(0, 10, 0);
		//transform.RotateAround(new Vector3( 0, 0, 0), new Vector3(0, 1, 0), 0.1f);
		transform.Rotate(Vector3.up * Time.deltaTime * 100f);
		
	}
}
