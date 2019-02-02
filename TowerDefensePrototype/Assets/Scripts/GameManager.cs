using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static bool gameEnded = false;

	public GameObject gameOverUI;

	public GameObject completeLvlUI;

	private SFXManager sfxMan;

	// Use this for initialization
	void Start () {
		gameEnded = false;
		sfxMan = FindObjectOfType<SFXManager>();
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
		sfxMan.lose.Play();
	}

	public void WinLevel(){
		if (!gameEnded) {
			gameEnded = true;
		completeLvlUI.SetActive(true);
		}
		sfxMan.win.Play();
	}

}
