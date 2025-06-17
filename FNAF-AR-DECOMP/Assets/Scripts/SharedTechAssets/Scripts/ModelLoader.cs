using UnityEngine;

namespace SharedTechAssets.Scripts
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ModelLoader : IModelLoader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.Dispensers.DownloadProgressDispenser _downloadProgressDispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isModelDownloaded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly CVModels MODEL_NAME;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isModelLocal;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModelLoader(SharedTechAssets.Scripts.TechInterfaces.Dispensers.DownloadProgressDispenser downloadProgressDispenser, CVModels modelName, bool isModelLocal)
        {
            this._downloadProgressDispenser = downloadProgressDispenser;
            this.MODEL_NAME = modelName;
            this._isModelLocal = isModelLocal;
            UnityCVManager.Instance.SetupDownloadProgressCallback(modelType:  this.MODEL_NAME, callback:  new UnityCVManager.DownloadProgressUpdate(object:  this, method:  System.Void SharedTechAssets.Scripts.ModelLoader::DownloadProgressCallback(int modelIndex, int bytesWritten, int totalBytesToWrite)));
            UnityCVManager.Instance.SetupDownloadCompleteCallback(modelType:  this.MODEL_NAME, callback:  new UnityCVManager.DownloadComplete(object:  this, method:  System.Void SharedTechAssets.Scripts.ModelLoader::DownloadCompleteCallback(int modelIndex, bool failed)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DownloadCompleteCallback(int modelIndex, bool failed)
        {
            if(failed != true)
            {
                    this._isModelDownloaded = true;
            }
            
            this._downloadProgressDispenser.SendDownloadCompleteEvent(label:  this.MODEL_NAME.ToString(format:  "G"), didFail:  failed);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DownloadProgressCallback(int modelIndex, int bytesWritten, int totalBytesToWrite)
        {
            this._downloadProgressDispenser.SendDownloadUpdateEvent(label:  this.MODEL_NAME.ToString(format:  "G"), bytesWritten:  bytesWritten, totalBytesToWrite:  totalBytesToWrite);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadModel(string url)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DownloadModel(string url)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadModelLocally()
        {
        
        }
    
    }

}
