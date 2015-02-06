using UnityEngine;
using System.Collections;

public class SpawnPrefab : MonoBehaviour {

	public GameObject Prefab1;
	public GameObject Prefab2;
	public float time_between_spawns;
	float time_counter;
	public int total_to_spawn;
	int total_spawned;
	public Vector3 spawnpoint_one;
	public Vector3 spawnpoint_two;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Quaternion rotation = new Quaternion (0, 0, 0, 0);
		bool spawn_one = Input.GetKey (KeyCode.Alpha1);
		bool spawn_two = Input.GetKey (KeyCode.Alpha2);
		if (spawn_one && time_counter > time_between_spawns) {
			Instantiate (Prefab1, spawnpoint_one, rotation);
			time_counter = 0;
				}
		else if (spawn_two & time_counter > time_between_spawns) {
			Instantiate (Prefab2, spawnpoint_two, rotation);
			time_counter = 0;
		}
		time_counter += Time.deltaTime;

		//auto spawn if total_to_spawn > 0
		if (time_counter > time_between_spawns && total_spawned < total_to_spawn ){
			Instantiate (Prefab1, spawnpoint_one, rotation);
			time_counter = 0;
			total_spawned++;
		}
	}
}
