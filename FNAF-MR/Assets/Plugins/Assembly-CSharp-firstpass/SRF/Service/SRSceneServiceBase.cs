using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SRF.Service
{
	public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService where T : class where TImpl : Component
	{
		private TImpl _rootObject;

		protected abstract string SceneName { get; }

		protected TImpl RootObject => _rootObject;

		public bool IsLoaded => _rootObject != null;

		[Conditional("ENABLE_LOGGING")]
		private void Log(string msg, Object target)
		{
			UnityEngine.Debug.Log(msg, target);
		}

		protected override void Start()
		{
			base.Start();
			StartCoroutine(LoadCoroutine());
		}

		protected override void OnDestroy()
		{
			if (IsLoaded)
			{
				Object.Destroy(_rootObject.gameObject);
			}
			base.OnDestroy();
		}

		protected virtual void OnLoaded()
		{
		}

		private IEnumerator LoadCoroutine()
		{
			if (_rootObject != null)
			{
				yield break;
			}
			SRServiceManager.LoadingCount++;
			if (!SceneManager.GetSceneByName(SceneName).isLoaded)
			{
				yield return SceneManager.LoadSceneAsync(SceneName, LoadSceneMode.Additive);
			}
			GameObject gameObject = GameObject.Find(SceneName);
			if (!(gameObject == null))
			{
				TImpl component = gameObject.GetComponent<TImpl>();
				if (!(component == null))
				{
					_rootObject = component;
					_rootObject.transform.parent = base.CachedTransform;
					Object.DontDestroyOnLoad(gameObject);
					UnityEngine.Debug.Log("[Service] Loading {0} complete. (Scene: {1})".Fmt(GetType().Name, SceneName), this);
					SRServiceManager.LoadingCount--;
					OnLoaded();
					yield break;
				}
			}
			SRServiceManager.LoadingCount--;
			UnityEngine.Debug.LogError("[Service] Root object ({0}) not found".Fmt(SceneName), this);
			base.enabled = false;
		}
	}
}
