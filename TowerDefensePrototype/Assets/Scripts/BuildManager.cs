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


	
private TurretBlueprint turretToBuild;
private Node selectedNode;

public NodeUI nodeUI;

public bool CanBuild { get { return turretToBuild != null;}}
public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost;}}



	public void SelectNode (Node node) {
		
		// esto no funciona tan bien y no entiendo porqué
		if (selectedNode == node) {
			DeselectNode();
			return;
		}

		selectedNode = node;
		turretToBuild = null;

		nodeUI.SetTarget(node);
	}

	public void DeselectNode() {
		selectedNode = null;
		nodeUI.Hide();
	}
		
	public void SelectTurretToBuild (TurretBlueprint turret) {
		turretToBuild = turret;
		DeselectNode();
	}

	public TurretBlueprint GetTurretToBuild() {
		return turretToBuild;
	}



}
