using UnityEngine;

namespace Systems.AssetManagement.Assets
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AssetCache : AsyncInterfaceAccess<Systems.AssetManagement.Assets.IAssetCache>, IAssetCache
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.IBundleCache _bundleCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<Systems.AssetManagement.Assets.IAssetLoader> _assetLoaders;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool IsReady { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Systems.AssetManagement.Assets.IAssetCache GetPublicInterface { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool get_IsReady()
        {
            return (bool)(this._bundleCache != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Systems.AssetManagement.Assets.IAssetCache get_GetPublicInterface()
        {
            return (Systems.AssetManagement.Assets.IAssetCache)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DoesBundleContainAsset(string bundleName, string assetName, System.Action<bool> result)
        {
            string val_11;
            var val_12;
            AssetCache.<>c__DisplayClass6_0 val_13;
            var val_14;
            val_11 = bundleName;
            val_12 = this;
            AssetCache.<>c__DisplayClass6_0 val_1 = null;
            val_13 = val_1;
            val_1 = new AssetCache.<>c__DisplayClass6_0();
            if(val_13 != null)
            {
                    val_14 = val_13;
                .result = result;
            }
            else
            {
                    val_14 = 16;
                mem[16] = result;
            }
            
            .assetName = assetName;
            if(this._bundleCache != null)
            {
                    mem[1152921523434213120] = val_13;
                mem[1152921523434213128] = System.Void AssetCache.<>c__DisplayClass6_0::<DoesBundleContainAsset>b__0(UnityEngine.CachedAssetBundle info, UnityEngine.AssetBundle bundle);
                mem[1152921523434213104] = System.Void AssetCache.<>c__DisplayClass6_0::<DoesBundleContainAsset>b__0(UnityEngine.CachedAssetBundle info, UnityEngine.AssetBundle bundle);
                mem[1152921523434217216] = val_13;
                mem[1152921523434217224] = System.Void AssetCache.<>c__DisplayClass6_0::<DoesBundleContainAsset>b__1(UnityEngine.CachedAssetBundle info);
                mem[1152921523434217200] = System.Void AssetCache.<>c__DisplayClass6_0::<DoesBundleContainAsset>b__1(UnityEngine.CachedAssetBundle info);
                var val_3 = 0;
                val_3 = val_3 + 1;
            }
            else
            {
                    if(val_14 == 0)
            {
                    return;
            }
            
                val_14.Invoke(obj:  false);
                return;
            }
            
            val_11 = ???;
            val_12 = ???;
            val_13 = ???;
            this._bundleCache.LoadAssetBundleAsync(bundleName:  val_11, onSuccess:  new Systems.AssetManagement.Bundles.BundleLoadSuccess(), onFailure:  new Systems.AssetManagement.Bundles.BundleLoadFailure());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadAssetAsync<T>(string assetName, string bundleName, System.Action<T> onSuccess, System.Action onFailure)
        {
            System.Action<Systems.AssetManagement.Assets.IAssetLoader> val_1 = new System.Action<Systems.AssetManagement.Assets.IAssetLoader>(object:  this, method:  System.Void Systems.AssetManagement.Assets.AssetCache::AssetLoadComplete(Systems.AssetManagement.Assets.IAssetLoader loader));
            bool val_2 = this._assetLoaders.Add(item:  __RuntimeMethodHiddenParam + 48);
            if((__RuntimeMethodHiddenParam + 48) == 0)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReleaseAsset(string bundleName, string assetName)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AssetLoadComplete(Systems.AssetManagement.Assets.IAssetLoader loader)
        {
            bool val_1 = this._assetLoaders.Remove(item:  loader);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AssetCache(Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Bundles.IBundleCache> bundleCacheAccess)
        {
            this._assetLoaders = new System.Collections.Generic.HashSet<Systems.AssetManagement.Assets.IAssetLoader>();
            bundleCacheAccess.GetInterfaceAsync(callback:  new System.Action<Systems.AssetManagement.Bundles.IBundleCache>(object:  this, method:  System.Void Systems.AssetManagement.Assets.AssetCache::BundleCacheReady(Systems.AssetManagement.Bundles.IBundleCache bundleCache)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BundleCacheReady(Systems.AssetManagement.Bundles.IBundleCache bundleCache)
        {
            this._bundleCache = bundleCache;
            this.TryToDispatchPublicInterface();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._assetLoaders.Clear();
            this._bundleCache = 0;
            this._assetLoaders = 0;
        }
    
    }

}
