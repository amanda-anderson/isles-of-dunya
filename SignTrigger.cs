using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignTrigger : MonoBehaviour {

	private Animator anim;
	public GameObject sign;

	// Zoom in on the sign when player enters collider  (make sign contents full screen).
	void OnTriggerEnter(Collider other){

		sign.GetComponent<Animator> ().Play ("PanelSlideIn"); //
		Debug.Log("Now the animation clip should play");

	}


}
