using UnityEngine;

namespace Systems.AssetManagement.Bundles.Downloader
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BundlePrimer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <FailedAssetCount>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.BundleLoader _bundleLoader;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _completeCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.HashSet<string> _waitingToFinish;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int FailedAssetCount { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_FailedAssetCount()
        {
            return (int)this.<FailedAssetCount>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_FailedAssetCount(int value)
        {
            this.<FailedAssetCount>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PrimeBundleCache(System.Collections.Generic.Dictionary<string, Systems.AssetManagement.Bundles.BundleState> bundleStateLookup, System.Action completeCallback)
        {
            uint val_3;
            string val_4;
            this._completeCallback = completeCallback;
            Dictionary.Enumerator<TKey, TValue> val_1 = bundleStateLookup.GetEnumerator();
            label_7:
            if((1643708800 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_5 = val_4.trackableId;
            if((UnityEngine.Caching.IsVersionCached(cachedBundle:  new UnityEngine.CachedAssetBundle() {m_Name = val_4, m_Hash = new UnityEngine.Hash128() {m_u32_0 = val_4, m_u32_1 = val_4, m_u32_2 = val_3, m_u32_3 = val_3}})) == true)
            {
                goto label_7;
            }
            
            bool val_8 = this._waitingToFinish.Add(item:  val_4.emailUIDataHandler);
            mem[1152921523430489616] = this;
            mem[1152921523430489624] = System.Void Systems.AssetManagement.Bundles.Downloader.BundlePrimer::CacheSuccess(UnityEngine.CachedAssetBundle info, UnityEngine.AssetBundle bundle);
            mem[1152921523430489600] = System.Void Systems.AssetManagement.Bundles.Downloader.BundlePrimer::CacheSuccess(UnityEngine.CachedAssetBundle info, UnityEngine.AssetBundle bundle);
            mem[1152921523430493712] = this;
            mem[1152921523430493720] = System.Void Systems.AssetManagement.Bundles.Downloader.BundlePrimer::CacheFailure(UnityEngine.CachedAssetBundle info);
            mem[1152921523430493696] = System.Void Systems.AssetManagement.Bundles.Downloader.BundlePrimer::CacheFailure(UnityEngine.CachedAssetBundle info);
            this._bundleLoader.CacheBundle(state:  val_5.m_SubId1, onSuccess:  new Systems.AssetManagement.Bundles.BundleLoadSuccess(), onFailure:  new Systems.AssetManagement.Bundles.BundleLoadFailure());
            goto label_7;
            label_2:
            long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523430424960});
            this.TryToFinish();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CacheSuccess(UnityEngine.CachedAssetBundle info, UnityEngine.AssetBundle bundle)
        {
            this.CacheComplete(info:  new UnityEngine.CachedAssetBundle() {m_Name = info.m_Name, m_Hash = new UnityEngine.Hash128() {m_u32_0 = 1643914032, m_u32_1 = 268435460, m_u32_2 = info.m_Hash.m_u32_2}});
            this.TryToFinish();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CacheFailure(UnityEngine.CachedAssetBundle info)
        {
            var val_3;
            int val_3 = this.<FailedAssetCount>k__BackingField;
            val_3 = val_3 + 1;
            this.<FailedAssetCount>k__BackingField = val_3;
            val_3 = null;
            val_3 = null;
            ConsoleLogger.LogError(className:  Systems.AssetManagement.Bundles.Downloader.BundlePrimer.ClassName, functionName:  "DownloadFailure", logString:  System.String.Format(format:  "Failed to download \'{0}:{1}\'", arg0:  info.m_Name.emailUIDataHandler, arg1:  1152921523430770928));
            this.CacheComplete(info:  new UnityEngine.CachedAssetBundle() {m_Name = info.m_Name, m_Hash = new UnityEngine.Hash128() {m_u32_0 = 1644058816, m_u32_1 = 268435460, m_u32_2 = info.m_Hash.m_u32_2}});
            this.TryToFinish();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CacheComplete(UnityEngine.CachedAssetBundle info)
        {
            System.Collections.Generic.HashSet<System.String> val_5 = this._waitingToFinish;
            if((val_5.Contains(item:  info.m_Name.emailUIDataHandler)) != false)
            {
                    val_5 = this._waitingToFinish;
                bool val_4 = val_5.Remove(item:  info.m_Name.emailUIDataHandler);
            }
            
            this.TryToFinish();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryToFinish()
        {
            if(this._waitingToFinish.Count > 0)
            {
                    return;
            }
            
            if(this._completeCallback != null)
            {
                    this._completeCallback.Invoke();
            }
            
            this._completeCallback = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BundlePrimer(Systems.AssetManagement.Bundles.BundleLoader bundleLoader)
        {
            this._waitingToFinish = new System.Collections.Generic.HashSet<System.String>();
            this._bundleLoader = bundleLoader;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._waitingToFinish.Clear();
            this._bundleLoader = 0;
            this._completeCallback = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static BundlePrimer()
        {
            Systems.AssetManagement.Bundles.Downloader.BundlePrimer.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
