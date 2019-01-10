﻿using UnityEngine;

public class BuildManager : MonoBehaviour {

	//singleton || monada

	public static BuildManager instance;

	void Awake () {

		if (instance != null) {
			return;
		}

		instance = this;
	}

public GameObject standardTurretPrefab;
public GameObject missileLauncherPrefab;
	
private TurretBlueprint turretToBuild;

public bool CanBuild { get { return turretToBuild != null;}}
public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost;}}

public void BuildTurretOn (Node node) {

		if (PlayerStats.Money < turretToBuild.cost){
			return;
		}

		PlayerStats.Money -= turretToBuild.cost;


		GameObject turret = (GameObject) Instantiate (turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity );
	 	node.turret = turret;

}

		
	public void SelectTurretToBuild (TurretBlueprint turret) {
		turretToBuild = turret;
	}



}
