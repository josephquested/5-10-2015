using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : Clickable {
	public GameObject window;

	public override void Click ()
	{
		window.SetActive(false);
	}
}
