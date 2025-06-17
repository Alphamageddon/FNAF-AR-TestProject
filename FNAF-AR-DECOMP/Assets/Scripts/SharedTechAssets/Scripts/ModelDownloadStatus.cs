using UnityEngine;

namespace SharedTechAssets.Scripts
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ModelDownloadStatus : IModelDownloadStatus, IDownloadProgressAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool hasBeenDownloaded;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModelDownloadStatus()
        {
            this.hasBeenDownloaded = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasBeenDownloaded()
        {
            return (bool)this.hasBeenDownloaded;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDownloadUpdate(string label, int bytesWritten, int totalBytesToWrite)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDownloadComplete(string label, bool didFail)
        {
            if(didFail == true)
            {
                    return;
            }
            
            this.hasBeenDownloaded = true;
        }
    
    }

}
