using UnityEngine;
using System.Collections;

public class FloatingText : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.velocity = new Vector2 (0, 2);
	
	}
}
