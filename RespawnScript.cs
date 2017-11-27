using UnityEngine;
using System.Collections;

public class RespawnScript : MonoBehaviour {

	public GameObject player;
	public Transform SpawnPoint;

	// Script to respawn player when they fall off the ledge.
	// Set the score counter variable back to 0.
	
	void OnTriggerEnter (Collider col)
	{
		if     (col.tag == "Player")
		{
			Time.timeScale = 1;
			Application.LoadLevel("Level1");
			DestroyerScript.Global.count = 0;
			Debug.Log("Player should respawn. Score should go back down to 0.");
		}
	}


}