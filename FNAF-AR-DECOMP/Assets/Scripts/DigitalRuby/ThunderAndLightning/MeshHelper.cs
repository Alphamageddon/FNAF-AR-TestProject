using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MeshHelper
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Mesh mesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int[] triangles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[] vertices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[] normals;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float[] normalizedAreaWeights;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Mesh Mesh { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int[] Triangles { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3[] Vertices { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3[] Normals { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MeshHelper(UnityEngine.Mesh mesh)
        {
            this.mesh = mesh;
            if(mesh != null)
            {
                    this.triangles = mesh.triangles;
                this.vertices = mesh.vertices;
            }
            else
            {
                    this.triangles = 0.triangles;
                this.vertices = 0.vertices;
            }
            
            this.normals = mesh.normals;
            this.CalculateNormalizedAreaWeights();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GenerateRandomPoint(ref UnityEngine.RaycastHit hit, out int triangleIndex)
        {
            int val_1 = this.SelectRandomTriangle();
            triangleIndex = val_1;
            this.GetRaycastFromTriangleIndex(triangleIndex:  val_1, hit: ref  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = hit.m_Point.x, y = hit.m_Point.y, z = hit.m_Point.z}, m_Normal = new UnityEngine.Vector3() {x = hit.m_Normal.x, y = hit.m_Normal.y, z = hit.m_Normal.z}, m_FaceID = hit.m_FaceID, m_Distance = hit.m_Distance, m_UV = new UnityEngine.Vector2() {x = hit.m_UV.x, y = hit.m_UV.y}, m_Collider = hit.m_Collider});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetRaycastFromTriangleIndex(int triangleIndex, ref UnityEngine.RaycastHit hit)
        {
            int val_17;
            System.Int32[] val_18;
            float val_19;
            float val_20;
            float val_21;
            float val_22;
            val_17 = triangleIndex;
            UnityEngine.Vector3 val_1 = this.GenerateRandomBarycentricCoordinates();
            var val_18 = 12;
            val_18 = this.vertices + (this.triangles[(long)val_17] * val_18);
            val_18 = (long)val_17 + 1;
            var val_20 = 12;
            val_20 = this.vertices + (this.triangles[val_18] * val_20);
            var val_22 = 12;
            val_22 = this.vertices + ((this.triangles[(long)val_17 + 2]) * val_22);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = (this.triangles[(long)(int)(triangleIndex)][0] * 12) + this.vertices + 32, y = (this.triangles[(long)(int)(triangleIndex)][0] * 12) + this.vertices + 32 + 4, z = (this.triangles[(long)(int)(triangleIndex)][0] * 12) + this.vertices + 40}, d:  val_1.x);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = (this.triangles[(long)(int)((triangleIndex + 1))][0] * 12) + this.vertices + 32, y = (this.triangles[(long)(int)((triangleIndex + 1))][0] * 12) + this.vertices + 32 + 4, z = (this.triangles[(long)(int)((triangleIndex + 1))][0] * 12) + this.vertices + 40}, d:  val_1.y);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = (this.triangles[(long)(int)((triangleIndex + 2))][0] * 12) + this.vertices + 32, y = (this.triangles[(long)(int)((triangleIndex + 2))][0] * 12) + this.vertices + 32 + 4, z = (this.triangles[(long)(int)((triangleIndex + 2))][0] * 12) + this.vertices + 40}, d:  val_1.z);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            if(this.normals != null)
            {
                    var val_24 = 12;
                val_24 = this.normals + (this.triangles[(long)val_17] * val_24);
                var val_26 = 12;
                val_26 = this.normals + (this.triangles[val_18] * val_26);
                val_18 = this.triangles;
                val_17 = val_18[(long)val_17 + 2];
                var val_27 = 12;
                val_27 = this.normals + (val_17 * val_27);
                val_19 = mem[(this.triangles[(long)(int)((triangleIndex + 2))][0] * 12) + this.normals + 32];
                val_19 = (this.triangles[(long)(int)((triangleIndex + 2))][0] * 12) + this.normals + 32;
                val_20 = mem[(this.triangles[(long)(int)((triangleIndex + 2))][0] * 12) + this.normals + 32 + 4];
                val_20 = (this.triangles[(long)(int)((triangleIndex + 2))][0] * 12) + this.normals + 32 + 4;
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = (this.triangles[(long)(int)(triangleIndex)][0] * 12) + this.normals + 32, y = (this.triangles[(long)(int)(triangleIndex)][0] * 12) + this.normals + 32 + 4, z = (this.triangles[(long)(int)(triangleIndex)][0] * 12) + this.normals + 40}, d:  val_1.x);
                val_21 = val_9.y;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = (this.triangles[(long)(int)((triangleIndex + 1))][0] * 12) + this.normals + 32, y = (this.triangles[(long)(int)((triangleIndex + 1))][0] * 12) + this.normals + 32 + 4, z = (this.triangles[(long)(int)((triangleIndex + 1))][0] * 12) + this.normals + 40}, d:  val_1.y);
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_21, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                val_22 = val_11.y;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = (this.triangles[(long)(int)((triangleIndex + 2))][0] * 12) + this.normals + 40}, d:  val_1.z);
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_22, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                return;
            }
            
            val_21 = (this.triangles[(long)(int)(triangleIndex)][0] * 12) + this.vertices + 32;
            val_20 = (this.triangles[(long)(int)((triangleIndex + 1))][0] * 12) + this.vertices + 32 + 4;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (this.triangles[(long)(int)((triangleIndex + 2))][0] * 12) + this.vertices + 32, y = (this.triangles[(long)(int)((triangleIndex + 2))][0] * 12) + this.vertices + 32 + 4, z = (this.triangles[(long)(int)((triangleIndex + 2))][0] * 12) + this.vertices + 40}, b:  new UnityEngine.Vector3() {x = (this.triangles[(long)(int)((triangleIndex + 1))][0] * 12) + this.normals + 40, y = val_20, z = (this.triangles[(long)(int)((triangleIndex + 1))][0] * 12) + this.vertices + 40});
            val_22 = val_14.z;
            val_19 = val_14.x;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21, y = (this.triangles[(long)(int)(triangleIndex)][0] * 12) + this.vertices + 32 + 4, z = (this.triangles[(long)(int)(triangleIndex)][0] * 12) + this.vertices + 40}, b:  new UnityEngine.Vector3() {x = (this.triangles[(long)(int)((triangleIndex + 1))][0] * 12) + this.normals + 40, y = val_20, z = (this.triangles[(long)(int)((triangleIndex + 1))][0] * 12) + this.vertices + 40});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_19, y = val_14.y, z = val_22}, rhs:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Mesh get_Mesh()
        {
            return (UnityEngine.Mesh)this.mesh;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int[] get_Triangles()
        {
            return (System.Int32[])this.triangles;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3[] get_Vertices()
        {
            return (UnityEngine.Vector3[])this.vertices;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3[] get_Normals()
        {
            return (UnityEngine.Vector3[])this.normals;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float[] CalculateSurfaceAreas(out float totalSurfaceArea)
        {
            var val_18;
            var val_19;
            totalSurfaceArea = 0f;
            int val_19 = this.triangles.Length;
            val_19 = val_19 * 1431655766;
            val_19 = val_19 >> 32;
            int val_2 = val_19 + (val_19 >> 63);
            float[] val_3 = new float[0];
            val_18 = 0;
            val_19 = 2;
            goto label_2;
            label_20:
            int val_4 = this.vertices + (this.triangles[(long)(long)(int)(W26)] * 12);
            int val_6 = this.vertices + (this.triangles[1] * 12);
            var val_7 = (W26 + 1) + 1;
            int val_8 = this.vertices + (this.triangles[2] * 12);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (this.triangles[(long)(int)(W26)][0] * 12) + this.vertices + 32, y = (this.triangles[(long)(int)(W26)][0] * 12) + this.vertices + 32 + 4, z = (this.triangles[(long)(int)(W26)][0] * 12) + this.vertices + 40}, b:  new UnityEngine.Vector3() {x = (this.triangles[0x1][0] * 12) + this.vertices + 32, y = (this.triangles[0x1][0] * 12) + this.vertices + 32 + 4, z = (this.triangles[0x1][0] * 12) + this.vertices + 40});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (this.triangles[(long)(int)(W26)][0] * 12) + this.vertices + 32, y = (this.triangles[(long)(int)(W26)][0] * 12) + this.vertices + 32 + 4, z = (this.triangles[(long)(int)(W26)][0] * 12) + this.vertices + 40}, b:  new UnityEngine.Vector3() {x = (this.triangles[0x2][0] * 12) + this.vertices + 32, y = (this.triangles[0x2][0] * 12) + this.vertices + 32 + 4, z = (this.triangles[0x2][0] * 12) + this.vertices + 40});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (this.triangles[0x1][0] * 12) + this.vertices + 32, y = (this.triangles[0x1][0] * 12) + this.vertices + 32 + 4, z = (this.triangles[0x1][0] * 12) + this.vertices + 40}, b:  new UnityEngine.Vector3() {x = (this.triangles[0x2][0] * 12) + this.vertices + 32, y = (this.triangles[0x2][0] * 12) + this.vertices + 32 + 4, z = (this.triangles[0x2][0] * 12) + this.vertices + 40});
            float val_12 = val_9.x + val_9.x;
            float val_13 = val_10.x + val_10.x;
            val_12 = val_12 * val_10.x;
            val_13 = val_13 * val_11.x;
            val_12 = val_12 + val_13;
            float val_14 = val_11.x + val_11.x;
            val_14 = val_9.x * val_14;
            val_12 = val_12 + val_14;
            val_12 = val_12 - (val_9.x * val_9.x);
            val_12 = val_12 - (val_10.x * val_10.x);
            val_11.x = val_11.x * val_11.x;
            val_11.x = val_12 - val_11.x;
            val_11.x = val_11.x * 0.0625f;
            float val_17 = DigitalRuby.ThunderAndLightning.PathGenerator.SquareRoot(x:  val_11.x);
            val_3[0] = val_17;
            float val_23 = totalSurfaceArea;
            val_19 = 5;
            val_18 = 1;
            val_23 = val_17 + val_23;
            totalSurfaceArea = val_23;
            label_2:
            if((val_19 - 2) < this.triangles.Length)
            {
                goto label_20;
            }
            
            return (System.Single[])val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CalculateNormalizedAreaWeights()
        {
            var val_3;
            this.normalizedAreaWeights = this.CalculateSurfaceAreas(totalSurfaceArea: out  float val_1 = -6.154635E-15f);
            if(val_2.Length == 0)
            {
                    return;
            }
            
            val_3 = 0;
            float val_4 = 0f;
            goto label_2;
            label_8:
            float val_3 = this.normalizedAreaWeights[0];
            val_3 = val_3 / 0f;
            this.normalizedAreaWeights[0] = val_4;
            val_4 = val_4 + val_3;
            val_3 = 1;
            label_2:
            if(val_3 < this.normalizedAreaWeights.Length)
            {
                goto label_8;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int SelectRandomTriangle()
        {
            var val_5;
            float val_1 = UnityEngine.Random.value;
            int val_6 = this.normalizedAreaWeights.Length;
            int val_2 = val_6 - 1;
            if(val_2 < 1)
            {
                goto label_1;
            }
            
            val_5 = 0;
            label_7:
            val_6 = val_5 + val_2;
            var val_4 = ((val_6 < 0) ? (val_6 + 1) : (val_6)) >> 1;
            if(this.normalizedAreaWeights[(long)val_4] >= 0)
            {
                goto label_4;
            }
            
            val_5 = val_4 + 1;
            if(val_5 < val_2)
            {
                goto label_7;
            }
            
            return (int)val_5 + 0;
            label_4:
            if(val_5 < val_4)
            {
                goto label_7;
            }
            
            return (int)val_5 + 0;
            label_1:
            val_5 = 0;
            return (int)val_5 + 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 GenerateRandomBarycentricCoordinates()
        {
            null = null;
            float val_1 = UnityEngine.Random.Range(min:  UnityEngine.Mathf.Epsilon, max:  1f);
            float val_2 = UnityEngine.Random.Range(min:  UnityEngine.Mathf.Epsilon, max:  1f);
            float val_3 = UnityEngine.Random.Range(min:  UnityEngine.Mathf.Epsilon, max:  1f);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  (0f + 0f) + 0f);
            return new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
    
    }

}
