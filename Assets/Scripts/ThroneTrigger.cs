using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThroneTrigger : MonoBehaviour {

	public GameObject doorObj;

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Player")
		{
			StartCoroutine(DoorRoutine());
		}
	}

	IEnumerator DoorRoutine ()
	{
		doorObj.SetActive(true);
		doorObj.GetComponent<Animator>().SetTrigger("Shut");
		yield return null;
	}
}
