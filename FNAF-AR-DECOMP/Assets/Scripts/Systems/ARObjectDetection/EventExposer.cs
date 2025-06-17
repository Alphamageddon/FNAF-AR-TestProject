using UnityEngine;

namespace Systems.ARObjectDetection
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EventExposer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnObjectDetectionBeginEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[]> OnObjectDetectionUpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Systems.ARObjectDetection.ARObjectDetectionDomain _arObjectDetectionDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnObjectDetectionBeginEvent(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnObjectDetectionBeginEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnObjectDetectionBeginEvent != 1152921523437312416);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnObjectDetectionBeginEvent(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnObjectDetectionBeginEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnObjectDetectionBeginEvent != 1152921523437448992);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnObjectDetectionUpdatedEvent(System.Action<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[]> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnObjectDetectionUpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnObjectDetectionUpdatedEvent != 1152921523437585576);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnObjectDetectionUpdatedEvent(System.Action<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[]> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnObjectDetectionUpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnObjectDetectionUpdatedEvent != 1152921523437722152);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EventExposer(Systems.ARObjectDetection.ARObjectDetectionDomain arObjectDetectionDomain)
        {
            this._arObjectDetectionDomain = arObjectDetectionDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerOnObjectDetectionBeginEvent()
        {
            if(this.OnObjectDetectionBeginEvent == null)
            {
                    return;
            }
            
            this.OnObjectDetectionBeginEvent.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerOnObjectDetectionUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] detectedObjects)
        {
            if(this.OnObjectDetectionUpdatedEvent == null)
            {
                    return;
            }
            
            this.OnObjectDetectionUpdatedEvent.Invoke(obj:  detectedObjects);
        }
    
    }

}
