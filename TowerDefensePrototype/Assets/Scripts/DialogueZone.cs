using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueZone : MonoBehaviour {

    public GameObject canvasTxt;
    public Dialogue dialogue;
    private SFXManager sfxMan;

    // Start is called before the first frame update
    void Start()
    {
        sfxMan = GetComponent<SFXManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canvasTxt.SetActive(true);

            /*if (Input.GetKeyDown(KeyCode.E))
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            }*/

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canvasTxt.SetActive(false);

        }
    }

    public void StartTalk()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void Kill ()
    {
        gameObject.SetActive(false);
       
    }
}
