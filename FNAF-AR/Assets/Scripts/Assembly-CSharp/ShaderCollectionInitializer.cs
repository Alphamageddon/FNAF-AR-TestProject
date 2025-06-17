using System;
using UnityEngine;

public class ShaderCollectionInitializer
{
	private readonly string _bundleName;

	private readonly string _shaderCollectionName;

	private AssetCache _assetCache;

	private ShaderVariantCollection _loadedShaderVariantCollection;

	private Action _onFinished;

	public bool ShadersReady { get; set; }

	public ShaderCollectionInitializer(AssetCache assetCache, string bundleName, string shaderCollectionName, bool forceLoad, Action onFinished)
	{
		ShadersReady = false;
		_bundleName = bundleName;
		_shaderCollectionName = shaderCollectionName;
		_assetCache = assetCache;
		_onFinished = onFinished;
		if (forceLoad)
		{
			LoadShaderCollection();
		}
		else
		{
			assetCache.BundleContainsAsset(bundleName, shaderCollectionName, ctor);
		}
	}

	public void Teardown()
	{
		if (_loadedShaderVariantCollection != null)
		{
			_assetCache.ReleaseAsset(_loadedShaderVariantCollection);
			_loadedShaderVariantCollection = null;
		}
		_onFinished = null;
		_assetCache = null;
	}

	private void LoadShaderCollection()
	{
		_assetCache.LoadAsset<ShaderVariantCollection>(_bundleName, _shaderCollectionName, LoadSuccess, LoadFailure);
	}

	private void LoadSuccess(ShaderVariantCollection shaderCollection)
	{
		_loadedShaderVariantCollection = shaderCollection;
		shaderCollection.WarmUp();
		ShadersReady = true;
		if (_onFinished != null)
		{
			_onFinished();
		}
		_onFinished = null;
	}

	private void LoadFailure()
	{
		Debug.LogError("ShaderCollectionInitializer LoadFailure - Cannot initialize shaders. Failed to load ShaderVariantCollection '" + _shaderCollectionName + "' from '" + _bundleName + "'");
		if (_onFinished != null)
		{
			_onFinished();
		}
		_onFinished = null;
	}

	private void NotifyFinished()
	{
		if (_onFinished != null)
		{
			_onFinished();
		}
		_onFinished = null;
	}

	private void ctor(bool containsAsset)
	{
		if (containsAsset)
		{
			LoadShaderCollection();
			return;
		}
		if (_onFinished != null)
		{
			_onFinished();
		}
		_onFinished = null;
	}
}
