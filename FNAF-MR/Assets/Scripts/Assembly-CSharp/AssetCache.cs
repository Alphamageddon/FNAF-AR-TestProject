using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AssetCache
{
	private BundleCache _bundleCache;

	private readonly Dictionary<string, Dictionary<string, IAssetLoader>> _assetLoaders;

	private readonly Dictionary<string, Dictionary<string, AssetRefData>> _refDataByPath;

	private readonly Dictionary<object, AssetRefData> _refDataByLoadedAsset;

	private readonly Dictionary<object, AssetRefData> _refDataByAssetInstance;

	private Action<AssetCache> callbacks;

	private bool dispatched;

	private SceneLoadingInformation currentSceneLoadInfo;

	protected AssetCache GetPublicInterface => this;

	public int NumLoadedBundles => _refDataByPath.Count;

	public int NumLoadedAssets
	{
		get
		{
			int num = 0;
			foreach (Dictionary<string, AssetRefData> value in _refDataByPath.Values)
			{
				num += value.Count;
			}
			return num;
		}
	}

	public void GetInterfaceAsync(Action<AssetCache> callback)
	{
		if (!dispatched)
		{
			callbacks = (Action<AssetCache>)Delegate.Combine(callbacks, callback);
		}
		else
		{
			callback?.Invoke(this);
		}
	}

	public void BundleContainsAsset(string bundleName, string assetName, Action<bool> containsCallback)
	{
		if (_bundleCache == null)
		{
			Debug.LogError("AssetCache BundleContainsAsset - Bundle cache is null");
			containsCallback(obj: false);
		}
		else
		{
			Debug.LogError("BundleContainsAsset was called but Orton didn't finish coding this, auto returned false.");
			containsCallback(obj: false);
		}
	}

	public void LoadAsset<T>(string bundleName, string assetName, Action<T> onSuccess, Action onFailure) where T : class
	{
		if (HasAssetInCache(bundleName, assetName))
		{
			InvokeSuccessOnCachedAsset(bundleName, assetName, onSuccess);
		}
		else if (!IsLoadingAsset(bundleName, assetName))
		{
			StartLoadingAsset(bundleName, assetName, onSuccess, onFailure);
		}
		else
		{
			AddLoadRequestToLoadingAsset(bundleName, assetName, onSuccess, onFailure);
		}
	}

	public void LoadScene(string bundleName, string assetName, Action<AsyncOperation> onSuccess, Action onFailure)
	{
		SceneLoadingInformation sceneLoadingInformation = new SceneLoadingInformation(bundleName, assetName, onSuccess, onFailure);
		currentSceneLoadInfo = sceneLoadingInformation;
		_bundleCache.LoadAssetBundleAsync(bundleName, SceneBundleLoaded, SceneBundleFailed);
	}

	private void SceneBundleLoaded(CachedAssetBundle cache, AssetBundle sceneAssetBundle)
	{
		string[] allScenePaths = sceneAssetBundle.GetAllScenePaths();
		if (allScenePaths.Length != 0)
		{
			AsyncOperation obj = SceneManager.LoadSceneAsync(allScenePaths[0], LoadSceneMode.Additive);
			currentSceneLoadInfo.successAction?.Invoke(obj);
		}
		else
		{
			currentSceneLoadInfo.failureAction?.Invoke();
		}
	}

	private void SceneBundleFailed(CachedAssetBundle cache)
	{
		currentSceneLoadInfo.failureAction?.Invoke();
	}

	public void UnloadScene(string bundleName, string assetName, Action complete)
	{
		bool flag = false;
		foreach (Entry entry in ConstantVariables.Instance.AssetBundleDownloader.DeserializedTOC.Entries)
		{
			if (entry.BundleName == bundleName)
			{
				flag = true;
				break;
			}
		}
		string bundleName2 = bundleName;
		string sceneName = assetName;
		if (!flag)
		{
			Debug.LogError("Environment " + bundleName + " - " + assetName + " is not in TOC.");
			bundleName2 = "environments/freddy";
			sceneName = "Environment";
		}
		SceneManager.UnloadSceneAsync(sceneName);
		_bundleCache.ReleaseAssetBundleReference(bundleName2);
		complete?.Invoke();
	}

	private bool HasAssetInCache(string bundleName, string assetName)
	{
		if (!_refDataByPath.ContainsKey(bundleName))
		{
			return false;
		}
		return _refDataByPath[bundleName].ContainsKey(assetName);
	}

	private void InvokeSuccessOnCachedAsset<T>(string bundleName, string assetName, Action<T> onSuccess) where T : class
	{
		AssetRefData assetRefData = _refDataByPath[bundleName][assetName];
		assetRefData.IncrementRefCount();
		if (assetRefData.Asset != null)
		{
			onSuccess?.Invoke((T)assetRefData.Asset);
		}
	}

	private bool IsLoadingAsset(string bundleName, string assetName)
	{
		if (!_assetLoaders.ContainsKey(bundleName))
		{
			return false;
		}
		return _assetLoaders[bundleName].ContainsKey(assetName);
	}

	private void AddLoadRequestToLoadingAsset<T>(string bundleName, string assetName, Action<T> onSuccess, Action onFailure) where T : class
	{
		IAssetLoader assetLoader = _assetLoaders[bundleName][assetName];
		if (assetLoader != null)
		{
			((AssetLoader<T>)assetLoader).AddRequest(onSuccess, onFailure);
		}
	}

	private void StartLoadingAsset<T>(string bundleName, string assetName, Action<T> onSuccess, Action onFailure) where T : class
	{
		AssetLoader<T> assetLoader = new AssetLoader<T>(onSuccess, onFailure, AssetLoadComplete);
		AddToNestedDictionaries(bundleName, assetName, assetLoader, _assetLoaders);
		assetLoader.Load(_bundleCache, bundleName, assetName);
	}

	private void AssetLoadComplete<T>(IAssetLoader loader, T loadedAsset) where T : class
	{
		RemoveFromNestedDictionaries(loader.GetBundleName(), loader.GetAssetName(), _assetLoaders);
		if (!_refDataByPath.ContainsKey(loader.GetBundleName()))
		{
			TrackLoadedAsset(loader.GetBundleName(), loader.GetAssetName(), loader.GetNumRequests(), loadedAsset);
		}
		else if (!_refDataByPath[loader.GetBundleName()].ContainsKey(loader.GetAssetName()))
		{
			TrackLoadedAsset(loader.GetBundleName(), loader.GetAssetName(), loader.GetNumRequests(), loadedAsset);
		}
		else if (_refDataByPath[loader.GetBundleName()][loader.GetAssetName()] == null)
		{
			TrackLoadedAsset(loader.GetBundleName(), loader.GetAssetName(), loader.GetNumRequests(), loadedAsset);
		}
	}

	private void TrackLoadedAsset<T>(string bundleName, string assetName, int requestCount, T loadedAsset) where T : class
	{
		if (loadedAsset != null)
		{
			AddToNestedDictionaries(bundleName, assetName, new AssetRefData(bundleName, assetName, loadedAsset, requestCount), _refDataByPath);
			_refDataByLoadedAsset.Add(loadedAsset, _refDataByPath[bundleName][assetName]);
		}
	}

	public void Instantiate(string bundleName, string assetName, Action<GameObject> onSuccess, Action onFailure)
	{
		LoadAsset(bundleName, assetName, delegate(GameObject asset)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(asset);
			AssetRefData assetRefData = new AssetRefData(bundleName, assetName, gameObject, _refDataByLoadedAsset[asset]);
			assetRefData.IncrementRefCount();
			_refDataByAssetInstance.Add(gameObject, assetRefData);
			onSuccess(gameObject);
		}, onFailure);
	}

	public void ReleaseAsset(object loadedAsset)
	{
		if (loadedAsset != null)
		{
			if (_refDataByLoadedAsset.ContainsKey(loadedAsset))
			{
				AssetRefData assetRefData = _refDataByLoadedAsset[loadedAsset];
				DecrementRefCount(assetRefData);
				CleanUpUnreferencedAsset(assetRefData, loadedAsset);
			}
		}
		else
		{
			Debug.LogError("AssetCache ReleaseAsset - Attempting to release a null object.");
		}
	}

	private void CleanUpUnreferencedAsset(AssetRefData assetRefData, object loadedAsset)
	{
		if (!assetRefData.HasRefs())
		{
			RemoveFromNestedDictionaries(assetRefData.BundleName, assetRefData.AssetName, _refDataByPath);
			_refDataByLoadedAsset.Remove(loadedAsset);
		}
	}

	public void ReleaseInstance(object assetInstance)
	{
		if (assetInstance != null)
		{
			if (!_refDataByAssetInstance.ContainsKey(assetInstance))
			{
				Debug.Log("No reference data for " + assetInstance);
				return;
			}
			AssetRefData assetRefData = _refDataByAssetInstance[assetInstance];
			DecrementRefCount(assetRefData);
			CleanupUnreferencedAssetInstance(assetRefData, assetInstance);
		}
		else
		{
			Debug.LogError("AssetCache ReleaseInstance - Attempting to release a null object.");
		}
	}

	private void CleanupUnreferencedAssetInstance(AssetRefData assetRefData, object assetInstance)
	{
		if (assetRefData.HasRefs())
		{
			Debug.Log("Destroying cant happen, has refs for " + assetRefData.AssetName);
			return;
		}
		_refDataByAssetInstance.Remove(assetInstance);
		if (assetInstance != null)
		{
			Debug.Log("Destroying Asset Instance " + assetRefData.AssetName);
			UnityEngine.Object.Destroy((UnityEngine.Object)assetInstance);
		}
	}

	public void DumpCache()
	{
		foreach (string key in _refDataByPath.Keys)
		{
			_refDataByPath[key].Clear();
		}
		_refDataByPath.Clear();
		_refDataByLoadedAsset.Clear();
		_refDataByAssetInstance.Clear();
	}

	private void DecrementRefCount(AssetRefData assetRefData)
	{
		assetRefData.DecrementRefCount();
		if (assetRefData.Parent != null)
		{
			ReleaseAsset(assetRefData.Parent.Asset);
		}
	}

	private void AddToNestedDictionaries<T>(string bundleName, string assetName, T entry, Dictionary<string, Dictionary<string, T>> dict) where T : class
	{
		if (!dict.ContainsKey(bundleName))
		{
			dict.Add(bundleName, new Dictionary<string, T>());
		}
		if (dict[bundleName].ContainsKey(assetName) && dict[bundleName][assetName] != null)
		{
			Debug.LogError("AssetCache AddToNestedDictionaries - " + $"Already tracking an {typeof(T)} entry for bundle {bundleName} asset {assetName}");
		}
		else
		{
			dict[bundleName].Add(assetName, entry);
		}
	}

	private void RemoveFromNestedDictionaries<T>(string bundleName, string assetName, Dictionary<string, Dictionary<string, T>> dict) where T : class
	{
		if (!dict.ContainsKey(bundleName))
		{
			Debug.LogError("AssetCache RemoveFromNestedDictionaries - " + $"Attempting to remove a non-existent {typeof(T)} entry for bundle {bundleName} asset {assetName}");
		}
		else if (!dict[bundleName].ContainsKey(assetName))
		{
			Debug.LogError("AssetCache RemoveFromNestedDictionaries - " + $"Attempting to remove a non-existent {typeof(T)} entry for bundle {bundleName} asset {assetName}");
		}
		else
		{
			dict[bundleName].Remove(assetName);
		}
	}

	public AssetCache(BundleCache bundleCacheAccess)
	{
		_assetLoaders = new Dictionary<string, Dictionary<string, IAssetLoader>>();
		_refDataByPath = new Dictionary<string, Dictionary<string, AssetRefData>>();
		_refDataByLoadedAsset = new Dictionary<object, AssetRefData>();
		_refDataByAssetInstance = new Dictionary<object, AssetRefData>();
		bundleCacheAccess.GetInterfaceAsync(BundleCacheReady);
	}

	private void BundleCacheReady(BundleCache bundleCache)
	{
		_bundleCache = bundleCache;
		TryToDispatchPublicInterface();
	}

	private void TryToDispatchPublicInterface()
	{
		dispatched = true;
		callbacks?.Invoke(this);
		callbacks = null;
	}

	public void Teardown()
	{
		DumpCache();
		_assetLoaders.Clear();
		_bundleCache = null;
	}
}
