using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetDataPrompt : MonoBehaviour {

    public GameObject resetUI;

    public void AskForResetData()
    {
        resetUI.SetActive(true);
    }

    public void ResetGameData()
    {
        PlayerPrefs.SetInt("levelReached", 1);
        resetUI.SetActive(false);
    }

    public void CancelResetData()
    {
        resetUI.SetActive(false);
    }
}
