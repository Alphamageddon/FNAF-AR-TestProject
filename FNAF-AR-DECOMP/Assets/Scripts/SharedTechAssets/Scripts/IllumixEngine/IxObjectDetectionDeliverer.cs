using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxObjectDetectionDeliverer : IIxObjectDetectionAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.Update UpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.Begin BeginEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_UpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.Update value)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.UpdatedEvent, b:  value);
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
        public static void remove_UpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.Update value)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.UpdatedEvent, value:  value);
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
        public static void add_BeginEvent(SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.Begin value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.BeginEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.BeginEvent != 1152921505157648392);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_BeginEvent(SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.Begin value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.BeginEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.BeginEvent != 1152921505157648392);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnObjectDetectionUpdate(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detections)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.UpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.UpdatedEvent.Invoke(detections:  detections);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnObjectDetectionBegin()
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.BeginEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxObjectDetectionDeliverer.BeginEvent.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxObjectDetectionDeliverer()
        {
        
        }
    
    }

}
