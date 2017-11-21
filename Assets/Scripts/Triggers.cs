using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour {

	// Accesses the audio clip
	public AudioClip SoundToPlay;
	// Volume Control
	public float Volume;
	// Accesses audio source
	AudioSource audio;
	// Boolean to see if audio has played
	public bool alreadyPlayed = false;
	// Boolean to see if game has ended
	public bool endGame = false;

	// Accesses game object
	public GameObject door;
	// Delay before trigger invokes
	public int triggerDelay = 0;

	//--------------------------------------------------------------------------------------
	//	Start()
	// Runs during initialisation
	//
	// Param:
	//		None
	// Return:
	//		Void
	//--------------------------------------------------------------------------------------
	void Start()
	{
		audio = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider other)
	{
		
		if (other.tag == "Player" && door != null) {
			door.GetComponent<TriggerAnimation> ().isOpen = true;
			Invoke ("TriggerRemotely",triggerDelay);

		}

		if (!alreadyPlayed) {
			audio.PlayOneShot(SoundToPlay, Volume);
			alreadyPlayed = true;
		}

		if (!door == null) {
			if (!alreadyPlayed && !door.GetComponent<Animation> ().isPlaying) {
				audio.PlayOneShot(SoundToPlay, Volume);
				alreadyPlayed = true;

			}
		}
		if (endGame == true) {
			Invoke ("EndGame", 4);
		}

		return;
	}


	//--------------------------------------------------------------------------------------
	// Trigger Remotely()
	// An action that plays on detection of a player entering a trigger
	//
	// Param:
	//		
	// Return:
	//		Void
	//--------------------------------------------------------------------------------------
	public void TriggerRemotely(){
		if (!alreadyPlayed) {
			door.GetComponent<TriggerAnimation> ().isOpen = true;
			audio.PlayOneShot (SoundToPlay, Volume);
			alreadyPlayed = true;
		}
	}


	//--------------------------------------------------------------------------------------
	// PlayAudio()
	// Plays Audio
	//
	// Param:
	//		
	// Return:
	//		Void
	//--------------------------------------------------------------------------------------
	void PlayAudio(){
		
	}

	//--------------------------------------------------------------------------------------
	//	OnTriggerExit()
	// Trigger detection, Detects when the player leaves the trigger box
	//
	// Param:
	//		Collider other - The collider of any objects that pass into this trigger
	// Return:
	//		Void
	//--------------------------------------------------------------------------------------
	void OnTriggerExit()
	{
		audio.Stop ();
	}


	//--------------------------------------------------------------------------------------
	//	EndGame()
	// Ends the game
	//
	// Param:
	//		
	// Return:
	//		Void
	//--------------------------------------------------------------------------------------
	void EndGame()
	{
		Application.Quit ();
	}

}
