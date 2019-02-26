using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour {

		private SFXManager sfxMan;
    static private Shop shop;

	public Color hoverColor;
	public Color notEnoughMoneyColor;
	public Vector3 positionOffset;

	[HideInInspector]
	public GameObject turret;
	[HideInInspector]
	public TurretBlueprint turretBlueprint;
	[HideInInspector]
	public bool isUpgraded = false;

    Turret turretComponent;

	private Renderer rend;
	private Color startColor;

	BuildManager buildManager;

    Transform turretArea { get { return BuildManager.instance.nodeUI.targetArea; }}

	void Start () {

		sfxMan = FindObjectOfType<SFXManager>();
	
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
		buildManager = BuildManager.instance;
        if (!shop) { shop = FindObjectOfType<Shop>(); }
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
            DisableTurretGhost();
            Debug.Log("Deseleccionada");
            //currentTurretIndex = -1;
            //shop.currentTurretIndex = -1;

		}

    void ShowArea(){
        turretArea.position = transform.position + (Vector3.up * 0.6f);
        turretArea.localScale = Vector3.one + (Turret.areaAxes * turretComponent.range * 2);
        turretArea.gameObject.SetActive(true);
    }

    void HideArea(){
        turretArea.gameObject.SetActive(false);
    }
     


    private void OnMouseOver(){
        if (shop.currentTurretIndex != -1 && !turret) {
            shop.go.transform.position = transform.position;
            if (!shop.rend.enabled) {
                shop.rend.enabled = true;
            }
        } else if (turret){
            if (!turretArea.gameObject.activeInHierarchy) {
                ShowArea();
            }
        }
	}

    void OnMouseExit()
    {
        rend.material.color = startColor;
        DisableTurretGhost();
        HideArea();
    }

	void BuildTurret (TurretBlueprint blueprint) {

				if (PlayerStats.Money < blueprint.cost){
				return;
			}

			PlayerStats.Money -= blueprint.cost;


			GameObject _turret = (GameObject) Instantiate (blueprint.prefab, GetBuildPosition(), Quaternion.identity );
		 	turret = _turret;

		 	turretBlueprint = blueprint;

        turretComponent = turret.GetComponent<Turret>();


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

        turretComponent = turret.GetComponent<Turret>();


		 	isUpgraded = true;

			}


			public void SellTurret () {
				 PlayerStats.Money += turretBlueprint.GetSellAmount();

				 Destroy(turret);
				 turretBlueprint = null;
			}

    void DisableTurretGhost () {
        shop.go.transform.position = Vector3.back * 500;
        if (shop.rend.enabled)
        {
            shop.rend.enabled = false;
        }
    }
}
