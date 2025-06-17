using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public interface IProcessedDirectedPointsAccepter
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnDirectedPointsUpdateEvent(UnityEngine.Vector3[] keys, DirectedPointsManager.DirectedPointData[] data, UnityEngine.Vector3 cameraPos); // 0

}
