using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public interface IBoundedPlaneAccepter
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnHorizontalBoundedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnHorizontalBoundedPlaneUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, float height); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnHorizontalBoundedPlaneRemove(int id); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnVerticalBoundedPlaneAdd(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector3 normal); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnVerticalBoundedPlaneUpdate(int id, System.Collections.Generic.List<UnityEngine.Vector3> boundary, UnityEngine.Vector3 center, UnityEngine.Vector3 normal); // 0
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract void OnVerticalBoundedPlaneRemove(int id); // 0

}
