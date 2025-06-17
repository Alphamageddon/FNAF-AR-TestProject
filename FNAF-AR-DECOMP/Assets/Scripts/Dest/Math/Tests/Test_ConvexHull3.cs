using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ConvexHull3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3[] _points;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int[] _indices;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _dim;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _previous;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ToggleToGenerate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GenerateRadius;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CoeffX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CoeffY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CoeffZ;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GenerateCountMin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GenerateCountMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CreateMeshObject;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            var val_12;
            var val_13;
            float val_14;
            var val_15;
            var val_16;
            if(this._points == null)
            {
                    return;
            }
            
            this.DrawPoints(points:  this._points, size:  0.11f);
            if(this._indices == null)
            {
                    return;
            }
            
            this.ResultsColor();
            if(this._dim == 1)
            {
                goto label_2;
            }
            
            if(this._dim == 3)
            {
                goto label_3;
            }
            
            if(this._dim != 2)
            {
                    return;
            }
            
            val_12 = 1;
            val_13 = 12;
            goto label_5;
            label_15:
            int val_1 = this._points + (this._indices[(long)(long)(int)(W23)] * val_13);
            val_14 = mem[(this._indices[(long)(int)(W23)][0] * val_13) + this._points + 40];
            val_14 = (this._indices[(long)(int)(W23)][0] * val_13) + this._points + 40;
            int val_2 = val_12 / this._indices.Length;
            val_2 = val_12 - (val_2 * this._indices.Length);
            int val_3 = this._points + (this._indices[(long)val_2] * val_13);
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = (this._indices[(long)(int)(W23)][0] * val_13) + this._points + 32, y = (this._indices[(long)(int)(W23)][0] * val_13) + this._points + 32 + 4, z = val_14}, to:  new UnityEngine.Vector3() {x = (this._indices[(long)(int)(val_12 - ((val_12 / this._indices.Length) * this._indices.Length))][0] * val_13) + this._points + 32, y = (this._indices[(long)(int)(val_12 - ((val_12 / this._indices.Length) * this._indices.Length))][0] * val_13) + this._points + 32 + 4, z = (this._indices[(long)(int)(val_12 - ((val_12 / this._indices.Length) * this._indices.Length))][0] * val_13) + this._points + 40});
            val_12 = 2;
            label_5:
            val_15 = val_12 - 1;
            if(val_15 < this._indices.Length)
            {
                goto label_15;
            }
            
            return;
            label_2:
            var val_15 = 12;
            val_15 = this._points + (this._indices[0] * val_15);
            var val_17 = 12;
            val_17 = this._points + (this._indices[1] * val_17);
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = (this._indices[0] * 12) + this._points + 32, y = (this._indices[0] * 12) + this._points + 32 + 4, z = (this._indices[0] * 12) + this._points + 40}, to:  new UnityEngine.Vector3() {x = (this._indices[1] * 12) + this._points + 32, y = (this._indices[1] * 12) + this._points + 32 + 4, z = (this._indices[1] * 12) + this._points + 40});
            return;
            label_3:
            val_16 = 2;
            val_13 = 12;
            goto label_25;
            label_51:
            int val_4 = this._points + (this._indices[(long)(long)(int)(W23)] * val_13);
            var val_5 = W23 + 1;
            int val_6 = this._points + (this._indices[1] * val_13);
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = (this._indices[(long)(int)(W23)][0] * val_13) + this._points + 32, y = (this._indices[(long)(int)(W23)][0] * val_13) + this._points + 32 + 4, z = (this._indices[(long)(int)(W23)][0] * val_13) + this._points + 40}, to:  new UnityEngine.Vector3() {x = (this._indices[0x1][0] * val_13) + this._points + 32, y = (this._indices[0x1][0] * val_13) + this._points + 32 + 4, z = (this._indices[0x1][0] * val_13) + this._points + 40});
            int val_7 = this._points + (this._indices[1] * val_13);
            val_5 = val_5 + 1;
            int val_8 = this._points + (this._indices[2] * val_13);
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = (this._indices[0x1][0] * val_13) + this._points + 32, y = (this._indices[0x1][0] * val_13) + this._points + 32 + 4, z = (this._indices[0x1][0] * val_13) + this._points + 40}, to:  new UnityEngine.Vector3() {x = (this._indices[0x2][0] * val_13) + this._points + 32, y = (this._indices[0x2][0] * val_13) + this._points + 32 + 4, z = (this._indices[0x2][0] * val_13) + this._points + 40});
            int val_9 = this._points + (this._indices[2] * val_13);
            val_14 = mem[(this._indices[0x2][0] * val_13) + this._points + 40];
            val_14 = (this._indices[0x2][0] * val_13) + this._points + 40;
            var val_10 = val_5 - 2;
            int val_11 = this._points + (this._indices[(long)(long)(int)(W23)] * val_13);
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = (this._indices[0x2][0] * val_13) + this._points + 32, y = (this._indices[0x2][0] * val_13) + this._points + 32 + 4, z = val_14}, to:  new UnityEngine.Vector3() {x = (this._indices[(long)(int)(W23)][0] * val_13) + this._points + 32, y = (this._indices[(long)(int)(W23)][0] * val_13) + this._points + 32 + 4, z = (this._indices[(long)(int)(W23)][0] * val_13) + this._points + 40});
            val_16 = 5;
            label_25:
            val_15 = val_16 - 2;
            if(val_15 < this._indices.Length)
            {
                goto label_51;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(((this.ToggleToGenerate == true) ? 1 : 0) != ((this._previous == true) ? 1 : 0))
            {
                    UnityEngine.Vector3[] val_3 = 48268.GenerateMemoryRandomSet3D(setRadius:  this.GenerateRadius, countMin:  this.GenerateCountMin, countMax:  this.GenerateCountMax, coeffX:  this.CoeffX, coeffY:  this.CoeffY, coeffZ:  this.CoeffZ);
                this._points = val_3;
                object[] val_8 = new object[4];
                val_8[0] = "Created: ";
                val_8[1] = Dest.Math.ConvexHull.Create3D(points:  val_3, indices: out  this._indices, dimension: out  this._dim, epsilon:  1E-05f).ToString();
                val_8[2] = "   Dimension: ";
                val_8[3] = this._dim;
                Dest.Math.Logger.LogInfo(value:  +val_8);
                if(this.CreateMeshObject != false)
            {
                    this.CreateMesh();
            }
            
            }
            
            this._previous = this.ToggleToGenerate;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateMesh()
        {
            System.Int32[] val_14;
            string val_16;
            if(this._points == null)
            {
                    return;
            }
            
            if(this._indices == null)
            {
                    return;
            }
            
            if(this._dim == 2)
            {
                goto label_3;
            }
            
            if(this._dim != 3)
            {
                    return;
            }
            
            UnityEngine.Mesh val_1 = new UnityEngine.Mesh();
            if(val_1 == null)
            {
                goto label_5;
            }
            
            val_1.name = "Hull";
            val_1.vertices = this._points;
            val_1.SetIndices(indices:  this._indices, topology:  0, submesh:  0);
            val_1.RecalculateNormals();
            goto label_6;
            label_3:
            int val_2 = this._indices.Length + 1;
            int[] val_3 = new int[0];
            System.Buffer.BlockCopy(src:  this._indices, srcOffset:  0, dst:  val_3, dstOffset:  0, count:  this._indices.Length << 2);
            val_14 = this._indices;
            if(this._indices != null)
            {
                goto label_8;
            }
            
            val_14 = this._indices;
            if(val_14 == null)
            {
                goto label_9;
            }
            
            label_8:
            val_3[(this._indices.Length) << 2] = val_14[0];
            UnityEngine.Mesh val_5 = new UnityEngine.Mesh();
            if(val_5 == null)
            {
                goto label_13;
            }
            
            val_5.name = "Hull";
            val_5.vertices = this._points;
            goto label_14;
            label_5:
            0.name = "Hull";
            val_1.vertices = this._points;
            val_1.SetIndices(indices:  this._indices, topology:  0, submesh:  0);
            val_1.RecalculateNormals();
            label_6:
            val_1.RecalculateBounds();
            UnityEngine.GameObject val_6 = new UnityEngine.GameObject(name:  "ConvexHull3D");
            val_6.AddComponent<UnityEngine.MeshFilter>().sharedMesh = val_1;
            UnityEngine.MeshRenderer val_8 = val_6.AddComponent<UnityEngine.MeshRenderer>();
            val_16 = "Diffuse";
            goto label_18;
            label_13:
            0.name = "Hull";
            val_5.vertices = this._points;
            label_14:
            val_5.SetIndices(indices:  val_3, topology:  4, submesh:  0);
            UnityEngine.GameObject val_9 = new UnityEngine.GameObject(name:  "ConvexHull2D");
            val_9.AddComponent<UnityEngine.MeshFilter>().sharedMesh = val_5;
            val_16 = "Unlit/Texture";
            label_18:
            val_9.AddComponent<UnityEngine.MeshRenderer>().sharedMaterial = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  val_16));
            return;
            label_9:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ConvexHull3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
