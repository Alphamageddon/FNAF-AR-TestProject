using UnityEngine;

namespace Systems.AssetManagement.Bundles
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IBundleCacheManagement
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void StartWithLocalBundlesOnly(Systems.AssetManagement.Bundles.Config.ILocalBundleConfig localBundleConfig, System.Action<int> bundlesFullyLoadedCallback); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void StartWithDownloadedBundles(Systems.AssetManagement.Bundles.Config.ILocalBundleConfig localBundleConfig, Systems.AssetManagement.Bundles.Config.IBundleDownloadConfig bundleDownloadConfig, System.Action readyCallback, System.Action<int> bundlesFullyLoadedCallback); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void DownloadRemainingBundleSegments(System.Action<Systems.AssetManagement.Bundles.BundleDownloadProgressData> progressCallback); // 0
    
    }

}
