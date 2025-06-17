using UnityEngine;

namespace Dest.Math
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NonIndexedTrianglesSampler : TrianglesSamplerBase
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NonIndexedTrianglesSampler(UnityEngine.Vector3[] vertices)
        {
            null = null;
            mem[1152921519519801800] = vertices;
            this.Init();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NonIndexedTrianglesSampler(UnityEngine.Vector3[] vertices, Dest.Math.Rand rand)
        {
            mem[1152921519519991624] = vertices;
            this.Init();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NonIndexedTrianglesSampler(UnityEngine.Mesh mesh)
        {
            null = null;
            mem[1152921519520185544] = mesh.vertices;
            this.Init();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NonIndexedTrianglesSampler(UnityEngine.Mesh mesh, Dest.Math.Rand rand)
        {
            mem[1152921519520383560] = mesh.vertices;
            this.Init();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void Init()
        {
            float val_13;
            float val_14;
            float val_15;
            var val_1 = mem[69734424] * 1431655766;
            val_1 = val_1 >> 32;
            var val_3 = val_1 + (val_1 >> 63);
            mem[1152921519520544688] = new float[0];
            val_13 = mem[X21 + 40];
            val_13 = X21 + 40;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = X22 + 44, y = X22 + 44 + 4, z = X22 + 52}, b:  new UnityEngine.Vector3() {x = X21 + 32, y = X21 + 32 + 4, z = val_13});
            val_14 = mem[X21 + 64];
            val_14 = X21 + 64;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = X21 + 56, y = X21 + 56 + 4, z = val_14}, b:  new UnityEngine.Vector3() {x = X22 + 32, y = X22 + 32 + 4, z = X22 + 40});
            val_15 = this.CalclTriangleArea(e0: ref  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, e1: ref  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            mem2[0] = val_15;
            if(mem[69734424] >= 6)
            {
                    var val_25 = 0;
                var val_26 = 17179869184;
                var val_24 = 12884901888;
                do
            {
                var val_8 = 5 - 1;
                var val_9 = X21 + (0 * 12);
                var val_10 = 5 - 2;
                var val_11 = X23 + (0 * 12);
                val_13 = mem[(0 * 12) + X23 + 40];
                val_13 = (0 * 12) + X23 + 40;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (0 * 12) + X21 + 32, y = (0 * 12) + X21 + 32 + 4, z = (0 * 12) + X21 + 40}, b:  new UnityEngine.Vector3() {x = (0 * 12) + X23 + 32, y = (0 * 12) + X23 + 32 + 4, z = val_13});
                var val_23 = 12;
                val_23 = X23 + (0 * val_23);
                val_14 = mem[(0 * 12) + X23 + 32];
                val_14 = (0 * 12) + X23 + 32;
                var val_13 = X23 + (0 * 12);
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_14, y = (0 * 12) + X23 + 32 + 4, z = (0 * 12) + X23 + 40}, b:  new UnityEngine.Vector3() {x = (0 * 12) + X23 + 32, y = (0 * 12) + X23 + 32 + 4, z = (0 * 12) + X23 + 40});
                var val_15 = val_25 + 1;
                var val_16 = 0 + 0;
                val_15 = ((0 + 0) + 32) + (this.CalclTriangleArea(e0: ref  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, e1: ref  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}));
                mem2[0] = val_15;
                val_24 = val_24 + 12884901888;
                val_25 = val_25 + 1;
                var val_19 = 21474836480 + 12884901888;
                var val_20 = 5 + 3;
                val_26 = val_26 + 12884901888;
            }
            while((val_25 + 2) < (long)val_3);
            
            }
            
            var val_21 = (long)val_3 - 1;
            var val_22 = val_24 + ((((long)(int)((((mem[69734424] * 1431655766) >> 32) + ((mem[69734424] * 1431655766) >> 63))) - 1)) << 2);
            mem[1152921519520544696] = ((12884901888 + 12884901888) + (((long)(int)((((mem[69734424] * 1431655766) >> 32) + ((mem[69734424] * 1431655766) >> 63))) - 1)) << 2) + 32;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 Sample()
        {
            var val_6;
            var val_7;
            int val_1 = this.SampleIndex();
            val_6 = X23;
            val_7 = X23;
            if(X23 == 0)
            {
                    val_7 = val_6;
                if(val_6 == 0)
            {
                    val_7 = 0;
            }
            
            }
            
            int val_2 = val_1 + (val_1 << 1);
            UnityEngine.Vector3 val_7 = (long)val_2;
            var val_6 = 12;
            val_6 = X23 + (val_7 * val_6);
            val_7 = val_6 + 32;
            UnityEngine.Vector3 val_9 = (long)val_2 + 1;
            var val_8 = 12;
            val_8 = val_7 + (val_9 * val_8);
            val_9 = val_8 + 32;
            var val_10 = 12;
            val_10 = val_6 + (((long)val_2 + 2) * val_10);
            return X19.InTriangle(v0: ref  new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}, v1: ref  new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_9}, v2: ref  new UnityEngine.Vector3() {x = val_10 + 32, y = val_10 + 32, z = val_10 + 32});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3[] SampleArray(int count)
        {
            int val_10;
            UnityEngine.Vector3[] val_11;
            var val_12;
            var val_13;
            val_10 = count;
            val_11 = new UnityEngine.Vector3[0];
            if(val_10 < 1)
            {
                    return val_11;
            }
            
            var val_12 = 0;
            do
            {
                int val_2 = this.SampleIndex();
                val_12 = X24;
                val_13 = X24;
                if(X24 == 0)
            {
                    val_13 = val_12;
                if(val_12 == 0)
            {
                    val_13 = 0;
            }
            
            }
            
                int val_3 = val_2 + (val_2 << 1);
                UnityEngine.Vector3 val_10 = (long)val_3;
                val_10 = 12;
                val_10 = (X24 + (val_10 * val_10)) + 32;
                int val_5 = val_3 + 1;
                UnityEngine.Vector3 val_11 = (long)val_5;
                val_5 = val_13 + (val_11 * val_10);
                val_11 = val_5 + 32;
                UnityEngine.Vector3 val_9 = X22.InTriangle(v0: ref  new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_10}, v1: ref  new UnityEngine.Vector3() {x = val_11, y = val_11, z = val_11}, v2: ref  new UnityEngine.Vector3() {x = (val_12 + (((long)val_3 + 2) * val_10)) + 32, y = (val_12 + (((long)val_3 + 2) * val_10)) + 32, z = (val_12 + (((long)val_3 + 2) * val_10)) + 32});
                val_11 = val_11;
                mem2[0] = val_9.x;
                mem2[0] = val_9.y;
                mem2[0] = val_9.z;
                val_12 = val_12 + 1;
            }
            while(val_10 != val_12);
            
            return val_11;
        }
    
    }

}
