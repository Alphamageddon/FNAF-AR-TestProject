using UnityEngine;

namespace RuntimeHandle
{
	public class ScaleGlobal : HandleBase
	{
		protected Vector3 _axis;

		protected Vector3 _startScale;

		public ScaleGlobal Initialize(RuntimeTransformHandle p_parentTransformHandle, Vector3 p_axis, Color p_color)
		{
			_parentTransformHandle = p_parentTransformHandle;
			_axis = p_axis;
			_defaultColor = p_color;
			InitializeMaterial();
			base.transform.SetParent(p_parentTransformHandle.transform, worldPositionStays: false);
			GameObject obj = new GameObject();
			obj.transform.SetParent(base.transform, worldPositionStays: false);
			obj.AddComponent<MeshRenderer>().material = _material;
			obj.AddComponent<MeshFilter>().mesh = MeshUtils.CreateBox(0.35f, 0.35f, 0.35f);
			obj.AddComponent<MeshCollider>();
			return this;
		}

		public override void Interact(Vector3 p_previousPosition)
		{
			Vector3 vector = RuntimeTransformHandle.GetMousePosition() - p_previousPosition;
			float num = (vector.x + vector.y) * Time.deltaTime * 2f;
			delta += num;
			_parentTransformHandle.target.localScale = _startScale + Vector3.Scale(_startScale, _axis) * delta;
			base.Interact(p_previousPosition);
		}

		public override void StartInteraction(Vector3 p_hitPoint)
		{
			base.StartInteraction(p_hitPoint);
			_startScale = _parentTransformHandle.target.localScale;
		}
	}
}
