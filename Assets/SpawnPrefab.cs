using UnityEngine;
using System.Collections;

public class SpawnPrefab : MonoBehaviour {

	public GameObject Prefab; 
	public float time_between_spawns;
	float time_counter;
	public int total_to_spawn;
	int total_spawned;
	public Vector3 spawnpoint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//spawnpoint = new Vector3(100,15,0);
		Quaternion rotation = new Quaternion (0, 0, 0, 0);
		time_counter += Time.deltaTime;
		if (time_counter > time_between_spawns && total_spawned < total_to_spawn ){
			Instantiate (Prefab, spawnpoint, rotation);
			time_counter = 0;
			total_spawned++;
		}
	}
}
