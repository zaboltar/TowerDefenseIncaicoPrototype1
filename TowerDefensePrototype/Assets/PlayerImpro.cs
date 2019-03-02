using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImpro : MonoBehaviour {

    Rigidbody myRB;
    private Vector3 lastEnemyPos;
    private SpriteRenderer rend;

    // Use this for initialization
    void Start () {
        myRB = GetComponent<Rigidbody>();
        lastEnemyPos = transform.position;
        rend = transform.GetChild(1).GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }

        if ((transform.position.x - lastEnemyPos.x) > 0 && rend.flipX)
        {
            rend.flipX = false;
        }
        else if ((transform.position.x - lastEnemyPos.x) < 0 && !rend.flipX)
        {
            rend.flipX = true;
        }

        lastEnemyPos = transform.position;


    }

    /*void FixedUpdate ()
    {
        if (Input.GetButtonDown(KeyCode.D) || (Input.GetButtonDown(KeyCode.RightArrow)) {

        }
    }*/
}
