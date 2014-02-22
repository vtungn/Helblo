using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {
	/// <summary>
	/// Projectile prefab for shooting
	/// </summary>
	public Transform shotPrefab;
	
	/// <summary>
	/// Cooldown in seconds between two shots
	/// </summary>
	public float shootingSpeed = 0.005f;
	private float shootCooldown;
	void Start () {
		shootCooldown = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (shootCooldown > 0)
		{
			shootCooldown -= Time.deltaTime;
		}
	}

	public void shoot () {
		if (CanAttackNow()) {
			shootCooldown = shootingSpeed;
			var shotTransform = Instantiate (shotPrefab) as Transform;

			// Assign position
			shotTransform.position = transform.position;

			// The is enemy property
			BulletScript shot = shotTransform.gameObject.GetComponent<BulletScript> ();
			if (shot != null) {
					//shoot arr right out the head of Poi
					shot.direction = transform.up;
			}
		}

	}

	bool CanAttackNow () {
		if (shootCooldown <= 0)
						return true;
		else return false;
	}
}
