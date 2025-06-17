using System;
using UnityEngine;

namespace RuntimeHandle
{
	public class RotationAxis : HandleBase
	{
		private Mesh _arcMesh;

		private Material _arcMaterial;

		private Vector3 _axis;

		private Vector3 _rotatedAxis;

		private Plane _axisPlane;

		private Vector3 _tangent;

		private Vector3 _biTangent;

		private Quaternion _startRotation;

		public RotationAxis Initialize(RuntimeTransformHandle p_runtimeHandle, Vector3 p_axis, Color p_color)
		{
			_parentTransformHandle = p_runtimeHandle;
			_axis = p_axis;
			_defaultColor = p_color;
			InitializeMaterial();
			base.transform.SetParent(p_runtimeHandle.transform, worldPositionStays: false);
			GameObject obj = new GameObject();
			obj.transform.SetParent(base.transform, worldPositionStays: false);
			obj.AddComponent<MeshRenderer>().material = _material;
			obj.AddComponent<MeshFilter>().mesh = MeshUtils.CreateTorus(2f, 0.02f, 32, 6);
			obj.AddComponent<MeshCollider>().sharedMesh = MeshUtils.CreateTorus(2f, 0.1f, 32, 6);
			obj.transform.localRotation = Quaternion.FromToRotation(Vector3.up, _axis);
			return this;
		}

		protected override void InitializeMaterial()
		{
			_material = new Material(Resources.Load("Shaders/AdvancedHandleShader") as Shader);
			_material.color = _defaultColor;
		}

		public void Update()
		{
			_material.SetVector("_CameraPosition", _parentTransformHandle.handleCamera.transform.position);
			_material.SetFloat("_CameraDistance", (_parentTransformHandle.handleCamera.transform.position - _parentTransformHandle.transform.position).magnitude);
		}

		public override void Interact(Vector3 p_previousPosition)
		{
			Ray ray = Camera.main.ScreenPointToRay(RuntimeTransformHandle.GetMousePosition());
			if (!_axisPlane.Raycast(ray, out var enter))
			{
				base.Interact(p_previousPosition);
				return;
			}
			Vector3 normalized = (ray.GetPoint(enter) - _parentTransformHandle.target.position).normalized;
			float num = Mathf.Atan2(x: Vector3.Dot(normalized, _tangent), y: Vector3.Dot(normalized, _biTangent));
			float num2 = num * 57.29578f;
			if (_parentTransformHandle.rotationSnap != 0f)
			{
				num2 = Mathf.Round(num2 / _parentTransformHandle.rotationSnap) * _parentTransformHandle.rotationSnap;
				num = num2 * (MathF.PI / 180f);
			}
			if (_parentTransformHandle.space == HandleSpace.LOCAL)
			{
				_parentTransformHandle.target.localRotation = _startRotation * Quaternion.AngleAxis(num2, _axis);
			}
			else
			{
				Vector3 axis = Quaternion.Inverse(_startRotation) * _axis;
				_parentTransformHandle.target.rotation = _startRotation * Quaternion.AngleAxis(num2, axis);
			}
			_arcMesh = MeshUtils.CreateArc(base.transform.position, _hitPoint, _rotatedAxis, 2f, num, Mathf.Abs(Mathf.CeilToInt(num2)) + 1);
			DrawArc();
			base.Interact(p_previousPosition);
		}

		public override bool CanInteract(Vector3 p_hitPoint)
		{
			float magnitude = (_parentTransformHandle.transform.position - _parentTransformHandle.handleCamera.transform.position).magnitude;
			return (p_hitPoint - _parentTransformHandle.handleCamera.transform.position).magnitude <= magnitude;
		}

		public override void StartInteraction(Vector3 p_hitPoint)
		{
			if (CanInteract(p_hitPoint))
			{
				base.StartInteraction(p_hitPoint);
				_startRotation = ((_parentTransformHandle.space == HandleSpace.LOCAL) ? _parentTransformHandle.target.localRotation : _parentTransformHandle.target.rotation);
				_arcMaterial = new Material(Shader.Find("sHTiF/HandleShader"));
				_arcMaterial.color = new Color(1f, 1f, 0f, 0.4f);
				_arcMaterial.renderQueue = 5000;
				if (_parentTransformHandle.space == HandleSpace.LOCAL)
				{
					_rotatedAxis = _startRotation * _axis;
				}
				else
				{
					_rotatedAxis = _axis;
				}
				_axisPlane = new Plane(_rotatedAxis, _parentTransformHandle.target.position);
				Ray ray = Camera.main.ScreenPointToRay(RuntimeTransformHandle.GetMousePosition());
				float enter;
				Vector3 vector = ((!_axisPlane.Raycast(ray, out enter)) ? _axisPlane.ClosestPointOnPlane(p_hitPoint) : ray.GetPoint(enter));
				_tangent = (vector - _parentTransformHandle.target.position).normalized;
				_biTangent = Vector3.Cross(_rotatedAxis, _tangent);
			}
		}

		public override void EndInteraction()
		{
			base.EndInteraction();
			delta = 0f;
		}

		private void DrawArc()
		{
			Graphics.DrawMesh(_arcMesh, Matrix4x4.identity, _arcMaterial, 0);
		}
	}
}
