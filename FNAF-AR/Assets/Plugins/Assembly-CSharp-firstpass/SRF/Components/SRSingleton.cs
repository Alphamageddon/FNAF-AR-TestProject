using System;
using System.Diagnostics;
using UnityEngine;

namespace SRF.Components
{
	public abstract class SRSingleton<T> : SRMonoBehaviour where T : SRSingleton<T>
	{
		private static T _instance;

		public static T Instance
		{
			[DebuggerStepThrough]
			get
			{
				if (_instance == null)
				{
					throw new InvalidOperationException("No instance of {0} present in scene".Fmt(typeof(T).Name));
				}
				return _instance;
			}
		}

		public static bool HasInstance
		{
			[DebuggerStepThrough]
			get
			{
				return _instance != null;
			}
		}

		private void Register()
		{
			if (_instance != null)
			{
				UnityEngine.Debug.LogWarning("More than one singleton object of type {0} exists.".Fmt(typeof(T).Name));
				if (GetComponents<Component>().Length == 2)
				{
					UnityEngine.Object.Destroy(base.gameObject);
				}
				else
				{
					UnityEngine.Object.Destroy(this);
				}
			}
			else
			{
				_instance = (T)this;
			}
		}

		protected virtual void Awake()
		{
			Register();
		}

		protected virtual void OnEnable()
		{
			if (_instance == null)
			{
				Register();
			}
		}

		private void OnApplicationQuit()
		{
			_instance = null;
		}
	}
}
