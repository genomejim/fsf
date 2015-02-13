using UnityEngine;
using System.Collections;

public class jimanimation : MonoBehaviour {
	public float HorizontalMovement;
	public Animator anim; // Refrerence to the animator
	GameObject player;
	// Use this for initialization
	void Start () {
		//player = gameObject.FindWithTag("Player");
		player = GameObject.FindWithTag("Player");
		anim.SetFloat ("Horizontal Movement", 0);
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//player = gameObject.Find ("animated player");
		HorizontalMovement = Mathf.Abs(player.rigidbody2D.velocity.x);
		anim.SetFloat ("Horizontal Movement", HorizontalMovement);

	
	}
}
