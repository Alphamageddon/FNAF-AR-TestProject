using UnityEngine;

namespace RuntimeHandle
{
	public class PositionAxis : HandleBase
	{
		protected Vector3 _startPosition;

		protected Vector3 _axis;

		private Vector3 _interactionOffset;

		private Ray _raxisRay;

		public PositionAxis Initialize(RuntimeTransformHandle p_runtimeHandle, Vector3 p_axis, Color p_color)
		{
			_parentTransformHandle = p_runtimeHandle;
			_axis = p_axis;
			_defaultColor = p_color;
			InitializeMaterial();
			base.transform.SetParent(p_runtimeHandle.transform, worldPositionStays: false);
			GameObject obj = new GameObject();
			obj.transform.SetParent(base.transform, worldPositionStays: false);
			obj.AddComponent<MeshRenderer>().material = _material;
			obj.AddComponent<MeshFilter>().mesh = MeshUtils.CreateCone(2f, 0.02f, 0.02f, 8, 1);
			obj.AddComponent<MeshCollider>().sharedMesh = MeshUtils.CreateCone(2f, 0.1f, 0.02f, 8, 1);
			obj.transform.localRotation = Quaternion.FromToRotation(Vector3.up, p_axis);
			GameObject obj2 = new GameObject();
			obj2.transform.SetParent(base.transform, worldPositionStays: false);
			obj2.AddComponent<MeshRenderer>().material = _material;
			obj2.AddComponent<MeshFilter>().mesh = MeshUtils.CreateCone(0.4f, 0.2f, 0f, 8, 1);
			obj2.AddComponent<MeshCollider>();
			obj2.transform.localRotation = Quaternion.FromToRotation(Vector3.up, _axis);
			obj2.transform.localPosition = p_axis * 2f;
			return this;
		}

		public override void Interact(Vector3 p_previousPosition)
		{
			Ray other = Camera.main.ScreenPointToRay(RuntimeTransformHandle.GetMousePosition());
			float distance = HandleMathUtils.ClosestPointOnRay(_raxisRay, other);
			Vector3 vector = _raxisRay.GetPoint(distance) + _interactionOffset - _startPosition;
			Vector3 positionSnap = _parentTransformHandle.positionSnap;
			float magnitude = Vector3.Scale(positionSnap, _axis).magnitude;
			if (magnitude != 0f && _parentTransformHandle.snappingType == HandleSnappingType.RELATIVE)
			{
				vector = Mathf.Round(vector.magnitude / magnitude) * magnitude * vector.normalized;
			}
			Vector3 position = _startPosition + vector;
			if (magnitude != 0f && _parentTransformHandle.snappingType == HandleSnappingType.ABSOLUTE)
			{
				if (positionSnap.x != 0f)
				{
					position.x = Mathf.Round(position.x / positionSnap.x) * positionSnap.x;
				}
				if (positionSnap.y != 0f)
				{
					position.y = Mathf.Round(position.y / positionSnap.y) * positionSnap.y;
				}
				if (positionSnap.x != 0f)
				{
					position.z = Mathf.Round(position.z / positionSnap.z) * positionSnap.z;
				}
			}
			_parentTransformHandle.target.position = position;
			base.Interact(p_previousPosition);
		}

		public override void StartInteraction(Vector3 p_hitPoint)
		{
			base.StartInteraction(p_hitPoint);
			_startPosition = _parentTransformHandle.target.position;
			Vector3 direction = ((_parentTransformHandle.space == HandleSpace.LOCAL) ? (_parentTransformHandle.target.rotation * _axis) : _axis);
			_raxisRay = new Ray(_startPosition, direction);
			Ray other = Camera.main.ScreenPointToRay(RuntimeTransformHandle.GetMousePosition());
			float distance = HandleMathUtils.ClosestPointOnRay(_raxisRay, other);
			Vector3 point = _raxisRay.GetPoint(distance);
			_interactionOffset = _startPosition - point;
		}
	}
}
