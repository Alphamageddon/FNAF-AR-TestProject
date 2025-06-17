using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ConvexHull2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2[] _points;
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
        public int GenerateCountMin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int GenerateCountMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CreateMeshObject;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            var val_4;
            int val_5;
            var val_6;
            if(this._points == null)
            {
                    return;
            }
            
            48265.DrawPoints(points:  this._points, size:  0.11f);
            if(this._indices == null)
            {
                    return;
            }
            
            48265.ResultsColor();
            if(this._dim == 1)
            {
                goto label_3;
            }
            
            if(this._dim != 2)
            {
                goto label_16;
            }
            
            val_4 = 1;
            goto label_5;
            label_15:
            int val_1 = val_4 / this._indices.Length;
            val_1 = val_4 - (val_1 * this._indices.Length);
            val_5 = (long)val_1;
            0.DrawSegment(p0:  new UnityEngine.Vector2() {x = this._points[this._indices[(long)(long)(int)(W22)]], y = this._points[this._indices[(long)(long)(int)(W22)]]}, p1:  new UnityEngine.Vector2() {x = this._points[this._indices[val_5]], y = this._points[this._indices[val_5]]});
            val_4 = 2;
            label_5:
            if((val_4 - 1) < this._indices.Length)
            {
                goto label_15;
            }
            
            goto label_16;
            label_3:
            0.DrawSegment(p0:  new UnityEngine.Vector2() {x = this._points[this._indices[0]], y = this._points[this._indices[0]]}, p1:  new UnityEngine.Vector2() {x = this._points[this._indices[1]], y = this._points[this._indices[1]]});
            label_16:
            UnityEngine.Color val_3 = UnityEngine.Color.red;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
            val_6 = 0;
            goto label_25;
            label_33:
            val_5 = this._indices[0];
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this._points[val_5], y = this._points[val_5]});
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, radius:  0.085f);
            val_6 = 1;
            label_25:
            if(val_6 < this._indices.Length)
            {
                goto label_33;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(((this.ToggleToGenerate == true) ? 1 : 0) != ((this._previous == true) ? 1 : 0))
            {
                    UnityEngine.Vector2[] val_3 = 48266.GenerateMemoryRandomSet2D(setRadius:  this.GenerateRadius, countMin:  this.GenerateCountMin, countMax:  this.GenerateCountMax, coeffX:  this.CoeffX, coeffY:  this.CoeffY);
                this._points = val_3;
                object[] val_8 = new object[4];
                val_8[0] = "Created: ";
                val_8[1] = Dest.Math.ConvexHull.Create2D(points:  val_3, indices: out  this._indices, dimension: out  this._dim, epsilon:  1E-05f).ToString();
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
            var val_12;
            System.Int32[] val_13;
            if(this._points == null)
            {
                    return;
            }
            
            if(this._indices == null)
            {
                    return;
            }
            
            if(this._dim != 2)
            {
                    return;
            }
            
            UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[0];
            val_12 = 0;
            goto label_4;
            label_11:
            UnityEngine.Vector3 val_2 = Dest.Math.Vector2ex.ToVector3XY(vector:  new UnityEngine.Vector2() {x = this._points[0], y = this._points[0]});
            var val_3 = val_1 + (0 * 12);
            val_12 = 1;
            mem2[0] = val_2.x;
            mem2[0] = val_2.y;
            mem2[0] = val_2.z;
            label_4:
            if(val_12 < val_1.Length)
            {
                goto label_11;
            }
            
            int val_4 = this._indices.Length + 1;
            int[] val_5 = new int[0];
            System.Buffer.BlockCopy(src:  this._indices, srcOffset:  0, dst:  val_5, dstOffset:  0, count:  this._indices.Length << 2);
            val_13 = this._indices;
            if(this._indices != null)
            {
                goto label_14;
            }
            
            val_13 = this._indices;
            if(val_13 == null)
            {
                goto label_15;
            }
            
            label_14:
            val_5[(this._indices.Length) << 2] = val_13[0];
            UnityEngine.Mesh val_7 = new UnityEngine.Mesh();
            if(val_7 != null)
            {
                    val_7.name = "Hull";
                val_7.vertices = val_1;
            }
            else
            {
                    0.name = "Hull";
                val_7.vertices = val_1;
            }
            
            val_7.SetIndices(indices:  val_5, topology:  4, submesh:  0);
            UnityEngine.GameObject val_8 = new UnityEngine.GameObject(name:  "ConvexHull2D");
            val_8.AddComponent<UnityEngine.MeshFilter>().sharedMesh = val_7;
            val_8.AddComponent<UnityEngine.MeshRenderer>().sharedMaterial = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  "Unlit/Texture"));
            return;
            label_15:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ConvexHull2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
