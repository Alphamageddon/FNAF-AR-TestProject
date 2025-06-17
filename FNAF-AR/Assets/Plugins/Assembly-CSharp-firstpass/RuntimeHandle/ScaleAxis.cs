using UnityEngine;

namespace RuntimeHandle
{
	public class ScaleAxis : HandleBase
	{
		private const float SIZE = 2f;

		private Vector3 _axis;

		private Vector3 _startScale;

		private float _interactionDistance;

		private Ray _raxisRay;

		public ScaleAxis Initialize(RuntimeTransformHandle p_parentTransformHandle, Vector3 p_axis, Color p_color)
		{
			_parentTransformHandle = p_parentTransformHandle;
			_axis = p_axis;
			_defaultColor = p_color;
			InitializeMaterial();
			base.transform.SetParent(p_parentTransformHandle.transform, worldPositionStays: false);
			GameObject obj = new GameObject();
			obj.transform.SetParent(base.transform, worldPositionStays: false);
			obj.AddComponent<MeshRenderer>().material = _material;
			obj.AddComponent<MeshFilter>().mesh = MeshUtils.CreateCone(p_axis.magnitude * 2f, 0.02f, 0.02f, 8, 1);
			obj.AddComponent<MeshCollider>().sharedMesh = MeshUtils.CreateCone(p_axis.magnitude * 2f, 0.1f, 0.02f, 8, 1);
			obj.transform.localRotation = Quaternion.FromToRotation(Vector3.up, p_axis);
			GameObject obj2 = new GameObject();
			obj2.transform.SetParent(base.transform, worldPositionStays: false);
			obj2.AddComponent<MeshRenderer>().material = _material;
			obj2.AddComponent<MeshFilter>().mesh = MeshUtils.CreateBox(0.25f, 0.25f, 0.25f);
			obj2.AddComponent<MeshCollider>();
			obj2.transform.localRotation = Quaternion.FromToRotation(Vector3.up, p_axis);
			obj2.transform.localPosition = p_axis * 2f;
			return this;
		}

		protected void Update()
		{
			base.transform.GetChild(0).localScale = new Vector3(1f, 1f + delta, 1f);
			base.transform.GetChild(1).localPosition = _axis * (2f * (1f + delta));
		}

		public override void Interact(Vector3 p_previousPosition)
		{
			Ray other = Camera.main.ScreenPointToRay(RuntimeTransformHandle.GetMousePosition());
			float distance = HandleMathUtils.ClosestPointOnRay(_raxisRay, other);
			Vector3 point = _raxisRay.GetPoint(distance);
			float num = Vector3.Distance(_parentTransformHandle.target.position, point) / _interactionDistance - 1f;
			float num2 = Mathf.Abs(Vector3.Dot(_parentTransformHandle.scaleSnap, _axis));
			if (num2 != 0f)
			{
				if (_parentTransformHandle.snappingType == HandleSnappingType.RELATIVE)
				{
					num = Mathf.Round(num / num2) * num2;
				}
				else
				{
					float num3 = Mathf.Abs(Vector3.Dot(_startScale, _axis));
					num = Mathf.Round((num + num3) / num2) * num2 - num3;
				}
			}
			delta = num;
			Vector3 localScale = Vector3.Scale(_startScale, _axis * num + Vector3.one);
			_parentTransformHandle.target.localScale = localScale;
			base.Interact(p_previousPosition);
		}

		public override void StartInteraction(Vector3 p_hitPoint)
		{
			base.StartInteraction(p_hitPoint);
			_startScale = _parentTransformHandle.target.localScale;
			Vector3 direction = ((_parentTransformHandle.space == HandleSpace.LOCAL) ? (_parentTransformHandle.target.rotation * _axis) : _axis);
			_raxisRay = new Ray(_parentTransformHandle.target.position, direction);
			Ray other = Camera.main.ScreenPointToRay(RuntimeTransformHandle.GetMousePosition());
			float distance = HandleMathUtils.ClosestPointOnRay(_raxisRay, other);
			Vector3 point = _raxisRay.GetPoint(distance);
			_interactionDistance = Vector3.Distance(_parentTransformHandle.target.position, point);
		}
	}
}
