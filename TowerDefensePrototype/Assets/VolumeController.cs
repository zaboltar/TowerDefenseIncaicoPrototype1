using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour {

    

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


	void Update () {

        music1.volume = musicSlider.value;
        music2.volume = musicSlider.value;

        // The wicked CaveMan rant

        SfxonebyOnecauseAmaCaveManAlpha.volume = sfxSlider.value;
        SfxonebyOnecauseAmaCaveManBeta.volume = sfxSlider.value;
        SfxonebyOnecauseAmaCaveManGamma.volume = sfxSlider.value;
        SfxonebyOnecauseAmaCaveManDelta.volume = sfxSlider.value;
        SfxonebyOnecauseAmaCaveManEpsilon.volume = sfxSlider.value;
        SfxonebyOnecauseAmaCaveManEta.volume = sfxSlider.value;
        SfxonebyOnecauseAmaCaveManTheta.volume = sfxSlider.value;
        SfxonebyOnecauseAmaCaveManIota.volume = sfxSlider.value;
    }
}
