using UnityEngine;
using UnityEngine.UI;


public class EnemyMovement : MonoBehaviour {

	public float startSpeed = 10f;
	[HideInInspector]

	public float speed;
	
	public float startHealth = 100f;
	private float health;

	public int value = 50;

	public GameObject deathFX;

	[Header("Unity Stuff")]
	public Image healthBar;


		void Start (){
			speed = startSpeed;
			health = startHealth;
		}

		public void TakeDamage(float amount) {
			health -= amount;

			healthBar.fillAmount = health / startHealth;

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

			WaveSpawner.EnemiesAlive--;
			
			Destroy(gameObject);
		}

	
	
}
