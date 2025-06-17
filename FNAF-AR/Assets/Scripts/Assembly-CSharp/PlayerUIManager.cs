using UnityEngine;

public class PlayerUIManager : MonoBehaviour
{
	public GameObject LockerExitButton;

	public void EnterLocker()
	{
		LockerExitButton.SetActive(value: true);
	}

	public void ExitLocker()
	{
		LockerExitButton.SetActive(value: false);
	}
}
