using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public struct ObjectTrackingManager.TileInfo
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector2 center;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int planeId;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ObjectTrackingManager.TileInfo(UnityEngine.Vector2 center, int planeId)
    {
        mem[1152921523079269568] = center.x;
        mem[1152921523079269572] = center.y;
        mem[1152921523079269576] = planeId;
    }

}
