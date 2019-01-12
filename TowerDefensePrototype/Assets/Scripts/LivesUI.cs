
using UnityEngine;
using UnityEngine.UI;
// esto deberia estar en una corutina para celulares y no en el update**
public class LivesUI : MonoBehaviour {

	public Text livestText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		livestText.text = PlayerStats.Lives.ToString() + "LIVES";
	}
}
