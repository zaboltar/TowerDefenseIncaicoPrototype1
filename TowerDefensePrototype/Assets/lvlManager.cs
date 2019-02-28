using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SFXManager.instance.sfxVolumeSetting();
        MusicController.instance.VolumeSetting();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
