using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public ParticleSystem system;
	public float weaponRange;

	RaycastHit hit;
	Vector3 rayOrigin; 
	LineRenderer laserLine; 
	private WaitForSeconds shotDuration = new WaitForSeconds(0.07f);

	void Start () 
	{
		laserLine = GetComponent<LineRenderer>();
	}
	
	void Update ()
	{
		if(Input.GetMouseButtonDown(0))
		{
			rayOrigin = Camera.main.ViewportToWorldPoint (new Vector3(0.5f, 0.5f, 0.0f));

			laserLine.SetPosition (0, transform.position);

			if (Physics.Raycast (rayOrigin, Camera.main.transform.forward, out hit, weaponRange))
			{
				laserLine.SetPosition (1, hit.point);
				StartCoroutine (ShotEffect());

				transform.LookAt(hit.point);	
				system.Emit(1);
			}
		}
	}

	private IEnumerator ShotEffect()
    {
        laserLine.enabled = true;
        yield return shotDuration;
        laserLine.enabled = false;
    }

}
