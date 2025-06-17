using UnityEngine;

namespace SharedTechAssets.Scripts.TSDF2
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VoxelBlock
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> tsdfCoords;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VoxelBlock(int blockSize)
        {
            this.tsdfCoords = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
        }
    
    }

}
