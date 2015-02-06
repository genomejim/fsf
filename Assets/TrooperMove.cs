using UnityEngine;
using System.Collections;

public class TrooperMove : MonoBehaviour {

	public float max_speed = 10f;
	bool facing_right = true;
	public Rigidbody2D projectile;
	public float jump_speed = .3f;
	public string enemy_tag;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		float move = -1;
		int random_number = Random.Range (1, 2);
		rigidbody2D.velocity = new Vector2 (move * max_speed * random_number, rigidbody2D.velocity.y);
		
		if (move < 0 && !facing_right)
			Flip ();
		else if (move > 0 && facing_right)
			Flip ();
	}

	
	void Flip () {
		facing_right = !facing_right;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
