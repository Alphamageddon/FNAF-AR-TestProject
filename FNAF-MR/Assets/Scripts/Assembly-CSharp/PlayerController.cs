using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public static PlayerController Instance;

	public int _playerSpeed = 3;

	public int activeLockerIndex;

	public bool InLocker;

	private bool canMove;

	private CharacterController characterController;

	private Vector3 cachedPos;

	private PlayerUIManager UIManager;

	private void Start()
	{
		Instance = this;
		characterController = GetComponent<CharacterController>();
		UIManager = GetComponent<PlayerUIManager>();
		InLocker = false;
		canMove = true;
	}

	public void MovementUpdate(float horizontal, float vertical)
	{
		if (canMove)
		{
			float num = horizontal;
			float axis = Input.GetAxis("Horizontal");
			if (axis != 0f)
			{
				num = axis;
			}
			float num2 = vertical;
			float axis2 = Input.GetAxis("Vertical");
			if (axis2 != 0f)
			{
				num2 = axis2;
			}
			Vector3 vector = base.transform.right * num + base.transform.forward * num2;
			vector.y = 0f;
			characterController.Move(vector * _playerSpeed * Time.deltaTime);
		}
	}

	public void EnterLocker(int idx, Vector3 lockerPos)
	{
		activeLockerIndex = idx;
		InLocker = true;
		canMove = false;
		cachedPos = base.transform.position;
		base.transform.position = new Vector3(lockerPos.x, 0f, lockerPos.z);
		UIManager.EnterLocker();
	}

	public void ExitLocker()
	{
		InLocker = false;
		canMove = true;
		base.transform.position = cachedPos;
		UIManager.ExitLocker();
	}

	public void Jumpscare()
	{
		canMove = false;
	}
}
