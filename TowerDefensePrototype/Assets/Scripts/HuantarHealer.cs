using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuantarHealer : MonoBehaviour {

    float buff = 555;
    public GameObject healFx;

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Enemy")) {
            Debug.Log("Heal");
            other.GetComponent<EnemyMovement>().health = buff;
            other.GetComponent<EnemyMovement>().healthBar.fillAmount = buff;
            GameObject effect = (GameObject)Instantiate(healFx, transform.position, Quaternion.identity);
            Destroy(effect, 5f);

        }
    } 
}
