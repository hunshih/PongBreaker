﻿using UnityEngine;
using System.Collections;

public class Player2Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(35f * Time.deltaTime * Input.GetAxis("Horizontal2"), 0, 0);	
	}
}
