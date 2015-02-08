// 2D Sky FREE version: 1.0
// Author: Gold Experience Team (http://ge-team.com/pages/unity-3d/)
// Support: geteamdev@gmail.com
// Please direct any bugs/comments/suggestions to geteamdev@gmail.com

using UnityEngine;
using System.Collections;

// ######################################################################
// This class does strength sprite to fit the orthographic camera view
// ######################################################################

public class SkyBG : MonoBehaviour {
	
	// ######################################################################
	// Variables
	// ######################################################################
	
	#region Variables	
	
	public Camera m_Camera = null;					// Handle Orthographic Camera in the scene
	
	Vector3 LeftMostOfScreen;						// Vector3 of middle-left most position at the edge of the camera view
	Vector3 RightMostOfScreen;						// Vector3 of middle-right most position at the edge of the camera view
	
	#endregion
	
	// ######################################################################
	// MonoBehaviour Functions
	// ######################################################################
	
	#region Monobehavior

	// Use this for initialization
	void Start () {

		// Find an Orthographic camera in the scene
		FindTheOrthographicCamera();

		// Strength this gameObject to fit the camera view
		this.transform.localScale = new Vector3((RightMostOfScreen.x-LeftMostOfScreen.x)/this.renderer.bounds.size.x, (m_Camera.orthographicSize*2)/this.renderer.bounds.size.y, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	#endregion {Monobehavior}
	
	// ######################################################################
	// Functions
	// ######################################################################
	
	#region Functions
	
	// Find an Orthographic camera in the scene
	void FindTheOrthographicCamera()
	{
		if(m_Camera==null)
		{
			Camera[] CameraList = FindObjectsOfType<Camera>();
			foreach(Camera child in CameraList)
			{
				if(child.isOrthoGraphic==true)
				{
					// Keep only first Orthographic Camera
					m_Camera = child;
					break;
				}
			}
		}
		
		// Calculate Left/Right most position at the edge of camera view
		if(m_Camera!=null)
		{
			LeftMostOfScreen = m_Camera.ScreenToWorldPoint(new Vector3(0, 0, 0));
			RightMostOfScreen = m_Camera.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));
		}
	}
	
	#endregion {Functions}
}
