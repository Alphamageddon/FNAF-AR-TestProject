using UnityEngine;

namespace Game.AssetManagement.Downloader
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TableOfContentsDownloader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _masterEventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.AssetManagement.Files.IFileCache _fileCache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _fileUri;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _successCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<int> _failureCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _tableOfContentsFailureCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _tableOfContentsRetryCooldown;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly SimpleTimer _tableOfContentsRetry;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TableOfContentsDownloader(Systems.AssetManagement.Files.IFileCache fileCache, string fileUri, System.Action<string> successCallback, System.Action<int> failureCallback)
        {
            this._tableOfContentsRetryCooldown = 10;
            this._tableOfContentsRetry = new SimpleTimer();
            val_2 = new System.Object();
            this._fileCache = fileCache;
            this._fileUri = val_2;
            this._successCallback = successCallback;
            this._failureCallback = failureCallback;
            this.RequestTableOfContents();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._fileCache = 0;
            this._successCallback = 0;
            this._failureCallback = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            if(this._tableOfContentsRetry.Started() == false)
            {
                    return;
            }
            
            if(this._tableOfContentsRetry.IsExpired() == false)
            {
                    return;
            }
            
            this.RequestTableOfContents();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RequestTableOfContents()
        {
            IntPtr val_5;
            this._tableOfContentsRetry.Reset();
            .FilePath = this._fileUri;
            .FileLoadSuccess = new System.Action<Systems.AssetManagement.Files.FileLoadSettings, UnityEngine.Networking.DownloadHandler>(object:  this, method:  System.Void Game.AssetManagement.Downloader.TableOfContentsDownloader::DownloadSuccess(Systems.AssetManagement.Files.FileLoadSettings settings, UnityEngine.Networking.DownloadHandler downloadHandler));
            System.Action<Systems.AssetManagement.Files.FileLoadSettings> val_3 = null;
            val_5 = System.Void Game.AssetManagement.Downloader.TableOfContentsDownloader::DownloadFailure(Systems.AssetManagement.Files.FileLoadSettings settings);
            val_3 = new System.Action<Systems.AssetManagement.Files.FileLoadSettings>(object:  this, method:  val_5);
            .FileLoadFailure = val_3;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = 0;
            this._fileCache.LoadFileFromPath(settings:  new Systems.AssetManagement.Files.FileLoadSettings());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DownloadSuccess(Systems.AssetManagement.Files.FileLoadSettings settings, UnityEngine.Networking.DownloadHandler downloadHandler)
        {
            if(this._successCallback != null)
            {
                    this._successCallback.Invoke(obj:  downloadHandler.text);
            }
            
            this._successCallback = 0;
            mem[1152921525504616224] = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DownloadFailure(Systems.AssetManagement.Files.FileLoadSettings settings)
        {
            ConsoleLogger.LogError(className:  "TableOfContentsDownloader", functionName:  "DownloadFailure", logString:  System.String.Format(format:  "Failed to load server bundle table of contents from \'{0}\'. Retry in {1} seconds", arg0:  settings.FilePath, arg1:  this._tableOfContentsRetryCooldown));
            if(this._failureCallback != null)
            {
                    int val_2 = this._tableOfContentsFailureCount + 1;
                this._tableOfContentsFailureCount = val_2;
                this._failureCallback.Invoke(obj:  val_2);
            }
            
            this._tableOfContentsRetry.StartTimer(time:  (float)this._tableOfContentsRetryCooldown);
            int val_3 = this._tableOfContentsRetryCooldown;
            val_3 = val_3 << 1;
            this._tableOfContentsRetryCooldown = val_3;
        }
    
    }

}
