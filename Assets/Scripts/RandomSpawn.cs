using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

	public GameObject toSpawn;
	public BoxCollider spawnArea;
	public int amount = 3;
	// Use this for initialization
	void Start () {

		for(int i = 0; i< amount ; i++){
			float x = Random.Range(spawnArea.bounds.min.x,spawnArea.bounds.max.x);
			float y = Random.Range(spawnArea.bounds.min.y,spawnArea.bounds.max.y);
			float z = Random.Range(spawnArea.bounds.min.z,spawnArea.bounds.max.z);

			toSpawn.transform.position = new Vector3(x, .5f, z);
			Instantiate(toSpawn);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
