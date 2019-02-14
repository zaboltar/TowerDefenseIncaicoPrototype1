using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyMovement))]
public class EnemyMovement2 : MonoBehaviour {

	private Transform target;
	private int wavepointIndex = 0;

    private Vector3 lastEnemyPos;
    private SpriteRenderer rend;

	private EnemyMovement enemy;

	void Start () {

        lastEnemyPos = transform.position;
		enemy = GetComponent<EnemyMovement>();
		target = Waypoints.points[0];
        rend = transform.GetChild(1).GetComponent<SpriteRenderer>();

	}	

	void Update () {
        // se guarda el mov en el start

        // mover personaje
		Vector3 dir = target.position - transform.position;
		transform.Translate(dir.normalized * enemy.speed * Time.deltaTime, Space.World);

		if (Vector3.Distance(transform.position, target.position) <= 0.4f ) {
			GetNextWaypoint();
		}

		enemy.speed = enemy.startSpeed;

        // pregunta por FlipX

        if ((transform.position.x - lastEnemyPos.x) > 0 && rend.flipX) {
            rend.flipX = false;
        } else if ((transform.position.x - lastEnemyPos.x) < 0 && !rend.flipX) {
            rend.flipX = true;
        }

        // guardar mov de nuevo
        lastEnemyPos = transform.position;
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
			WaveSpawner.EnemiesAlive--;
			Destroy(gameObject);

		}
}
