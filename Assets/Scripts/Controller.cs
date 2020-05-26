using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Controller : MonoBehaviour {


	public CarController car;
	public CarUserControl controls;
	public CarAudio audio;
	public static float totalScore = 0;
	public static float maxScore = 100;
	
	public Canvas canvas;
	public Canvas pause, gameOver;
	public Player player;

	public static bool finished = false, allDone = false, paused = false, gameOvers = false;

	public static float timer = 0, bestTimer = 0, timer2 = 0;
	public Text bestTime, ervaring;

	public Text textField, timerField, bestTimerField;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(finished && allDone || paused || allDone && gameOvers){
			return;
		}

		if(Input.GetKeyDown(KeyCode.Escape)){
			if(paused)
				UnPause();
			else
				Pause();
		}

		textField.text = totalScore.ToString();
		timer += Time.deltaTime;
		timer2 += Time.deltaTime;
		bestTimer = Mathf.Max(bestTimer, timer);
		timerField.text = timer.ToString("n2") + " s";
		bestTimerField.text = bestTimer.ToString("n2") + " s";
		if(timer >= 5 && car.CurrentSpeed > 2){
			if( timer2 >= 1){
				timer2 = 0;
				totalScore += 2 * (int)(timer / 5);
			}
			player.damage -= 0.1f;
			player.damage = Mathf.Max(0, player.damage);
		}

		if(gameOvers){
			allDone = true;
			
			bestTime.text = bestTimer.ToString("n2") + " s";
			ervaring.text = totalScore.ToString();

			audio.enabled = false;
			car.enabled = false;
			controls.enabled = false;
			gameOver.gameObject.SetActive(true);
		}

		if(finished){
			allDone = true;
			
			audio.enabled = false;
			car.enabled = false;
			controls.enabled = false;
			canvas.gameObject.SetActive(true);
		}
	}

	public static void AddScore(float experience){
		totalScore += experience;
	}

	public void Pause(){
		audio.enabled = false;
		paused = true;
		Time.timeScale = 0;
		pause.gameObject.SetActive(true);
	}

	public void UnPause(){
		audio.enabled = true;
		paused = false;
		Time.timeScale = 1;
		pause.gameObject.SetActive(false);
	}

	public void Menu(){
		audio.enabled = true;
		player.damage = 0;
		paused = false;
		Time.timeScale = 1;
		pause.gameObject.SetActive(false);
		gameOver.gameObject.SetActive(false);
		totalScore = 0;
		timer = 0;
		bestTimer = 0;
		timer2 = 0;
		car.enabled = true;
		controls.enabled = true;
		allDone = false;
		finished = false;
		gameOvers = false;
		canvas.gameObject.SetActive(false);
		SceneManager.LoadScene("Menu");
	}

	public void Exit(){
		Application.Quit();
	}
}
