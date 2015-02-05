using UnityEngine;
using System.Collections;

public class SmoothFollow2D : MonoBehaviour {
	
	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;
	//public int zoom;
	public int orthographicSizeMin;
	public int orthographicSizeMax;
	
	// Update is called once per frame
	void Update () 
	{
		if (target)
		{
			//Debug.Log (target.position);
			Vector3 point = camera.WorldToViewportPoint(new Vector3(target.position.x,target.position.y,0));
			Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(.5f, .5f, point.z )); //(new Vector3(0.5, 0.5, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}
		if (Input.GetAxis("Mouse ScrollWheel")  > 0) // forward
		{ if (camera.orthographicSize > 0){
			camera.orthographicSize--;
			}
		}
		if (Input.GetAxis("Mouse ScrollWheel")  < 0) // back
		{
			camera.orthographicSize++;
		}
	}
}