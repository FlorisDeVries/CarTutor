using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSpawn : MonoBehaviour {

	public GameObject toSpawn1, toSpawn2;
	public BoxCollider spawnArea;

	// Use this for initialization
	void Start () {

		float x = Random.Range(spawnArea.bounds.min.x,spawnArea.bounds.max.x);
		float y = Random.Range(spawnArea.bounds.min.y,spawnArea.bounds.max.y);
		float z = Random.Range(spawnArea.bounds.min.z,spawnArea.bounds.max.z);

		toSpawn2.transform.position = new Vector3(x, .5f, z);
		Instantiate(toSpawn2);

		for(int i = 0; i < 1; i++){
			x = Random.Range(spawnArea.bounds.min.x,spawnArea.bounds.max.x);
			y = Random.Range(spawnArea.bounds.min.y,spawnArea.bounds.max.y);
			z = Random.Range(spawnArea.bounds.min.z,spawnArea.bounds.max.z);

			toSpawn1.transform.position = new Vector3(x, -1.1f, z);
			Instantiate(toSpawn1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
