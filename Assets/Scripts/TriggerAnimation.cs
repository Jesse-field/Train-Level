using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour {

	// accesses the animator
	public Animator anim;

	// A boolean for the door
	public bool isOpen;

	//--------------------------------------------------------------------------------------
	//	Start()
	// Runs during initialisation
	//
	// Param:
	//		None
	// Return:
	//		Void
	//--------------------------------------------------------------------------------------
	void Start(){
		anim = GetComponent<Animator> ();
	}


	//--------------------------------------------------------------------------------------
	//	Update()
	// Runs every frame
	//
	// Param:
	//		None
	// Return:
	//		Void
	//--------------------------------------------------------------------------------------
	void Update(){
		if (isOpen) {
			
			anim.SetBool ("CloseDoor", true);
		}
	}





}
