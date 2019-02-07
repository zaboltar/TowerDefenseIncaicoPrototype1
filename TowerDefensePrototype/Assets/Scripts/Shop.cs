using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

	public TurretBlueprint standardTurret;
	public TurretBlueprint missileLauncer;
	public TurretBlueprint laserBeamer;

    public List<TurretBlueprint> turretList;

    // public bool isSelected = false;
    public GameObject go;
    public Renderer rend { get; private set; }
    public int currentTurretIndex;

	BuildManager buildManager;

	void Start () {
		buildManager = BuildManager.instance;
        rend = go.GetComponent<Renderer>();
	}

	public void SelectStandardTurret () {
		buildManager.SelectTurretToBuild(standardTurret);
        Debug.Log("Seleccionada");
        //isSelected = true;
        currentTurretIndex = 0;
        MeshFilter meshFilter = go.GetComponent<MeshFilter>();
        meshFilter.sharedMesh = turretList[currentTurretIndex].prefab.transform.GetChild(0).GetComponent<MeshFilter>().sharedMesh;
	}

	public void SelectMissileLauncher () {
		buildManager.SelectTurretToBuild(missileLauncer);
        currentTurretIndex = 1;
        MeshFilter meshFilter = go.GetComponent<MeshFilter>();
        meshFilter.sharedMesh = turretList[currentTurretIndex].prefab.transform.GetChild(0).GetComponent<MeshFilter>().sharedMesh;
	}

	public void SelectLaserBeamer () {
		buildManager.SelectTurretToBuild(laserBeamer);
	}
	
    public void SelectCustomTurret (int turretBPIndex) {
        buildManager.SelectTurretToBuild(turretList[turretBPIndex]);
        Debug.Log("Seleccionada");
        currentTurretIndex = turretBPIndex;
        //isSelected = true;
    }
}
