using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SimpleMeshWithCollider : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshFilter meshFilter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.MeshCollider meshCollider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh mesh;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitializeMesh(UnityEngine.Vector3[] vertices, int[] triangles)
        {
            UnityEngine.Mesh val_1 = new UnityEngine.Mesh();
            this.mesh = val_1;
            val_1.MarkDynamic();
            this.UpdateMesh(vertices:  vertices, triangles:  triangles);
            this.meshFilter.mesh = this.mesh;
            this.meshCollider.sharedMesh = this.mesh;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateMesh(UnityEngine.Vector3[] vertices, int[] triangles)
        {
            this.mesh.vertices = vertices;
            this.mesh.triangles = triangles;
            UnityEngine.Vector4[] val_1 = new UnityEngine.Vector4[0];
            if(vertices.Length >= 1)
            {
                    var val_4 = 0;
                do
            {
                val_1[0] = 0;
                val_1[0] = 0;
                val_1[0] = 0;
                val_1[0] = 0;
                val_4 = val_4 + 1;
            }
            while(val_4 < vertices.Length);
            
            }
            
            this.mesh.colors = new UnityEngine.Color[0];
            this.mesh.uv = new UnityEngine.Vector2[0];
            this.mesh.tangents = val_1;
            this.mesh.RecalculateNormals();
            this.meshCollider.sharedMesh = 0;
            this.meshCollider.sharedMesh = this.mesh;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearMesh()
        {
            this.mesh.Clear(keepVertexLayout:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SimpleMeshWithCollider()
        {
        
        }
    
    }

}
