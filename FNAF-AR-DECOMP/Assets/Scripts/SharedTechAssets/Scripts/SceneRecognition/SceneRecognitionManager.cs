using UnityEngine;

namespace SharedTechAssets.Scripts.SceneRecognition
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SceneRecognitionManager : ITimeUpdateAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.SceneRecognition.SceneRecognition_Config Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.Dispensers.SceneRecognitionDispenser _dispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.IModelDownloadStatus _modelDownloadStatus;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string MODEL_NAME = "GoogLeNet";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long lastFire;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool isModelDownloaded;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool pendingResponse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool initModel;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(SharedTechAssets.Scripts.SceneRecognition.SceneRecognition_Config config, SharedTechAssets.Scripts.TechInterfaces.Dispensers.SceneRecognitionDispenser dispenser, SharedTechAssets.Scripts.IModelDownloadStatus modelDownloadStatus)
        {
            this.Config = config;
            this._dispenser = dispenser;
            this._modelDownloadStatus = modelDownloadStatus;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TimeUpdateEvent()
        {
            if(this.isModelDownloaded != true)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                bool val_2 = this._modelDownloadStatus.HasBeenDownloaded();
                this.isModelDownloaded = val_2;
                if(val_2 == false)
            {
                    return;
            }
            
            }
            
            bool val_8 = this.pendingResponse;
            val_8 = val_8 + 3;
            var val_9 = ~val_8;
            val_9 = val_9 & 3;
            if(val_9 != 0)
            {
                    return;
            }
            
            System.DateTime val_4 = System.DateTime.UtcNow;
            long val_5 = val_4.dateData.Ticks;
            if(this.Config.enableSceneRecognition == false)
            {
                    return;
            }
            
            if((1844674407370955 - this.lastFire) <= this.Config.updateFrequency)
            {
                    return;
            }
            
            this.pendingResponse = true;
            this.lastFire = 1844674407370955;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CoreMLFrameUpdated(int index, string[] strings, float[] floats, int floatsW, int floatsH, double[] depth, int w, int h)
        {
            if(strings.Length >= 1)
            {
                    this._dispenser.SendSceneRecognitionEvent(labels:  strings, probs:  floats);
            }
            
            this.pendingResponse = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SceneRecognitionManager()
        {
            this.initModel = true;
        }
    
    }

}
