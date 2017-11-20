using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour {

	Light theLight;

	public float minTime;
	public float maxTime;


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
