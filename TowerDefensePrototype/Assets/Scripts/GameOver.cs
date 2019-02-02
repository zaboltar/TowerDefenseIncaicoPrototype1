using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	private MusicController theMc;

	public string menuSceneName = "0Menu";

	public SceneFader sceneFad;

	void Start () {
		theMc = FindObjectOfType<MusicController>();
	}
	

	public void Retry (){
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		sceneFad.FadeTo(SceneManager.GetActiveScene().name);
	}

	public void Menu () {
		//no se porq esto no funciona bien X___X
		//no para la musica >.< y no cambia de track....:@
		theMc.musicTracks[theMc.currentTrack].Stop();
		theMc.SwitchTrack(0);
		sceneFad.FadeTo(menuSceneName);
	}

}
