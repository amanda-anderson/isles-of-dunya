using UnityEngine;
using System.Collections;

public class PlantRustle : MonoBehaviour {

	public GameObject Plant;

	// Play rustling animation for a plant when player contact it (plant moves when player runs through them).
	
	void OnTriggerEnter (Collider col)
	{
		if     (col.tag == "Player")
		{
			Plant.GetComponent<Animator> ().Play ("RotateTest", -1, 0f);
			Debug.Log("Plant animation should play.");

		}
	}
		
}