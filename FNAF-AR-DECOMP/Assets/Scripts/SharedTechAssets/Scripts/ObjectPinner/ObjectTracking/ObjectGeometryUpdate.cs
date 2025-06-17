using UnityEngine;

namespace SharedTechAssets.Scripts.ObjectPinner.ObjectTracking
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct ObjectGeometryUpdate
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int objId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string label;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float voxelResolution;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.TileUpdateInfo> horizontalTileUpdateInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.TileUpdateInfo> verticalTileUpdateInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.VoxelUpdateInfo> voxelUpdateInfo;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ObjectGeometryUpdate(int objId, string label, float voxelResolution)
        {
        
        }
    
    }

}
