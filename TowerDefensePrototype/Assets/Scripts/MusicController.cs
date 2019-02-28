using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

	public static bool mcExists;

	public AudioSource[] musicTracks;
    public static MusicController instance;


	public int currentTrack;

	public bool musicCanPlay;



	void Start () {
		    if (!mcExists) {
			mcExists = true;
            instance = this;
			DontDestroyOnLoad(transform.gameObject);
		    } else {
			Destroy(gameObject);
		    }

           // Time.timeScale = 1f;
            //musicTracks[currentTrack].volume = PlayerPrefs.GetFloat("MusicVolume", 1);
        }
	
	
	void Update () {
		
		if (musicCanPlay) {

			if (!musicTracks[currentTrack].isPlaying) {
				musicTracks[currentTrack].Play();
			}

			} else {
				musicTracks[currentTrack].Stop();
			}

	}

	public void SwitchTrack(int newTrack) {
        Debug.Log("SwitchTrack");
        if (this != null )
        {
            musicTracks[currentTrack].Stop();

            musicTracks[newTrack].Play();
            currentTrack = newTrack;
        }
      
	}

    public void VolumeSetting () {
        musicTracks = GetComponentsInChildren<AudioSource>();

        for (int i = 0; i < musicTracks.Length; i++){

            if (musicTracks[i] != null)
                musicTracks[i].volume = PlayerPrefs.GetFloat("MusicVolume", 1);
        }
            
    }

}
