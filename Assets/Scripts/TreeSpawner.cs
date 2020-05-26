using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour {

	public GameObject toSpawn;
	public BoxCollider spawnArea;
	public int maxAmount = 8;
	// Use this for initialization
	void Start () {
		int amount = Random.Range(3,maxAmount);
		
		for(int i = 0; i < amount;i++){
			float x = Random.Range(spawnArea.bounds.min.x,spawnArea.bounds.max.x);
			float z = Random.Range(spawnArea.bounds.min.z,spawnArea.bounds.max.z);

			toSpawn.transform.position = new Vector3(x, -1.2f, z);
			Instantiate(toSpawn);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
