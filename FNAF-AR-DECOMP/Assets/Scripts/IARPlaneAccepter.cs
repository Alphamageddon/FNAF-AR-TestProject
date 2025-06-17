using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public interface IARPlaneAccepter
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnPlaneAddedEvent(UnityEngine.XR.ARFoundation.ARPlane plane); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnPlaneRemovedEvent(UnityEngine.XR.ARFoundation.ARPlane plane); // 0

}
