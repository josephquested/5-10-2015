using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MineButton : Clickable {
	public GameObject blownMineSprite;
	public GameObject wallsScreen;
	public GameObject brokenScreen;

	public override void Click ()
	{
		blownMineSprite.SetActive(true);
		StartCoroutine(ExplosionRoutine());
	}

	IEnumerator ExplosionRoutine ()
	{
		yield return new WaitForSeconds(1.5f);
		wallsScreen.SetActive(false);
		brokenScreen.SetActive(true);
		GameObject.FindWithTag("Player").GetComponent<PlayerExplode>().Explode();
	}
}
