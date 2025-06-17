using UnityEngine;

namespace Game.AssetManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AssetBundleVersionInfo
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int Version;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string VersionBucketUri;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string BundleBucketUri;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string CvBucketUri;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AssetBundleVersionInfo(int version, string versionBucketUri, string bundleBucketUri, string cvBucketUri)
        {
            val_1 = new System.Object();
            this.Version = version;
            this.VersionBucketUri = val_1;
            this.BundleBucketUri = bundleBucketUri;
            this.CvBucketUri = cvBucketUri;
        }
    
    }

}
