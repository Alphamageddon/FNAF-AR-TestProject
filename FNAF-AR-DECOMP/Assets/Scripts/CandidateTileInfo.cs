using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public struct SemanticVerticalPlaneTracker.CandidateTileInfo
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int planeId;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector2 key;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int collidedObjectId;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SemanticVerticalPlaneTracker.CandidateTileInfo(int planeId, UnityEngine.Vector2 key)
    {
        mem[1152921524708492896] = planeId;
        mem[1152921524708492900] = key.x;
        mem[1152921524708492904] = key.y;
        mem[1152921524708492908] = 0;
    }

}
