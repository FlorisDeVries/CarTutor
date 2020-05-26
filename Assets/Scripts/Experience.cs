using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience : MonoBehaviour {

	public float value;
	public Vector3 up;

	private float rotSpeed, bounceSpeed, Y;

	// Use this for initialization
	void Start () {
		rotSpeed = Random.Range(0.5f,1.0f);
		bounceSpeed = Random.Range(0.001f,0.005f);
		Y = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(up, rotSpeed);
		
		this.transform.position += new Vector3(0,bounceSpeed, 0);
		if(this.transform.position.y <= Y - .5f || this.transform.position.y >= Y + .5f){
			bounceSpeed *= -1;
		}
	}

	private void OnTriggerEnter(Collider other) {
		Controller.AddScore(value);
		Destroy(this.gameObject);
	}
}
