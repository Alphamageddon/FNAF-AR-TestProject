using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public interface IIllumixObjectAccepter
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnTileAddEvent(IllumixTile tile); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnTileRemoveEvent(UnityEngine.Vector3 center); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnMeshBlockAddedEvent(IllumixMeshBlock meshBlock); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnDirectedPointUpdate(IllumixDirectedPoint[] points); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnHorizontalBoundedPlaneAddEvent(IllumixHorizontalBoundedPlane plane); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnHorizontalBoundedPlaneUpdateEvent(int key); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnHorizontalBoundedPlaneRemoveEvent(int key); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnVerticalBoundedPlaneAddEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane plane); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnVerticalBoundedPlaneUpdateEvent(int key); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnVerticalBoundedPlaneRemoveEvent(int key); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IllumixVerticalBoundedPlane GetVerticalBoundedPlane(int key); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract IllumixHorizontalBoundedPlane GetHorizontalBoundedPlane(int key); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract IllumixMeshBlock GetMeshBlock(UnityEngine.Vector3 key); // 0

}
