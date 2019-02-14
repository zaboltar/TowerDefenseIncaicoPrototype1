using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoreNavigator : MonoBehaviour {

	
	public int loreIndex;

	public TextMeshProUGUI name, type, info;

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
				info.text = "This edification had rough stone placement, yet solid grip of irregular rocky fields. Inside some troops with slings and spears where gathered away from a harsh weather. This warriors may be slow, but can refine some deadly fortification upgrades. Don´t look too much to the sun. ";
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
				info.text = "The scholars of the empire had developed ingenious ways of destruction. The manipulation of monoliths was a reknown matter of expertise. It took just a little twist to throw them at raging waves of enemies. Beware of lack of speed in turn to a devastating power. ";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 3:

				name.text = "Advanced Megalith Fort";
				type.text = "Upgraded Shrine of Destruction";
				info.text = "This fortification is a temple of underground obscure deities. It is always guarded by one priest that reveres the Ukupacha. The unspeakable sacrifices performed in the basement of the structure commands a great power that is bestowed upon the ravaging imperial defenders.";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 4:
			
				name.text = "Basic Sun God Shrine";
				type.text = "Basic Structure";
				info.text = "The canalization of light is best known to perform in golden circumstances. The interest in reflection and domestication of light waves derives from the faithful worship of Inti, the Sun God. The solar priest are fierce and have no regrets in light-burning pillagers and plunderers.";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 5:

				name.text = "Holy Temple of Inti";
				type.text = "Upgraded Shrine of Destruction";
				info.text = "In a secret temple, the virgins of the Sun dwells devoutly. They participate in a holy ritual where all of the maidens gaze upon the Sun until they become blinded and consider that this represent a consummation of their love towards the Sun God.";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

				// seccion entidades

			case 6:

				name.text = "Liviak's Blood Seeker";
				type.text = "Enemy Unit";
				info.text = "The ancient folks of Chavin of Huantar have a long and complex story. Some warriors revered Liviak, the Jaguar God. They were pleased to keep the fresh blood in their bodies and thus had a natural armor with a kind of power that only cannibals could understand.";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 7:
			
				name.text = "Ai Apaec Defender";
				type.text = "Enemy Unit";
				info.text = "The powerful lords of the fertile valleys worship the Decapitator deity. The walls of their fortress are known to be high and beatiful. In the murals of the temples, the fearsome manners are in accordance to a fair and strong society. The ceramics of this folks are precise as comic books in their fourth phase.";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 8:

				name.text = "Sechin Heavy Spearman";
				type.text = "Enemy Unit";
				info.text = "The folks of Sechin Valley are the elder inhabitants that worshiped the Two-Scepter God, before they were converted into the ways of the Jaguar God. Their walls had stone giant warriors that spread savagery through the representation of battlefields. Separete fallen single stone blocks represented decapitated heads";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 9:

				name.text = "Naked Warlock";
				type.text = "Enemy Unit";
				info.text = "The lords of certain valleys supported the witchery and sorcery in addition to their usual military expenses. The power of warlocks become formidable and decisive to overturn the flow of battles. Their powerful spells were devastating even against stone fortifications.";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 10:
			
				name.text = "Drunk Megalith Bludgeoneer";
				type.text = "Enemy Unit";
				info.text = "There are two important parts of a healthy primitive society: warfare and extasis-driven states. Smoking leaves, eating shrooms or drinking brews are few of many ways to get closer to gods. The fermentation of diverse corn derives into the sacred Chicha drink, which warriors just adore.";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 11:

				name.text = "Jungle´s Ghost";
				type.text = "Enemy Unit";
				info.text = "The vast jungle forest has made a deep impact in the ways of life of ancient inhabitants. The souls of an uncountable ammount of entities are forgotten into de thick vegetation. Many citadels are hidden beneath the green overwhelming jungle fields.";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 12:

				name.text = "Mochica Kicker";
				type.text = "Enemy Unit";
				info.text = "The eldest warriors invented a marvelous way to fight back against nature´s cruelty and harshness. Before the Tool and Weapon Age, they had to improve with their own resources. The growth of cities lead to the creation of roads and the excess of traveling developed shoes, which are great protection for kicking.";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);	
				break;


			case 13:

				name.text = "Chimu Clubzerker";
				type.text = "Enemy Unit";
				info.text = "Some priest had the power to transmute into animals. In ancient times it was common to see megafauna wrapped in bronze plates. Whenever one oddity was spotted, soon the rumors began to grow and soon the settlements were desolated, since no one wants to face in combat with a wild druid.";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 14:

				name.text = "Fire Shaman of Chicha";
				type.text = "Enemy Unit";
				info.text = "The holy brew of Chicha had an elevated level of alcohol, yet the sweet taste made it not only bearable, but addictive. When warriors drank it they said to be carnage machines. When warlocks took it, thou, the power of their magic manifested in amazing ways that peasants and skeptics couldn´t understand.";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 15:
			
				name.text = "Chan Chan´s Sentinel";
				type.text = "Enemy Unit";
				info.text = "To unlock this entry, Buy the complete game.";
				displayObjs[loreIndex -1].SetActive(false);
				displayObjs[loreIndex].SetActive(true);
				break;

			case 16:

				name.text = "The Lord of The Valley of Yesbread";
				type.text = "Elite Enemy Unit";
				info.text = "To unlock this entry, Buy the complete game.";
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
