using UnityEngine;

public class ParticleForceFieldsDemo_CameraRig : MonoBehaviour
{
	public Transform pivot;

	private Vector3 targetRotation;

	[Range(0f, 90f)]
	public float rotationLimit = 90f;

	public float rotationSpeed = 2f;

	public float rotationLerpSpeed = 4f;

	private Vector3 startRotation;

	private void Start()
	{
		startRotation = pivot.localEulerAngles;
		targetRotation = startRotation;
	}

	private void Update()
	{
		float axis = Input.GetAxis("Horizontal");
		float axis2 = Input.GetAxis("Vertical");
		if (Input.GetKeyDown(KeyCode.R))
		{
			targetRotation = startRotation;
		}
		axis *= rotationSpeed;
		axis2 *= rotationSpeed;
		targetRotation.y += axis;
		targetRotation.x += axis2;
		targetRotation.x = Mathf.Clamp(targetRotation.x, 0f - rotationLimit, rotationLimit);
		targetRotation.y = Mathf.Clamp(targetRotation.y, 0f - rotationLimit, rotationLimit);
		Vector3 localEulerAngles = pivot.localEulerAngles;
		localEulerAngles.x = Mathf.LerpAngle(localEulerAngles.x, targetRotation.x, Time.deltaTime * rotationLerpSpeed);
		localEulerAngles.y = Mathf.LerpAngle(localEulerAngles.y, targetRotation.y, Time.deltaTime * rotationLerpSpeed);
		pivot.localEulerAngles = localEulerAngles;
	}
}
