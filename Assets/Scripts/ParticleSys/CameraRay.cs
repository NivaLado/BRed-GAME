using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRay : MonoBehaviour {

	public float weaponRange = 50f;
	private Camera 	camera;

	void Start () 
	{
		camera = GetComponent<Camera>();
	}
	
	void Update () 
	{
		Vector3 lineOrigin = camera.ViewportToWorldPoint(new Vector3( 0.5f, 0.5f, 0));
		Debug.DrawLine( lineOrigin, camera.transform.forward * weaponRange, Color.green);
	}
}
