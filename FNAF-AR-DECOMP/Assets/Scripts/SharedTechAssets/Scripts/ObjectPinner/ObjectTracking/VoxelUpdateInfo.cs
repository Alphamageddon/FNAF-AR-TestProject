using UnityEngine;

namespace SharedTechAssets.Scripts.ObjectPinner.ObjectTracking
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct VoxelUpdateInfo
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3Int coord;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isAdd;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VoxelUpdateInfo(UnityEngine.Vector3Int coord, bool isAdd)
        {
            mem[1152921523073716608] = coord.m_X;
            mem[1152921523073716612] = coord.m_Y;
            mem[1152921523073716616] = coord.m_Z;
            mem[1152921523073716620] = isAdd;
        }
    
    }

}
