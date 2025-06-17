using UnityEngine;

namespace Systems.AssetManagement.Bundles
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IBundleCache
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void LoadAssetBundleAsync(string bundleName, Systems.AssetManagement.Bundles.BundleLoadSuccess onSuccess, Systems.AssetManagement.Bundles.BundleLoadFailure onFailure); // 0
    
    }

}
