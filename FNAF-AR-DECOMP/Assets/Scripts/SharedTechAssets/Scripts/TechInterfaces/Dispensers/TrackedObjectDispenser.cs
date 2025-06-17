using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Dispensers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TrackedObjectDispenser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ITrackedObjectAccepter> _accepters;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddAccepter(SharedTechAssets.Scripts.TechInterfaces.Accepters.ITrackedObjectAccepter accepter)
        {
            this._accepters.Add(item:  accepter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAccepters(System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ITrackedObjectAccepter> accepters)
        {
            this._accepters = accepters;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddObject(SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update)
        {
            var val_5;
            var val_6;
            val_5 = 1152921523061807920;
            val_6 = 0;
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepters.Item[0].AddObject(update:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate() {objId = update.objId, voxelResolution = update.voxelResolution, verticalTileUpdateInfo = update.verticalTileUpdateInfo, voxelUpdateInfo = update.verticalTileUpdateInfo});
            val_6 = 1;
            label_1:
            if(val_6 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateObject(SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update)
        {
            var val_5;
            var val_6;
            val_5 = 1152921523061985424;
            val_6 = 0;
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._accepters.Item[0].UpdateObject(update:  new SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate() {objId = update.objId, voxelResolution = update.voxelResolution, verticalTileUpdateInfo = update.verticalTileUpdateInfo, voxelUpdateInfo = update.verticalTileUpdateInfo});
            val_6 = 1;
            label_1:
            if(val_6 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveObject(int objId)
        {
            var val_4;
            var val_5;
            val_4 = 0;
            goto label_1;
            label_9:
            val_5 = public SharedTechAssets.Scripts.TechInterfaces.Accepters.ITrackedObjectAccepter System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ITrackedObjectAccepter>::get_Item(int index);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_5 = 2;
            this._accepters.Item[0].RemoveObject(objId:  objId);
            val_4 = 1;
            label_1:
            if(val_4 < this._accepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TrackedObjectDispenser()
        {
            this._accepters = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.ITrackedObjectAccepter>();
        }
    
    }

}
