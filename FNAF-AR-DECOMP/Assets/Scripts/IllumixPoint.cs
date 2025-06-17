using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class IllumixPoint : IllumixSurfaceObject
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixPoint(UnityEngine.Vector3 point)
    {
        this = new System.Object();
        mem[1152921518949530752] = point.x;
        mem[1152921518949530756] = point.y;
        mem[1152921518949530760] = point.z;
        mem[1152921518949530768] = "Point";
        mem[1152921518949530776] = 1;
    }

}
