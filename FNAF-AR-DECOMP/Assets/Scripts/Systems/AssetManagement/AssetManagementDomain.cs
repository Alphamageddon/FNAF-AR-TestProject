using UnityEngine;

namespace Systems.AssetManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AssetManagementDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _domainGameObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Assets.AssetCache _assetCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Bundles.BundleCache _bundleCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Files.FileCache _fileCache;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Assets.IAssetCache> AssetCacheAccess { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Bundles.IBundleCache> BundleCacheAccess { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Files.IFileCache> FileCacheAccess { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.AssetManagement.Bundles.IBundleCacheManagement BundleCacheManagement { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Assets.IAssetCache> get_AssetCacheAccess()
        {
            return (Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Assets.IAssetCache>)this._assetCache;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Bundles.IBundleCache> get_BundleCacheAccess()
        {
            return (Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Bundles.IBundleCache>)this._bundleCache;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Files.IFileCache> get_FileCacheAccess()
        {
            return (Utilities.AsyncInterfaceAccess<Systems.AssetManagement.Files.IFileCache>)this._fileCache;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.AssetManagement.Bundles.IBundleCacheManagement get_BundleCacheManagement()
        {
            return (Systems.AssetManagement.Bundles.IBundleCacheManagement)this._bundleCache;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AssetManagementDomain(UnityEngine.Transform parent)
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "AssetManagement");
            this._domainGameObject = val_1;
            val_1.transform.parent = parent;
            Systems.AssetManagement.Files.FileCache val_3 = new Systems.AssetManagement.Files.FileCache(parent:  this._domainGameObject);
            this._fileCache = val_3;
            Systems.AssetManagement.Bundles.BundleCache val_4 = new Systems.AssetManagement.Bundles.BundleCache(parent:  this._domainGameObject, fileCacheAccess:  val_3);
            this._bundleCache = val_4;
            this._assetCache = new Systems.AssetManagement.Assets.AssetCache(bundleCacheAccess:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            if(this._assetCache != null)
            {
                    this._assetCache.Teardown();
            }
            
            this._assetCache = 0;
            if(this._bundleCache != null)
            {
                    this._bundleCache.Teardown();
            }
            
            this._bundleCache = 0;
            if(this._fileCache != null)
            {
                    this._fileCache._fileLoader = 0;
            }
            
            this._fileCache = 0;
            UnityEngine.Object.Destroy(obj:  this._domainGameObject);
            this._domainGameObject = 0;
        }
    
    }

}
