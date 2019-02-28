using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepTheVolume : MonoBehaviour {

    public Slider musicSlider;
    public Slider sfxSlider;

 

    // Use this for initialization
    void Start () {
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
    }
	
	// Update is called once per frame
	void Update () {
        //musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        // sfxSlider.value = PlayerPrefs.GetFloat("SfxVolume");
        SetVolume();
        MusicController.instance.VolumeSetting();

    }

    public void SetVolume() {

        PlayerPrefs.SetFloat("MusicVolume", musicSlider.value);
        PlayerPrefs.SetFloat("MusicVolume", musicSlider.value);

        PlayerPrefs.SetFloat("SfxVolume", sfxSlider.value);

    }
}
