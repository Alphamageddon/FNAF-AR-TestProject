using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxTrackedObjectDeliverer : IIxTrackedObjectAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<int, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject> idToObj;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.Add AddedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.Update UpdatedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.Remove RemovedEvent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxTrackedObjectDeliverer()
        {
            this.idToObj = new System.Collections.Generic.Dictionary<System.Int32, SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_AddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.Add value)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.AddedEvent, b:  value);
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
        public static void remove_AddedEvent(SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.Add value)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.AddedEvent, value:  value);
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
        public static void add_UpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.Update value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.UpdatedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.UpdatedEvent != 1152921505158074376);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_UpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.Update value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.UpdatedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.UpdatedEvent != 1152921505158074376);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void add_RemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.Remove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.RemovedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.RemovedEvent != 1152921505158074384);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void remove_RemovedEvent(SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.Remove value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.RemovedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.RemovedEvent != 1152921505158074384);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddTrackedObject(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject obj)
        {
            this.idToObj.set_Item(key:  obj.id, value:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject() {id = obj.id, horizontalTiles = obj.horizontalTiles, verticalTiles = obj.horizontalTiles, voxels = obj.voxels, voxelResolution = 3.885789E+09f});
            if(SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.AddedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.AddedEvent.Invoke(obj:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject() {id = obj.id, horizontalTiles = obj.horizontalTiles, verticalTiles = obj.horizontalTiles, voxels = obj.voxels, voxelResolution = 3.885789E+09f});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateTrackedObject(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject obj, SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update)
        {
            var val_1 = 1152921523119092256;
            this.idToObj.set_Item(key:  obj.id, value:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject() {id = obj.id, horizontalTiles = obj.horizontalTiles, verticalTiles = obj.horizontalTiles, voxels = obj.voxels, voxelResolution = 3.932299E+09f});
            if(SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.UpdatedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.UpdatedEvent.Invoke(obj:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject() {id = obj.id, horizontalTiles = obj.horizontalTiles, verticalTiles = obj.horizontalTiles, voxels = obj.voxels, voxelResolution = 3.932299E+09f}, update:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate() {objId = update.objId, voxelResolution = update.voxelResolution, verticalTileUpdateInfo = update.verticalTileUpdateInfo, voxelUpdateInfo = update.verticalTileUpdateInfo});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveTrackedObject(int objId)
        {
            bool val_1 = this.idToObj.Remove(key:  objId);
            if(SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.RemovedEvent == null)
            {
                    return;
            }
            
            SharedTechAssets.Scripts.IllumixEngine.IxTrackedObjectDeliverer.RemovedEvent.Invoke(objId:  objId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject GetObject(int objId)
        {
            if(this.idToObj != null)
            {
                    return this.idToObj.Item[objId];
            }
            
            return this.idToObj.Item[objId];
        }
    
    }

}
