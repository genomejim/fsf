using UnityEngine;
using System.Collections;

public class LanternFixer : MonoBehaviour
{
	public Transform DirectionTarget;

	private Vector3 mInitLocalPos;
	private float mInitZ;
	private Vector3 mInitAngleDelta;

	void Start()
	{
		mInitLocalPos = transform.localPosition;
		mInitZ = transform.position.z;
		mInitAngleDelta = transform.eulerAngles - DirectionTarget.eulerAngles;
	}

	void Update ()
	{
		transform.localPosition = mInitLocalPos;
		Vector3 pos = transform.position;
		pos.z = mInitZ;
		transform.position = pos;

		Vector3 angles = transform.eulerAngles;
		angles.z = DirectionTarget.eulerAngles.z + mInitAngleDelta.z;
		transform.eulerAngles = angles;
	}
}
