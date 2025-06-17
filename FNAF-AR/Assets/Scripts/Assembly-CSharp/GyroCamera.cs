using System.Collections;
using UnityEngine;

public class GyroCamera : MonoBehaviour
{
	private float _initialYAngle;

	private float _appliedGyroYAngle;

	private float _calibrationYAngle;

	private Transform _rawGyroRotation;

	private float _tempSmoothing;

	[SerializeField]
	private float _smoothing = 0.1f;

	private void Start()
	{
		Input.gyro.enabled = true;
		_initialYAngle = base.transform.eulerAngles.y;
		_rawGyroRotation = new GameObject("GyroRaw").transform;
		_rawGyroRotation.position = base.transform.position;
		_rawGyroRotation.rotation = base.transform.rotation;
	}

	private void Update()
	{
		ApplyGyroRotation();
		ApplyCalibration();
		base.transform.rotation = Quaternion.Slerp(base.transform.rotation, _rawGyroRotation.rotation, _smoothing);
	}

	private IEnumerator CalibrateYAngle()
	{
		_tempSmoothing = _smoothing;
		_smoothing = 1f;
		_calibrationYAngle = _appliedGyroYAngle - _initialYAngle;
		yield return null;
		_smoothing = _tempSmoothing;
	}

	private void ApplyGyroRotation()
	{
		_rawGyroRotation.rotation = Input.gyro.attitude;
		_rawGyroRotation.Rotate(0f, 0f, 180f, Space.Self);
		_rawGyroRotation.Rotate(90f, 180f, 0f, Space.World);
		_appliedGyroYAngle = _rawGyroRotation.eulerAngles.y;
	}

	private void ApplyCalibration()
	{
		_rawGyroRotation.Rotate(0f, 0f - _calibrationYAngle, 0f, Space.World);
	}

	public void SetEnabled(bool value)
	{
		Input.gyro.enabled = true;
		_initialYAngle = base.transform.eulerAngles.y;
		if (_rawGyroRotation == null)
		{
			_rawGyroRotation = new GameObject("GyroRaw").transform;
		}
		_rawGyroRotation.position = base.transform.position;
		_rawGyroRotation.rotation = base.transform.rotation;
		base.enabled = true;
	}
}
