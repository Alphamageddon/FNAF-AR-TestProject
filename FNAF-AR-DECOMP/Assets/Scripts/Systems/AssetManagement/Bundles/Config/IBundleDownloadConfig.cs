using UnityEngine;

namespace Systems.AssetManagement.Bundles.Config
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public interface IBundleDownloadConfig
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetServerTableOfContentsString(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.IEnumerable<Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig> GetBundleDownloadSegmentConfigs(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetS3BundleUri(UnityEngine.CachedAssetBundle info); // 0
    
    }

}
