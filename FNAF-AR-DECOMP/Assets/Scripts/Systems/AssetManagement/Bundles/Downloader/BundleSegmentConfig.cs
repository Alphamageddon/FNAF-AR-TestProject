using UnityEngine;

namespace Systems.AssetManagement.Bundles.Downloader
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BundleSegmentConfig
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly string SegmentName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly System.Collections.Generic.List<string> BundleNames;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int ConcurrentMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<string> SegmentCompleteCallback;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BundleSegmentConfig(string segmentName, System.Collections.Generic.List<string> bundleNames, int concurrentMax, System.Action<string> segmentCompleteCallback)
        {
            val_1 = new System.Object();
            this.SegmentName = segmentName;
            this.BundleNames = val_1;
            this.ConcurrentMax = concurrentMax;
            this.SegmentCompleteCallback = segmentCompleteCallback;
        }
    
    }

}
