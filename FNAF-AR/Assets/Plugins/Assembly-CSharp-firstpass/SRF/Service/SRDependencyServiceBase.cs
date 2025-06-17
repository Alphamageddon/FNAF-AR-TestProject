using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace SRF.Service
{
	public abstract class SRDependencyServiceBase<T> : SRServiceBase<T>, IAsyncService where T : class
	{
		private bool _isLoaded;

		protected abstract Type[] Dependencies { get; }

		public bool IsLoaded => _isLoaded;

		[Conditional("ENABLE_LOGGING")]
		private void Log(string msg, UnityEngine.Object target)
		{
			UnityEngine.Debug.Log(msg, target);
		}

		protected override void Start()
		{
			base.Start();
			StartCoroutine(LoadDependencies());
		}

		protected virtual void OnLoaded()
		{
		}

		private IEnumerator LoadDependencies()
		{
			SRServiceManager.LoadingCount++;
			Type[] dependencies = Dependencies;
			foreach (Type type in dependencies)
			{
				if (SRServiceManager.HasService(type))
				{
					continue;
				}
				object service = SRServiceManager.GetService(type);
				if (service == null)
				{
					UnityEngine.Debug.LogError("[Service] Could not resolve dependency ({0})".Fmt(type.Name));
					base.enabled = false;
					yield break;
				}
				if (service is IAsyncService a)
				{
					while (!a.IsLoaded)
					{
						yield return new WaitForEndOfFrame();
					}
				}
			}
			_isLoaded = true;
			SRServiceManager.LoadingCount--;
			OnLoaded();
		}
	}
}
