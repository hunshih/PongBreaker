using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnBricks : MonoBehaviour {

	public GameObject 		myPrefab;
	public float			radius = 4f;
	public List<GameObject>	player1Bricks;
	public List<GameObject>	player2Bricks;
	
	// Use this for initialization
	void Start () {
			
		float x1 = -17.5f;
		float y1 = 1.6f;
		float z1 = 30f;
		Vector3 p1 = new Vector3(x1, y1, z1);
		Vector3 p2 = new Vector3(-x1, y1, -z1);
		
		player1Bricks = new List<GameObject>();
		player2Bricks = new List<GameObject>();
		
		for (float z = 0; z < 5; z++)
        {
            for (float x = 0; x < 6; x++)
            {
				Vector3 pos = new Vector3(7f*x, 0, 4f*z);
				GameObject go = Instantiate(myPrefab, pos + p1, transform.rotation) as GameObject;
				GameObject go2 = Instantiate(myPrefab, p2 - pos, transform.rotation) as GameObject;

				player1Bricks.Add(go);
				player2Bricks.Add(go2);
			}
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void removeBricks(){
		
	}
}
