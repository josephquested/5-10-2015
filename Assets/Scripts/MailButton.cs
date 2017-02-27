using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailButton : Clickable {
	public GameObject mailScreen;

	public override void Click ()
	{
		print("clicked the mail button");
		// mailScreen.SetActive(true);
	}
}
