using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public struct ObjectTrackingManager.ObjectGeometry
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string label;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int id;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.HashSet<SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectTrackingManager.TileInfo> horizontalTiles;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.HashSet<SharedTechAssets.Scripts.ObjectPinner.ObjectTracking.ObjectTrackingManager.TileInfo> verticalTiles;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float voxelResolution;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.HashSet<UnityEngine.Vector3Int> voxels;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ObjectTrackingManager.ObjectGeometry(string label, int id, float voxelResolution)
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int GetSize()
    {
    
    }

}
