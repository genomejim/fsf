using UnityEngine;
using System.Collections;

public class ScienceBeam : MonoBehaviour {

	bool fire_beam;
	public float xoffset;
	public float yoffset;
	public int raycast_layer;
	public string enemy_tag;
	public float raycast_distance;
	//public LineRenderer beam;
	Color c1 = Color.green;
	Color c2 = Color.cyan;
	Color c3 = Color.red;
	Color c4 = Color.cyan;
	public int lengthOfLineRenderer = 2;
	public LineRenderer lineRenderer;

	// Use this for initialization
	void Start () {
		//lineRenderer = gameObject.AddComponent<LineRenderer>();
		lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
		lineRenderer.SetColors(c1, c2);
		lineRenderer.SetWidth(0.2F, 2F);
		lineRenderer.SetVertexCount(lengthOfLineRenderer);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//bool fire_beam = Input.GetKey (KeyCode.LeftControl);
		//if (fire_beam) {
					Engage ();
		//		}
	}

	void Engage () {
		
		Vector2 raycast_origin = new Vector2 (rigidbody2D.position.x + xoffset, rigidbody2D.position.y + yoffset);
		
		int layerMask = 1 << raycast_layer;
		Vector2 ahead = new Vector2 (1, 0);
		Vector2 behind = new Vector2 (-1,0);
		RaycastHit2D hitf = Physics2D.Raycast (raycast_origin,ahead,raycast_distance,layerMask);
		RaycastHit2D hitb = Physics2D.Raycast (raycast_origin,behind,raycast_distance,layerMask);

		//Debug.DrawLine (raycast_origin,hit.point,Color.red,100f);
		//Debug.Log (hit.collider.name);
		if (hitf) {
						Vector3 beam_start = new Vector3 (transform.position.x + xoffset, transform.position.y + yoffset);
						lineRenderer.SetPosition (0, beam_start);
						lineRenderer.SetPosition (1, hitf.point);
						lineRenderer.enabled = true;
						Vector2 force = new Vector2 (10, hitf.collider.rigidbody2D.mass * Random.Range (2,10));
						hitf.collider.rigidbody2D.AddForceAtPosition (force, hitf.point, ForceMode2D.Impulse);
				
				}		
		else if (hitb ) {
			
			Vector3 beam_start = new Vector3 (transform.position.x + xoffset, transform.position.y + yoffset);
//			Vector3 beam_end = new Vector3 (0,0,0);

			lineRenderer.SetPosition(0, beam_start);
			lineRenderer.SetPosition(1, hitb.point);
			lineRenderer.enabled = true;
			Vector2 force = new Vector2 (-10,hitb.collider.rigidbody2D.mass *2);
			hitb.collider.rigidbody2D.AddForceAtPosition(force,hitb.point,ForceMode2D.Impulse);
		} else {
			lineRenderer.enabled = false;

		}
	}



}
