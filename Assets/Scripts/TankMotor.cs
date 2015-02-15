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
						//power through collisions like a TANK
						rigidbody2D.velocity = new Vector2 (-5, rigidbody2D.velocity.y);
						Quaternion keep_the_front_wheels_down = new Quaternion (0, 0, 0, 15); 
						rigidbody2D.transform.rotation = keep_the_front_wheels_down;

				} else if (coll.gameObject.tag == "zonewall") {
						Debug.Log (gameObject.name);
						DestroyObject (gameObject);
				}
		}

}
