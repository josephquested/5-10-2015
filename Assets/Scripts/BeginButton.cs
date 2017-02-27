using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginButton : Clickable {
	public GameObject beginBar;

	bool isOpen;

	public override void Click ()
	{
		if (!isOpen)
		{
			GetComponent<AudioSource>().Play();
			beginBar.SetActive(true);
			isOpen = true;
		}
		else
		{
			beginBar.SetActive(false);
			isOpen = false;
		}
	}
}
