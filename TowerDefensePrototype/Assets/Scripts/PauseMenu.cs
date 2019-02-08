using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public GameObject ui;

	public string menuSceneName = "0Menu";

	public SceneFader sceneFad;

	private MusicController theMc;

	void Start () {
		theMc = FindObjectOfType<MusicController>();
	}

	void Update () {

		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P) ) {
			Toggle();
		}
	}

	public void Toggle() {
		ui.SetActive(!ui.activeSelf);

		if (ui.activeSelf) {
			Time.timeScale = 0f;
			// tmb debe cambiarse el Time.fixedDeltaTime para slowmotion y speedups
		} else {
			Time.timeScale = 1f;
		}
	}

	public void Retry() {
		Toggle();
		sceneFad.FadeTo(SceneManager.GetActiveScene().name);
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

    public void Menu() {
        
                theMc.SwitchTrack(0);
		        Toggle();
		        sceneFad.FadeTo(menuSceneName);
        
		
	}
}
