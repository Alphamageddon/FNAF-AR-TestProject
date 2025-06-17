using UnityEngine;

namespace com.illumix.TSDF
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VoxelBlock
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.Vector3> vertices_1d_list;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<UnityEngine.Vector3, int> vertexToIdx;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.List<int>> cubeToTriangles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> tsdfCoords;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> smoothedTsdfCoords;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool[] isTileLayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool[] isSmoothLayer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int[] layerwiseCounts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool[,] isColumn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int[,] columnwiseCounts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int changesSinceLastUpdate;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VoxelBlock(int blockSize)
        {
            this.tsdfCoords = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            this.smoothedTsdfCoords = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            this.cubeToTriangles = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Collections.Generic.List<System.Int32>>();
            this.layerwiseCounts = new int[0];
            this.isTileLayer = new bool[0];
            this.isSmoothLayer = new bool[0];
            this.isColumn = null;
            this.columnwiseCounts = null;
            this.vertices_1d_list = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.vertexToIdx = new System.Collections.Generic.Dictionary<UnityEngine.Vector3, System.Int32>();
            this.changesSinceLastUpdate = 0;
        }
    
    }

}
