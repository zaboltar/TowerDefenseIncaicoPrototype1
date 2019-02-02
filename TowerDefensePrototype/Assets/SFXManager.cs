using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {

	public AudioSource baseImpact;
	public AudioSource shoot;
	public AudioSource cannonShot;
	public AudioSource construct;
	//public AudioSource explode;
	public AudioSource laser;
	public AudioSource lose;
	public AudioSource win;

	private static bool sfxManExist;

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
}
