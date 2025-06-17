using UnityEngine;

namespace Systems.AssetManagement.Assets
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IAssetLoader
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Load(Systems.AssetManagement.Bundles.IBundleCache bundleCache, string bundleName, string assetName); // 0
    
    }

}
