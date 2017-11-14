using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGameObject : MonoBehaviour {

	public GameObject triggerToActivate;


	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter(Collider Other)

	{
		
		triggerToActivate.SetActive (true);
	}
}
