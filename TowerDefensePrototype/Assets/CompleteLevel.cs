using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour {


	public string menuSceneName = "0Menu";

	public string nextLevel = "Level02";
	public int levelToUnlock = 2;
	
	public SceneFader sceneFad;

		public void Menu () {
			sceneFad.FadeTo(menuSceneName);
		}

	public void Continue (){
		PlayerPrefs.SetInt("levelReached", levelToUnlock);
		 sceneFad.FadeTo(nextLevel);


	}

	
}
