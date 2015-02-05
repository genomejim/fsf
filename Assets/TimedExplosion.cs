using UnityEngine;
using System.Collections;



public class TimedExplosion : MonoBehaviour {
	public int Power;
	public GameObject Prefab;
	//public int Radius;
	public float time_til_explosion;
	float time_counter;
	public int number;
	int count = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		time_counter += Time.deltaTime;
		if (time_counter > time_til_explosion && count < number ){
			Vector2 force = new Vector2 (Random.Range(-2,2) * Power,Random.Range(-2,2)* Power);
			Vector2 position = new Vector2 (rigidbody2D.position.x,rigidbody2D.position.y);
			Vector3 explosion_start = new Vector3 (transform.position.x - 2, transform.position.y);
			Quaternion rotation = new Quaternion (0, 0, 0, 0);
			Instantiate (Prefab, explosion_start, rotation);
			rigidbody2D.AddForceAtPosition(force,position);
			rigidbody2D.fixedAngle = false;
			count++;
		}
	}
}
