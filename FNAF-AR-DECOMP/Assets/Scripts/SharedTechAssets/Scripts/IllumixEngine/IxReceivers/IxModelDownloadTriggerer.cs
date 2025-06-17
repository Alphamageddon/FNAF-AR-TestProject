using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IxReceivers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxModelDownloadTriggerer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static bool _initialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer.ModelType, SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IModelLoader> _loadableModels;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool TriggerModelLoad(SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer.ModelType modelType, string url)
        {
            System.Collections.Generic.Dictionary<ModelType, SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IModelLoader> val_4;
            var val_5;
            var val_7;
            var val_8;
            var val_10;
            val_5 = null;
            val_5 = null;
            if(SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer._initialized == false)
            {
                goto label_7;
            }
            
            val_4 = SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer._loadableModels;
            if((val_4.ContainsKey(key:  modelType)) == false)
            {
                goto label_7;
            }
            
            val_7 = null;
            val_7 = null;
            val_4 = SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer._loadableModels;
            val_8 = public SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IModelLoader System.Collections.Generic.Dictionary<ModelType, SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IModelLoader>::get_Item(ModelType key);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_8 = 0;
            goto label_15;
            label_7:
            val_10 = 0;
            return (bool)val_10;
            label_15:
            val_4.Item[modelType].LoadModel(url:  url);
            val_10 = 1;
            return (bool)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Setup(System.Collections.Generic.Dictionary<SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer.ModelType, SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IModelLoader> loadableModels)
        {
            null = null;
            SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer._initialized = true;
            SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer._loadableModels = loadableModels;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxModelDownloadTriggerer()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static IxModelDownloadTriggerer()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer._initialized = false;
            SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IxModelDownloadTriggerer._loadableModels = new System.Collections.Generic.Dictionary<ModelType, SharedTechAssets.Scripts.IllumixEngine.IxReceivers.IModelLoader>();
        }
    
    }

}
