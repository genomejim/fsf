using UnityEngine;
using System.Collections;

public class TrooperMove : MonoBehaviour { 

	public float max_speed = 10f;
	bool facing_right = true;
	public Rigidbody2D projectile;
	public float jump_speed = .3f;
	public string enemy_tag;
	public float HitPoints;
	public TextMesh HPDisplay;
	public GameObject healthbar;
	public TextMesh FloatingText;
	//public TextMesh FloatingTextText;
//	public GameObject scorekeeper;

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
				HPDisplay.text = HitPoints.ToString ();
				if (HitPoints < 50) {
						healthbar.renderer.material.SetColor ("_SpecColor", Color.red);
				}
				healthbar.transform.localScale = new Vector3 (HitPoints / 100f, .1f, 0f);
		
				if (HitPoints <= 0) {
						//Debug.Log (gameObject.tag);
						if (gameObject.tag == "enemy") {
							GameState.AllyScore++;
						} else if (gameObject.tag == "goodtrooper"){
							GameState.EnemyScore++;
						}

				DestroyObject (gameObject);

		}
	}

	
	void Flip () {
		facing_right = !facing_right;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
		

	void OnCollisionEnter2D(Collision2D coll) {
		//Debug.Log (coll.relativeVelocity.magnitude.ToString());
		if (coll.relativeVelocity.magnitude > 12) {

			HitPoints = HitPoints - coll.relativeVelocity.magnitude;

				//Debug.Log ("coll.gameObject.name");
				//Debug.Log (coll.gameObject.name);
				//Debug.Log ("gameobject.name");
				//Debug.Log (gameObject.name);
				Quaternion rotation = new Quaternion (0, 0, 0, 0);
				Vector2 TextPosition = new Vector2(gameObject.transform.position.x , gameObject.transform.position.y + .5f);
				FloatingText.text = coll.relativeVelocity.magnitude.ToString("F0");
				TextMesh clone = Instantiate (FloatingText, TextPosition , rotation) as TextMesh;
				//clone.text = coll.relativeVelocity.magnitude.ToString();
				//clone.text = "changed";
		} else if (coll.gameObject.tag == "zonewall") {
			DestroyObject (gameObject);
	}
	
}
}
