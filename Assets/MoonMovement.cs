using UnityEngine;
using System.Collections;

public class MoonMovement : MonoBehaviour {
	public float x_speed = 15;
	public float y_speed = 0;
	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		        if (rigidbody2D.position.x > 60) {
						x_speed = -x_speed;
						y_speed = -y_speed;
						Flip ();
				} else if (rigidbody2D.position.x < -70) {
						x_speed = -x_speed;
						y_speed = -y_speed;
						Flip ();
				}
		rigidbody2D.velocity = new Vector2 (x_speed, y_speed);
	}
	void Flip () {
		//facing_right = !facing_right;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
