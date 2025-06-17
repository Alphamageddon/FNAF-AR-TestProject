using UnityEngine;

namespace Game.Server.Processors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ConfigProcessor
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string PLAYER_PREFS_KEY_PREFIX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly string PLAYER_PREFS_KEY_MASTER_DATA_VERSION;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly string PLAYER_PREFS_KEY_ASSET_DATA_VERSION;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly string PLAYER_PREFS_KEY_VERSION_URI;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly string PLAYER_PREFS_KEY_BUNDLE_URI;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly string PLAYER_PREFS_KEY_CV_URI;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly string PLAYER_PREFS_KEY_MASTER_DATA_BASE_URI;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, System.Action<string>> dataCallbackTable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<int> MasterDataVersionReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.AssetManagement.AssetBundleVersionInfo> AssetBundleVersionReceived;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Files.IFileCache _fileCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.Processors.ConfigProcessor.Context _context;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Master.EventExposer eventExposer)
        {
            System.Collections.Generic.Dictionary<System.String, System.Action<System.String>> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Action<System.String>>();
            val_1.Add(key:  "CONFIG", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnConfigJsonDataReceived(string e)));
            val_1.Add(key:  "ANIMATRONIC", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnAnimatronicJsonDataReceived(string e)));
            val_1.Add(key:  "ALERT", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnAlertJsonDataReceived(string e)));
            val_1.Add(key:  "AUDIO", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnAudioJsonDataReceived(string data)));
            val_1.Add(key:  "DEVICES", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnDevicesJsonDataReceived(string data)));
            val_1.Add(key:  "TUTORIAL", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnTutorialJsonDataReceived(string data)));
            val_1.Add(key:  "KEY_VALUE", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnKeyValueJsonDataReceived(string data)));
            val_1.Add(key:  "ESSENCE", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnEssenceJsonDataReceived(string data)));
            val_1.Add(key:  "ESSENCE_TYPES", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnEssenceTypesJsonDataReceived(string data)));
            val_1.Add(key:  "MODS", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnModsJsonDataReceived(string data)));
            val_1.Add(key:  "PROGRESSION", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnProgressionJsonDataReceived(string data)));
            val_1.Add(key:  "STATIC", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnStaticJsonDataReceived(string data)));
            val_1.Add(key:  "WEARANDTEAR", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnWearAndTearJsonDataReceived(string data)));
            val_1.Add(key:  "CPU", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnCPUJsonDataReceived(string data)));
            val_1.Add(key:  "PLUSHSUIT", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnPlushSuitJsonDataReceived(string data)));
            val_1.Add(key:  "ATTACK", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnAttackJsonDataReceived(string data)));
            val_1.Add(key:  "LOC", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnLocJsonDataReceived(string data)));
            val_1.Add(key:  "STORE", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnStoreJsonDataReceived(string data)));
            val_1.Add(key:  "REMNANT_DEBUFF", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnRemnantDebuffJsonDataReceived(string data)));
            val_1.Add(key:  "MODCATEGORIES", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnModCategoriesDataRecieved(string data)));
            val_1.Add(key:  "SERVERBLOCKINGERROR", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnServerBlockingErrorDataReceived(string data)));
            val_1.Add(key:  "SEASONAL", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnSeasonalDataReceived(string data)));
            val_1.Add(key:  "SEASONAL_ASSETS", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnSeasonalAssetsDataReceived(string data)));
            val_1.Add(key:  "SEQUENTIAL_REWARDS", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnSequentialRewardsDataReceived(string data)));
            val_1.Add(key:  "INBOX", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnInboxFolderDataReceived(string data)));
            val_1.Add(key:  "STORESECTIONS", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnStoreSectionJsonDataReceived(string data)));
            val_1.Add(key:  "DAILY_CHALLENGE", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnDailyChallengeJsonDataReceived(string data)));
            val_1.Add(key:  "DAILY_CHALLENGE_REWARDS", value:  new System.Action<System.String>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnDailyChallengeRewardsJsonDataReceived(string data)));
            this.dataCallbackTable = val_1;
            this.MasterDataVersionReceived = new System.Action<System.Int32>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnMasterDataVersionReceived(int data));
            this.AssetBundleVersionReceived = new System.Action<Game.AssetManagement.AssetBundleVersionInfo>(object:  eventExposer, method:  public System.Void Master.EventExposer::OnAssetBundleVersionReceived(Game.AssetManagement.AssetBundleVersionInfo info));
            this._fileCache = new Systems.AssetManagement.Files.FileCache(parent:  new UnityEngine.GameObject(name:  "ConfigProcessor"));
            .inFlight = false;
            this._context = new ConfigProcessor.Context();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ProcessFromCache()
        {
            var val_4;
            var val_19;
            var val_20;
            var val_21;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this.dataCallbackTable.Keys.GetEnumerator();
            label_11:
            if(((-872304384) & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            val_19 = null;
            val_19 = null;
            if((UnityEngine.PlayerPrefs.HasKey(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_PREFIX + val_5)) == false)
            {
                goto label_11;
            }
            
            val_20 = null;
            val_20 = null;
            this.dataCallbackTable.Item[val_5].Invoke(obj:  UnityEngine.PlayerPrefs.GetString(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_PREFIX + val_5));
            goto label_11;
            label_3:
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525209379072});
            val_21 = null;
            val_21 = null;
            this.MasterDataVersionReceived.Invoke(obj:  UnityEngine.PlayerPrefs.GetInt(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_MASTER_DATA_VERSION));
            this.AssetBundleVersionReceived.Invoke(obj:  new Game.AssetManagement.AssetBundleVersionInfo(version:  UnityEngine.PlayerPrefs.GetInt(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_ASSET_DATA_VERSION), versionBucketUri:  UnityEngine.PlayerPrefs.GetString(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_VERSION_URI), bundleBucketUri:  UnityEngine.PlayerPrefs.GetString(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_BUNDLE_URI), cvBucketUri:  UnityEngine.PlayerPrefs.GetString(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_CV_URI)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Process(Systems.Server.ServerData data)
        {
            string val_5;
            Context val_6;
            string val_7;
            string val_8;
            string val_9;
            val_5 = this;
            val_6 = this._context;
            if(this._context.inFlight != false)
            {
                    val_7 = "ConfigProcessor";
                val_8 = "TryToDownloadMasterData";
                val_9 = "Attempting to request master data while request already in process; Ignoring";
            }
            else
            {
                    string val_1 = data.GetString(key:  "MasterDataBaseURI");
                val_6 = val_1;
                if(((System.String.IsNullOrEmpty(value:  val_1)) != true) && (this._fileCache != null))
            {
                    this._context.Build(data:  data, expectedResponses_:  this.dataCallbackTable.Count);
                this.TryToDownloadMasterData();
                return;
            }
            
                val_5 = "Null or empty masterDataBaseUri: "("Null or empty masterDataBaseUri: ") + val_6 + " or null file cache";
                val_9 = val_5;
                val_7 = "ConfigProcessor";
                val_8 = "Process";
            }
            
            ConsoleLogger.LogError(className:  val_7, functionName:  val_8, logString:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnConfigLoaded()
        {
            Context val_2;
            int val_3;
            var val_4;
            this.MasterDataVersionReceived.Invoke(obj:  this._context.masterDataVersion);
            val_2 = this._context;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            val_3 = this._context.assetBundleVersion;
            goto label_4;
            label_3:
            val_3 = this._context.assetBundleVersion;
            if(this._context == null)
            {
                goto label_5;
            }
            
            val_2 = this._context;
            label_4:
            label_16:
            label_17:
            this.AssetBundleVersionReceived.Invoke(obj:  new Game.AssetManagement.AssetBundleVersionInfo(version:  val_3, versionBucketUri:  this._context.versionUri, bundleBucketUri:  this._context.bundleUri, cvBucketUri:  this._context.cvDataUri));
            val_4 = null;
            val_4 = null;
            UnityEngine.PlayerPrefs.SetString(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_MASTER_DATA_BASE_URI, value:  this._context.masterDataBaseUri);
            UnityEngine.PlayerPrefs.SetString(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_VERSION_URI, value:  this._context.versionUri);
            UnityEngine.PlayerPrefs.SetString(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_BUNDLE_URI, value:  this._context.bundleUri);
            UnityEngine.PlayerPrefs.SetString(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_CV_URI, value:  this._context.cvDataUri);
            UnityEngine.PlayerPrefs.SetInt(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_ASSET_DATA_VERSION, value:  this._context.assetBundleVersion);
            UnityEngine.PlayerPrefs.SetInt(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_MASTER_DATA_VERSION, value:  this._context.masterDataVersion);
            this._context.inFlight = false;
            return;
            label_5:
            if(this._context != null)
            {
                goto label_16;
            }
            
            if(this._context != null)
            {
                goto label_17;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToDownloadMasterData()
        {
            var val_6 = this;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = this.dataCallbackTable.Keys.GetEnumerator();
            label_4:
            if(((-871642904) & 1) == 0)
            {
                goto label_3;
            }
            
            this.LoadMasterDataFileAsync(key:  0.emailUIDataHandler);
            goto label_4;
            label_3:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525210040552});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadMasterDataFileAsync(string key)
        {
            Context val_9;
            string val_10;
            IntPtr val_11;
            ConfigProcessor.<>c__DisplayClass18_0 val_1 = new ConfigProcessor.<>c__DisplayClass18_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .key = key;
            val_9 = this._context;
            if(val_9 != null)
            {
                    val_10 = this._context.masterDataBaseUri;
            }
            else
            {
                    val_10 = this._context.masterDataBaseUri;
                if(this._context != null)
            {
                    val_9 = this._context;
            }
            else
            {
                    val_9 = 0;
            }
            
            }
            
            string[] val_3 = new string[5];
            val_3[0] = val_10;
            val_3[1] = mem[16].ToString();
            val_3[2] = "/";
            val_3[3] = (ConfigProcessor.<>c__DisplayClass18_0)[1152921525210276640].key;
            val_3[4] = "_DATA";
            .FilePath = +val_3;
            .FileLoadSuccess = new System.Action<Systems.AssetManagement.Files.FileLoadSettings, UnityEngine.Networking.DownloadHandler>(object:  val_1, method:  System.Void ConfigProcessor.<>c__DisplayClass18_0::<LoadMasterDataFileAsync>b__0(Systems.AssetManagement.Files.FileLoadSettings settings, UnityEngine.Networking.DownloadHandler downloadHandler));
            System.Action<Systems.AssetManagement.Files.FileLoadSettings> val_7 = null;
            val_11 = System.Void ConfigProcessor.<>c__DisplayClass18_0::<LoadMasterDataFileAsync>b__1(Systems.AssetManagement.Files.FileLoadSettings settings);
            val_7 = new System.Action<Systems.AssetManagement.Files.FileLoadSettings>(object:  val_1, method:  val_11);
            .FileLoadFailure = val_7;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_11 = 0;
            this._fileCache.LoadFileFromPath(settings:  new Systems.AssetManagement.Files.FileLoadSettings());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessReceivedMasterData(string key, string data)
        {
            var val_3;
            Context val_4;
            int val_5;
            Context val_6;
            this.dataCallbackTable.Item[key].Invoke(obj:  data);
            val_3 = null;
            val_3 = null;
            UnityEngine.PlayerPrefs.SetString(key:  Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_PREFIX + key, value:  data);
            val_4 = this._context;
            if(val_4 != null)
            {
                    val_5 = this._context.successfulResponsesReceived;
            }
            else
            {
                    val_4 = 60;
                val_5 = 1769500;
            }
            
            mem[60] = 1769501;
            val_6 = this._context;
            if(this._context != null)
            {
                goto label_7;
            }
            
            val_6 = this._context;
            if(val_6 == null)
            {
                goto label_8;
            }
            
            label_7:
            if(this._context.successfulResponsesReceived < this._context.expectedResponses)
            {
                    return;
            }
            
            this.OnConfigLoaded();
            return;
            label_8:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConfigProcessor()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ConfigProcessor()
        {
            Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_PREFIX = "Startup_Config_";
            Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_MASTER_DATA_VERSION = "Startup_Config_MasterDataVersion";
            Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_ASSET_DATA_VERSION = "Startup_Config_AssetDataVersion";
            Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_VERSION_URI = "Startup_Config_VersionURI";
            Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_BUNDLE_URI = "Startup_Config_BundleURI";
            Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_CV_URI = "Startup_Config_CVURI";
            Game.Server.Processors.ConfigProcessor.PLAYER_PREFS_KEY_MASTER_DATA_BASE_URI = "Startup_Config_MasterDataBaseUri";
        }
    
    }

}
