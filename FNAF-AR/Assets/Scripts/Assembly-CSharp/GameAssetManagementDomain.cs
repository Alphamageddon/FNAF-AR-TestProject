using System;
using System.Collections.Generic;
using UnityEngine;

public class GameAssetManagementDomain
{
	public const string PreWarmAssetName = "PreWarmOnLoad";

	private EventExposer _masterEventExposer;

	private BundleCache _bundleCache;

	private AssetCache _assetCacheAccess;

	private IconLookup _iconLookup;

	private Action _onDownloadServerTableOfContents;

	private bool _inStreamingAssetsMode;

	private bool _loadStarted;

	private bool _fullyLoaded;

	private bool _modelViewer;

	private Dictionary<string, List<GenericCreationRequest>> _pendingCreationRequests;

	private Dictionary<string, List<SubEntityCreationRequest>> _pendingSubEntityCreationRequests;

	public AssetCache AssetCacheAccess => _assetCacheAccess;

	public IconLookup IconLookupAccess => _iconLookup;

	public bool FullyLoaded => _fullyLoaded;

	public bool InStreamingAssetsMode => _inStreamingAssetsMode;

	public GameAssetManagementDomain(EventExposer masterEventExposer, MasterDataDomain masterDataDomain)
	{
		_masterEventExposer = masterEventExposer;
		_bundleCache = new BundleCache();
		_assetCacheAccess = new AssetCache(_bundleCache);
		_iconLookup = new IconLookup(masterEventExposer, masterDataDomain, AssetCacheAccess);
		Application.lowMemory += OnLowMemoryWarning;
		_masterEventExposer.add_AllOrtonBundlesDownloaded(AllOrtonBundlesDownloaded);
		_pendingCreationRequests = new Dictionary<string, List<GenericCreationRequest>>();
		_pendingSubEntityCreationRequests = new Dictionary<string, List<SubEntityCreationRequest>>();
	}

	private void AllOrtonBundlesDownloaded()
	{
		_bundleCache.AllOrtonBundlesDownloaded();
		_masterEventExposer.remove_AllOrtonBundlesDownloaded(AllOrtonBundlesDownloaded);
	}

	public void Teardown()
	{
		Application.lowMemory -= OnLowMemoryWarning;
		_iconLookup.Teardown();
		_iconLookup = null;
		_masterEventExposer = null;
		_pendingCreationRequests.Clear();
		_pendingCreationRequests = null;
		_pendingSubEntityCreationRequests.Clear();
		_pendingSubEntityCreationRequests = null;
	}

	public void Update()
	{
	}

	public void SetupForStreamingAssetsOnly()
	{
		if (!_loadStarted && !_fullyLoaded)
		{
			_inStreamingAssetsMode = true;
			_loadStarted = true;
			_fullyLoaded = false;
		}
	}

	public void SetupForAssetsOnDemand()
	{
		_ = _inStreamingAssetsMode;
		_inStreamingAssetsMode = true;
		_loadStarted = true;
		_fullyLoaded = false;
	}

	public void DownloadBundleSet(HashSet<string> bundleSet, Action onComplete)
	{
	}

	private void EpisodicConfigReceived(string episodicBundlerUri)
	{
		TryToDownloadEpisodicServerTableOfContents();
	}

	private void TableOfContentsDownloadFailure(int failureCount)
	{
		if (failureCount >= 5)
		{
			Debug.LogError("GameAssetManagementDomain TableOfContentsDownloadFailure - Failed to download the server table of contents at least 5 times");
		}
	}

	private void StreamingAssetsGameplayAssetsReady(int failedAssetCount)
	{
		if (failedAssetCount >= 1)
		{
			Debug.LogError("GameAssetManagementDomain StreamingAssetsGameplayAssetsReady - Failed to load at least 1 streaming assets bundle");
		}
	}

	private void AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)
	{
		if (failedAssetCount >= 1)
		{
			Debug.LogError("GameAssetManagementDomain AssetBundleDownloadSegmentsAllComplete - Failed to download at least 1 asset bundle");
		}
	}

	private void StreamingAssetsBundleLoadComplete(int failedAssetCount)
	{
		if (_inStreamingAssetsMode)
		{
			_loadStarted = true;
			_fullyLoaded = true;
		}
	}

	private void DownloadAllServerTableOfContents()
	{
		TryToDownloadServerTableOfContents();
		TryToDownloadEpisodicServerTableOfContents();
	}

	private void TryToDownloadServerTableOfContents()
	{
		if (!_inStreamingAssetsMode)
		{
			_ = _loadStarted;
		}
	}

	private void TryToDownloadEpisodicServerTableOfContents()
	{
	}

	public void DownloadServerTableOfContents(Action onComplete)
	{
	}

	public bool CanDownloadServerTableOfContents()
	{
		return false;
	}

	private void OnDownloadServerTableOfContents(string message)
	{
	}

	private void OnDownloadEpisodicServerTableOfContents(string message)
	{
	}

	private void OnLowMemoryWarning()
	{
		Resources.UnloadUnusedAssets();
	}

	public void ReleaseGenericSpawn(GameObject spawnedObject)
	{
		_assetCacheAccess.ReleaseInstance(spawnedObject);
	}

	public void CreateSafeObject(GenericCreationRequest request)
	{
		if (!_pendingCreationRequests.ContainsKey(request.Bundle + "_" + request.Asset))
		{
			_pendingCreationRequests.Add(request.Bundle + "_" + request.Asset, new List<GenericCreationRequest>());
		}
		_pendingCreationRequests[request.Bundle + "_" + request.Asset].Add(request);
		request.add_OnRequestComplete(CreationRequestComplete);
		Debug.Log("Instantiating Generic Object " + request.Asset + " from Bundle: " + request.Bundle);
		_assetCacheAccess.Instantiate(request.Bundle, request.Asset, delegate(GameObject prefab)
		{
			OnObjectInstantiated(prefab, request);
		}, delegate
		{
			ObjectLoadFailure(request);
		});
	}

	public void CreateSubEntity(SubEntityCreationRequest request)
	{
		if (!_pendingSubEntityCreationRequests.ContainsKey(request.Bundle + "_" + request.Asset))
		{
			_pendingSubEntityCreationRequests.Add(request.Bundle + "_" + request.Asset, new List<SubEntityCreationRequest>());
		}
		_pendingSubEntityCreationRequests[request.Bundle + "_" + request.Asset].Add(request);
		request.add_OnRequestComplete(SubEntityCreationRequestComplete);
		Debug.Log("Instantiating Sub Entity Object " + request.Asset + " from Bundle: " + request.Bundle);
		_assetCacheAccess.Instantiate(request.Bundle, request.Asset, delegate(GameObject prefab)
		{
			OnSubEntityInstantiated(prefab, request);
		}, delegate
		{
			SubEntityLoadFailure(request);
		});
	}

	private void OnObjectInstantiated(GameObject gameObject, GenericCreationRequest request)
	{
		if (_pendingCreationRequests.ContainsKey(request.Bundle + "_" + request.Asset))
		{
			request.SetObjectCreationSuccess(gameObject);
		}
	}

	private void ObjectLoadFailure(GenericCreationRequest request)
	{
		if (!_pendingCreationRequests.ContainsKey(request.Bundle + "_" + request.Asset))
		{
			Debug.LogError("Received a PrefabLoadFailure callback for an object '" + request.Bundle + "_" + request.Asset + "' with no associated GenericCreationRequest");
			request.SetObjectCreationFailure();
		}
		else
		{
			_pendingCreationRequests[request.Bundle + "_" + request.Asset].Remove(request);
		}
	}

	private void CreationRequestComplete(GenericCreationRequest request)
	{
		Debug.Log("Generic creation request complete actually worked somehow");
		request.remove_OnRequestComplete(CreationRequestComplete);
		_pendingCreationRequests[request.Bundle + "_" + request.Asset].Remove(request);
	}

	private void OnSubEntityInstantiated(GameObject gameObject, SubEntityCreationRequest request)
	{
		if (_pendingSubEntityCreationRequests.ContainsKey(request.Bundle + "_" + request.Asset))
		{
			request.SetObjectCreationSuccess(gameObject);
		}
	}

	private void SubEntityLoadFailure(SubEntityCreationRequest request)
	{
		if (!_pendingSubEntityCreationRequests.ContainsKey(request.Bundle + "_" + request.Asset))
		{
			Debug.LogError("Received a PrefabLoadFailure callback for an object '" + request.Bundle + "_" + request.Asset + "' with no associated SubEntityCreationRequest");
			request.SetObjectCreationFailure();
		}
		else
		{
			_pendingSubEntityCreationRequests[request.Bundle + "_" + request.Asset].Remove(request);
		}
	}

	private void SubEntityCreationRequestComplete(SubEntityCreationRequest request)
	{
		Debug.Log("Sub Entity creation request complete actually worked somehow");
		request.remove_OnRequestComplete(SubEntityCreationRequestComplete);
		_pendingSubEntityCreationRequests[request.Bundle + "_" + request.Asset].Remove(request);
	}
}
