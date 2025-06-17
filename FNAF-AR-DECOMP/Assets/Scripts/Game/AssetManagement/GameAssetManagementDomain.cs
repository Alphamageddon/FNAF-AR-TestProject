using UnityEngine;

namespace Game.AssetManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GameAssetManagementDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string PreWarmAssetName = "PreWarmOnLoad";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.AssetManagementDomain _assetManagementDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.IBundleCacheManagement _bundleCacheManagement;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Files.IFileCache _fileCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Downloader.CvModelDownloader _cvModelDownloader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Downloader.TableOfContentsDownloader _tableOfContentsDownloader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IconLookup _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.AssetBundleVersionInfo _assetBundleVersionInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.BundleDownloadConfig _bundleDownloadConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _inLocalAssetMode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _loadStarted;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _fullyLoaded;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Assets.IAssetCache> AssetCacheAccess { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Files.IFileCache> FileCacheAccess { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Game.AssetManagement.Icons.IIconLookup> IconLookupAccess { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Assets.IAssetCache> get_AssetCacheAccess()
        {
            if(this._assetManagementDomain != null)
            {
                    return this._assetManagementDomain.AssetCacheAccess;
            }
            
            return this._assetManagementDomain.AssetCacheAccess;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Files.IFileCache> get_FileCacheAccess()
        {
            if(this._assetManagementDomain != null)
            {
                    return this._assetManagementDomain.FileCacheAccess;
            }
            
            return this._assetManagementDomain.FileCacheAccess;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Game.AssetManagement.Icons.IIconLookup> get_IconLookupAccess()
        {
            return (Utilities.AsyncInterfaceAccess<Game.AssetManagement.Icons.IIconLookup>)this._iconLookup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameAssetManagementDomain(UnityEngine.Transform parent, Master.EventExposer masterEventExposer, Game.MasterData.MasterDataDomain masterDataDomain)
        {
            val_1 = new System.Object();
            this._masterEventExposer = val_1;
            Systems.AssetManagement.AssetManagementDomain val_2 = new Systems.AssetManagement.AssetManagementDomain(parent:  parent);
            this._assetManagementDomain = val_2;
            this._bundleCacheManagement = val_2.BundleCacheManagement;
            this._iconLookup = new Game.AssetManagement.Icons.IconLookup(masterEventExposer:  Master.EventExposer val_1 = masterEventExposer, masterDataDomain:  masterDataDomain, assetCacheAccess:  this.AssetCacheAccess, bundleCacheAccess:  this._assetManagementDomain.BundleCacheAccess);
            this._masterEventExposer.add_AssetBundleVersionReceived(value:  new System.Action<Game.AssetManagement.AssetBundleVersionInfo>(object:  this, method:  System.Void Game.AssetManagement.GameAssetManagementDomain::AssetBundleVersionReceived(Game.AssetManagement.AssetBundleVersionInfo info)));
            this._masterEventExposer.add_TableOfContentsDownloadFailure(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.AssetManagement.GameAssetManagementDomain::TableOfContentsDownloadFailure(int failureCount)));
            this._masterEventExposer.add_LocalGameplayAssetsReady(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.AssetManagement.GameAssetManagementDomain::LocalGameplayAssetsReady(int failedAssetCount)));
            this._masterEventExposer.add_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.AssetManagement.GameAssetManagementDomain::AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)));
            this.FileCacheAccess.GetInterfaceAsync(callback:  new System.Action<Systems.AssetManagement.Files.IFileCache>(object:  this, method:  System.Void Game.AssetManagement.GameAssetManagementDomain::FileCacheReady(Systems.AssetManagement.Files.IFileCache fileCache)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._masterEventExposer.remove_AssetBundleDownloadSegmentsAllComplete(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.AssetManagement.GameAssetManagementDomain::AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)));
            this._masterEventExposer.remove_LocalGameplayAssetsReady(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.AssetManagement.GameAssetManagementDomain::LocalGameplayAssetsReady(int failedAssetCount)));
            this._masterEventExposer.remove_TableOfContentsDownloadFailure(value:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.AssetManagement.GameAssetManagementDomain::TableOfContentsDownloadFailure(int failureCount)));
            this._masterEventExposer.remove_AssetBundleVersionReceived(value:  new System.Action<Game.AssetManagement.AssetBundleVersionInfo>(object:  this, method:  System.Void Game.AssetManagement.GameAssetManagementDomain::AssetBundleVersionReceived(Game.AssetManagement.AssetBundleVersionInfo info)));
            this._assetBundleVersionInfo = 0;
            this._bundleDownloadConfig = 0;
            this._iconLookup.Teardown();
            this._iconLookup = 0;
            if(this._tableOfContentsDownloader != null)
            {
                    this._tableOfContentsDownloader._fileCache = 0;
                this._tableOfContentsDownloader._successCallback = 0;
                this._tableOfContentsDownloader._failureCallback = 0;
            }
            
            this._tableOfContentsDownloader = 0;
            if(this._cvModelDownloader != null)
            {
                    this._cvModelDownloader._callback = 0;
            }
            
            this._fileCache = 0;
            this._cvModelDownloader = 0;
            this._bundleCacheManagement = 0;
            this._assetManagementDomain.Teardown();
            this._masterEventExposer = 0;
            this._assetManagementDomain = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._cvModelDownloader != null)
            {
                    this._cvModelDownloader.Update();
            }
            
            if(this._tableOfContentsDownloader == null)
            {
                    return;
            }
            
            this._tableOfContentsDownloader.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetupForLocalAssets()
        {
            if(this._loadStarted == true)
            {
                    return;
            }
            
            if(this._fullyLoaded != false)
            {
                    return;
            }
            
            this._fullyLoaded = false;
            this._inLocalAssetMode = true;
            this._loadStarted = true;
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._bundleCacheManagement.StartWithLocalBundlesOnly(localBundleConfig:  new Game.AssetManagement.LocalBundleConfig(), bundlesFullyLoadedCallback:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.AssetManagement.GameAssetManagementDomain::LocalBundleLoadComplete(int failedAssetCount)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetupForStandardAssets()
        {
            if(this._inLocalAssetMode != false)
            {
                    this._masterEventExposer.OnLocalGameplayEnded();
            }
            
            this._inLocalAssetMode = true;
            this._loadStarted = true;
            this._fullyLoaded = false;
            this.TryToDownloadServerTableOfContents();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetBundleVersionReceived(Game.AssetManagement.AssetBundleVersionInfo info)
        {
            if(this._assetBundleVersionInfo != null)
            {
                    return;
            }
            
            this._assetBundleVersionInfo = info;
            this.TryToDownloadServerTableOfContents();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TableOfContentsDownloadFailure(int failureCount)
        {
            if(failureCount < 5)
            {
                    return;
            }
            
            ConsoleLogger.LogError(className:  "GameAssetManagementDomain", functionName:  "TableOfContentsDownloadFailure", logString:  "Failed to download the server table of contents at least 5 times");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocalGameplayAssetsReady(int failedAssetCount)
        {
            if(failedAssetCount < 1)
            {
                    return;
            }
            
            ConsoleLogger.LogError(className:  "GameAssetManagementDomain", functionName:  "LocalGameplayAssetsReady", logString:  "Failed to load at least 1 local asset bundle");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetBundleDownloadSegmentsAllComplete(int failedAssetCount)
        {
            if(failedAssetCount < 1)
            {
                    return;
            }
            
            ConsoleLogger.LogError(className:  "GameAssetManagementDomain", functionName:  "AssetBundleDownloadSegmentsAllComplete", logString:  "Failed to download at least 1 asset bundle");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FileCacheReady(Systems.AssetManagement.Files.IFileCache fileCache)
        {
            this._fileCache = fileCache;
            this.TryToDownloadServerTableOfContents();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocalBundleLoadComplete(int failedAssetCount)
        {
            if(this._inLocalAssetMode == false)
            {
                    return;
            }
            
            this._loadStarted = true;
            this._fullyLoaded = true;
            this._masterEventExposer.OnLocalGameplayAssetsReady(failedAssetCount:  failedAssetCount);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToDownloadServerTableOfContents()
        {
            Game.AssetManagement.AssetBundleVersionInfo val_10;
            if(this._inLocalAssetMode != false)
            {
                    return;
            }
            
            if(this._loadStarted == false)
            {
                    return;
            }
            
            if(this._fileCache == null)
            {
                    return;
            }
            
            if(this._assetBundleVersionInfo == null)
            {
                    return;
            }
            
            this._cvModelDownloader = new Game.AssetManagement.Downloader.CvModelDownloader(uri:  this._assetBundleVersionInfo.CvBucketUri, completeCallback:  new System.Action(object:  this, method:  System.Void Game.AssetManagement.GameAssetManagementDomain::CvDownloadComplete()));
            val_10 = this._assetBundleVersionInfo;
            if(this._assetBundleVersionInfo != null)
            {
                goto label_5;
            }
            
            val_10 = this._assetBundleVersionInfo;
            if(val_10 == null)
            {
                goto label_6;
            }
            
            label_5:
            string[] val_5 = new string[7];
            val_5[0] = this._assetBundleVersionInfo.VersionBucketUri;
            val_5[1] = "/";
            val_5[2] = this._assetBundleVersionInfo.Version.ToString();
            val_5[3] = "/";
            val_5[4] = "Android";
            val_5[5] = "/";
            val_5[6] = Game.AssetManagement.AssetPathHelper.GetPlatformStringToC();
            this._tableOfContentsDownloader = new Game.AssetManagement.Downloader.TableOfContentsDownloader(fileCache:  this._fileCache, fileUri:  +val_5, successCallback:  new System.Action<System.String>(object:  this, method:  System.Void Game.AssetManagement.GameAssetManagementDomain::ServerTableOfContentsStringReady(string serverTableOfContentsString)), failureCallback:  new System.Action<System.Int32>(object:  this._masterEventExposer, method:  public System.Void Master.EventExposer::OnTableOfContentsDownloadFailure(int failureCount)));
            return;
            label_6:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ServerTableOfContentsStringReady(string serverTableOfContentsString)
        {
            ._s3BucketPrefix = this._assetBundleVersionInfo.BundleBucketUri;
            ._serverTableOfContentsString = serverTableOfContentsString;
            ._segmentConfigs = Game.AssetManagement.GameAssetManagementDomain.BuildBundleSegments();
            this._bundleDownloadConfig = new Game.AssetManagement.BundleDownloadConfig();
            var val_8 = 0;
            val_8 = val_8 + 1;
            this._assetManagementDomain.BundleCacheManagement.StartWithDownloadedBundles(localBundleConfig:  new Game.AssetManagement.LocalBundleConfig(), bundleDownloadConfig:  this._bundleDownloadConfig, readyCallback:  new System.Action(object:  this, method:  System.Void Game.AssetManagement.GameAssetManagementDomain::StartBundleDownloads()), bundlesFullyLoadedCallback:  new System.Action<System.Int32>(object:  this, method:  System.Void Game.AssetManagement.GameAssetManagementDomain::ServerBundleDownloadsAllComplete(int failedAssetCount)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartBundleDownloads()
        {
            IntPtr val_4;
            System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData> val_2 = null;
            val_4 = public System.Void Master.EventExposer::OnAssetBundleDownloadProgressUpdated(Systems.AssetManagement.Bundles.BundleDownloadProgressData progressData);
            val_2 = new System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData>(object:  this._masterEventExposer, method:  val_4);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 2;
            this._assetManagementDomain.BundleCacheManagement.DownloadRemainingBundleSegments(progressCallback:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ServerBundleDownloadsAllComplete(int failedAssetCount)
        {
            this._inLocalAssetMode = true;
            this._loadStarted = true;
            this._fullyLoaded = true;
            this._masterEventExposer.OnAssetBundleDownloadSegmentsAllComplete(failedAssetCount:  failedAssetCount);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CvDownloadComplete()
        {
            this._cvModelDownloader = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.List<Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig> BuildBundleSegments()
        {
            System.Collections.Generic.List<Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig> val_1 = new System.Collections.Generic.List<Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig>();
            System.Collections.Generic.List<System.String> val_2 = new System.Collections.Generic.List<System.String>();
            if(val_2 != null)
            {
                    val_2.Add(item:  "ui/icons/cpu");
            }
            else
            {
                    val_2.Add(item:  "ui/icons/cpu");
            }
            
            val_2.Add(item:  "ui/icons/plushsuit");
            if(val_2 != null)
            {
                    val_2.Add(item:  "ui/icons/portrait");
            }
            else
            {
                    val_2.Add(item:  "ui/icons/portrait");
            }
            
            val_2.Add(item:  "ui/icons/mod");
            val_1.Add(item:  new Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig(segmentName:  "UIBundles", bundleNames:  val_2, concurrentMax:  1, segmentCompleteCallback:  0));
            System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>();
            if(val_4 != null)
            {
                    val_4.Add(item:  "audio/init");
            }
            else
            {
                    val_4.Add(item:  "audio/init");
            }
            
            val_4.Add(item:  "audio/ui");
            if(val_4 != null)
            {
                    val_4.Add(item:  "audio/music");
            }
            else
            {
                    val_4.Add(item:  "audio/music");
            }
            
            val_4.Add(item:  "audio/shared");
            if(val_4 != null)
            {
                    val_4.Add(item:  "audio/bareendo");
            }
            else
            {
                    val_4.Add(item:  "audio/bareendo");
            }
            
            val_4.Add(item:  "audio/freddy");
            if(val_4 != null)
            {
                    val_4.Add(item:  "audio/shadowbonnie");
            }
            else
            {
                    val_4.Add(item:  "audio/shadowbonnie");
            }
            
            val_4.Add(item:  "audio/bonnie");
            if(val_4 != null)
            {
                    val_4.Add(item:  "audio/chica");
            }
            else
            {
                    val_4.Add(item:  "audio/chica");
            }
            
            val_4.Add(item:  "audio/balloonboy");
            if(val_4 != null)
            {
                    val_4.Add(item:  "audio/foxy");
            }
            else
            {
                    val_4.Add(item:  "audio/foxy");
            }
            
            val_4.Add(item:  "audio/baby");
            val_4.Add(item:  "audio/springtrap");
            val_1.Add(item:  new Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig(segmentName:  "AudioBundles", bundleNames:  val_4, concurrentMax:  1, segmentCompleteCallback:  0));
            System.Collections.Generic.List<System.String> val_6 = new System.Collections.Generic.List<System.String>();
            if(val_6 != null)
            {
                    val_6.Add(item:  "essencecollection");
            }
            else
            {
                    val_6.Add(item:  "essencecollection");
            }
            
            val_6.Add(item:  "animatronics/shared");
            if(val_6 != null)
            {
                    val_6.Add(item:  "animatronics/bareendo");
            }
            else
            {
                    val_6.Add(item:  "animatronics/bareendo");
            }
            
            val_6.Add(item:  "animatronics/freddy");
            if(val_6 != null)
            {
                    val_6.Add(item:  "animatronics/shadowbonnie");
            }
            else
            {
                    val_6.Add(item:  "animatronics/shadowbonnie");
            }
            
            val_6.Add(item:  "animatronics/bonnie");
            if(val_6 != null)
            {
                    val_6.Add(item:  "animatronics/chica");
            }
            else
            {
                    val_6.Add(item:  "animatronics/chica");
            }
            
            val_6.Add(item:  "animatronics/balloonboy");
            if(val_6 != null)
            {
                    val_6.Add(item:  "animatronics/foxy");
            }
            else
            {
                    val_6.Add(item:  "animatronics/foxy");
            }
            
            val_6.Add(item:  "animatronics/baby");
            val_6.Add(item:  "animatronics/springtrap");
            val_1.Add(item:  new Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig(segmentName:  "Required", bundleNames:  val_6, concurrentMax:  1, segmentCompleteCallback:  0));
            return val_1;
        }
    
    }

}
