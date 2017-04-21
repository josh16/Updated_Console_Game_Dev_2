using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour {

	public PlayerHealth playerHealth;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player" && playerHealth.currentHealth < playerHealth.maxHealth)
		{
			Destroy (this.gameObject);

		}
	}


}
