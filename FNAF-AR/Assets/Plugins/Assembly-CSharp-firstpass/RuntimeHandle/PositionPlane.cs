using UnityEngine;

namespace RuntimeHandle
{
	public class PositionPlane : HandleBase
	{
		protected Vector3 _startPosition;

		protected Vector3 _axis1;

		protected Vector3 _axis2;

		protected Vector3 _perp;

		protected Plane _plane;

		protected Vector3 _interactionOffset;

		protected GameObject _handle;

		public PositionPlane Initialize(RuntimeTransformHandle p_runtimeHandle, Vector3 p_axis1, Vector3 p_axis2, Vector3 p_perp, Color p_color)
		{
			_parentTransformHandle = p_runtimeHandle;
			_defaultColor = p_color;
			_axis1 = p_axis1;
			_axis2 = p_axis2;
			_perp = p_perp;
			InitializeMaterial();
			base.transform.SetParent(p_runtimeHandle.transform, worldPositionStays: false);
			_handle = new GameObject();
			_handle.transform.SetParent(base.transform, worldPositionStays: false);
			_handle.AddComponent<MeshRenderer>().material = _material;
			_handle.AddComponent<MeshFilter>().mesh = MeshUtils.CreateBox(0.02f, 0.5f, 0.5f);
			_handle.AddComponent<MeshCollider>();
			_handle.transform.localRotation = Quaternion.FromToRotation(Vector3.up, _perp);
			_handle.transform.localPosition = (_axis1 + _axis2) * 0.25f;
			return this;
		}

		public override void Interact(Vector3 p_previousPosition)
		{
			Ray ray = Camera.main.ScreenPointToRay(RuntimeTransformHandle.GetMousePosition());
			float enter = 0f;
			_plane.Raycast(ray, out enter);
			Vector3 vector = ray.GetPoint(enter) + _interactionOffset - _startPosition;
			Vector3 b = _axis1 + _axis2;
			Vector3 positionSnap = _parentTransformHandle.positionSnap;
			float magnitude = Vector3.Scale(positionSnap, b).magnitude;
			if (magnitude != 0f && _parentTransformHandle.snappingType == HandleSnappingType.RELATIVE)
			{
				if (positionSnap.x != 0f)
				{
					vector.x = Mathf.Round(vector.x / positionSnap.x) * positionSnap.x;
				}
				if (positionSnap.y != 0f)
				{
					vector.y = Mathf.Round(vector.y / positionSnap.y) * positionSnap.y;
				}
				if (positionSnap.z != 0f)
				{
					vector.z = Mathf.Round(vector.z / positionSnap.z) * positionSnap.z;
				}
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
			Vector3 inNormal = ((_parentTransformHandle.space == HandleSpace.LOCAL) ? (_parentTransformHandle.target.rotation * _perp) : _perp);
			_plane = new Plane(inNormal, _parentTransformHandle.target.position);
			Ray ray = Camera.main.ScreenPointToRay(RuntimeTransformHandle.GetMousePosition());
			float enter = 0f;
			_plane.Raycast(ray, out enter);
			Vector3 point = ray.GetPoint(enter);
			_startPosition = _parentTransformHandle.target.position;
			_interactionOffset = _startPosition - point;
		}

		private void Update()
		{
			Vector3 vector = _axis1;
			Vector3 to = ((_parentTransformHandle.space == HandleSpace.LOCAL) ? (_parentTransformHandle.target.rotation * vector) : vector);
			if (Vector3.Angle(_parentTransformHandle.handleCamera.transform.forward, to) < 90f)
			{
				vector = -vector;
			}
			Vector3 vector2 = _axis2;
			Vector3 to2 = ((_parentTransformHandle.space == HandleSpace.LOCAL) ? (_parentTransformHandle.target.rotation * vector2) : vector2);
			if (Vector3.Angle(_parentTransformHandle.handleCamera.transform.forward, to2) < 90f)
			{
				vector2 = -vector2;
			}
			_handle.transform.localPosition = (vector + vector2) * 0.25f;
		}
	}
}
