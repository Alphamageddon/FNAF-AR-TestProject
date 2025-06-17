using System;
using UnityEngine;

public class AssetLoader<T> : IAssetLoader where T : class
{
	private string _bundleName;

	private string _assetName;

	private string _assetPath;

	private Action<T> _successCallbacks;

	private Action _failureCallbacks;

	private Action<IAssetLoader, T> _completeCallback;

	private int _numRequests;

	public void Load(BundleCache bundleCache, string bundleName, string assetName)
	{
		_assetName = assetName;
		_bundleName = bundleName;
		bundleCache.LoadAssetBundleAsync(bundleName, BundleLoadSuccess, BundleLoadFailure);
	}

	public string GetBundleName()
	{
		return _bundleName;
	}

	public string GetAssetName()
	{
		return _assetName;
	}

	public int GetNumRequests()
	{
		return _numRequests;
	}

	public void AddRequest(Action<T> onSuccess, Action onFailure)
	{
		_successCallbacks = (Action<T>)Delegate.Combine(_successCallbacks, onSuccess);
		_failureCallbacks = (Action)Delegate.Combine(_failureCallbacks, onFailure);
		_numRequests++;
	}

	private void BundleLoadSuccess(CachedAssetBundle info, AssetBundle bundle)
	{
		bundle.LoadAssetAsync(_assetName, typeof(T)).completed += AssetLoadFromBundleComplete;
	}

	private void BundleLoadFailure(CachedAssetBundle info)
	{
		_failureCallbacks?.Invoke();
	}

	private void AssetLoadFromBundleComplete(AsyncOperation request)
	{
		UnityEngine.Object obj = null;
		if (request != null)
		{
			obj = ((AssetBundleRequest)request).asset;
		}
		if (obj == null)
		{
			AssetLoadFailure();
		}
		else
		{
			AssetLoadSuccess((T)Convert.ChangeType(obj, typeof(T)));
		}
	}

	private void AssetLoadSuccess(T asset)
	{
		_completeCallback?.Invoke(this, asset);
		_successCallbacks?.Invoke(asset);
		ClearCallbacks();
	}

	private void AssetLoadFailure()
	{
		_failureCallbacks?.Invoke();
		ClearCallbacks();
	}

	public AssetLoader(Action<T> onSuccess, Action onFailure, Action<IAssetLoader, T> onComplete)
	{
		_successCallbacks = (Action<T>)Delegate.Combine(_successCallbacks, onSuccess);
		_failureCallbacks = (Action)Delegate.Combine(_failureCallbacks, onFailure);
		_completeCallback = (Action<IAssetLoader, T>)Delegate.Combine(_completeCallback, onComplete);
		_numRequests = 1;
	}

	private void ClearCallbacks()
	{
		_successCallbacks = null;
		_failureCallbacks = null;
		_completeCallback = null;
		_numRequests = 0;
	}
}
