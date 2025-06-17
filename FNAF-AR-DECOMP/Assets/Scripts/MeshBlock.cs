using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class MarchingCubes.MeshBlock
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<UnityEngine.Vector3> vertices_1d_list;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.Dictionary<UnityEngine.Vector3, int> vertexToIdx;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.List<int>> cubeToTriangles;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MarchingCubes.MeshBlock()
    {
        this.vertices_1d_list = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.vertexToIdx = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Int32>();
        this.cubeToTriangles = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.List<System.Int32>>();
    }

}
