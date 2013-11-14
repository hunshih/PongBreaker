using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerupSpawn : MonoBehaviour {
	public GameObject 		myPrefab;
	public float			radius = 4f;
	public List<GameObject>	spawnedPowerups;
	
	// Use this for initialization
	void Start () {
		spawnedPowerups = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space)) {
			
			float x_range = 20/100f;
			
			int rand = Random.Range(-100, 100);
			float x = x_range * rand;
			
			float y = 0.5f;
			
			float z_range = 10/100f;
			rand = Random.Range(-100, 100);
			float z = z_range * rand;
			
			Vector3 pos = new Vector3(x, y, z);
			GameObject go = Instantiate(myPrefab, pos, transform.rotation) as GameObject;	
			go.name = "Powerup";
			spawnedPowerups.Add (go);
		}
	}
}
