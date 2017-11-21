using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour {
	// accesses the light
	Light theLight;

	// minimum time light will be off for
	public float minTime;
	// maximum time light will be on for
	public float maxTime;

	//--------------------------------------------------------------------------------------
	//	Start()
	// Runs during initialisation
	//
	// Param:
	//		None
	// Return:
	//		Void
	//-------------------------------------------------------------------------------------- 
	void Start () {
		theLight = GetComponent<Light> ();

		StartCoroutine (Flashing ());
	}
	
	IEnumerator Flashing (){
		while (true) {
			yield return new WaitForSeconds(Random.Range(minTime, maxTime));

			theLight.enabled = !theLight.enabled;
		}
	}
}
