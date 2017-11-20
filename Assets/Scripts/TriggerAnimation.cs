using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour {


	public Animator anim;

	public bool isOpen;


	void Start(){
		anim = GetComponent<Animator> ();
	}

	void Update(){
		if (isOpen) {
			Debug.Log ("Is true");
			anim.SetBool ("CloseDoor", true);
		}
	}





}
