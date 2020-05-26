using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Exit(){
		Application.Quit();
	}

	public void StartGame(){
		SceneManager.LoadScene("GameScene");
	}

	public void Endless(){
		SceneManager.LoadScene("Endless");
	}

	public void Gedicht(){

	}
}
