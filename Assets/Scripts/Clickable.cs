using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour {
	public virtual void Click ()
	{
		print("I was clicked");
	}

	void OnMouseOver()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Click();
		}
	}
}
