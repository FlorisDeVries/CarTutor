using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public int chunkSize = 16;

	public GameObject[] objects;
	private static GameObject[] sObjects;
	private static int sChunkSize;

	// Use this for initialization
	void Start () {
		sChunkSize = chunkSize;
		sObjects = objects;
		if(objects.Length <= 0)
			return;

		GameObject chosen;
		for(int i = -1; i < 2 ;i++){
			chosen = objects[Random.Range(0, objects.Length)];
			chosen.transform.position = new Vector3(chunkSize * i, 0, 0);
			chosen = Instantiate(chosen);
			if(i == -1)
				chosen.GetComponent<TriggerAction>().spawned = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void SpawnArea(Vector3 position){
		if(sObjects.Length <= 0 )
			return;
		GameObject chosenObject = sObjects[Random.Range(0, sObjects.Length)];
		chosenObject.transform.position = position;

		GameObject spawnedObject = Instantiate(chosenObject);
	}
}
