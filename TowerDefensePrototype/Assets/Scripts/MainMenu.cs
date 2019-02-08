using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    private ResetDataPrompt resetData;
	public string levelToLoad = "ProtoLevel";
    public SceneFader sceneFad;

    void Start()
    {
        resetData = FindObjectOfType<ResetDataPrompt>();
    }

	// esto esta a modo de apunte
	public void Play () {

        sceneFad.FadeTo(levelToLoad);
        
		// NO FADER => SceneManager.LoadScene(levelToLoad);
	}

    public void ResetData () {
        // PlayerPrefs.SetInt("levelReached", 1); ASK FIRST
        resetData.AskForResetData();
    }
	
	// Update is called once per frame
	/*public void Quit () {
		Application.Quit();
	}*/

public void SceneLoader(int SceneIndex)
    {

        /* if (AudioManagment.audioMngr != null ) {
             Destroy(AudioManagment.audioMngr.gameObject);
         }
 */
        SceneManager.LoadScene(SceneIndex);

        // esto debería apagar la música



    }


    public void QuitGame() {
#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;
        //para el editor durante compiplaciòn de prueba

#else

        Application.Quit();
        // para compilacion externa de win?
    
#endif
    }

}
