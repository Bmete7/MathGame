﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class gameController : MonoBehaviour {

	public GameObject chicken , condor , nextButton,gameButton, startButton;
	public Animator anim ;

	public GameObject tavukKonusma, kaplumKonusma;
	float speed =100;

	void Start () {
		anim.enabled = false;
		tavukKonusma.SetActive(false);
		kaplumKonusma.SetActive(false);
		nextButton.SetActive (false);
		gameButton.SetActive (false);

	}

	// Update is called once per frame
	void Update () {

	}

	public void startClick (){

		//Debug.Log(chicken.transform.rotation.eulerAngles.y);
		while (chicken.transform.rotation.eulerAngles.y >= 145) {
			chicken.transform.Rotate (Vector3.down * Time.deltaTime * speed);
			condor.transform.Rotate (Vector3.up * Time.deltaTime * speed);
			startButton.SetActive (false);
		}

		anim.enabled = true;
		tavukKonusma.SetActive(true);
		nextButton.SetActive (true);
	}

	public void nextButtonClicked()
	{
		tavukKonusma.SetActive(false);
		kaplumKonusma.SetActive(true);
		gameButton.SetActive (true);
		nextButton.SetActive (false);
	}

	public void gameButtonClicked () {
		SceneManager.LoadScene ("alanTuzak");
		
	}

}
