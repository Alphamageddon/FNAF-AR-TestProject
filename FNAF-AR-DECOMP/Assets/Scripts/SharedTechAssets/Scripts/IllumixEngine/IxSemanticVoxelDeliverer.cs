using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSemanticVoxelDeliverer : IIxSemanticVoxelAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<UnityEngine.Vector3, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel> _voxelStore;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.LabelVoxel VoxelLabeledEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.Remove RemovedEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSemanticVoxelDeliverer()
        {
            this._voxelStore = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_VoxelLabeledEvent(SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.LabelVoxel value)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.VoxelLabeledEvent, b:  value);
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
        public static void remove_VoxelLabeledEvent(SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.LabelVoxel value)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.VoxelLabeledEvent, value:  value);
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
        public static void add_RemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.Remove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.RemovedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.RemovedEvent != 1152921505157914632);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_RemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.Remove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.RemovedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.RemovedEvent != 1152921505157914632);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnAddVoxelEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel v)
        {
            this._voxelStore.set_Item(key:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, value:  v);
            if(SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.VoxelLabeledEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.VoxelLabeledEvent.Invoke(voxel:  v);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnUpdateVoxelEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel v)
        {
            if(SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.VoxelLabeledEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.VoxelLabeledEvent.Invoke(voxel:  v);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnRemoveVoxelEvent(UnityEngine.Vector3 coord)
        {
            bool val_1 = this._voxelStore.Remove(key:  new UnityEngine.Vector3() {x = coord.x, y = coord.y, z = coord.z});
            if(SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.RemovedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxSemanticVoxelDeliverer.RemovedEvent.Invoke(center:  new UnityEngine.Vector3() {x = coord.x, y = coord.y, z = coord.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSemanticVoxel GetVoxel(UnityEngine.Vector3 vec)
        {
            if(this._voxelStore != null)
            {
                    return this._voxelStore.Item[new UnityEngine.Vector3() {x = vec.x, y = vec.y, z = vec.z}];
            }
            
            return this._voxelStore.Item[new UnityEngine.Vector3() {x = vec.x, y = vec.y, z = vec.z}];
        }
    
    }

}
