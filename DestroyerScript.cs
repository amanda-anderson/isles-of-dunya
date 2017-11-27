using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour 
{

	public GameObject particleEffect;
	public GameObject Plant;
	public GameObject FlowerCounterImage;

	// Script to destory the special, collectible plants.
	// Upon collision, destroy the special plant object and update the global variable Score.
	
	
	public class Global 
 {
     public static int count = 0;
 }
	
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			
			//Destroy special plant and its particle effect.
			Plant.GetComponent<Animator>().Play ("FadeOut");
			Destroy (particleEffect);
					Debug.Log("Plant and particle should be destroyed.");
			
			// Add 1 to score.
			Global.count = Global.count + 1;
					Debug.Log("Score increased by 1.");
			
			// Play animation that updates the score to the new number. 
			FlowerCounterImage.GetComponent<Animator>().Play("Test_Score_Animation", -1, 0f);
					Debug.Log("Counter animation plays.");

			return;
		}
	
}
}
