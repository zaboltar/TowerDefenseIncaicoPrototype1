
using UnityEngine;

public class Shop : MonoBehaviour {

	public TurretBlueprint standardTurret;
	public TurretBlueprint missileLauncer;
	public TurretBlueprint laserBeamer;

    public bool isSelected = false;
    

	BuildManager buildManager;

	void Start () {
		buildManager = BuildManager.instance;
		 
	}

	public void SelectStandardTurret () {
		buildManager.SelectTurretToBuild(standardTurret);
        Debug.Log("Seleccionada");
        isSelected = true;
	}

	public void SelectMissileLauncher () {
		buildManager.SelectTurretToBuild(missileLauncer);
	}

	public void SelectLaserBeamer () {
		buildManager.SelectTurretToBuild(laserBeamer);
	}
	

}
