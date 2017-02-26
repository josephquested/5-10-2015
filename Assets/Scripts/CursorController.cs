using UnityEngine;
using System.Collections;

public class CursorController : MonoBehaviour {
	// [SerializeField] ComputerController computerController;
	// [SerializeField] GameObject activeFolder;
	// [SerializeField] FolderController folderController;
	[SerializeField] float speed = 1.0f;
	[SerializeField] bool canMove;

	void Start ()
	{
		canMove = true;
	}

	void Update ()
	{
		ControlMouseMovement();
  }

	public void Click ()
	{
		// if (folderController)
		// {
		// 	folderController.Click();
		// }
	}

	public void DoubleClick ()
	{
		// if (folderController) {
		// 	folderController.DoubleClick();
		// }
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
			collider.GetComponent<Clickable>().Click();
		}
	}

	void OnTriggerExit (Collider collider)
	{
		// if (collider.CompareTag("Folder")) {
		// 	activeFolder = null;
		// 	folderController = null;
		// }
	}
}
