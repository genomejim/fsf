using UnityEngine;
using System.Collections;

public class TankMotor : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		rigidbody2D.centerOfMass = new Vector2 (0, -5f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.velocity = new Vector2 (-5, rigidbody2D.velocity.y);
	}
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "ally") {
						rigidbody2D.velocity = new Vector2 (-10, rigidbody2D.velocity.y);
				}
	}
}
