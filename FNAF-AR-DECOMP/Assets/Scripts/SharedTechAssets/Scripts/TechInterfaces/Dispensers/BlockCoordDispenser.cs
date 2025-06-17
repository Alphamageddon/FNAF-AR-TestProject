using UnityEngine;

namespace SharedTechAssets.Scripts.TechInterfaces.Dispensers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BlockCoordDispenser
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IBlockCoordAccepter> _blockCoordAccepters;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddAccepter(SharedTechAssets.Scripts.TechInterfaces.Accepters.IBlockCoordAccepter accepter)
        {
            this._blockCoordAccepters.Add(item:  accepter);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAccepters(System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IBlockCoordAccepter> accepters)
        {
            this._blockCoordAccepters = accepters;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateBlockEvent(UnityEngine.Vector3 center, System.Collections.Generic.List<UnityEngine.Vector3> pointsToAdd, System.Collections.Generic.List<UnityEngine.Vector3> pointsToRemove)
        {
            goto label_1;
            label_9:
            var val_4 = 0;
            val_4 = val_4 + 1;
            this._blockCoordAccepters.Item[0].OnBlockUpdatedEvent(center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, pointsToAdd:  pointsToAdd, pointsToRemove:  pointsToRemove);
            0 = 1;
            label_1:
            if(0 < this._blockCoordAccepters.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BlockCoordDispenser()
        {
            this._blockCoordAccepters = new System.Collections.Generic.List<SharedTechAssets.Scripts.TechInterfaces.Accepters.IBlockCoordAccepter>();
        }
    
    }

}
