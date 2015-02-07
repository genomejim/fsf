using UnityEngine;
using System.Collections;

public class EngageWithProjectile : MonoBehaviour {


	public Rigidbody2D projectile;
	public string enemy_tag;
	public int max_projectiles = 10;
	public float time_between_spawns;
	public int total_to_spawn;
	float time_counter;
	int total_spawned;
	public float grenade_x;
	public float grenade_y;
	public int raycast_layer;
	public float raycast_distance;
	public Vector2 engage_direction_modifier;
	public bool use_engage_random_delay;

	// Use this for initialization
	void Start () {
		//total_to_spawn = Random.Range (0, total_to_spawn);
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		int random_number = Random.Range (1, 2);
		time_counter += Time.deltaTime;
		if (time_counter > time_between_spawns + random_number * random_number && total_spawned < total_to_spawn && use_engage_random_delay) {
			Engage ();
			time_counter = 0;
		} else if (time_counter > time_between_spawns  && !use_engage_random_delay) {
			Engage ();
			time_counter = 0;
		}
	}
		void Engage () {
			
			
			Vector2 raycast_origin = new Vector2 (rigidbody2D.position.x -.3f, rigidbody2D.position.y);
			
			int layerMask = 1 << raycast_layer;
			RaycastHit2D hit = Physics2D.Raycast (raycast_origin,rigidbody2D.velocity + engage_direction_modifier,raycast_distance,layerMask);
			//Debug.DrawLine (raycast_origin,hit.point,Color.red,100f);
			//Debug.Log (hit.collider.name);
			if (hit && total_spawned < total_to_spawn ) {
				
				//Debug.DrawLine (raycast_origin,hit.point,Color.red,100f);
				//Debug.Log (hit.collider.tag);
				//Debug.Log (distance);
				if (hit.collider.tag == enemy_tag) {
					//Debug.Log (hit.collider.tag);
					//Debug.Log (distance);
					Vector3 projectile_start = new Vector3 (transform.position.x, transform.position.y);
					Rigidbody2D clone = Instantiate (projectile, projectile_start, transform.rotation) as Rigidbody2D;
					
					Vector2 impulse = new Vector2 (rigidbody2D.velocity.x + grenade_x * Random.Range (0, 2),rigidbody2D.velocity.y + grenade_y * Random.Range (-1, 2));
					clone.rigidbody2D.AddForce(impulse,ForceMode2D.Impulse);
					
					clone.renderer.enabled = true;
					clone.fixedAngle = false;
					total_spawned++;
					
				}
			}
		}
	
	}

