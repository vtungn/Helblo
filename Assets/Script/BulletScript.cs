using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	public int damage = 1;
	
	/// <summary>
	/// Projectile damage player or enemies?
	/// </summary>
	public bool isEnemyShot = false;
	public Vector2 direction;
	public Vector2 speed = new Vector2(1.5f,1.5f);

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 2); // 20sec avoid leaking memory
		// point the bullet toward enemy
		float RotateAngle = Vector2.Angle (Vector2.up, direction);
		if (direction.x > 0)
			RotateAngle = -RotateAngle;
		transform.eulerAngles =new Vector3 (0, 0, RotateAngle);

	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = new Vector2(direction.x * speed.x , direction.y * speed.y );
	}
}
