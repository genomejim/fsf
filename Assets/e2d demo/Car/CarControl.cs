using UnityEngine;
using System.Collections;

public class CarControl : MonoBehaviour 
{
	public GameObject RightWheel;
	public GameObject LeftWheel;

	void Start()
	{
		Vector3 center = rigidbody.centerOfMass;
		center.y -= 1;
		rigidbody.centerOfMass = center;
	}

	void FixedUpdate ()
	{
		float h = Input.GetAxisRaw("Horizontal");

		JointMotor motor = LeftWheel.hingeJoint.motor;
		motor.force = (h!=0?1:0) * 30;
		motor.freeSpin = true;
		motor.targetVelocity = -h * 4000;

		LeftWheel.hingeJoint.useMotor = h != 0;
		LeftWheel.hingeJoint.motor = motor;

		RightWheel.hingeJoint.useMotor = h != 0;
		RightWheel.hingeJoint.motor = motor;

		rigidbody.AddRelativeTorque(0, 0, -h * 3000);


		// flip the car
		if (Input.GetButton("Fire1"))
		{
			float deltaAngle = Mathf.DeltaAngle(transform.eulerAngles.z, 0);
			if (Mathf.Abs(deltaAngle) > 10)
			{
				rigidbody.AddTorque(0, 0, deltaAngle * deltaAngle * deltaAngle, ForceMode.VelocityChange);
			}
		}
	}
}
