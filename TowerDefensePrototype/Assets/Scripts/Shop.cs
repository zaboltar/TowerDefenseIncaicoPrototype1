
using UnityEngine;

public class Shop : MonoBehaviour {

	public TurretBlueprint standardTurret;
	public TurretBlueprint missileLauncer;
	public TurretBlueprint laserBeamer;


	BuildManager buildManager;

	void Start () {
		buildManager = BuildManager.instance;
		 
	}

	public void SelectStandardTurret () {
		buildManager.SelectTurretToBuild(standardTurret);
	}

	public void SelectMissileLauncher () {
		buildManager.SelectTurretToBuild(missileLauncer);
	}

	public void SelectLaserBeamer () {
		buildManager.SelectTurretToBuild(laserBeamer);
	}
	

}
