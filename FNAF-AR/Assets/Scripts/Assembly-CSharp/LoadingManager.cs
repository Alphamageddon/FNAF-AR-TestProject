using PlayFab;
using PlayFab.ClientModels;
using TMPro;
using UnityEngine;

public class LoadingManager : MonoBehaviour
{
	private MasterDataDownloadCacheDeserialize masterdatadownloader;

	private AssetBundleDownloader _assetBundleDownloader;

	private ConstantVariables constantVariables;

	[HideInInspector]
	public int PlayFabMasterdataVersion;

	[HideInInspector]
	public string PlayFabDownloadURI = "";

	[HideInInspector]
	public string PlayFabTOC = "";

	[Header("Editor Hookups")]
	public GameObject betaClosed;

	public TextMeshProUGUI playerID;

	[SerializeField]
	private Animator loadingAnimator;

	private const int BETA_VERSION = 18;

	private void Start()
	{
		constantVariables = ConstantVariables.Instance;
		masterdatadownloader = constantVariables.MasterDataDownloader;
		_assetBundleDownloader = constantVariables.AssetBundleDownloader;
	}

	public void Login()
	{
		string text = "";
		if (!PlayerPrefs.HasKey("ForsakenMR_DeviceID"))
		{
			PlayerPrefs.SetString("ForsakenMR_DeviceID", SystemInfo.deviceUniqueIdentifier);
			PlayerPrefs.Save();
			text = SystemInfo.deviceUniqueIdentifier;
		}
		else
		{
			text = PlayerPrefs.GetString("ForsakenMR_DeviceID");
		}
		PlayFabClientAPI.LoginWithCustomID(new LoginWithCustomIDRequest
		{
			CustomId = text,
			CreateAccount = true
		}, OnSuccess, OnError);
	}

	private void OnSuccess(LoginResult result)
	{
		ServerDomain.AuthContext = result.AuthenticationContext;
		ServerDomain.IllumixAuthContext = new IllumixAuthenticationContext(result.AuthenticationContext);
		Debug.Log("Successfully Logged In To PlayFab!");
		Debug.Log(result.PlayFabId);
		playerID.text = "PlayerID: " + result.PlayFabId;
		playerID.gameObject.SetActive(value: true);
		GetTitleData();
	}

	private void OnError(PlayFabError error)
	{
		Debug.LogError("PlayFab Error.");
		Debug.LogError(error.GenerateErrorReport());
		MasterDomain.GetDomain().ServerDomain.networkAvailabilityChecker.UpdatedConnection(connection: false);
	}

	private void GetTitleData()
	{
		PlayFabClientAPI.GetTitleData(new GetTitleDataRequest(), OnTitleDataReceived, OnError);
	}

	private void OnTitleDataReceived(GetTitleDataResult result)
	{
		if (int.Parse(result.Data["PrivateBetaOpen"]) != 18)
		{
			if (betaClosed != null)
			{
				betaClosed.SetActive(value: true);
			}
			return;
		}
		PlayFabMasterdataVersion = int.Parse(result.Data["MasterDataVersion"]);
		PlayFabTOC = result.Data["TOC"];
		PlayFabDownloadURI = result.Data["DownloadURI"];
		Debug.Log("PlayFabMasterDataVersion = " + PlayFabMasterdataVersion);
		Debug.Log("PlayFabDownloadURI = " + PlayFabDownloadURI);
		constantVariables.DownloadURI = PlayFabDownloadURI;
		LoadStage1();
	}

	public void LoadStage1()
	{
		if (constantVariables.UseStreamingAssets)
		{
			Debug.Log("StreamingAssets active, Asked for new masterdata!");
			masterdatadownloader.DownloadNewMasterData(PlayFabMasterdataVersion, constantVariables.DownloadURI);
		}
		else if (constantVariables.ActiveMasterDataVersion != PlayFabMasterdataVersion)
		{
			Debug.Log("Saved masterdata version doesn't match server, Asked for new masterdata!");
			masterdatadownloader.DownloadNewMasterData(PlayFabMasterdataVersion, constantVariables.DownloadURI);
		}
		else if (IsPLISTDataNull())
		{
			Debug.Log("Error with saved masterdata, Asked for new masterdata!");
			masterdatadownloader.DownloadNewMasterData(PlayFabMasterdataVersion, constantVariables.DownloadURI);
		}
		else
		{
			masterdatadownloader.DeserializeMasterData();
		}
	}

	public bool IsPLISTDataNull()
	{
		foreach (MasterDataDownloadCacheDeserialize.MasterDataDownloadInfo key in masterdatadownloader.masterDataSections.Keys)
		{
			if (!PlayerPrefs.HasKey(key.MasterDataType.ToString()))
			{
				Debug.LogError("Missing Masterdata Key " + key.MasterDataType.ToString());
				return true;
			}
			if (string.IsNullOrEmpty(PlayerPrefs.GetString(key.MasterDataType.ToString())))
			{
				Debug.LogError("Missing Masterdata String " + key.MasterDataType.ToString());
				return true;
			}
		}
		return false;
	}

	public void LoadStage2(string streamingAssetsTOC)
	{
		Debug.Log("Load thinks masterdata is deserialized!");
		PlayerPrefs.SetString("TOC", PlayFabTOC);
		PlayerPrefs.Save();
		if (constantVariables.UseStreamingAssets)
		{
			PlayerPrefs.SetInt("MasterDataVersion", 0);
			PlayerPrefs.Save();
			_assetBundleDownloader.DeserializeTOC(streamingAssetsTOC);
		}
		else
		{
			_assetBundleDownloader.DeserializeTOC(PlayFabTOC);
		}
	}

	public void LoadComplete()
	{
		loadingAnimator.SetTrigger("Complete");
	}

	public void WarningEnded()
	{
		MasterDomain.GetDomain().TheGameDomain.gameDisplayChanger.RequestDisplayChange(GameDisplayData.DisplayType.map);
	}
}
