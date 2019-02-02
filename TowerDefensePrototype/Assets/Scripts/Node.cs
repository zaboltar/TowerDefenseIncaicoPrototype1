using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour {

		private SFXManager sfxMan;

		public Color hoverColor;
		public Color notEnoughMoneyColor;
		public Vector3 positionOffset;

		[HideInInspector]
		public GameObject turret;
		[HideInInspector]
		public TurretBlueprint turretBlueprint;
		[HideInInspector]
		public bool isUpgraded = false;

		private Renderer rend;
		private Color startColor;

		BuildManager buildManager;

		void Start () {

			sfxMan = FindObjectOfType<SFXManager>();
	
			rend = GetComponent<Renderer>();
			startColor = rend.material.color;
			buildManager = BuildManager.instance;
		}

		public Vector3 GetBuildPosition() {
			return transform.position + positionOffset;
		}

			void OnMouseDown (){

				if (EventSystem.current.IsPointerOverGameObject()) {
					return; 
				}


				if (turret != null) {

					buildManager.SelectNode(this);

					return;
				}


				if (!buildManager.CanBuild) {
					return; 
				}

				BuildTurret(buildManager.GetTurretToBuild());

			}

		void BuildTurret (TurretBlueprint blueprint) {

				if (PlayerStats.Money < blueprint.cost){
				return;
			}

			PlayerStats.Money -= blueprint.cost;


			GameObject _turret = (GameObject) Instantiate (blueprint.prefab, GetBuildPosition(), Quaternion.identity );
		 	turret = _turret;

		 	turretBlueprint = blueprint;

		 	sfxMan.construct.Play();


			}

		public void UpgradeTurret() {
					if (PlayerStats.Money < turretBlueprint.upgradeCost){
				return;
			}

			PlayerStats.Money -= turretBlueprint.upgradeCost;

			Destroy(turret);


			GameObject _turret = (GameObject) Instantiate (turretBlueprint.upgradedPrefab, GetBuildPosition(), Quaternion.identity );
		 	turret = _turret;

		 	isUpgraded = true;

			}


			public void SellTurret () {
				 PlayerStats.Money += turretBlueprint.GetSellAmount();

				 Destroy(turret);
				 turretBlueprint = null;
			}


		void OnMouseEnter () {

			if (EventSystem.current.IsPointerOverGameObject()) {
				return; 
			}

			if (!buildManager.CanBuild) {
				return; 
			}

			if (buildManager.HasMoney) {
				rend.material.color = hoverColor;
				} else {
					rend.material.color = notEnoughMoneyColor;
				}



			
		} 

		void OnMouseExit () {
			rend.material.color = startColor;
		}

}
