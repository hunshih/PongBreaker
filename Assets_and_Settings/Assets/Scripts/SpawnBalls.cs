using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnBalls : MonoBehaviour {

	public GameObject 		myPrefab;
	public List<GameObject>	Balls;
	public int num_balls =	5;
	public float range = 	15.0f;
	
	// Use this for initialization
	void Start () {

		Balls = new List<GameObject>();
		StartCoroutine(SpawnDelay ());

	}
	
    IEnumerator SpawnDelay() {
		for (int i = 0; i < num_balls; i++)
		{	
		
			int rand = Random.Range(-100, 100);
			float x = range * rand/100;
			
			//rand = Random.Range(1, 100);
			float y = 50f;
			
			rand = Random.Range(-100, 100);
			float z = range * rand/100;
			
			Vector3 pos = new Vector3(x, y, z);
			GameObject go = Instantiate(myPrefab, pos, transform.rotation) as GameObject;	
			go.name = "Ball";
			
			Balls.Add (go);
			yield return new WaitForSeconds(1f);
		}
    }
	/*
	WaitForSeconds waitTime(float dur){
		yield return new WaitForSeconds (waitTime);
	}
	*/
	
	// Update is called once per frame
	void Update () {
	
	}
}
