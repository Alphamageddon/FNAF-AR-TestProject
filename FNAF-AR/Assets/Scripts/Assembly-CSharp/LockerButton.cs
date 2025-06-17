using UnityEngine;
using UnityEngine.UI;

public class LockerButton : MonoBehaviour
{
	private Transform playerTransform;

	public Button button;

	private bool playerInLocker;

	private bool lockerInUse;

	private Transform canvasTransform;

	public Canvas lockerCanvas;

	public LockerController lockerController;

	public float InteractDistance = 3f;

	private void Start()
	{
		lockerInUse = false;
		lockerCanvas.worldCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
		canvasTransform = lockerCanvas.transform;
	}

	private void Update()
	{
		canvasTransform.LookAt(playerTransform);
		playerInLocker = PlayerController.Instance.InLocker;
		playerTransform = PlayerController.Instance.transform;
		if (lockerInUse || playerInLocker || Vector3.Distance(PlayerController.Instance.transform.position, base.transform.position) > InteractDistance)
		{
			base.transform.localScale = new Vector3(0f, 0f, 0f);
			button.interactable = false;
		}
		else
		{
			base.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
			button.interactable = true;
		}
	}

	public void ButtonPressed()
	{
		Debug.Log("ButtonPressed!");
		lockerInUse = true;
		lockerController.EnterLocker();
	}

	public void ExitLocker()
	{
		lockerInUse = false;
	}
}
