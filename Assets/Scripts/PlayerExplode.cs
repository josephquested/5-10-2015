using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerExplode : MonoBehaviour {
	public void Explode ()
	{
		GetComponent<Animator>().enabled = true;
		StartCoroutine(ExplosionCoroutine());
	}

	IEnumerator ExplosionCoroutine ()
	{
		yield return new WaitForSeconds(2f);
		Destroy(GetComponent<Animator>());
		GetComponent<FirstPersonController>().enabled = true;
	}
}
