using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {
    public static SFXManager instance;

	public AudioSource baseImpact;
	public AudioSource shoot;
	public AudioSource cannonShot;
	public AudioSource construct;
	public AudioSource death;
	public AudioSource laser;
	public AudioSource lose;
	public AudioSource win;

	private static bool sfxManExist;


	private void Awake()
	{
        instance = this;
	}

	// Use this for initialization
	void Start () {
		if (!sfxManExist) {
			sfxManExist = true;
			DontDestroyOnLoad(transform.gameObject);
		} else {
			Destroy(gameObject);
		}

       
           
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void sfxVolumeSetting (){
        
        baseImpact.volume = PlayerPrefs.GetFloat("SfxVolume", 1);
        shoot.volume = PlayerPrefs.GetFloat("SfxVolume", 1);
        cannonShot.volume = PlayerPrefs.GetFloat("SfxVolume", 1);
        construct.volume = PlayerPrefs.GetFloat("SfxVolume", 1);
        death.volume = PlayerPrefs.GetFloat("SfxVolume", 1);
        laser.volume = PlayerPrefs.GetFloat("SfxVolume", 1);
        win.volume = PlayerPrefs.GetFloat("SfxVolume", 1);

    }
}
