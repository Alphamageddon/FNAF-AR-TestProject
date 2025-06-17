using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public interface IMeshBlockAccepter
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnMeshBlockUpdatedEvent(UnityEngine.Vector3 key, UnityEngine.Vector3[] indexes, int[] triangles); // 0

}
