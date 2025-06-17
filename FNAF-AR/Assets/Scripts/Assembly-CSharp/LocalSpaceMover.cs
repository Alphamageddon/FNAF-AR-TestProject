using UnityEngine;

public class LocalSpaceMover
{
	private Transform _animatronicPrefabTransform;

	private float _movementUnitsPerSecond;

	private bool _rotateAroundOrigin;

	public float GetDistanceFromLocalOrigin()
	{
		return _animatronicPrefabTransform.localPosition.magnitude;
	}

	public void SetMovementUnitsPerSecond(float movementSpeed)
	{
		_movementUnitsPerSecond = movementSpeed;
	}

	public void RotateAroundOrigin()
	{
		Vector3 vector = Quaternion.AngleAxis(_movementUnitsPerSecond * Time.deltaTime, Vector3.up) * _animatronicPrefabTransform.localPosition;
		_animatronicPrefabTransform.forward = vector - _animatronicPrefabTransform.localPosition;
		_animatronicPrefabTransform.localPosition = vector;
	}

	public bool MoveTowardOrigin()
	{
		float num = _movementUnitsPerSecond * Time.deltaTime;
		if (num < GetDistanceFromLocalOrigin())
		{
			Vector3 translation = (-_animatronicPrefabTransform.localPosition).normalized * num;
			_animatronicPrefabTransform.Translate(translation, Space.World);
			_animatronicPrefabTransform.forward = -_animatronicPrefabTransform.localPosition;
			return false;
		}
		_animatronicPrefabTransform.localPosition = Vector3.zero;
		return true;
	}

	public LocalSpaceMover(Transform animatronicPrefabTransform)
	{
		_animatronicPrefabTransform = animatronicPrefabTransform;
	}

	public void Teardown()
	{
		_animatronicPrefabTransform = null;
	}
}
