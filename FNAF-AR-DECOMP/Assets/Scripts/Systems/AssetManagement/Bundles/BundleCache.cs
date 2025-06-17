using UnityEngine;

namespace Systems.AssetManagement.Bundles
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BundleCache : AsyncInterfaceAccess<Systems.AssetManagement.Bundles.IBundleCache>, IBundleCache, IBundleCacheManagement
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Files.IFileCache _fileCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.Config.BundleTableOfContents _bundleTableOfContents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.BundleLoader _bundleLoader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.Downloader.BundlePrimer _bundlePrimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.Downloader.BundleDownloader _bundleDownloader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.Config.ILocalBundleConfig _localBundleConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _localBundlesCaching;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _localBundlesCached;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.Config.IBundleDownloadConfig _bundleDownloadConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _bundlesPreparingToDownload;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _bundlesDownloading;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _bundlesDownloaded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnReadyToDownloadCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<int> OnBundlesFullyDownloaded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Systems.AssetManagement.Bundles.BundleState> _localBundleStateLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Systems.AssetManagement.Bundles.BundleState> _bundleStateLookup;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool IsReady { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Systems.AssetManagement.Bundles.IBundleCache GetPublicInterface { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool get_IsReady()
        {
            if(this._localBundlesCached != false)
            {
                    return true;
            }
            
            if(this._bundleDownloader == null)
            {
                    return true;
            }
            
            return (bool)((this._bundleDownloader.<NumSegmentsFinished>k__BackingField) > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Systems.AssetManagement.Bundles.IBundleCache get_GetPublicInterface()
        {
            return (Systems.AssetManagement.Bundles.IBundleCache)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void add_OnReadyToDownloadCallback(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnReadyToDownloadCallback, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnReadyToDownloadCallback != 1152921523418786992);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void remove_OnReadyToDownloadCallback(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnReadyToDownloadCallback, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnReadyToDownloadCallback != 1152921523418923568);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void add_OnBundlesFullyDownloaded(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnBundlesFullyDownloaded, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnBundlesFullyDownloaded != 1152921523419060152);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void remove_OnBundlesFullyDownloaded(System.Action<int> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnBundlesFullyDownloaded, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnBundlesFullyDownloaded != 1152921523419196728);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadAssetBundleAsync(string bundleName, Systems.AssetManagement.Bundles.BundleLoadSuccess onSuccess, Systems.AssetManagement.Bundles.BundleLoadFailure onFailure)
        {
            var val_6;
            var val_1 = (this._bundleDownloadConfig == 0) ? this._localBundleStateLookup : this._bundleStateLookup;
            if((val_1.ContainsKey(key:  bundleName)) != false)
            {
                    this._bundleLoader.LoadBundle(state:  val_1.Item[bundleName], onSuccess:  onSuccess, onFailure:  onFailure);
                return;
            }
            
            val_6 = null;
            val_6 = null;
            ConsoleLogger.LogError(className:  Systems.AssetManagement.Bundles.BundleCache.ClassName, functionName:  "LoadAssetBundleAsync", logString:  "Bundle \'" + bundleName + "\' failed to load: Bundle not known"("\' failed to load: Bundle not known"));
            if(onFailure == null)
            {
                    return;
            }
            
            onFailure.Invoke(info:  new UnityEngine.CachedAssetBundle() {m_Hash = new UnityEngine.Hash128()});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartWithLocalBundlesOnly(Systems.AssetManagement.Bundles.Config.ILocalBundleConfig localBundleConfig, System.Action<int> bundlesFullyLoadedCallback)
        {
            this._localBundleConfig = localBundleConfig;
            this.OnBundlesFullyDownloaded = bundlesFullyLoadedCallback;
            this._localBundlesCaching = true;
            this.LoadLocalTableOfContents(callback:  new System.Action<System.Collections.Generic.Dictionary<System.String, UnityEngine.Hash128>>(object:  this, method:  System.Void Systems.AssetManagement.Bundles.BundleCache::CacheLocalBundles(System.Collections.Generic.Dictionary<string, UnityEngine.Hash128> localTableOfContents)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartWithDownloadedBundles(Systems.AssetManagement.Bundles.Config.ILocalBundleConfig localBundleConfig, Systems.AssetManagement.Bundles.Config.IBundleDownloadConfig bundleDownloadConfig, System.Action readyToDownloadCallback, System.Action<int> bundlesFullyLoadedCallback)
        {
            var val_7;
            var val_8;
            if(this._bundlesDownloading != true)
            {
                    if(this._bundlesPreparingToDownload == false)
            {
                goto label_2;
            }
            
            }
            
            val_7 = null;
            val_7 = null;
            label_20:
            ConsoleLogger.LogError(className:  Systems.AssetManagement.Bundles.BundleCache.ClassName, functionName:  "StartWithDownloadedBundles", logString:  "BundleCache has already been started using downloaded bundles. Cannot start");
            return;
            label_2:
            if(this._localBundlesCaching != false)
            {
                    if(this._localBundlesCached == false)
            {
                goto label_8;
            }
            
            }
            
            this._bundleDownloadConfig = bundleDownloadConfig;
            this._bundlesPreparingToDownload = true;
            this.OnReadyToDownloadCallback = readyToDownloadCallback;
            this.OnBundlesFullyDownloaded = bundlesFullyLoadedCallback;
            if(this._localBundleConfig == null)
            {
                goto label_9;
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this._localBundleStateLookup.Values.GetEnumerator();
            label_14:
            if((1632964104 & 1) == 0)
            {
                goto label_12;
            }
            
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            0.emailUIDataHandler.UnloadBundle();
            goto label_14;
            label_9:
            this._localBundleConfig = localBundleConfig;
            this.LoadLocalTableOfContents(callback:  new System.Action<System.Collections.Generic.Dictionary<System.String, UnityEngine.Hash128>>(object:  this, method:  System.Void Systems.AssetManagement.Bundles.BundleCache::PrepareForBundleDownloads(System.Collections.Generic.Dictionary<string, UnityEngine.Hash128> localTableOfContents)));
            return;
            label_8:
            val_8 = null;
            val_8 = null;
            goto label_20;
            label_12:
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523419680264});
            UnityEngine.AssetBundle.UnloadAllAssetBundles(unloadAllObjects:  true);
            this._localBundleStateLookup.Clear();
            this._localBundleStateLookup = 0;
            this.PrepareForBundleDownloads(localTableOfContents:  this._bundleTableOfContents.LocalToC);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DownloadRemainingBundleSegments(System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData> progressCallback)
        {
            var val_7;
            var val_11;
            var val_12;
            if(this._bundlesDownloading != false)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
            }
            else
            {
                    val_7 = null;
                val_7 = null;
                ConsoleLogger.LogError(className:  Systems.AssetManagement.Bundles.BundleCache.ClassName, functionName:  "DownloadRemainingBundleSegments", logString:  "BundleCache is either not ready or already finished downloading bundles. Cannot download");
                return;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            System.Collections.Generic.IEnumerator<T> val_4 = this._bundleDownloadConfig.GetBundleDownloadSegmentConfigs().GetEnumerator();
            label_29:
            var val_12 = 0;
            val_12 = val_12 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_21;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            T val_8 = val_4.Current;
            this._bundleDownloader.AddSegmentToQueue(segmentName:  val_8 + 16);
            goto label_29;
            label_21:
            val_11 = 0;
            val_12 = 92;
            if(val_4 == null)
            {
                
            }
            else
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_4.Dispose();
            }
            
            this._bundleDownloader.AddUnreferencedSegmentToQueue();
            this._bundleDownloader.StartDownloads(progressCallback:  progressCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadLocalTableOfContents(System.Action<System.Collections.Generic.Dictionary<string, UnityEngine.Hash128>> callback)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            Systems.AssetManagement.Bundles.Config.BundleTableOfContents.LoadTableOfContentsFromUri(fileCache:  this._fileCache, uri:  this._localBundleConfig.GetLocalTableOfContentsPath(), resultCallback:  callback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StoreLocalTableOfContents(System.Collections.Generic.Dictionary<string, UnityEngine.Hash128> localTableOfContents)
        {
            this._bundleTableOfContents.LocalToC = localTableOfContents;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CacheLocalBundles(System.Collections.Generic.Dictionary<string, UnityEngine.Hash128> localTableOfContents)
        {
            int val_1 = localTableOfContents.Count;
            this._bundleTableOfContents.LocalToC = localTableOfContents;
            this.BuildLocalBundleStateLookup();
            Systems.AssetManagement.Bundles.Downloader.BundlePrimer val_2 = new Systems.AssetManagement.Bundles.Downloader.BundlePrimer(bundleLoader:  this._bundleLoader);
            this._bundlePrimer = val_2;
            val_2.PrimeBundleCache(bundleStateLookup:  this._localBundleStateLookup, completeCallback:  new System.Action(object:  this, method:  System.Void Systems.AssetManagement.Bundles.BundleCache::LocalBundleCacheComplete()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildLocalBundleStateLookup()
        {
            var val_3;
            var val_5;
            var val_6;
            UnityEngine.CachedAssetBundle val_7;
            var val_18;
            Systems.AssetManagement.Bundles.Config.BundleTableOfContents val_19;
            var val_22;
            val_18 = this;
            val_19 = this._bundleTableOfContents;
            this._localBundleStateLookup = new System.Collections.Generic.Dictionary<System.String, Systems.AssetManagement.Bundles.BundleState>();
            Dictionary.Enumerator<TKey, TValue> val_2 = this._bundleTableOfContents.LocalToC.GetEnumerator();
            goto label_10;
            label_18:
            if((this._localBundleStateLookup.ContainsKey(key:  val_7.emailUIDataHandler)) != false)
            {
                    val_22 = null;
                val_22 = null;
                val_19 = "Bundle \'" + val_7.emailUIDataHandler + "\' is listed more than once in the local table of contents. Skipping repeat entry";
                ConsoleLogger.LogError(className:  Systems.AssetManagement.Bundles.BundleCache.ClassName, functionName:  "BuildLocalBundleStateLookup", logString:  val_19);
            }
            else
            {
                    GameUI.EmailUIDataHandler val_12 = val_7.emailUIDataHandler;
                new Systems.AssetManagement.Bundles.BundleState() = new System.Object();
                val_6 = 0;
                val_7 = 0;
                var val_19 = 0;
                val_19 = val_19 + 1;
                val_3 = 0;
                val_5 = 0;
                mem[1152921523420582320] = val_6;
                .<LocalUri>k__BackingField = this._localBundleConfig.GetLocalBundleUri(info:  new UnityEngine.CachedAssetBundle() {m_Hash = new UnityEngine.Hash128()});
                .<ServerUri>k__BackingField = System.String.alignConst;
                .<Status>k__BackingField = 0;
                ._bundle = 0;
                .<Info>k__BackingField = val_7;
                val_19 = this._localBundleStateLookup;
                val_19.Add(key:  val_7.emailUIDataHandler, value:  new Systems.AssetManagement.Bundles.BundleState());
            }
            
            label_10:
            if((1633789216 & 1) != 0)
            {
                goto label_18;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocalBundleCacheComplete()
        {
            Systems.AssetManagement.Bundles.Downloader.BundlePrimer val_1;
            int val_2;
            val_1 = this._bundlePrimer;
            if(val_1 != null)
            {
                    val_2 = this._bundlePrimer.<FailedAssetCount>k__BackingField;
            }
            else
            {
                    val_2 = this._bundlePrimer.<FailedAssetCount>k__BackingField;
                if(this._bundlePrimer != null)
            {
                    val_1 = this._bundlePrimer;
            }
            else
            {
                    val_1 = 0;
            }
            
            }
            
            val_1.Teardown();
            this._bundlePrimer = 0;
            this._localBundlesCached = true;
            if(this.OnBundlesFullyDownloaded != null)
            {
                    this.OnBundlesFullyDownloaded.Invoke(obj:  val_2);
            }
            
            this.OnBundlesFullyDownloaded = 0;
            this.TryToDispatchPublicInterface();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PrepareForBundleDownloads(System.Collections.Generic.Dictionary<string, UnityEngine.Hash128> localTableOfContents)
        {
            this._bundlesDownloading = true;
            this._bundleTableOfContents.LocalToC = localTableOfContents;
            this.BuildServerBundleStateLookup();
            Systems.AssetManagement.Bundles.Downloader.BundleDownloader val_1 = new Systems.AssetManagement.Bundles.Downloader.BundleDownloader(bundleLoader:  this._bundleLoader);
            this._bundleDownloader = val_1;
            val_1.PrepareForDownloads(bundleStateLookup:  this._bundleStateLookup, bundleTableOfContents:  this._bundleTableOfContents, bundleDownloadConfig:  this._bundleDownloadConfig, completeCallback:  new System.Action(object:  this, method:  System.Void Systems.AssetManagement.Bundles.BundleCache::BundleDownloadsComplete()));
            if(this.OnReadyToDownloadCallback != null)
            {
                    this.OnReadyToDownloadCallback.Invoke();
            }
            
            this.OnReadyToDownloadCallback = 0;
            this.TryToDispatchPublicInterface();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildServerBundleStateLookup()
        {
            var val_6;
            var val_8;
            var val_9;
            UnityEngine.CachedAssetBundle val_10;
            var val_22;
            Systems.AssetManagement.Bundles.Config.BundleTableOfContents val_24;
            var val_26;
            var val_27;
            var val_28;
            val_22 = this;
            this._bundleStateLookup = new System.Collections.Generic.Dictionary<System.String, Systems.AssetManagement.Bundles.BundleState>();
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_24 = this._bundleTableOfContents;
            this._bundleTableOfContents.ServerToC = Systems.AssetManagement.Bundles.Config.BundleTableOfContents.BuildTableOfContentsFromString(tableOfContentsString:  this._bundleDownloadConfig.GetServerTableOfContentsString());
            Dictionary.Enumerator<TKey, TValue> val_5 = this._bundleTableOfContents.ServerToC.GetEnumerator();
            val_26 = 1152921523420446032;
            val_27 = 1152921505174151168;
            goto label_18;
            label_31:
            if((this._bundleStateLookup.ContainsKey(key:  val_10.emailUIDataHandler)) != false)
            {
                    val_28 = null;
                val_28 = null;
                val_24 = "Bundle \'" + val_10.emailUIDataHandler + "\' is listed more than once in the server table of contents. Skipping repeat entry";
                ConsoleLogger.LogError(className:  Systems.AssetManagement.Bundles.BundleCache.ClassName, functionName:  "BuildServerBundleStateLookup", logString:  val_24);
            }
            else
            {
                    GameUI.EmailUIDataHandler val_15 = val_10.emailUIDataHandler;
                new Systems.AssetManagement.Bundles.BundleState() = new System.Object();
                val_9 = 0;
                val_10 = 0;
                var val_25 = 0;
                val_25 = val_25 + 1;
                var val_26 = 0;
                val_26 = val_26 + 1;
                val_6 = 0;
                val_8 = 0;
                mem[1152921523421162480] = val_9;
                .<LocalUri>k__BackingField = this._localBundleConfig.GetLocalBundleUri(info:  new UnityEngine.CachedAssetBundle() {m_Hash = new UnityEngine.Hash128()});
                .<ServerUri>k__BackingField = this._bundleDownloadConfig.GetS3BundleUri(info:  new UnityEngine.CachedAssetBundle() {m_Hash = new UnityEngine.Hash128()});
                .<Status>k__BackingField = 0;
                ._bundle = 0;
                .<Info>k__BackingField = val_10;
                val_24 = this._bundleStateLookup;
                val_24.Add(key:  val_10.emailUIDataHandler, value:  new Systems.AssetManagement.Bundles.BundleState());
                val_27 = val_27;
                val_26 = val_26;
            }
            
            label_18:
            if((1634352944 & 1) != 0)
            {
                goto label_31;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BundleDownloadsComplete()
        {
            Systems.AssetManagement.Bundles.Downloader.BundleDownloader val_1;
            int val_2;
            val_1 = this._bundleDownloader;
            if(val_1 != null)
            {
                    val_2 = this._bundleDownloader.<FailedAssetCount>k__BackingField;
            }
            else
            {
                    val_2 = this._bundleDownloader.<FailedAssetCount>k__BackingField;
                if(this._bundleDownloader != null)
            {
                    val_1 = this._bundleDownloader;
            }
            else
            {
                    val_1 = 0;
            }
            
            }
            
            val_1.Teardown();
            this._bundleDownloader = 0;
            if(this.OnBundlesFullyDownloaded != null)
            {
                    this.OnBundlesFullyDownloaded.Invoke(obj:  val_2);
            }
            
            this.OnBundlesFullyDownloaded = 0;
            this._bundlesDownloaded = true;
            this.TryToDispatchPublicInterface();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BundleCache(UnityEngine.GameObject parent, Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Files.IFileCache> fileCacheAccess)
        {
            val_1 = new Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Bundles.IBundleCache>();
            this._bundleTableOfContents = new Systems.AssetManagement.Bundles.Config.BundleTableOfContents();
            Systems.AssetManagement.Bundles.BundleLoader val_3 = parent.AddComponent<Systems.AssetManagement.Bundles.BundleLoader>();
            this._bundleLoader = val_3;
            this._bundleDownloader = new Systems.AssetManagement.Bundles.Downloader.BundleDownloader(bundleLoader:  val_3);
            val_1.GetInterfaceAsync(callback:  new System.Action<Systems.AssetManagement.Files.IFileCache>(object:  this, method:  System.Void Systems.AssetManagement.Bundles.BundleCache::FileCacheReady(Systems.AssetManagement.Files.IFileCache fileCache)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FileCacheReady(Systems.AssetManagement.Files.IFileCache fileCache)
        {
            this._fileCache = fileCache;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            var val_4;
            var val_14;
            if(this._localBundleStateLookup == null)
            {
                goto label_1;
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this._localBundleStateLookup.Values.GetEnumerator();
            label_5:
            if((1635010992 & 1) == 0)
            {
                goto label_3;
            }
            
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            val_4.emailUIDataHandler.UnloadBundle();
            goto label_5;
            label_1:
            val_14 = 0;
            goto label_6;
            label_3:
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523421727152});
            val_14 = 0;
            this._localBundleStateLookup.Clear();
            label_6:
            this._localBundleStateLookup = 0;
            if(this._bundleStateLookup == null)
            {
                goto label_12;
            }
            
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_9 = this._bundleStateLookup.Values.GetEnumerator();
            label_16:
            if((1635010992 & 1) == 0)
            {
                goto label_14;
            }
            
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            val_4.emailUIDataHandler.UnloadBundle();
            goto label_16;
            label_14:
            long val_11 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523421727152});
            this._bundleStateLookup.Clear();
            label_12:
            this._bundleStateLookup = 0;
            if(this._bundleDownloader != null)
            {
                    this._bundleDownloader.Teardown();
            }
            
            this._bundleDownloader = 0;
            this._bundleDownloadConfig = 0;
            this._bundleTableOfContents = 0;
            this._bundleLoader = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static BundleCache()
        {
            Systems.AssetManagement.Bundles.BundleCache.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
