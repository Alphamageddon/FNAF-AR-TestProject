using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Dispensers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DownloadProgressDispenser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IDownloadProgressAccepter> downloadProgressAccepters;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddAccepter(SharedTechAssets.Scripts.TechInterfaces.Accepters.IDownloadProgressAccepter accepter)
        {
            this.downloadProgressAccepters.Add(item:  accepter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAccepters(System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IDownloadProgressAccepter> accepters)
        {
            this.downloadProgressAccepters = accepters;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendDownloadUpdateEvent(string label, int bytesWritten, int totalBytesToWrite)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.downloadProgressAccepters.Item[0].OnDownloadUpdate(label:  label, bytesWritten:  bytesWritten, totalBytesToWrite:  totalBytesToWrite);
            0 = 1;
            label_1:
            if(0 < this.downloadProgressAccepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendDownloadCompleteEvent(string label, bool didFail)
        {
            goto label_1;
            label_9:
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.downloadProgressAccepters.Item[0].OnDownloadComplete(label:  label, didFail:  didFail);
            0 = 1;
            label_1:
            if(0 < this.downloadProgressAccepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DownloadProgressDispenser()
        {
            this.downloadProgressAccepters = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IDownloadProgressAccepter>();
        }
    
    }

}
