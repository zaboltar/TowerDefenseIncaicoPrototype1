﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeMusicController : MonoBehaviour {
    public Slider musicSlider;

    public AudioSource music1;
    public AudioSource music2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        music1.volume = musicSlider.value;
        music2.volume = musicSlider.value;
    }
}
