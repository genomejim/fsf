using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour {
	public float max_speed = 10f;
	bool facing_right = true;
	public Rigidbody2D projectile;
	public int available_bolts = 1;
	public float jump_speed = .3f;
	bool grounded = true;
	bool airborne = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float move = Input.GetAxis ("Horizontal");
		rigidbody2D.velocity = new Vector2 (move * max_speed, rigidbody2D.velocity.y);

		if (move > 0 && !facing_right)
						Flip ();
				else if (move < 0 && facing_right)
						Flip ();
	
		bool jumping = Input.GetKey (KeyCode.Space);
		if (jumping)
						Jump ();
	}
	void Jump () {

		Vector2 down = new Vector2(0,-1);
		Vector2 raycast_origin = new Vector2 (rigidbody2D.position.x, rigidbody2D.position.y - 1f);
		RaycastHit2D hit = Physics2D.Raycast (raycast_origin, down, 20f);
		//Debug.Log (hit.collider.name);
		float distance = Vector2.Distance(raycast_origin, hit.point);
		//Debug.Log (hit.collider.tag);
		//Debug.Log (distance);
		if (hit) {
						if (hit.collider.tag == "ground" && distance < .01f) {
								grounded = true;
								airborne = false;
								//Debug.Log ("grounded");
						}
				}
		if (grounded && airborne != true){
				rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, jump_speed);
				grounded = false;
				airborne = true;
				}
		}

	void Flip () {
		facing_right = !facing_right;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
		}


}
