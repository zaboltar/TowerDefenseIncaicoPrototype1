using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


	//public string levelToLoad = "ProtoLevel";
	// Use this for initialization
	/*public void Play () {
		SceneManager.LoadScene(levelToLoad);
	}*/
	
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
