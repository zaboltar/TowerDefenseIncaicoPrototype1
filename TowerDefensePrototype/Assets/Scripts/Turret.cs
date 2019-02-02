﻿using System.Collections;
using UnityEngine;

public class Turret : MonoBehaviour {

	private SFXManager sfxMan;

	private Transform target;
	private EnemyMovement targetEnemy;

	[Header("General")]
	public float range = 15f;

	[Header("Use Bullets (default)")]

	public GameObject bulletPrefab;
	public float fireRate = 1f;
	private float fireCountDown = 0f;

	[Header("Use Laser")]
	public bool useLaser = false;

	public int damageOverTime = 30;
	public float slowPct = .5f;

	public LineRenderer lineRenderer;

	[Header("Unity Setup Fields")]
	public string enemyTag = "Enemy";
	public Transform partToRotate;
	public float turnSpeed = 10f;

	
	public Transform firePoint;


	// Use this for initialization
		void Start () {
			
			InvokeRepeating("UpdateTarget", 0f, 0.5f);

			sfxMan = FindObjectOfType<SFXManager>();
		}


		void UpdateTarget() {

				GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
				float shortestDistance = Mathf.Infinity;
				GameObject nearestEnemy = null;


				foreach (GameObject enemy in enemies) {

					float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
					if (distanceToEnemy < shortestDistance) {
						shortestDistance = distanceToEnemy;
						nearestEnemy = enemy;
					}
					
				}

				if (nearestEnemy != null && shortestDistance <= range) {
					target = nearestEnemy.transform;
					targetEnemy = nearestEnemy.GetComponent<EnemyMovement>();
				} else {
					target = null;
				}

		}

	
	// Update is called once per frame
		void Update () {
				
				if (target == null) {

					if(useLaser) {
							if (lineRenderer.enabled){
								lineRenderer.enabled = false;
							}
					}

					return;
				}

				LockOnTarget();

				if (useLaser) {
					Laser();
				} else {

					if (fireCountDown <= 0f) {
						Shoot();
						fireCountDown = 1f /fireRate;
						} 
						
						fireCountDown -= Time.deltaTime;
					}

		}

		void LockOnTarget() {
			//rotate targetlock on
				Vector3 dir = target.position - transform.position;
				Quaternion lookRotation = Quaternion.LookRotation(dir);
				Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
				partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);
		}

		void Shoot() {
			GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
			Bullet bullet = bulletGO.GetComponent<Bullet>();

			if (bullet != null) {
				bullet.Seek(target);
			}	
			sfxMan.shoot.Play();
		}

		void Laser() {

			targetEnemy.TakeDamage(damageOverTime * Time.deltaTime);
			targetEnemy.Slow(slowPct);

			if (!lineRenderer.enabled) {
				lineRenderer.enabled = true;
			}

			lineRenderer.SetPosition(0, firePoint.position);
			lineRenderer.SetPosition(1, target.position);

			sfxMan.laser.Play();
		}

		void OnDrawGizmosSelected() {
			Gizmos.color = Color.red;
			Gizmos.DrawWireSphere(transform.position, range);
		}
}
