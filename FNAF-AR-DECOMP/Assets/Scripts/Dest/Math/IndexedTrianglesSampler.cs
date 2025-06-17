using UnityEngine;

namespace Dest.Math
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IndexedTrianglesSampler : TrianglesSamplerBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected int[] _indices;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IndexedTrianglesSampler(UnityEngine.Vector3[] vertices, int[] indices)
        {
            null = null;
            mem[1152921519516878280] = vertices;
            this._indices = indices;
            this.Init();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IndexedTrianglesSampler(UnityEngine.Vector3[] vertices, int[] indices, Dest.Math.Rand rand)
        {
            mem[1152921519517141832] = vertices;
            this._indices = indices;
            this.Init();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IndexedTrianglesSampler(UnityEngine.Mesh mesh)
        {
            if(((110 & 2) != 0) && (1952411250 == 0))
            {
                    26777 = null;
            }
            
            if(mesh != null)
            {
                    mem[1152921519517446344] = mesh.vertices;
            }
            else
            {
                    mem[1152921519517446344] = 0.vertices;
            }
            
            this._indices = mesh.GetIndices(submesh:  0);
            this.Init();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IndexedTrianglesSampler(UnityEngine.Mesh mesh, Dest.Math.Rand rand)
        {
            if(mesh != null)
            {
                    mem[1152921519517791816] = mesh.vertices;
            }
            else
            {
                    mem[1152921519517791816] = 0.vertices;
            }
            
            this._indices = mesh.GetIndices(submesh:  0);
            this.Init();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void Init()
        {
            float val_17;
            int val_18;
            float val_19;
            float val_20;
            int val_1 = this._indices.Length * 1431655766;
            val_1 = val_1 >> 32;
            int val_3 = val_1 + (val_1 >> 63);
            mem[1152921519518284720] = new float[0];
            int val_22 = this._indices[0];
            int val_23 = this._indices[1];
            var val_24 = 12;
            val_24 = X22 + (val_23 * val_24);
            var val_25 = 12;
            val_25 = this._indices + (val_22 * val_25);
            val_17 = mem[(this._indices[0] * 12) + this._indices + 40];
            val_17 = (this._indices[0] * 12) + this._indices + 40;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (this._indices[1] * 12) + X22 + 32, y = (this._indices[1] * 12) + X22 + 32 + 4, z = (this._indices[1] * 12) + X22 + 40}, b:  new UnityEngine.Vector3() {x = (this._indices[0] * 12) + this._indices + 32, y = (this._indices[0] * 12) + this._indices + 32 + 4, z = val_17});
            val_18 = this._indices[2];
            var val_26 = 12;
            val_26 = X22 + (val_18 * val_26);
            val_19 = mem[(this._indices[2] * 12) + X22 + 32];
            val_19 = (this._indices[2] * 12) + X22 + 32;
            var val_27 = 12;
            val_27 = val_23 + (val_22 * val_27);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19, y = (this._indices[2] * 12) + X22 + 32 + 4, z = (this._indices[2] * 12) + X22 + 40}, b:  new UnityEngine.Vector3() {x = (this._indices[0] * 12) + this._indices[1] + 32, y = (this._indices[0] * 12) + this._indices[1] + 32 + 4, z = (this._indices[0] * 12) + this._indices[1] + 40});
            val_20 = this.CalclTriangleArea(e0: ref  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, e1: ref  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            mem2[0] = val_20;
            if(this._indices.Length >= 6)
            {
                    var val_33 = 0;
                var val_34 = 17179869184;
                var val_32 = 12884901888;
                do
            {
                var val_8 = 5 - 2;
                var val_31 = 0;
                int val_28 = this._indices[val_31];
                var val_9 = 5 - 1;
                int val_10 = val_31 + (this._indices[0] * 12);
                int val_11 = val_31 + (val_28 * 12);
                val_17 = mem[(this._indices[0x3][0] * 12) + 0 + 40];
                val_17 = (this._indices[0x3][0] * 12) + 0 + 40;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (this._indices[0x4][0] * 12) + 0 + 32, y = (this._indices[0x4][0] * 12) + 0 + 32 + 4, z = (this._indices[0x4][0] * 12) + 0 + 40}, b:  new UnityEngine.Vector3() {x = (this._indices[0x3][0] * 12) + 0 + 32, y = (this._indices[0x3][0] * 12) + 0 + 32 + 4, z = val_17});
                int val_13 = val_31 + (this._indices[0] * 12);
                val_19 = mem[(this._indices[0x5][0] * 12) + 0 + 32];
                val_19 = (this._indices[0x5][0] * 12) + 0 + 32;
                int val_14 = val_31 + (val_28 * 12);
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19, y = (this._indices[0x5][0] * 12) + 0 + 32 + 4, z = (this._indices[0x5][0] * 12) + 0 + 40}, b:  new UnityEngine.Vector3() {x = (this._indices[0x3][0] * 12) + 0 + 32, y = (this._indices[0x3][0] * 12) + 0 + 32 + 4, z = (this._indices[0x3][0] * 12) + 0 + 40});
                val_18 = val_33 + 1;
                val_31 = val_28 + 0;
                val_20 = ((this._indices[0x3][0] + 0) + 32) + (this.CalclTriangleArea(e0: ref  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, e1: ref  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}));
                mem2[0] = val_20;
                val_32 = val_32 + 12884901888;
                val_33 = val_33 + 1;
                var val_18 = 21474836480 + 12884901888;
                var val_19 = 5 + 3;
                val_34 = val_34 + 12884901888;
            }
            while((val_33 + 2) < (long)val_3);
            
            }
            
            var val_20 = (long)val_3 - 1;
            var val_21 = val_32 + ((((long)(int)((((this._indices.Length * 1431655766) >> 32) + ((this._indices.Length * 1431655766) >> 63))) - 1)) << 2);
            mem[1152921519518284728] = ((12884901888 + 12884901888) + (((long)(int)((((this._indices.Length * 1431655766) >> 32) + ((this._indices.Length * 1431655766) >> 63))) - 1)) << 2) + 32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 Sample()
        {
            int val_1 = this.SampleIndex();
            int val_2 = val_1 + (val_1 << 1);
            if(this._indices == null)
            {
                goto label_8;
            }
            
            label_14:
            var val_11 = 12;
            val_11 = X21 + (this._indices[(long)val_2] * val_11);
            var val_12 = 12;
            val_12 = this._indices + ((this._indices[(long)val_2 + 1]) * val_12);
            var val_13 = 12;
            val_13 = this._indices + ((this._indices[(long)val_2 + 2]) * val_13);
            return X19.InTriangle(v0: ref  new UnityEngine.Vector3() {x = val_11 + 32, y = val_11 + 32, z = val_11 + 32}, v1: ref  new UnityEngine.Vector3() {x = val_12 + 32, y = val_12 + 32, z = val_12 + 32}, v2: ref  new UnityEngine.Vector3() {x = val_13 + 32, y = val_13 + 32, z = val_13 + 32});
            label_8:
            if(X19 != 0)
            {
                goto label_14;
            }
            
            goto label_14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3[] SampleArray(int count)
        {
            int val_13;
            UnityEngine.Vector3[] val_14;
            val_13 = count;
            val_14 = new UnityEngine.Vector3[0];
            if(val_13 < 1)
            {
                    return val_14;
            }
            
            var val_15 = 0;
            do
            {
                int val_2 = this.SampleIndex();
                int val_3 = val_2 + (val_2 << 1);
                val_13 = this._indices[(long)val_3 + 2];
                UnityEngine.Vector3 val_12 = InTriangle(v0: ref  new UnityEngine.Vector3() {x = (X23 + (this._indices[(long)val_3] * 12)) + 32, y = (X23 + (this._indices[(long)val_3] * 12)) + 32, z = (X23 + (this._indices[(long)val_3] * 12)) + 32}, v1: ref  new UnityEngine.Vector3() {x = (X24 + ((this._indices[(long)val_3 + 1]) * 12)) + 32, y = (X24 + ((this._indices[(long)val_3 + 1]) * 12)) + 32, z = (X24 + ((this._indices[(long)val_3 + 1]) * 12)) + 32}, v2: ref  new UnityEngine.Vector3() {x = (this._indices + (val_13 * 12)) + 32, y = (this._indices + (val_13 * 12)) + 32, z = (this._indices + (val_13 * 12)) + 32});
                val_14 = val_14;
                mem2[0] = val_12.x;
                mem2[0] = val_12.y;
                mem2[0] = val_12.z;
                val_15 = val_15 + 1;
            }
            while(val_13 != val_15);
            
            return val_14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3[] SampleArray(int count, UnityEngine.Vector2[] uvs, UnityEngine.Texture2D sampleMap, float min = 0, float max = 1)
        {
            int val_18;
            var val_19;
            int val_20;
            val_19 = count;
            UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[0];
            if(val_19 >= 1)
            {
                    var val_25 = 0;
                do
            {
                int val_2 = this.SampleIndex();
                int val_3 = val_2 + (val_2 << 1);
                val_18 = this._indices[(long)val_3];
                int val_18 = this._indices[(long)val_3 + 1];
                val_20 = this._indices[(long)val_3 + 2];
                int val_6 = ((long)val_3 + 2) + (val_18 * 12);
                int val_7 = ((long)val_3 + 2) + (val_18 * 12);
                int val_8 = ((long)val_3 + 2) + (val_20 * 12);
                UnityEngine.Vector3 val_9 = (long)val_3 + 2.InTriangle(v0: ref  new UnityEngine.Vector3() {x = (this._indices[(long)(int)((val_2 + (val_2) << 1))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 32, y = (this._indices[(long)(int)((val_2 + (val_2) << 1))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 32, z = (this._indices[(long)(int)((val_2 + (val_2) << 1))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 40}, v1: ref  new UnityEngine.Vector3() {x = (this._indices[(long)(int)(((val_2 + (val_2) << 1) + 1))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 32, y = (this._indices[(long)(int)(((val_2 + (val_2) << 1) + 1))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 32, z = (this._indices[(long)(int)(((val_2 + (val_2) << 1) + 1))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 40}, v2: ref  new UnityEngine.Vector3() {x = (this._indices[(long)(int)(((val_2 + (val_2) << 1) + 2))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 32, y = (this._indices[(long)(int)(((val_2 + (val_2) << 1) + 2))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 32, z = (this._indices[(long)(int)(((val_2 + (val_2) << 1) + 2))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 40});
                Dest.Math.Triangle3.CalcBarycentricCoords(point: ref  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, v0: ref  new UnityEngine.Vector3() {x = (this._indices[(long)(int)((val_2 + (val_2) << 1))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 32, y = (this._indices[(long)(int)((val_2 + (val_2) << 1))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 32, z = (this._indices[(long)(int)((val_2 + (val_2) << 1))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 40}, v1: ref  new UnityEngine.Vector3() {x = (this._indices[(long)(int)(((val_2 + (val_2) << 1) + 1))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 32, y = (this._indices[(long)(int)(((val_2 + (val_2) << 1) + 1))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 32, z = (this._indices[(long)(int)(((val_2 + (val_2) << 1) + 1))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 40}, v2: ref  new UnityEngine.Vector3() {x = (this._indices[(long)(int)(((val_2 + (val_2) << 1) + 2))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 32, y = (this._indices[(long)(int)(((val_2 + (val_2) << 1) + 2))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 32, z = (this._indices[(long)(int)(((val_2 + (val_2) << 1) + 2))][0] * 12) + (long)(int)(((val_2 + (val_2) << 1) + 2)) + 40}, baryCoords: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = uvs[val_18], y = uvs[val_18]}, d:  0f);
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = uvs[val_18], y = uvs[val_18]}, d:  0f);
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = uvs[val_20], y = uvs[val_20]}, d:  0f);
                UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
                UnityEngine.Color val_15 = sampleMap.GetPixelBilinear(x:  val_14.x, y:  val_14.y);
                if((val_15.r >= min) && (val_15.r <= max))
            {
                    if(((long)val_3 + 2.NextFloat()) < 0)
            {
                    val_18 = val_9.x;
                val_20 = val_9.z;
                UnityEngine.Vector3[] val_26 = val_1;
                val_25 = val_25 + 1;
                val_26 = val_26 + (0 * 12);
                mem2[0] = val_18;
                mem2[0] = val_9.y;
                mem2[0] = val_20;
            }
            
            }
            
                val_19 = val_19 - 1;
            }
            while(val_19 != 0);
            
            }
            
            UnityEngine.Vector3[] val_17 = new UnityEngine.Vector3[0];
            System.Array.Copy(sourceArray:  val_1, destinationArray:  val_17, length:  mem[1152921519519566136]);
            return val_17;
        }
    
    }

}
