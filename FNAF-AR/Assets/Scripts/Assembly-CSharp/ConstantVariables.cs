using UnityEngine;

public class ConstantVariables : MonoBehaviour
{
	public static ConstantVariables Instance;

	[HideInInspector]
	public int ActiveMasterDataVersion;

	[HideInInspector]
	public string DownloadURI = "null";

	[Header("Debug Settings")]
	public int SpecificRevision;

	public bool UseStreamingAssets;

	public MasterDataDownloadCacheDeserialize MasterDataDownloader;

	public AssetBundleDownloader AssetBundleDownloader;

	private LoadingManager _loadingManager;

	private void Awake()
	{
		Instance = this;
		Caching.compressionEnabled = false;
		ActiveMasterDataVersion = PlayerPrefs.GetInt("MasterDataVersion");
		_loadingManager = GameObject.Find("LoadingManager").GetComponent<LoadingManager>();
		MasterDataDownloadCacheDeserialize masterDataDownloader = new MasterDataDownloadCacheDeserialize(_loadingManager, this);
		MasterDataDownloader = masterDataDownloader;
		LoadingBarController component = GameObject.Find("LoadingScreen").GetComponent<LoadingBarController>();
		AssetBundleDownloader assetBundleDownloader = new AssetBundleDownloader(_loadingManager, this, component);
		AssetBundleDownloader = assetBundleDownloader;
	}

	private void Start()
	{
		_loadingManager.Login();
	}
}
