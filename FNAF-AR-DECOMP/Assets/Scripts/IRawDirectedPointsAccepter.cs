using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public interface IRawDirectedPointsAccepter
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnDirectedPointsUpdateEvent(UnityEngine.Vector3[] positions, UnityEngine.Vector3[] directions, UnityEngine.Vector3 cameraPos); // 0

}
