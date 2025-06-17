using System;
using UnityEngine;

namespace RuntimeHandle
{
	public abstract class HandleBase : MonoBehaviour
	{
		protected RuntimeTransformHandle _parentTransformHandle;

		protected Color _defaultColor;

		protected Material _material;

		protected Vector3 _hitPoint;

		protected bool _isInteracting;

		public float delta;

		public event Action InteractionStart;

		public event Action InteractionEnd;

		public event Action<float> InteractionUpdate;

		protected virtual void InitializeMaterial()
		{
			_material = new Material(Resources.Load("Shaders/HandleShader") as Shader);
			_material.color = _defaultColor;
		}

		public void SetDefaultColor()
		{
			_material.color = _defaultColor;
		}

		public void SetColor(Color p_color)
		{
			_material.color = p_color;
		}

		public virtual void StartInteraction(Vector3 p_hitPoint)
		{
			_hitPoint = p_hitPoint;
			this.InteractionStart?.Invoke();
			_isInteracting = true;
		}

		public virtual bool CanInteract(Vector3 p_hitPoint)
		{
			return true;
		}

		public virtual void Interact(Vector3 p_previousPosition)
		{
			this.InteractionUpdate?.Invoke(delta);
		}

		public virtual void EndInteraction()
		{
			_isInteracting = false;
			this.InteractionEnd?.Invoke();
			delta = 0f;
			SetDefaultColor();
		}

		public static Vector3 GetVectorFromAxes(HandleAxes p_axes)
		{
			return p_axes switch
			{
				HandleAxes.X => new Vector3(1f, 0f, 0f), 
				HandleAxes.Y => new Vector3(0f, 1f, 0f), 
				HandleAxes.Z => new Vector3(0f, 0f, 1f), 
				HandleAxes.XY => new Vector3(1f, 1f, 0f), 
				HandleAxes.XZ => new Vector3(1f, 0f, 1f), 
				HandleAxes.YZ => new Vector3(0f, 1f, 1f), 
				_ => new Vector3(1f, 1f, 1f), 
			};
		}
	}
}
