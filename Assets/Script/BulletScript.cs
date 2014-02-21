using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	public int damage = 1;
	
	/// <summary>
	/// Projectile damage player or enemies?
	/// </summary>
	public bool isEnemyShot = false;
	public Vector2 direction = new Vector2(10,0);
	// Use this for initialization
	void Start () {
		Destroy(gameObject, 1); // 20sec avoid leaking memory
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = direction;
	}
}
