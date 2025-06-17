using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxMeshBlockDeliverer : IIxMeshBlockAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxMeshBlockDeliverer.SurfaceMeshBlockUpdate SurfaceMeshBlockUpdatedEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_SurfaceMeshBlockUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxMeshBlockDeliverer.SurfaceMeshBlockUpdate value)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxMeshBlockDeliverer.SurfaceMeshBlockUpdatedEvent, b:  value);
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
        public static void remove_SurfaceMeshBlockUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxMeshBlockDeliverer.SurfaceMeshBlockUpdate value)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxMeshBlockDeliverer.SurfaceMeshBlockUpdatedEvent, value:  value);
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
        public void OnMeshBlockAddedEvent(IllumixMeshBlock meshBlock)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxMeshBlockDeliverer.SurfaceMeshBlockUpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxMeshBlockDeliverer.SurfaceMeshBlockUpdatedEvent.Invoke(obj:  meshBlock);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxMeshBlockDeliverer()
        {
        
        }
    
    }

}
