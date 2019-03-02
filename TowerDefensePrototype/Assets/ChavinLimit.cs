﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChavinLimit : MonoBehaviour {

    public GameObject textDisplay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            textDisplay.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            textDisplay.SetActive(false);
        }
    }
}
