﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static bool gameEnded = false;

	public GameObject gameOverUI;

	public GameObject completeLvlUI;

	

	// Use this for initialization
	void Start () {
		gameEnded = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(gameEnded) {
			return;
		}

		if (PlayerStats.Lives <= 0) {
			EndGame();
		}
	}

	void EndGame() {
		gameEnded = true;

		gameOverUI.SetActive(true);
	}

	public void WinLevel(){
		if (!gameEnded) {
			gameEnded = true;
		completeLvlUI.SetActive(true);
		}
		
	}

}
