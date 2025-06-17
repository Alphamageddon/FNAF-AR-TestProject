using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSceneRecognitionDeliverer : IIxSceneRecognitionAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxSceneRecognitionDeliverer.Update UpdatedEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_UpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxSceneRecognitionDeliverer.Update value)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxSceneRecognitionDeliverer.UpdatedEvent, b:  value);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_UpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxSceneRecognitionDeliverer.Update value)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxSceneRecognitionDeliverer.UpdatedEvent, value:  value);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnSceneRecognitionUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSceneRecognition detections)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxSceneRecognitionDeliverer.UpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxSceneRecognitionDeliverer.UpdatedEvent.Invoke(recognition:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSceneRecognition() {SceneLabels = detections.SceneLabels, SceneProbs = detections.SceneProbs});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSceneRecognitionDeliverer()
        {
        
        }
    
    }

}
