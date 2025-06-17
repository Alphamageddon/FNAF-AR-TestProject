using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxModelDownloadProgressDeliverer : IIxModelDownloadProgressAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.Update UpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.Complete CompletedEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_UpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.Update value)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.UpdatedEvent, b:  value);
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
        public static void remove_UpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.Update value)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.UpdatedEvent, value:  value);
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
        public static void add_CompletedEvent(SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.Complete value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.CompletedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.CompletedEvent != 1152921505157488648);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_CompletedEvent(SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.Complete value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.CompletedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.CompletedEvent != 1152921505157488648);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnUpdateEvent(string label, int bytesWritten, int totalBytesToWrite)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.UpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.UpdatedEvent.Invoke(label:  label, bytesWritten:  bytesWritten, totalBytesToWrite:  totalBytesToWrite);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnCompleteEvent(string label, bool didFail)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.CompletedEvent == null)
            {
                    return;
            }
            
            didFail = didFail;
            SharedTechAssets.Scripts.IllumixEngine.IxModelDownloadProgressDeliverer.CompletedEvent.Invoke(label:  label, didFail:  didFail);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxModelDownloadProgressDeliverer()
        {
        
        }
    
    }

}
