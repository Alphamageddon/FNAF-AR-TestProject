using UnityEngine;

namespace SharedTechAssets.Scripts.Adapters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxModelDownloadProgressAdapter : IDownloadProgressAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxModelDownloadProgressAccepter _accepter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxModelDownloadProgressAccepter accepter)
        {
            this._accepter = accepter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDownloadUpdate(string label, int bytesWritten, int totalBytesToWrite)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._accepter.OnUpdateEvent(label:  label, bytesWritten:  bytesWritten, totalBytesToWrite:  totalBytesToWrite);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDownloadComplete(string label, bool didFail)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            didFail = didFail;
            this._accepter.OnCompleteEvent(label:  label, didFail:  didFail);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxModelDownloadProgressAdapter()
        {
        
        }
    
    }

}
