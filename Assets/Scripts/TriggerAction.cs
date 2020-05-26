using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAction : MonoBehaviour {

	public bool spawned = false;
	public float chunkSize = 16;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other) {
		if(spawned)
			return;
		spawned = true;
		Spawner.SpawnArea(this.transform.position + new Vector3(chunkSize * 2, 0, 0));
	}
}
