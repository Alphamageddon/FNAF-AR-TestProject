using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public static class AssetBundleManager
{
	private class AssetBundleRef
	{
		public AssetBundle assetBundle;

		public int version;

		public string url;

		public AssetBundleRef(string strUrlIn, int intVersionIn)
		{
			url = strUrlIn;
			version = intVersionIn;
		}
	}

	private static Dictionary<string, AssetBundleRef> dictAssetBundleRefs;

	static AssetBundleManager()
	{
		dictAssetBundleRefs = new Dictionary<string, AssetBundleRef>();
	}

	public static AssetBundle getAssetBundle(string url, int version)
	{
		string key = url + version;
		if (dictAssetBundleRefs.TryGetValue(key, out var value))
		{
			return value.assetBundle;
		}
		return null;
	}

	public static IEnumerator downloadAssetBundle(string url, int version, string bundleName)
	{
		Debug.Log("recieved download request " + url + " " + version);
		string keyName = url + version;
		if (dictAssetBundleRefs.ContainsKey(keyName))
		{
			Debug.Log("dict contains key " + keyName);
			yield return null;
			yield break;
		}
		if (ConstantVariables.Instance.UseStreamingAssets)
		{
			UnityWebRequest request = UnityWebRequestAssetBundle.GetAssetBundle(url);
			Debug.Log("made request for " + url);
			yield return request.SendWebRequest();
			Debug.Log(url + " is done!");
			if (request.result != UnityWebRequest.Result.Success)
			{
				Debug.LogError("WWW download:" + request.error + ": " + url);
			}
			else
			{
				AssetBundleRef assetBundleRef = new AssetBundleRef(url, version);
				assetBundleRef.assetBundle = DownloadHandlerAssetBundle.GetContent(request);
				Debug.Log(assetBundleRef.assetBundle.name);
				dictAssetBundleRefs.Add(keyName, assetBundleRef);
			}
		}
		else
		{
			while (!Caching.ready)
			{
				yield return null;
			}
			Caching.ClearOtherCachedVersions(bundleName, new Hash128(0u, 0u, 0u, (uint)version));
			using UnityWebRequest request2 = UnityWebRequestAssetBundle.GetAssetBundle(url, new CachedAssetBundle(bundleName, new Hash128(0u, 0u, 0u, (uint)version)));
			request2.SendWebRequest();
			Debug.Log("made request for " + url);
			while (!request2.isDone)
			{
				yield return null;
			}
			Debug.Log(url + " is done!");
			if (!request2.isNetworkError)
			{
				AssetBundleRef assetBundleRef2 = new AssetBundleRef(url, version);
				assetBundleRef2.assetBundle = DownloadHandlerAssetBundle.GetContent(request2);
				Debug.Log(assetBundleRef2.assetBundle.name);
				dictAssetBundleRefs.Add(keyName, assetBundleRef2);
			}
			else
			{
				Debug.LogError("WWW download:" + request2.error);
			}
		}
		yield return null;
	}

	public static void Unload(string url, int version, bool allObjects)
	{
		string key = url + version;
		if (dictAssetBundleRefs.TryGetValue(key, out var value))
		{
			value.assetBundle.Unload(allObjects);
			value.assetBundle = null;
			dictAssetBundleRefs.Remove(key);
		}
	}
}
