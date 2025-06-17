using System.Diagnostics;
using UnityEngine;

namespace SRF
{
	public abstract class SRMonoBehaviour : MonoBehaviour
	{
		private Collider _collider;

		private Transform _transform;

		private Rigidbody _rigidBody;

		private GameObject _gameObject;

		private Rigidbody2D _rigidbody2D;

		private Collider2D _collider2D;

		public Transform CachedTransform
		{
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				if (_transform == null)
				{
					_transform = base.transform;
				}
				return _transform;
			}
		}

		public Collider CachedCollider
		{
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				if (_collider == null)
				{
					_collider = GetComponent<Collider>();
				}
				return _collider;
			}
		}

		public Collider2D CachedCollider2D
		{
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				if (_collider2D == null)
				{
					_collider2D = GetComponent<Collider2D>();
				}
				return _collider2D;
			}
		}

		public Rigidbody CachedRigidBody
		{
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				if (_rigidBody == null)
				{
					_rigidBody = GetComponent<Rigidbody>();
				}
				return _rigidBody;
			}
		}

		public Rigidbody2D CachedRigidBody2D
		{
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				if (_rigidbody2D == null)
				{
					_rigidbody2D = GetComponent<Rigidbody2D>();
				}
				return _rigidbody2D;
			}
		}

		public GameObject CachedGameObject
		{
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				if (_gameObject == null)
				{
					_gameObject = base.gameObject;
				}
				return _gameObject;
			}
		}

		public new Transform transform => CachedTransform;

		public Collider collider => CachedCollider;

		public Collider2D collider2D => CachedCollider2D;

		public Rigidbody rigidbody => CachedRigidBody;

		public Rigidbody2D rigidbody2D => CachedRigidBody2D;

		public new GameObject gameObject => CachedGameObject;

		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void AssertNotNull(object value, string fieldName = null)
		{
			SRDebugUtil.AssertNotNull(value, fieldName, this);
		}

		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void Assert(bool condition, string message = null)
		{
			SRDebugUtil.Assert(condition, message, this);
		}

		[Conditional("UNITY_EDITOR")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssertNotNull(object value, string fieldName = null)
		{
			AssertNotNull(value, fieldName);
		}

		[Conditional("UNITY_EDITOR")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssert(bool condition, string message = null)
		{
			Assert(condition, message);
		}
	}
}
