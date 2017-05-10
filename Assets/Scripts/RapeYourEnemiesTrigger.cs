﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapeYourEnemiesTrigger : MonoBehaviour {

	// SYSTEM //

	public GameObject poster;
	public GameObject wall;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Player")
		{
			GetComponent<AudioSource>().Play();
			StartCoroutine(FlickerOnRoutine());
		}
	}

	void ActivatePoster (bool state)
	{
		poster.SetActive(state);
		wall.SetActive(state);
	}

	IEnumerator FlickerOnRoutine ()
	{
		ActivatePoster(true);
		yield return new WaitForSeconds(0.1f);
		ActivatePoster(false);
		yield return new WaitForSeconds(0.1f);
		ActivatePoster(true);
		yield return new WaitForSeconds(0.1f);
		ActivatePoster(false);
		yield return new WaitForSeconds(0.1f);
		ActivatePoster(true);
		yield return new WaitForSeconds(0.1f);
		ActivatePoster(false);
		yield return new WaitForSeconds(0.1f);
		ActivatePoster(true);
	}
}
