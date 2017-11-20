using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour {

	public AudioClip SoundToPlay;
	public float Volume;
	AudioSource audio;
	public bool alreadyPlayed = false;

	public GameObject door;
	public int triggerDelay = 0;

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
		return;
	}

	public void TriggerRemotely(){
		if (!alreadyPlayed) {
			door.GetComponent<TriggerAnimation> ().isOpen = true;
			audio.PlayOneShot (SoundToPlay, Volume);
			alreadyPlayed = true;
		}
	}

	void PlayAudio(){
		
	}


	void OnTriggerExit()
	{
		audio.Stop ();
	}

}
