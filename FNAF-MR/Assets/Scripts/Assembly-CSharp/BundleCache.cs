using System;
using UnityEngine;

public class BundleCache
{
	private Action<BundleCache> ortonBundlesDownloadedCallback;

	private bool allOrtonBundlesDownloaded;

	private BundleLoader _bundleLoader;

	public void LoadAssetBundleAsync(string bundleName, BundleLoadSuccess onSuccess, BundleLoadFailure onFailure)
	{
		_bundleLoader.LoadBundle(bundleName, onSuccess, onFailure);
	}

	public void ReleaseAssetBundleReference(string bundleName)
	{
		Debug.LogError("ORTON!!! BUNDLE " + bundleName + " IS BEING UNLOADED!!");
		_bundleLoader.UnloadBundle(bundleName);
	}

	public void AllOrtonBundlesDownloaded()
	{
		allOrtonBundlesDownloaded = true;
		ortonBundlesDownloadedCallback?.Invoke(this);
		ClearCallbacks();
	}

	private void ClearCallbacks()
	{
		ortonBundlesDownloadedCallback = null;
	}

	public void GetInterfaceAsync(Action<BundleCache> callback)
	{
		if (allOrtonBundlesDownloaded)
		{
			callback?.Invoke(this);
		}
		else
		{
			ortonBundlesDownloadedCallback = (Action<BundleCache>)Delegate.Combine(ortonBundlesDownloadedCallback, callback);
		}
	}

	public BundleCache()
	{
		GameObject gameObject = new GameObject
		{
			name = "BundleLoader"
		};
		_bundleLoader = gameObject.AddComponent<BundleLoader>();
		gameObject.AddComponent<DontDestroy>();
	}
}
