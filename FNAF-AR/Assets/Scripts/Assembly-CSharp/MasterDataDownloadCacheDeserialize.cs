using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;

public class MasterDataDownloadCacheDeserialize
{
	public class MasterDataDownloadInfo
	{
		public Type MasterDataType;

		public Type DeserializeType;

		public MasterDataDownloadInfo(Type type, Type deserialize)
		{
			MasterDataType = type;
			DeserializeType = deserialize;
		}
	}

	private ConstantVariables _constant;

	private LoadingManager _loadingManager;

	private string _downloadURI;

	private Action OnMasterDataDeserialized;

	public bool IsDeserialized;

	public Dictionary<MasterDataDownloadInfo, object> masterDataSections = new Dictionary<MasterDataDownloadInfo, object>
	{
		{
			new MasterDataDownloadInfo(typeof(ATTACK_DATA), typeof(ATTACK_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(PLUSHSUIT_DATA), typeof(PLUSHSUIT_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(CPU_DATA), typeof(CPU_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(STATIC_DATA), typeof(STATIC_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(CONFIG_DATA), typeof(CONFIG_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(LOC_DATA), typeof(LOC_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(AUDIO_DATA), typeof(AUDIO_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(LOOT_STRUCTURE_DATA), typeof(LOOT_STRUCTURE_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(LOOT_PACKAGE_DATA), typeof(LOOT_PACKAGE_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(LOOT_TABLE_DATA), typeof(LOOT_TABLE_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(LOOT_ITEM_DATA), typeof(LOOT_ITEM_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(CRATE_INFO_DATA), typeof(CRATE_INFO_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(STORE_DATA), typeof(STORE_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(STORESECTIONS_DATA), typeof(STORESECTIONS_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(TROPHY_DATA), typeof(TROPHY_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(PROFILE_AVATAR_DATA), typeof(PROFILE_AVATAR_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(MODS_DATA), typeof(MODS_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(MODCATEGORIES_DATA), typeof(MODCATEGORIES_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(SUB_ENTITY_DATA), typeof(SUB_ENTITY_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(SCAVENGING_ATTACK_DATA), typeof(SCAVENGING_ATTACK_DATA.Root)),
			null
		},
		{
			new MasterDataDownloadInfo(typeof(SCAVENGING_DATA), typeof(SCAVENGING_DATA.Root)),
			null
		}
	};

	private Dictionary<MasterDataDownloadInfo, bool> downloadedSections = new Dictionary<MasterDataDownloadInfo, bool>();

	public object GetMasterDataDeserialized(Type type)
	{
		foreach (MasterDataDownloadInfo key in masterDataSections.Keys)
		{
			if (key.MasterDataType == type)
			{
				return masterDataSections[key];
			}
		}
		return null;
	}

	public MasterDataDownloadCacheDeserialize(LoadingManager loading, ConstantVariables constant)
	{
		_constant = constant;
		_loadingManager = loading;
	}

	public void add_OnMasterDataDeserialized(Action value)
	{
		OnMasterDataDeserialized = (Action)Delegate.Combine(OnMasterDataDeserialized, value);
	}

	public void remove_OnMasterDataDeserialized(Action value)
	{
		OnMasterDataDeserialized = (Action)Delegate.Remove(OnMasterDataDeserialized, value);
	}

	private void ClearCurrentMasterData()
	{
		foreach (MasterDataDownloadInfo item in new List<MasterDataDownloadInfo>(masterDataSections.Keys))
		{
			ClearMasterDataSection(item);
		}
		Debug.Log("Cleared masterdata. This should be done before the /'Okay! I got it!/' Debug Log.");
	}

	private void ClearMasterDataSection(MasterDataDownloadInfo info)
	{
		PlayerPrefs.SetString(info.MasterDataType.ToString(), null);
		PlayerPrefs.Save();
	}

	public void DownloadNewMasterData(int playfabversion, string uri)
	{
		ClearCurrentMasterData();
		_downloadURI = uri;
		Debug.Log("Okay! I got it! I'll download!");
		List<MasterDataDownloadInfo> list = new List<MasterDataDownloadInfo>(masterDataSections.Keys);
		foreach (MasterDataDownloadInfo item in list)
		{
			downloadedSections.Add(item, value: false);
			masterDataSections[item] = null;
		}
		foreach (MasterDataDownloadInfo item2 in list)
		{
			CoroutineHelper.StartCoroutine(DownloadMasterDataSection(item2, playfabversion));
		}
	}

	private void SectionComplete(int masterdata)
	{
		foreach (MasterDataDownloadInfo key in masterDataSections.Keys)
		{
			if (!downloadedSections[key])
			{
				return;
			}
		}
		Debug.Log("All sections downloaded.");
		if (!_loadingManager.IsPLISTDataNull())
		{
			_constant.ActiveMasterDataVersion = masterdata;
			Debug.Log("Set ActiveMasterDataVersion.");
			PlayerPrefs.SetInt("MasterDataVersion", masterdata);
			PlayerPrefs.Save();
			Debug.Log("MasterData is installed boss.");
			DeserializeMasterData();
		}
		else
		{
			Debug.LogError("Masterdata section didnt download. error. error. error.");
			MasterDomain.GetDomain().ServerDomain.networkAvailabilityChecker.UpdatedConnection(connection: false);
		}
	}

	private IEnumerator DownloadMasterDataSection(MasterDataDownloadInfo downloadInfo, int masterdata)
	{
		Type type = downloadInfo.MasterDataType;
		yield return new WaitForSeconds(1f);
		if (ProgressUpdaterDebug.text != null)
		{
			ProgressUpdaterDebug.text.text = "DOWNLOADING " + type.ToString();
		}
		string text = masterdata.ToString();
		string masterdataURI = ((!_constant.UseStreamingAssets) ? (_downloadURI + "/masterdata/" + text + "/" + type.ToString()) : ("file://" + Application.streamingAssetsPath + "/MasterData/0/" + type.ToString()));
		using UnityWebRequest request = UnityWebRequest.Get(masterdataURI);
		yield return request.SendWebRequest();
		Debug.Log(masterdataURI);
		if (request.result == UnityWebRequest.Result.ProtocolError || request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.DataProcessingError)
		{
			Debug.LogError(request.error);
			MasterDomain.GetDomain().ServerDomain.networkAvailabilityChecker.UpdatedConnection(connection: false);
		}
		else
		{
			Debug.Log(type.ToString() + " Downloaded.");
			if (type.ToString() == "PLUSHSUIT_DATA")
			{
				Debug.Log(request.downloadHandler.text);
			}
			PlayerPrefs.SetString(type.ToString(), request.downloadHandler.text);
			PlayerPrefs.Save();
			Debug.Log("PLIST " + type.ToString() + " SET!");
			downloadedSections[downloadInfo] = true;
			SectionComplete(masterdata);
		}
		yield return null;
	}

	public void DeserializeMasterData()
	{
		foreach (MasterDataDownloadInfo item in new List<MasterDataDownloadInfo>(masterDataSections.Keys))
		{
			string value = PlayerPrefs.GetString(item.MasterDataType.ToString());
			Type deserializeType = item.DeserializeType;
			masterDataSections[item] = JsonConvert.DeserializeObject(value, deserializeType);
			Debug.Log("IS MASTER DATA SECTION DESERIALIZED PROPERLY? - " + (masterDataSections[item] != null));
		}
		if (_constant.UseStreamingAssets)
		{
			CoroutineHelper.StartCoroutine(GetStreamingAssetsTOC());
		}
		else
		{
			_loadingManager.LoadStage2("");
		}
		InvokeMasterDataDeserialized();
	}

	private IEnumerator GetStreamingAssetsTOC()
	{
		string streamingAssetFilePath = GetStreamingAssetFilePath("TOC/TOC.json");
		UnityWebRequest request = UnityWebRequest.Get(streamingAssetFilePath);
		yield return request.SendWebRequest();
		if (request.result != UnityWebRequest.Result.Success)
		{
			Debug.Log("Could not get StreamingAssets TOC. Should be fine, unless UseStreamingAssets is true in ConstantVariables.");
			_loadingManager.LoadStage2("");
		}
		else
		{
			string text = request.downloadHandler.text;
			_loadingManager.LoadStage2(text);
		}
	}

	private string GetStreamingAssetFilePath(string fileName)
	{
		return "file://" + Application.streamingAssetsPath + "/" + fileName;
	}

	public void InvokeMasterDataDeserialized()
	{
		OnMasterDataDeserialized?.Invoke();
		IsDeserialized = true;
	}
}
