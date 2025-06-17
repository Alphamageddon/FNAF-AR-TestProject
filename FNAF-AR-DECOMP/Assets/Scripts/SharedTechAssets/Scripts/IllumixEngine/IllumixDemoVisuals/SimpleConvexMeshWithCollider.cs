using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SimpleConvexMeshWithCollider : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshFilter meshFilter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.LineRenderer lineRenderer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshCollider _meshCollider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh planeMesh;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitializeMesh(UnityEngine.Vector3[] orderedConvexVertices)
        {
            UnityEngine.Mesh val_1 = new UnityEngine.Mesh();
            this.planeMesh = val_1;
            val_1.MarkDynamic();
            this.UpdateMesh(convexVertices:  orderedConvexVertices);
            this.meshFilter.mesh = this.planeMesh;
            this._meshCollider.sharedMesh = this.planeMesh;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int[] GenerateTrianglesFromOrderedConvexVertices(int numVertices)
        {
            if(numVertices > 2)
            {
                    numVertices = (numVertices + (numVertices << 1)) - 6;
                int[] val_2 = new int[0];
                if((numVertices - 1) < 2)
            {
                    return (System.Int32[])val_2;
            }
            
                var val_8 = 0;
                int val_9 = 2;
                do
            {
                var val_4 = val_8 + 1;
                val_2[0] = 0;
                var val_5 = val_8 + 2;
                val_8 = val_8 + 1;
                val_2[((long)(int)((0 + 1))) << 2] = val_9 - 1;
                val_8 = val_8 + 1;
                val_2[((long)(int)((0 + 2))) << 2] = val_9;
                val_9 = val_9 + 1;
                val_8 = val_8 + 1;
            }
            while(numVertices != val_9);
            
                return (System.Int32[])val_2;
            }
            
            System.Exception val_7 = new System.Exception(message:  "SimpleMesh requires at least 3 vertices");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateMesh(UnityEngine.Vector3[] convexVertices)
        {
            this.planeMesh.Clear();
            this.planeMesh.vertices = convexVertices;
            this.planeMesh.triangles = this.GenerateTrianglesFromOrderedConvexVertices(numVertices:  convexVertices.Length);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0f, y:  0f);
            if(convexVertices.Length >= 1)
            {
                    var val_6 = 0;
                do
            {
                new UnityEngine.Vector4[0][0] = 0;
                new UnityEngine.Vector4[0][0] = 0;
                new UnityEngine.Vector4[0][0] = 0;
                new UnityEngine.Vector4[0][0] = 0;
                new UnityEngine.Vector2[0][0] = val_4.x;
                new UnityEngine.Vector2[0][0] = val_4.y;
                new UnityEngine.Color[0][0] = 0;
                new UnityEngine.Color[0][0] = 0;
                new UnityEngine.Color[0][0] = 0;
                new UnityEngine.Color[0][0] = 0;
                val_6 = val_6 + 1;
            }
            while(val_6 < convexVertices.Length);
            
            }
            
            this.planeMesh.RecalculateBounds();
            this.planeMesh.RecalculateNormals();
            mem[1152921523168405792].positionCount = convexVertices.Length;
            mem[1152921523168405792].SetPositions(positions:  convexVertices);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearMesh()
        {
            this.planeMesh.Clear(keepVertexLayout:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SimpleConvexMeshWithCollider()
        {
        
        }
    
    }

}
