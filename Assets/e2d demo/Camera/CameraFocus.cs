using UnityEngine;
using System.Collections;

public class CameraFocus : MonoBehaviour 
{
	public Transform FocusTarget;


	void Update () 
	{
		// focus to the target position
		Vector3 newPos = FocusTarget.position;
		newPos.z = transform.position.z;
		Vector3 oldPos = transform.position;

		float delta = 0.3f;
		transform.position = (1 - delta) * oldPos + delta * newPos;
	}
}
