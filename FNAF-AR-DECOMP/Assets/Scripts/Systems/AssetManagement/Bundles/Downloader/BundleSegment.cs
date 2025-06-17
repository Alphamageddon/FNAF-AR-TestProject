using UnityEngine;

namespace Systems.AssetManagement.Bundles.Downloader
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BundleSegment
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Queue<Systems.AssetManagement.Bundles.BundleState> BundleStates;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsStartingBundleDownloads;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<string> InProgressDownloads;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsDownloadComplete;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BundleSegment(Systems.AssetManagement.Bundles.Downloader.BundleSegmentConfig config)
        {
            this.Config = config;
            this.BundleStates = new System.Collections.Generic.Queue<Systems.AssetManagement.Bundles.BundleState>();
            this.InProgressDownloads = new System.Collections.Generic.HashSet<System.String>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void MarkFinished()
        {
            if(this.Config.SegmentCompleteCallback != null)
            {
                    this.Config.SegmentCompleteCallback.Invoke(obj:  this.Config.SegmentName);
            }
            
            this.Config.SegmentCompleteCallback = 0;
            this.Teardown();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Teardown()
        {
            this.IsDownloadComplete = true;
            this.InProgressDownloads.Clear();
            this.InProgressDownloads = 0;
            this.BundleStates.Clear();
            this.Config = 0;
            this.BundleStates = 0;
        }
    
    }

}
