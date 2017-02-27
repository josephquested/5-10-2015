using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionLight : MonoBehaviour {
	public float speed;

	void Start ()
	{
		StartCoroutine(Explode());
	}

	IEnumerator Explode ()
	{
		Light light = GetComponent<Light>();
		while (light.intensity < 8)
		{
			light.intensity += 0.5f;
			yield return new WaitForSeconds(speed);
		}
		while (light.intensity > 1)
		{
			light.intensity -= 0.015f;
			yield return new WaitForSeconds(speed);
		}
	}
}
