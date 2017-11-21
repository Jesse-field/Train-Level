using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGameObject : MonoBehaviour {

	// An array for selected items to trigger
	public GameObject[] triggersToActivate;
	// A boolean used for turning on triggers
	public bool activate;
	// Used to set delays on triggers
	public int delayOnTrigger = 0;
	// Accesses the triggers
	public Triggers triggers;

	//--------------------------------------------------------------------------------------
	//	OnTriggerEnter()
	// Trigger detection, Detects when the player passes through the trigger boxr
	//
	// Param:
	//		Collider other - The collider of any objects that pass into this trigger
	// Return:
	//		Void
	//--------------------------------------------------------------------------------------
	void OnTriggerEnter(Collider Other)

	{
		if (triggersToActivate.Length > 0) {
			Invoke ("TriggerAction", delayOnTrigger);
		}

		if (triggers) {
			Invoke ("TriggerTrigger", delayOnTrigger);
		}
	}


	//--------------------------------------------------------------------------------------
	// TriggerAction()
	// An action that plays on detection of a player entering a trigger
	//
	// Param:
	//		
	// Return:
	//		Void
	//--------------------------------------------------------------------------------------
	private void TriggerAction(){
		foreach (GameObject triggers in triggersToActivate) {
			if (activate) {
				if	(triggers != null)			triggers.SetActive (true);
			} else {
				triggers.SetActive (false);
			}
		}
	}


	//--------------------------------------------------------------------------------------
	//	TriggerTrigger()
	//  Turns triggers on or off
	//
	// Param:
	//		
	// Return:
	//		Void
	//--------------------------------------------------------------------------------------
	private void TriggerTrigger(){
		triggers.TriggerRemotely ();
	}
}
