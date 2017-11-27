using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour {

	public GameObject MovingLedge;
	public GameObject ThePlayer;

    // Script for moving platforms. Reassign player parent to the moving ledge when player is in contact.
	// Make sure the platform or platform parent is at a 1, 1, 1 scale so there is no distortion of character.
	
	void OnTriggerEnter ()
	{

		ThePlayer.transform.parent = MovingLedge.transform
		Debug.Log("Player on the platform.");
		
	}

	void OnTriggerExit ()

	{
		ThePlayer.transform.parent = null;
		Debug.Log("Player off the platform.");
	}
}

