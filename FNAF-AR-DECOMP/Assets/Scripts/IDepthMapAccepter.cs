using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public interface IDepthMapAccepter
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnDepthMapUpdatedEvent(UnityEngine.Vector3[,] depthMap, bool[,] keepMask, UnityEngine.Vector3 cameraPos); // 0

}
