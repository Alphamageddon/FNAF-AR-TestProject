using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixObjects
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct IxTrackedObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string label;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.TileInfo> horizontalTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.TileInfo> verticalTiles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<UnityEngine.Vector3Int> voxels;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float voxelResolution;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxTrackedObject(SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectGeometryUpdate update)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 DiscreteToWorldPoint(UnityEngine.Vector3Int intVertex)
        {
            intVertex.m_Z = intVertex.m_Z & 4294967295;
        }
    
    }

}
