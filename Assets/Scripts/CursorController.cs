using UnityEngine;
using System.Collections;

public class CursorController : MonoBehaviour {
 	public float speed = 1.0f;
 	public bool canMove;

	Clickable clickable;

	void Start ()
	{
		canMove = true;
	}

	void Update ()
	{
		ControlMouseMovement();
		CheckForClick();
  }

	public void CheckForClick ()
	{
		if (Input.GetButtonDown("Fire1") && clickable != null)
		{
			clickable.Click();
		}
	}

	void ControlMouseMovement () {
		if (canMove)
		{
			transform.Translate(new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0) * Time.deltaTime * speed);
		}
	}

	void OnTriggerEnter (Collider collider)
	{
		if (collider.GetComponent<Clickable>() != null)
		{
			clickable = collider.GetComponent<Clickable>();
		}
	}

	void OnTriggerExit (Collider collider)
	{
		if (collider.GetComponent<Clickable>() != null)
		{
			clickable = null;
		}
	}
}
