using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour {

	private MusicController theMc;

	public string menuSceneName = "0Menu";

	public string nextLevel = "Level02";
	public int levelToUnlock = 2;
	
	public SceneFader sceneFad;

	 void Start () {
		theMc = FindObjectOfType<MusicController>();
	}

		public void Menu () {
			sceneFad.FadeTo(menuSceneName);
			theMc.SwitchTrack(0);
			// por las webas porq no se ve el botón de menu, pero porsiaca
		}

	public void Continue (){
		PlayerPrefs.SetInt("levelReached", levelToUnlock);
		 sceneFad.FadeTo(nextLevel);


	}

	
}
