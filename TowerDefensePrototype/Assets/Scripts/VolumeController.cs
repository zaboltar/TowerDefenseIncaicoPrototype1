using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour {

    

   
    public Slider sfxSlider;

   

    public AudioSource SfxonebyOnecauseAmaCaveManAlpha;
    public AudioSource SfxonebyOnecauseAmaCaveManBeta;
    public AudioSource SfxonebyOnecauseAmaCaveManGamma;
    public AudioSource SfxonebyOnecauseAmaCaveManDelta;
    public AudioSource SfxonebyOnecauseAmaCaveManEpsilon;
    public AudioSource SfxonebyOnecauseAmaCaveManEta;
    public AudioSource SfxonebyOnecauseAmaCaveManTheta;
    public AudioSource SfxonebyOnecauseAmaCaveManIota;


	void Update () {

      

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
