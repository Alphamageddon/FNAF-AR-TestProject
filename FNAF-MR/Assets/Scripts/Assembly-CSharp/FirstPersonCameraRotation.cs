using UnityEngine;

public class FirstPersonCameraRotation : MonoBehaviour
{
	[Range(0.1f, 9f)]
	[SerializeField]
	private float sensitivity = 2f;

	[Tooltip("Limits vertical camera rotation. Prevents the flipping that happens when rotation goes above 90.")]
	[Range(0f, 90f)]
	[SerializeField]
	private float yRotationLimit = 88f;

	private Vector2 rotation = Vector2.zero;

	private const string xAxis = "Mouse X";

	private const string yAxis = "Mouse Y";

	public float Sensitivity
	{
		get
		{
			return sensitivity;
		}
		set
		{
			sensitivity = value;
		}
	}

	private void Update()
	{
		rotation.x += Input.GetAxis("Mouse X") * sensitivity;
		rotation.y += Input.GetAxis("Mouse Y") * sensitivity;
		rotation.y = Mathf.Clamp(rotation.y, 0f - yRotationLimit, yRotationLimit);
		Quaternion quaternion = Quaternion.AngleAxis(rotation.x, Vector3.up);
		Quaternion quaternion2 = Quaternion.AngleAxis(rotation.y, Vector3.left);
		base.transform.localRotation = quaternion * quaternion2;
	}

	private void OnEnable()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	private void OnDisable()
	{
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}
}
