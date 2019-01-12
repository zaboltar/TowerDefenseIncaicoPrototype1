﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyMovement))]
public class EnemyMovement2 : MonoBehaviour {

	private Transform target;
	private int wavepointIndex = 0;

	private EnemyMovement enemy;

		void Start () {

			enemy = GetComponent<EnemyMovement>();
			target = Waypoints.points[0];
		}	

			void Update () {
			Vector3 dir = target.position - transform.position;
			transform.Translate(dir.normalized * enemy.speed * Time.deltaTime, Space.World);

				if (Vector3.Distance(transform.position, target.position) <= 0.4f ) {
					GetNextWaypoint();
				}

				enemy.speed = enemy.startSpeed;
		}

		void GetNextWaypoint() {

				if (wavepointIndex >= Waypoints.points.Length - 1) {
					EndPath();
					return;
				}

			wavepointIndex++;
			target = Waypoints.points[wavepointIndex];
		}

		void EndPath(){
			PlayerStats.Lives--;
			Destroy(gameObject);
		}
}
