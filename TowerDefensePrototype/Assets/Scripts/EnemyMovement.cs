using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public float startSpeed = 10f;
	[HideInInspector]
	public float speed;
	public float health = 100f;

	public int value = 50;

	public GameObject deathFX;


		void Start (){
			speed = startSpeed;
		}

		public void TakeDamage(float amount) {
			health -= amount;
			if (health <= 0) {
				Die();
			}
		}

		public void Slow (float pct) {
			speed = startSpeed * (1f - pct);
		}

		void Die() {

			PlayerStats.Money += value;

			GameObject effect = (GameObject)Instantiate(deathFX, transform.position, Quaternion.identity);
			Destroy(effect, 5f);
			
			Destroy(gameObject);
		}

	
	
}
