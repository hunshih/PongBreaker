using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LotsaSpawn : MonoBehaviour {
	public GameObject 		myPrefab;
	public float			radius = 16f;
	public List<GameObject>	Powerups;
	
	// Use this for initialization
	void Start () {
		Powerups = new List<GameObject>();
		GameObject go = Instantiate(myPrefab) as GameObject;
		go.transform.position = Random.insideUnitSphere*radius;
		Powerups.Add(go);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space)) {
			GameObject go = Instantiate(myPrefab) as GameObject;
			go.transform.position = Random.insideUnitSphere*radius;
			//spawnedObjects.Add(go);
		}
	}
}