using UnityEngine;

namespace SharedTechAssets.Scripts.Adapters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxTrackedObjectAdapter : ITrackedObjectAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxTrackedObjectAccepter _accepter;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(SharedTechAssets.Scripts.TechInterfaces.IllumixObjectInterfaces.Accepters.IIxTrackedObjectAccepter accepter)
        {
            this._accepter = accepter;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddObject(SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._accepter.AddTrackedObject(obj:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject() {voxelResolution = 0f});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateObject(SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update)
        {
            System.Collections.Generic.HashSet<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.TileInfo> val_3;
            System.Collections.Generic.HashSet<UnityEngine.Vector3Int> val_4;
            int val_5;
            var val_7 = 0;
            val_7 = val_7 + 1;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject val_2 = this._accepter.GetObject(objId:  update.objId);
            var val_8 = 0;
            val_8 = val_8 + 1;
            this._accepter.UpdateTrackedObject(obj:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxTrackedObject() {id = val_5, label = val_5, horizontalTiles = val_3, verticalTiles = val_3, voxels = val_4, voxelResolution = val_4}, update:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate() {objId = update.objId, voxelResolution = update.voxelResolution, verticalTileUpdateInfo = update.verticalTileUpdateInfo, voxelUpdateInfo = update.verticalTileUpdateInfo});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveObject(int objId)
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this._accepter.RemoveTrackedObject(objId:  objId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxTrackedObjectAdapter()
        {
        
        }
    
    }

}
