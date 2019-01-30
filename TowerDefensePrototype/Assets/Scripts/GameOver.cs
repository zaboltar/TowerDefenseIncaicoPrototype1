using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	

	public string menuSceneName = "0Menu";

	public SceneFader sceneFad;

	

	public void Retry (){
		//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		sceneFad.FadeTo(SceneManager.GetActiveScene().name);
	}

	public void Menu () {
		sceneFad.FadeTo(menuSceneName);
	}

}
