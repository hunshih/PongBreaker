using UnityEngine;
using System.Collections;

public class FollowPaddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		string paddleName ;
		if (this.gameObject.name == "PointLight1")
			paddleName = "Player1Paddle";
		else
			paddleName = "Player2Paddle";
		var paddle = GameObject.Find(paddleName);
		transform.position = new Vector3( paddle.transform.position.x, transform.position.y, paddle.transform.position.z);
	}
}
