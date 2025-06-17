using UnityEngine;

namespace Game.AssetManagement.Downloader
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CvModelDownloader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _cvUri;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _callback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _cvRetryCooldown;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _cvRetry;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CvModelDownloader(string uri, System.Action completeCallback)
        {
            this._cvRetryCooldown = 10;
            this._cvRetry = new SimpleTimer();
            this._cvUri = uri;
            this._callback = completeCallback;
            this.StartDownloadingCvModel();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._callback = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._cvRetry.Started() == false)
            {
                    return;
            }
            
            if(this._cvRetry.IsExpired() == false)
            {
                    return;
            }
            
            bool val_3 = SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer.TriggerModelLoad(modelType:  0, url:  this._cvUri);
            this._cvRetry.Reset();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartDownloadingCvModel()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.add_UpdatedEvent(value:  new IxModelDownloadProgressDeliverer.Update(object:  this, method:  System.Void Game.AssetManagement.Downloader.CvModelDownloader::IxModelDownloadProgressUpdated(string label, int bytesWritten, int totalBytesToWrite)));
            SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.add_CompletedEvent(value:  new IxModelDownloadProgressDeliverer.Complete(object:  this, method:  System.Void Game.AssetManagement.Downloader.CvModelDownloader::IxModelDownloadProgressCompleted(string label, bool didFail)));
            bool val_3 = SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer.TriggerModelLoad(modelType:  0, url:  this._cvUri);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IxModelDownloadProgressUpdated(string label, int bytesWritten, int totalBytesToWrite)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IxModelDownloadProgressCompleted(string label, bool didFail)
        {
            if(didFail != false)
            {
                    ConsoleLogger.LogError(className:  "CvModelDownloader", functionName:  "IxModelDownloadProgressCompleted", logString:  System.String.Format(format:  "Downloading CV Model from \'{0}\' failed. Retry in {1} seconds", arg0:  this._cvUri, arg1:  this._cvRetryCooldown));
                this._cvRetry.StartTimer(time:  (float)this._cvRetryCooldown);
                int val_4 = this._cvRetryCooldown;
                val_4 = val_4 << 1;
                this._cvRetryCooldown = val_4;
                return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.remove_UpdatedEvent(value:  new IxModelDownloadProgressDeliverer.Update(object:  this, method:  System.Void Game.AssetManagement.Downloader.CvModelDownloader::IxModelDownloadProgressUpdated(string label, int bytesWritten, int totalBytesToWrite)));
            SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.remove_CompletedEvent(value:  new IxModelDownloadProgressDeliverer.Complete(object:  this, method:  System.Void Game.AssetManagement.Downloader.CvModelDownloader::IxModelDownloadProgressCompleted(string label, bool didFail)));
            if(this._callback != null)
            {
                    this._callback.Invoke();
            }
            
            this._callback = 0;
        }
    
    }

}
