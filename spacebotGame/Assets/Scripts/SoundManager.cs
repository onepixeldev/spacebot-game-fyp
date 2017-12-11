using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public AudioClip soundTypeNotSel, soundTileLightOn, ShipMovement, SetCommand, TurnCommand, WrongLight;

	private AudioSource sourceTypeNotSel {get { return GetComponent<AudioSource> (); }}
	private AudioSource sourceTileLightOn {get { return GetComponent<AudioSource> (); }}
	private AudioSource sourceShipMovement {get { return GetComponent<AudioSource> (); }}
	private AudioSource sourceSetCommand {get { return GetComponent<AudioSource> (); }}
	private AudioSource sourceTurnCommand {get { return GetComponent<AudioSource> (); }}
	private AudioSource sourceWrongLight {get { return GetComponent<AudioSource> (); }}

	// Use this for initialization
	void Start () {
		// type not selected sound
		gameObject.AddComponent<AudioSource> ();

		// type not selected sound
		sourceTypeNotSel.clip = soundTypeNotSel;
		sourceTypeNotSel.playOnAwake = false;

		// tile light on
		sourceTileLightOn.clip = soundTileLightOn;
		sourceTileLightOn.playOnAwake = false;

		// ship movement sound
		sourceShipMovement.clip = ShipMovement;
		sourceShipMovement.playOnAwake = false;

		// set command
		sourceSetCommand.clip = SetCommand;
		sourceSetCommand.playOnAwake = false;

		// turn command
		sourceTurnCommand.clip = TurnCommand;
		sourceTurnCommand.playOnAwake = false;

		// wrong light
		sourceWrongLight.clip = WrongLight;
		sourceWrongLight.playOnAwake = false;
	}

	public void PlaySoundTypeNotSel(){
		sourceTypeNotSel.PlayOneShot (soundTypeNotSel);
	}

	public void PlaySoundTileLightOn(){
		sourceTileLightOn.PlayOneShot (soundTileLightOn);
	}

	public void PlaySoundShipMovement(){
		sourceShipMovement.PlayOneShot (ShipMovement);
	}

	public void PlaySoundSetCommand(){
		sourceSetCommand.PlayOneShot (SetCommand);
	}

	public void PlaySoundTurnCommand(){
		sourceTurnCommand.PlayOneShot (TurnCommand);
	}

	public void PlaySoundWrongLight(){
		sourceWrongLight.PlayOneShot (WrongLight);
	}
}
