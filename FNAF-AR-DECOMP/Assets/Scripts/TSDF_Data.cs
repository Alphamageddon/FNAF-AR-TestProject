using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public struct TSDF_Manager.TSDF_Data
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, SharedTechAssets.Scripts.TSDF2.Voxel>> tsdfStore;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, SharedTechAssets.Scripts.TSDF2.VoxelBlock> cachedBlocks;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, bool>> lastUpdatedBlocks;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> blocksToUpdateCoords;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<SharedTechAssets.Scripts.TSDF2.TSDF_Manager.CoordUpdate> coordsToUpdate;
    

}
