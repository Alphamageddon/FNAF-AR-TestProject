using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class AssetBundleDownloader
{
	public Root DeserializedTOC;

	private ConstantVariables _constant;

	private LoadingManager loadingManager;

	private LoadingBarController loadingBarController;

	public AssetBundleDownloader(LoadingManager loading, ConstantVariables constant, LoadingBarController loadingBar)
	{
		_constant = constant;
		loadingManager = loading;
		loadingBarController = loadingBar;
	}

	public void DeserializeTOC(string jsonResponse)
	{
		DeserializedTOC = JsonConvert.DeserializeObject<Root>(jsonResponse);
		CoroutineHelper.StartCoroutine(BundleDownload());
	}

	public IEnumerator BundleDownload()
	{
		if (ProgressUpdaterDebug.text != null)
		{
			ProgressUpdaterDebug.text.text = "DOWNLOADING BUNDLES.";
		}
		int TOCLength = 0;
		foreach (Entry entry2 in DeserializedTOC.Entries)
		{
			if (entry2.DownloadOnStartup)
			{
				TOCLength++;
			}
		}
		foreach (Entry entry in DeserializedTOC.Entries)
		{
			while (!Caching.ready)
			{
				yield return null;
			}
			if (_constant.UseStreamingAssets)
			{
				if (entry.DownloadOnStartup)
				{
					Debug.Log("Telling GetBundle to get " + entry.BundleName);
					yield return GetBundle(entry.BundleName, 0);
				}
			}
			else if (entry.DownloadOnStartup)
			{
				Debug.Log("Telling GetBundle to get " + entry.BundleName);
				yield return GetBundle(entry.BundleName, int.Parse(entry.WindowsBundleVersion));
			}
			loadingBarController.AddSliderValue(TOCLength);
		}
		MasterDomain.GetDomain().eventExposer.add_VirtualGoodsDataReceived(Done);
		MasterDomain.GetDomain().ServerDomain.playerDataRequester.GetPlayerData(PlayerDataError);
		MasterDomain.GetDomain().ServerDomain.getOwnedGoodsRequester.GetOwnedGoods();
		if (ProgressUpdaterDebug.text != null)
		{
			ProgressUpdaterDebug.text.text = "";
		}
	}

	private void Done(List<StoreContainer.StorefrontData> data)
	{
		MasterDomain.GetDomain().eventExposer.remove_VirtualGoodsDataReceived(Done);
		MasterDomain.GetDomain().eventExposer.OnAllOrtonBundlesDownloaded();
		loadingBarController.Complete();
		loadingManager.LoadComplete();
	}

	private void PlayerDataError(ServerData response)
	{
		Debug.LogError("Couldnt get player data heres the error ig: " + response.JSON);
	}

	private IEnumerator GetBundle(string requestedBundle, int version)
	{
		string downloadURI = _constant.DownloadURI;
		string text;
		if (_constant.UseStreamingAssets)
		{
			Debug.Log("Using streaming assets");
			text = "file://" + Application.streamingAssetsPath + "/Bundles/Windows/" + version + "/" + requestedBundle;
		}
		else
		{
			Debug.Log("Not using streaming assets.");
			text = downloadURI + "/bundles/Windows/" + version + "/" + requestedBundle;
		}
		Debug.Log(text);
		yield return CoroutineHelper.StartCoroutine(AssetBundleManager.downloadAssetBundle(text, version, requestedBundle));
	}
}
