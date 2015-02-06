using UnityEngine;
using System.Collections;

public class FlyingMovement : MonoBehaviour {
	public float x_speed;
	public float y_speed;
	public int right_patrol_boundary;
	public int left_patrol_boundary;
	// Use this for initialization
	void Start () {
	
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Debug.Log (rigidbody2D.velocity);

		if (rigidbody2D.position.x > right_patrol_boundary) {
			Debug.Log (x_speed);

						Flip ();
		} else if (rigidbody2D.position.x < left_patrol_boundary) {

						Flip ();
				}
		rigidbody2D.velocity = new Vector2 (x_speed, y_speed);


	}
	void Flip () {
		//facing_right = !facing_right;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
		x_speed = -x_speed;
		y_speed = -y_speed + Random.Range(-1,1);
	}
}
