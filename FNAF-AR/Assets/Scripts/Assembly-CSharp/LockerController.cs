using UnityEngine;

public class LockerController : MonoBehaviour
{
	[SerializeField]
	private Transform buttonTransform;

	[SerializeField]
	private LockerButton lockerButton;

	private int lockerIndex = -1;

	private Animator lockerAnimator;

	private void Start()
	{
		lockerAnimator = GetComponent<Animator>();
		lockerAnimator.SetBool("IsClosed", value: false);
	}

	public void SetIndex(int index)
	{
		lockerIndex = index;
	}

	public void PlayJumpscareAnimation()
	{
		lockerAnimator.SetTrigger("Jumpscare");
		buttonTransform.gameObject.SetActive(value: false);
	}

	public void EnterLocker()
	{
		PlayerController.Instance.EnterLocker(lockerIndex, base.transform.position);
		lockerAnimator.SetBool("IsClosed", value: true);
	}

	public void ExitLocker()
	{
		lockerAnimator.SetBool("IsClosed", value: false);
		lockerButton.ExitLocker();
	}
}
