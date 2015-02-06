using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
	float time_counter;
	public GUIText timer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		time_counter += Time.deltaTime;
		timer.text = time_counter.ToString();

		if (time_counter > 100) {
						Application.LoadLevel ("monkey");
				}
	}
}
