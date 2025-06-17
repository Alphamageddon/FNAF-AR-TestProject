using UnityEngine;

namespace SharedTechAssets.Scripts.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ModelLoadingHandler : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<CVModels, SharedTechAssets.Scripts.IModelDownloadStatus> ModelDownloadStatuses;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer.ModelType, SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IModelLoader> _modelDownloaders;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.Adapters.IxModelDownloadProgressAdapter _modelDownloadProgressAdapter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const CVModels DEPTH_MODEL = 1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const CVModels OBJDETECT_MODEL = 4;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const CVModels SCENEREC_MODEL = 5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnSetupComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _setupComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<CVModels, SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer.ModelType> cvModelToIxModel;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsSetupComplete { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnSetupComplete(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnSetupComplete, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSetupComplete != 1152921523086124896);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnSetupComplete(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnSetupComplete, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSetupComplete != 1152921523086261472);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsSetupComplete()
        {
            return (bool)this._setupComplete;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupComplete()
        {
            this._setupComplete = true;
            if(this.OnSetupComplete == null)
            {
                    return;
            }
            
            this.OnSetupComplete.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._modelDownloaders = new System.Collections.Generic.Dictionary<ModelType, SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IModelLoader>();
            this.ModelDownloadStatuses = new System.Collections.Generic.Dictionary<CVModels, SharedTechAssets.Scripts.IModelDownloadStatus>();
            this.Setup();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Setup()
        {
            SharedTechAssets.Scripts.TechBootstrap_Config val_1 = this.GetComponent<SharedTechAssets.Scripts.TechBootstrap_Config>();
            this.SetupModelDownloadProgressAdapter();
            this.SetupAllModelLoading(BootstrapConfig:  val_1);
            SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer.Setup(loadableModels:  this._modelDownloaders);
            if(val_1.AutoDownloadModels == false)
            {
                goto label_4;
            }
            
            label_6:
            this.TriggerAutoModelDownloading(config:  val_1);
            goto label_5;
            label_4:
            if(val_1.isRelease == false)
            {
                goto label_6;
            }
            
            label_5:
            this._setupComplete = true;
            if(this.OnSetupComplete == null)
            {
                    return;
            }
            
            this.OnSetupComplete.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupModelDownloadProgressAdapter()
        {
            this._modelDownloadProgressAdapter = new SharedTechAssets.Scripts.Adapters.IxModelDownloadProgressAdapter();
            this._modelDownloadProgressAdapter.Setup(accepter:  new SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupAllModelLoading(SharedTechAssets.Scripts.TechBootstrap_Config BootstrapConfig)
        {
            bool val_4;
            if(BootstrapConfig != null)
            {
                    val_4 = BootstrapConfig.DownloadRequired;
            }
            else
            {
                    val_4 = 0;
            }
            
            if(BootstrapConfig.DepthModelRequired != false)
            {
                    this.SetupModelLoading(model:  1, isLocal:  (val_4 == 0) ? 1 : 0);
            }
            
            if(BootstrapConfig.ObjDetectionRequired != false)
            {
                    this.SetupModelLoading(model:  4, isLocal:  (val_4 == 0) ? 1 : 0);
            }
            
            if(BootstrapConfig.SceneRecognitionRequired == false)
            {
                    return;
            }
            
            this.SetupModelLoading(model:  5, isLocal:  (val_4 == 0) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupModelLoading(CVModels model, bool isLocal)
        {
            SharedTechAssets.Scripts.ModelDownloadStatus val_2 = new SharedTechAssets.Scripts.ModelDownloadStatus();
            System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IDownloadProgressAccepter> val_3 = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IDownloadProgressAccepter>();
            if(val_3 != null)
            {
                    val_3.Add(item:  this._modelDownloadProgressAdapter);
            }
            else
            {
                    val_3.Add(item:  this._modelDownloadProgressAdapter);
            }
            
            val_3.Add(item:  val_2);
            .downloadProgressAccepters = val_3;
            this.ModelDownloadStatuses.set_Item(key:  model, value:  val_2);
            this._modelDownloaders.set_Item(key:  this.cvModelToIxModel.Item[model], value:  new SharedTechAssets.Scripts.ModelLoader(downloadProgressDispenser:  new SharedTechAssets.Scripts.TechInterfaces.Dispensers.DownloadProgressDispenser(), modelName:  model, isModelLocal:  isLocal));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TriggerAutoModelDownloading(SharedTechAssets.Scripts.TechBootstrap_Config config)
        {
            if(config.DepthModelRequired != false)
            {
                    bool val_1 = SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer.TriggerModelLoad(modelType:  1, url:  config.depthEstimationModelURL);
            }
            
            if(config.ObjDetectionRequired != false)
            {
                    bool val_2 = SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer.TriggerModelLoad(modelType:  0, url:  config.objectDetectionModelURL);
            }
            
            if(config.SceneRecognitionRequired == false)
            {
                    return;
            }
            
            bool val_3 = SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer.TriggerModelLoad(modelType:  2, url:  config.sceneRecognitionModelURL);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ModelLoadingHandler()
        {
            System.Collections.Generic.Dictionary<CVModels, ModelType> val_1 = new System.Collections.Generic.Dictionary<CVModels, ModelType>();
            if(val_1 != null)
            {
                    val_1.Add(key:  1, value:  1);
                val_1.Add(key:  4, value:  0);
            }
            else
            {
                    val_1.Add(key:  1, value:  1);
                val_1.Add(key:  4, value:  0);
            }
            
            val_1.Add(key:  5, value:  2);
            this.cvModelToIxModel = val_1;
        }
    
    }

}
