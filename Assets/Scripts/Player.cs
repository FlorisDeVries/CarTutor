using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Player : MonoBehaviour {

	public Slider slider;

	public float damage, speed = 50, amount = .5f;

	// Use this for initialization
	void Start () {
		slider.value = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if(Controller.paused)
			return;
		slider.value = damage;
		if(damage >= 25)
			slider.gameObject.transform.position += new Vector3(Mathf.Sin(Time.time * damage) * (amount + damage / 100), Mathf.Sin(Time.time * damage * 2) * (amount + damage / 100), 0);

		if(damage > 55)
			Controller.gameOvers = true;
	}

	private void OnCollisionEnter(Collision col) {
		Controller.timer = 0;
		damage += 10;
	}

}
