using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public interface ITileAccepter
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnTileAddEvent(UnityEngine.Vector3 center, float length); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnTileRemoveEvent(UnityEngine.Vector3 center); // 0

}
