using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnBricks : MonoBehaviour {

	public GameObject 		myPrefab;
	public float			radius = 4f;
	public List<GameObject>	spawnedObjects;
	public int				num_objects = 0;
	
	// Use this for initialization
	void Start () {
			
		for (float z = 0; z < 5; z++)
        {
            for (float x = 0; x < 5; x++)
            {
                //Instantiate(brick, new Vector3(3*x, 0, 2*z), Quaternion.identity);			
            	//GameObject go = Instantiate(Resources.Load("brick"));
				Vector3 pos = new Vector3(3f*x, 0, 2f*z);
				spawnedObjects = new List<GameObject>();
				GameObject go = Instantiate(myPrefab, pos, transform.rotation) as GameObject;
				//go.transform.position.Set(3f*x, 0f, 2f*z);
				//go.transform.position = Random.insideUnitSphere*radius;
				
				spawnedObjects.Add(go);
				num_objects++;
			}
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
