using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


	public string levelToLoad = "ProtoLevel";
	// Use this for initialization
	public void Play () {
		SceneManager.LoadScene(levelToLoad);
	}
	
	// Update is called once per frame
	public void Quit () {
		Application.Quit();
	}
}
