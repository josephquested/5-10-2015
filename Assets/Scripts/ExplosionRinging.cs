using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionRinging : MonoBehaviour {
	AudioSource ringAudio;
	public float highTime;

	void Start ()
	{
		ringAudio = GetComponent<AudioSource>();
		StartCoroutine(RingRoutine());
	}

	IEnumerator RingRoutine ()
	{
		while (ringAudio.volume < 1)
		{
			ringAudio.volume += 0.01f;
			yield return new WaitForSeconds(0.1f);
		}
		yield return new WaitForSeconds(highTime);
		while (ringAudio.volume > 0)
		{
			ringAudio.volume -= 0.01f;
			yield return new WaitForSeconds(0.1f);
		}
	}
}
