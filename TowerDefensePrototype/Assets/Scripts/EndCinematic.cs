using UnityEngine;
using UnityEngine.SceneManagement;
 
public class EndCinematic : MonoBehaviour
{
    void OnEnable()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        //SceneManager.LoadScene("0Menu", LoadSceneMode.Single);
        SceneManager.LoadScene("0Menu", LoadSceneMode.Additive);
    }
}