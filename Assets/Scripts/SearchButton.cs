using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchButton : Clickable {
	public float force;

	public override void Click ()
	{
		GetComponent<AudioSource>().Play();
		StartCoroutine(StartRotation());
		Rigidbody rb = GetComponent<Rigidbody>();
		Vector3 movement = new Vector3(-1, 2, 0);
		rb.AddForce(movement * force);
	}

	IEnumerator StartRotation ()
	{
		int i = 0;
		Rigidbody rb = GetComponent<Rigidbody>();
		while (i < 100)
		{
			yield return null;
			Vector3 rotation = new Vector3(10, 0);
			Quaternion deltaRotation = Quaternion.Euler(rotation * Time.deltaTime * 10);
			rb.MoveRotation(rb.rotation * deltaRotation);
		}
		Destroy(gameObject);
	}
}
