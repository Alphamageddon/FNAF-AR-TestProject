using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class IllumixTile : IllumixSurfaceObject
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector3[] vertices;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float length;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static int objectCounter;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public IllumixTile(UnityEngine.Vector3 center, UnityEngine.Vector3[] vertices, float length)
    {
        null = null;
        IllumixTile.objectCounter = IllumixTile.objectCounter + 1;
        this = new System.Object();
        mem[1152921518950512768] = center.x;
        mem[1152921518950512772] = center.y;
        mem[1152921518950512776] = center.z;
        mem[1152921518950512784] = "T" + IllumixTile.objectCounter;
        this.vertices = vertices;
        mem[1152921518950512792] = 1;
        this.length = length;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static IllumixTile()
    {
    
    }

}
