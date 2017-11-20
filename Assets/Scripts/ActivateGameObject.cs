using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGameObject : MonoBehaviour {

	public GameObject[] triggersToActivate;
	public bool activate;
	public int delayOnTrigger = 0;
	public Triggers triggers;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerEnter(Collider Other)

	{
		if (triggersToActivate.Length > 0) {
			Invoke ("TriggerAction", delayOnTrigger);
		}

		if (triggers) {
			Invoke ("TriggerTrigger", delayOnTrigger);
		}
	}

	private void TriggerAction(){
		foreach (GameObject triggers in triggersToActivate) {
			if (activate) {
				triggers.SetActive (true);
			} else {
				triggers.SetActive (false);
			}
		}
	}

	private void TriggerTrigger(){
		triggers.TriggerRemotely ();
	}
}
