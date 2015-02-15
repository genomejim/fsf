using UnityEngine;
using System.Collections;

public class GoodTrooperPrefabAnimation : MonoBehaviour {
	public float HorizontalMovement;
	public Animator anim; // Refrerence to the animator
	GameObject trooper;
	// Use this for initialization
	void Start () {
		//player = gameObject.FindWithTag("Player");
		trooper = GameObject.FindWithTag("goodtrooper");
		anim.SetFloat ("Horizontal Movement", 0);
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		//player = gameObject.Find ("animated player");
		HorizontalMovement = Mathf.Abs(trooper.rigidbody2D.velocity.x);
		anim.SetFloat ("Horizontal Movement", HorizontalMovement);
		
		
	}
}
