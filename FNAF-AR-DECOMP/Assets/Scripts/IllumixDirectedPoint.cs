using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class IllumixDirectedPoint : IllumixSurfaceObject
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static int objectCounter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 direction;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3 position;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public readonly double distanceFromCaptureToPoint;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixDirectedPoint(UnityEngine.Vector3 key, UnityEngine.Vector3 position, UnityEngine.Vector3 direction, UnityEngine.Vector3 cameraPos)
    {
        var val_1;
        float val_2;
        null = null;
        IllumixDirectedPoint.objectCounter = IllumixDirectedPoint.objectCounter + 1;
        this = new System.Object();
        mem[1152921518947965328] = key.x;
        mem[1152921518947965332] = key.y;
        mem[1152921518947965344] = "DP" + IllumixDirectedPoint.objectCounter;
        this.direction = direction;
        mem[1152921518947965360] = val_1;
        mem[1152921518947965364] = direction.y;
        this.position = position;
        mem[1152921518947965336] = key.z;
        mem[1152921518947965372] = position.y;
        mem[1152921518947965352] = 1;
        mem[1152921518947965376] = position.z;
        this.distanceFromCaptureToPoint = Math3d.GetDistance(vec1:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, vec2:  new UnityEngine.Vector3() {x = direction.z, y = val_2, z = cameraPos.x});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixDirectedPoint()
    {
    
    }

}
