using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoreNavigator : MonoBehaviour {

	
	public int loreIndex;


	public Text name, type, info;

	public GameObject[] displayObjs;

	






	// Use this for initialization
	void Start () {
		loreIndex = 0;

		

	}
	
	// Update is called once per frame
	void Update () {

		if (loreIndex == 17 ) {
			loreIndex = 0;
			}

		switch (loreIndex) {


			// Seccion Torres
			// 1. base model
			// 2. upgrade model

			case 0:

				name.text = "Basic Slingtrooper Defender";
				type.text = "Basic Stony Structure";
				info.text = "This edification had rough stone placement, yet solid grip of irregular rocky fields. Inside some troops with slings and spears where gathered away from a cold wind. This warriors may be slow, but can refine some deadly fortification upgrades. Don´t look too much to the sun. ";
				displayObjs[16].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 1:
			
				name.text = "Advanced Slingtrooper Fort";
				type.text = "Upgraded Shrine of Destruction";
				info.text = "This Imperial masonry is exact as a draw. All the megaliths fits in a greater harmony of solidness among soild bricks, carved as if they where simple clay. The fortification is packed with seasoned commanders that work together as one. They say that Blood God lurks in this recynth.";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 2:

				name.text = "Simple Megalith Tosser";
				type.text = "Basic Structure";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 3:

				name.text = "Advanced Megalith Fort";
				type.text = "Upgraded Shrine of Destruction";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 4:
			
				name.text = "Basic Sun God Shrine";
				type.text = "Basic Structure";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 5:

				name.text = "Holy Temple of Inti";
				type.text = "Upgraded Shrine of Destruction";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

				// seccion entidades

			case 6:

				name.text = "Liviak's Blood Seeker";
				type.text = "Enemy Unit";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 7:
			
				name.text = "Ai Apaec Defender";
				type.text = "Enemy Unit";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 8:

				name.text = "Sechin Heavy Spearman";
				type.text = "Enemy Unit";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 9:

				name.text = "Naked Warlock";
				type.text = "Enemy Unit";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 10:
			
				name.text = "Drunk Megalith Bludgeoneer";
				type.text = "Enemy Unit";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 11:

				name.text = "Jungle´s Ghost";
				type.text = "Enemy Unit";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 12:

				name.text = "Mochica Kicker";
				type.text = "Enemy Unit";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);	
				break;


			case 13:

				name.text = "Chimu Clubzerker";
				type.text = "Enemy Unit";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 14:

				name.text = "Fire Shaman of Chicha";
				type.text = "Enemy Unit";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 15:
			
				name.text = "Chan Chan´s Sentinel";
				type.text = "Enemy Unit";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 16:

				name.text = "The Lord of The Valley of Yesbread";
				type.text = "Elite Enemy Unit";
				info.text = "";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			
				

				default:
				name.text = "";
				type.text = "";
				info.text = "";

				break;

			
		}
		
	}

	public void DisplayNextItem () {
		loreIndex++;
	}
}
