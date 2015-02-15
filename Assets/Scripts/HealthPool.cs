using UnityEngine;
using System.Collections;

public class HealthPool : MonoBehaviour {
	public int HitPoints;
	public TextMesh HPDisplay;

	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//HPDisplay.text = HitPoints.ToString();

		if (HitPoints <= 0) {
			DestroyObject (gameObject);
			}
	
	}
}
