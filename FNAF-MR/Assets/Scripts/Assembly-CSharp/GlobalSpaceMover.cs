using UnityEngine;

public class GlobalSpaceMover
{
	private Transform _cameraTransform;

	private Transform _animatronicPrefabTransform;

	private float _movementUnitsPerSecond;

	public float GetDistanceFromCamera()
	{
		return (_animatronicPrefabTransform.position - _cameraTransform.position).magnitude;
	}

	private float GetFlatDistanceFromCamera()
	{
		Vector3 vector = _cameraTransform.position - _animatronicPrefabTransform.position;
		return new Vector3(vector.x, 0f, vector.z).magnitude;
	}

	public void RotateAroundCamera()
	{
		Vector3 vector = _animatronicPrefabTransform.position - _cameraTransform.position;
		float angle = _movementUnitsPerSecond * Time.deltaTime;
		Vector3 vector2 = new Vector3
		{
			x = vector.x,
			y = 0f,
			z = vector.z
		};
		Vector3 vector3 = Quaternion.AngleAxis(angle, Vector3.up) * vector2;
		_animatronicPrefabTransform.forward = vector3 - vector2;
		_animatronicPrefabTransform.position = _cameraTransform.position + vector3;
	}

	public bool MoveTowardCamera()
	{
		Vector3 vector = _cameraTransform.position - _animatronicPrefabTransform.position;
		Vector3 vector2 = new Vector3(vector.x, 0f, vector.z);
		float num = _movementUnitsPerSecond * Time.deltaTime;
		if (num < GetFlatDistanceFromCamera())
		{
			Vector3 translation = vector2.normalized * num;
			_animatronicPrefabTransform.Translate(translation, Space.World);
			_animatronicPrefabTransform.forward = vector2.normalized;
			return false;
		}
		return true;
	}

	public void SetMovementUnitsPerSecond(float movementUnitsPerSecond)
	{
		_movementUnitsPerSecond = movementUnitsPerSecond;
	}

	public GlobalSpaceMover(Transform animatronicPrefabTransform, Transform cameraTransform)
	{
		_cameraTransform = cameraTransform;
		_animatronicPrefabTransform = animatronicPrefabTransform;
	}

	public void Teardown()
	{
		_cameraTransform = null;
		_animatronicPrefabTransform = null;
	}
}
