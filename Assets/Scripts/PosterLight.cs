﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosterLight : MonoBehaviour {

	// SYSTEM //

	public Light posterLight;
	public float lightMin;
	public float lightMax;

	void Update ()
	{
		posterLight.intensity = Random.Range(lightMin, lightMax);
	}
}
