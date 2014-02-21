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
	public float shootingRate = 0.25f;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void shoot () {
		var shotTransform = Instantiate(shotPrefab) as Transform;
		
		// Assign position
		shotTransform.position = transform.position;
		
		// The is enemy property
		BulletScript shot = shotTransform.gameObject.GetComponent<BulletScript>();
		if (shot != null)
		{
			shot.direction = transform.up;
		}

	}
}
