using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSwitcher : MonoBehaviour {


	private MusicController theMc;

	public int newTrack;

	public bool switchOnStart;


	// Use this for initialization
	void Start () {

		theMc = FindObjectOfType<MusicController>();

		if (switchOnStart) {
			theMc.SwitchTrack(newTrack);
			
		}

	}
	
	// Update is called once per frame
	void Update () {
		


	}


}
