using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenButton : Clickable {
	public GameObject screen;

	public override void Click ()
	{
		screen.SetActive(true);
	}
}
