using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class IllumixMeshBlock : IllumixSurfaceObject
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3[] vertices;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int[] triangles;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static int objectCounter;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixMeshBlock(UnityEngine.Vector3 key, UnityEngine.Vector3[] vertices, int[] triangles)
    {
        null = null;
        IllumixMeshBlock.objectCounter = IllumixMeshBlock.objectCounter + 1;
        this = new System.Object();
        mem[1152921518949224752] = key.x;
        mem[1152921518949224756] = key.y;
        mem[1152921518949224760] = key.z;
        mem[1152921518949224768] = "MB" + IllumixMeshBlock.objectCounter;
        mem[1152921518949224776] = 1;
        this.vertices = vertices;
        this.triangles = triangles;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixMeshBlock()
    {
    
    }

}
