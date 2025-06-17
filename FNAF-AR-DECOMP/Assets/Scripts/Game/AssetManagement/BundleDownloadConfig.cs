using UnityEngine;

namespace Game.AssetManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BundleDownloadConfig : IBundleDownloadConfig
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _s3BucketPrefix;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _serverTableOfContentsString;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig> _segmentConfigs;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetServerTableOfContentsString()
        {
            return (string)this._serverTableOfContentsString;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.IEnumerable<Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig> GetBundleDownloadSegmentConfigs()
        {
            return (System.Collections.Generic.IEnumerable<Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig>)this._segmentConfigs;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetS3BundleUri(UnityEngine.CachedAssetBundle info)
        {
            return (string)System.String.Format(format:  "{0}/{1}", arg0:  this._s3BucketPrefix, arg1:  1152921525493662544);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BundleDownloadConfig(string s3BucketPrefix, string serverTableOfContentsString, System.Collections.Generic.List<Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig> segmentConfigs)
        {
            val_1 = new System.Object();
            this._s3BucketPrefix = s3BucketPrefix;
            this._serverTableOfContentsString = val_1;
            this._segmentConfigs = segmentConfigs;
        }
    
    }

}
