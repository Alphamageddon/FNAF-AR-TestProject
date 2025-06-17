using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class IconGroupData
{
	public string BundleName;

	private static readonly string ClassName;

	private AssetCache _assetCache;

	private Dictionary<string, Sprite> _spriteLookup;

	private Dictionary<string, SpriteAtlas> _spriteAtlasLookup;

	private Dictionary<string, List<Action<Sprite>>> _queuedSuccessCallbacks;

	private Dictionary<string, List<Action>> _queuedFailureCallbacks;

	public IconGroupData()
	{
		_spriteLookup = new Dictionary<string, Sprite>();
		_spriteAtlasLookup = new Dictionary<string, SpriteAtlas>();
		_queuedSuccessCallbacks = new Dictionary<string, List<Action<Sprite>>>();
		_queuedFailureCallbacks = new Dictionary<string, List<Action>>();
	}

	public void Teardown()
	{
		ReleaseAssets();
		_spriteLookup.Clear();
		_spriteLookup = null;
		_spriteAtlasLookup.Clear();
		_spriteAtlasLookup = null;
		_queuedSuccessCallbacks.Clear();
		_queuedSuccessCallbacks = null;
		_queuedFailureCallbacks.Clear();
		_queuedFailureCallbacks = null;
		_assetCache = null;
	}

	public void SetAssetCache(AssetCache assetCache)
	{
		_assetCache = assetCache;
	}

	public void GetIcon(string assetName, Action<Sprite> onSuccess, Action onFailure)
	{
		if (_spriteLookup.ContainsKey(assetName))
		{
			onSuccess?.Invoke(_spriteLookup[assetName]);
		}
		else if (_queuedSuccessCallbacks.ContainsKey(assetName))
		{
			AddCallbacksToLoadingAsset(assetName, onSuccess, onFailure);
		}
		else
		{
			LoadSpriteAsset(assetName, onSuccess, onFailure);
		}
	}

	public void GetIconFromAtlas(string assetName, string atlasName, Action<Sprite> onSuccess, Action onFailure)
	{
		if (_spriteLookup.ContainsKey(assetName))
		{
			Sprite sprite = _spriteLookup[assetName];
			if (sprite == null)
			{
				onFailure?.Invoke();
			}
			else
			{
				onSuccess?.Invoke(sprite);
			}
		}
		else if (_spriteAtlasLookup.ContainsKey(atlasName))
		{
			Sprite sprite = _spriteAtlasLookup[atlasName].GetSprite(assetName);
			if (sprite == null)
			{
				onFailure?.Invoke();
				return;
			}
			_spriteLookup.Add(assetName, sprite);
			onSuccess?.Invoke(sprite);
		}
		else if (_queuedSuccessCallbacks.ContainsKey(assetName))
		{
			AddCallbacksToLoadingAsset(assetName, onSuccess, onFailure);
		}
		else
		{
			LoadSpriteAtlasAsset(atlasName, assetName, onSuccess, onFailure);
		}
	}

	public void ReleaseAssets()
	{
		foreach (Sprite value in _spriteLookup.Values)
		{
			if (value != null)
			{
				_assetCache.ReleaseAsset(value);
			}
		}
		_spriteLookup.Clear();
		foreach (SpriteAtlas value2 in _spriteAtlasLookup.Values)
		{
			if (value2 != null)
			{
				_assetCache.ReleaseAsset(value2);
			}
		}
		_spriteAtlasLookup.Clear();
	}

	private void AddCallbacksToLoadingAsset(string assetName, Action<Sprite> onSuccess, Action onFailure)
	{
		_queuedSuccessCallbacks[assetName].Add(onSuccess);
		_queuedFailureCallbacks[assetName].Add(onFailure);
	}

	private void LoadSpriteAsset(string assetName, Action<Sprite> onSuccess, Action onFailure)
	{
		_queuedSuccessCallbacks.Add(assetName, new List<Action<Sprite>>());
		_queuedFailureCallbacks.Add(assetName, new List<Action>());
		AddCallbacksToLoadingAsset(assetName, onSuccess, onFailure);
		_assetCache.LoadAsset(BundleName, assetName, delegate(Sprite sprite)
		{
			SpriteLoadSuccess(assetName, sprite);
		}, delegate
		{
			AssetLoadFailure(assetName);
		});
	}

	private void LoadSpriteAtlasAsset(string atlasName, string assetName, Action<Sprite> onSuccess, Action onFailure)
	{
		_queuedSuccessCallbacks.Add(assetName, new List<Action<Sprite>>());
		_queuedFailureCallbacks.Add(assetName, new List<Action>());
		AddCallbacksToLoadingAsset(assetName, onSuccess, onFailure);
		_assetCache.LoadAsset(BundleName, atlasName, delegate(SpriteAtlas sprite)
		{
			SpriteAtlasLoadSuccess(atlasName, assetName, sprite);
		}, delegate
		{
			AssetLoadFailure(assetName);
		});
	}

	public void SpriteLoadSuccess(string assetName, Sprite sprite)
	{
		if (sprite == null)
		{
			Debug.LogError("IconGroupData SpriteAtlasLoadSuccess - Invalid 'sprite' for '" + assetName + "'!");
			UpdateObserversAssetFailure(assetName);
		}
		else
		{
			_spriteLookup.Add(assetName, sprite);
			UpdateObserversAssetSuccess(assetName, sprite);
		}
	}

	public void SpriteAtlasLoadSuccess(string atlasName, string spriteAssetName, SpriteAtlas spriteAtlas)
	{
		string text;
		if (spriteAtlas == null)
		{
			text = "Invalid 'spriteAtlas' for '" + atlasName + ":" + spriteAssetName + "'!";
			Debug.LogError("IconGroupData SpriteAtlasLoadSuccess - " + text);
			UpdateObserversAssetFailure(spriteAssetName);
			return;
		}
		if (!_spriteAtlasLookup.ContainsKey(atlasName))
		{
			_spriteAtlasLookup.Add(atlasName, spriteAtlas);
		}
		Sprite sprite = spriteAtlas.GetSprite(spriteAssetName);
		if (sprite != null)
		{
			_spriteLookup.Add(spriteAssetName, sprite);
			UpdateObserversAssetSuccess(spriteAssetName, sprite);
			return;
		}
		text = "SpriteAtlas '" + spriteAtlas.name + "' does not contain Sprite '" + spriteAssetName + "'";
		Debug.LogError("IconGroupData SpriteAtlasLoadSuccess - " + text);
		UpdateObserversAssetFailure(spriteAssetName);
	}

	public void AssetLoadFailure(string assetName)
	{
		UpdateObserversAssetFailure(assetName);
	}

	private void UpdateObserversAssetSuccess(string assetName, Sprite sprite)
	{
		if (_queuedSuccessCallbacks == null)
		{
			ClearCallbacks(assetName);
			return;
		}
		foreach (Action<Sprite> item in _queuedSuccessCallbacks[assetName])
		{
			item(sprite);
		}
		ClearCallbacks(assetName);
	}

	private void UpdateObserversAssetFailure(string assetName)
	{
		if (_queuedFailureCallbacks == null)
		{
			ClearCallbacks(assetName);
			return;
		}
		foreach (Action item in _queuedFailureCallbacks[assetName])
		{
			item();
		}
		ClearCallbacks(assetName);
	}

	private void ClearCallbacks(string assetName)
	{
		_queuedSuccessCallbacks[assetName].Clear();
		_queuedSuccessCallbacks.Remove(assetName);
		_queuedFailureCallbacks[assetName].Clear();
		_queuedFailureCallbacks.Remove(assetName);
	}
}
