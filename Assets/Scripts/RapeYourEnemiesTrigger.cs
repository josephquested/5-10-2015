﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapeYourEnemiesTrigger : MonoBehaviour {

	// SYSTEM //

	public GameObject poster;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Player")
		{
			poster.SetActive(true);
		}
	}
}
