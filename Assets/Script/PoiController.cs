using UnityEngine;
using System.Collections;

public class PoiController : MonoBehaviour {

	public Vector2 speed = new Vector2(50, 50);
	
	// 2 - Store the movement
	private Vector2 movement;
	Vector3 PoiDirection;
	private float RotateAngle;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//move around
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		if(Input.GetButton("Fire2") || Input.GetButton("Sprint") ) {
			inputX = inputX/3;
			inputY = inputY/3;
		}
		Vector3 mousePos =Camera.main.ScreenToWorldPoint( Input.mousePosition );
		if(Input.GetButton("Fire1")) {
			WeaponController weapon = GetComponent<WeaponController>();
			weapon.shoot();
		}
		movement = new Vector2(speed.x * inputX,speed.y * inputY);

		//head to mouse pointer
		///PoiDirection is the vector from Poi to mouse
		PoiDirection =mousePos -transform.position ;
		PoiDirection.z = 0;
		Debug.DrawLine(transform.position, mousePos, Color.red);
		//Debug.Log ("mousePos = " + Vector3.up);
		RotateAngle = Vector3.Angle (Vector3.up, PoiDirection);
		if (PoiDirection.x > 0)
			RotateAngle = -RotateAngle;
		//Debug.Log ("angle = " + angel);
	}
	void FixedUpdate () {
		rigidbody2D.velocity = movement;
		transform.eulerAngles =new Vector3 (0, 0, RotateAngle);
	}
}
