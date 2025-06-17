using System.Collections;
using UnityEngine;

public class BundleLoader : MonoBehaviour
{
	public void LoadBundle(string name, BundleLoadSuccess onSuccess, BundleLoadFailure onFailure)
	{
		ConstantVariables instance = ConstantVariables.Instance;
		string downloadURI = instance.DownloadURI;
		int num = 0;
		Entry entry = null;
		foreach (Entry entry2 in instance.AssetBundleDownloader.DeserializedTOC.Entries)
		{
			if (entry2.BundleName == name)
			{
				entry = entry2;
				break;
			}
		}
		string text;
		if (instance.UseStreamingAssets)
		{
			Debug.Log("Using streaming assets");
			text = "file://" + Application.streamingAssetsPath + "/Bundles/Windows/0/" + name;
		}
		else
		{
			num = int.Parse(entry.WindowsBundleVersion);
			text = downloadURI + "/bundles/Windows/" + num + "/" + name;
		}
		Debug.Log(text);
		AssetBundle assetBundle = AssetBundleManager.getAssetBundle(text, (!instance.UseStreamingAssets) ? num : 0);
		if (!assetBundle)
		{
			StartCoroutine(DownloadAB(name, text, (!instance.UseStreamingAssets) ? num : 0, name, onSuccess, onFailure));
			Debug.Log("starting coroutine");
		}
		else
		{
			onSuccess?.Invoke(new CachedAssetBundle(name, new Hash128(0u, 0u, 0u, (!instance.UseStreamingAssets) ? ((uint)num) : 0u)), assetBundle);
		}
	}

	public void UnloadBundle(string bundleName)
	{
		Debug.LogError("Requested unload of bundle " + bundleName);
		ConstantVariables instance = ConstantVariables.Instance;
		string downloadURI = instance.DownloadURI;
		int num = 0;
		Entry entry = null;
		foreach (Entry entry2 in instance.AssetBundleDownloader.DeserializedTOC.Entries)
		{
			if (entry2.BundleName == bundleName)
			{
				entry = entry2;
				break;
			}
		}
		if (entry == null)
		{
			Debug.LogError("Couldn't find bundle " + bundleName + " in DeserializedTOC.");
		}
		string url;
		if (instance.UseStreamingAssets)
		{
			Debug.Log("Using streaming assets");
			url = "file://" + Application.streamingAssetsPath + "/Bundles/Windows/0/" + bundleName;
		}
		else
		{
			num = int.Parse(entry.WindowsBundleVersion);
			url = downloadURI + "/bundles/Windows/" + num + "/" + bundleName;
		}
		AssetBundleManager.Unload(url, (!instance.UseStreamingAssets) ? num : 0, allObjects: false);
	}

	private IEnumerator DownloadAB(string name, string activeURL, int version, string bundleName, BundleLoadSuccess onSuccess, BundleLoadFailure onFailure)
	{
		yield return StartCoroutine(AssetBundleManager.downloadAssetBundle(activeURL, version, bundleName));
		AssetBundle assetBundle = AssetBundleManager.getAssetBundle(activeURL, version);
		if (!assetBundle)
		{
			onFailure?.Invoke(new CachedAssetBundle("null", default(Hash128)));
		}
		else
		{
			onSuccess?.Invoke(new CachedAssetBundle(name, default(Hash128)), assetBundle);
		}
	}
}
