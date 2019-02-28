using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepTheVolume : MonoBehaviour {

    public Slider musicSlider;
    public Slider sfxSlider;

    public AudioSource music1;
    public AudioSource music2;

    public AudioSource SfxonebyOnecauseAmaCaveManAlpha;
    public AudioSource SfxonebyOnecauseAmaCaveManBeta;
    public AudioSource SfxonebyOnecauseAmaCaveManGamma;
    public AudioSource SfxonebyOnecauseAmaCaveManDelta;
    public AudioSource SfxonebyOnecauseAmaCaveManEpsilon;
    public AudioSource SfxonebyOnecauseAmaCaveManEta;
    public AudioSource SfxonebyOnecauseAmaCaveManTheta;
    public AudioSource SfxonebyOnecauseAmaCaveManIota;


    // Use this for initialization
    void Start () {
        music1.volume = PlayerPrefs.GetFloat("MusicVolume");
        music2.volume = PlayerPrefs.GetFloat("MusicVolume");

        SfxonebyOnecauseAmaCaveManAlpha.volume = PlayerPrefs.GetFloat("SfxVolume");
        SfxonebyOnecauseAmaCaveManBeta.volume = PlayerPrefs.GetFloat("SfxVolume");
        SfxonebyOnecauseAmaCaveManGamma.volume = PlayerPrefs.GetFloat("SfxVolume");
        SfxonebyOnecauseAmaCaveManDelta.volume = PlayerPrefs.GetFloat("SfxVolume");
        SfxonebyOnecauseAmaCaveManEpsilon.volume = PlayerPrefs.GetFloat("SfxVolume");
        SfxonebyOnecauseAmaCaveManEta.volume = PlayerPrefs.GetFloat("SfxVolume");
        SfxonebyOnecauseAmaCaveManTheta.volume = PlayerPrefs.GetFloat("SfxVolume");
        SfxonebyOnecauseAmaCaveManIota.volume = PlayerPrefs.GetFloat("SfxVolume");
    }
	
	// Update is called once per frame
	void Update () {
        //musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
       // sfxSlider.value = PlayerPrefs.GetFloat("SfxVolume");
    }
}
