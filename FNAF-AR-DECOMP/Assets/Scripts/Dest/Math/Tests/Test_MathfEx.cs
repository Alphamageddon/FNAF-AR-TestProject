using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_MathfEx : MonoBehaviour
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.DrawSigmoid(offset:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.right;
            this.DrawOverlappedStep(offset:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.right;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, d:  2f);
            this.DrawSmoothOverlappedStep(offset:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.up;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, d:  2f);
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.right;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, d:  1.5f);
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            this.DrawGaussian(offset:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DrawSigmoid(UnityEngine.Vector2 offset)
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0f, y:  Dest.Math.Mathfex.EvalSigmoid(x:  0f));
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, radius:  0.02f);
            var val_15 = 1;
            do
            {
                float val_6 = 1f * 0.05f;
                UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_6, y:  Dest.Math.Mathfex.EvalSigmoid(x:  val_6));
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
                UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
                UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, to:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
                UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, radius:  0.02f);
                val_15 = val_15 + 1;
            }
            while(val_15 != 21);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DrawGaussian(UnityEngine.Vector2 offset)
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  -2f, y:  Dest.Math.Mathfex.EvalGaussian(x:  -2f, a:  1.5f, b:  0f, c:  0.5f));
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, radius:  0.02f);
            var val_15 = 18;
            do
            {
                float val_6 = 18f * 0.1f;
                UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  val_6, y:  Dest.Math.Mathfex.EvalGaussian(x:  val_6, a:  1.5f, b:  0f, c:  0.5f));
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
                UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
                UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, to:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
                UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, radius:  0.02f);
                val_15 = val_15 + 1;
            }
            while(val_15 != 21);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DrawOverlappedStep(UnityEngine.Vector2 offset)
        {
            UnityEngine.Color[] val_1 = new UnityEngine.Color[6];
            UnityEngine.Color val_2 = UnityEngine.Color.red;
            val_1[0] = val_2;
            val_1[0] = val_2.g;
            val_1[1] = val_2.b;
            val_1[1] = val_2.a;
            UnityEngine.Color val_3 = UnityEngine.Color.green;
            val_1[2] = val_3;
            val_1[2] = val_3.g;
            val_1[3] = val_3.b;
            val_1[3] = val_3.a;
            UnityEngine.Color val_4 = UnityEngine.Color.blue;
            val_1[4] = val_4;
            val_1[4] = val_4.g;
            val_1[5] = val_4.b;
            val_1[5] = val_4.a;
            UnityEngine.Color val_5 = UnityEngine.Color.yellow;
            val_1[6] = val_5;
            val_1[6] = val_5.g;
            val_1[7] = val_5.b;
            val_1[7] = val_5.a;
            UnityEngine.Color val_6 = UnityEngine.Color.magenta;
            val_1[8] = val_6;
            val_1[8] = val_6.g;
            val_1[9] = val_6.b;
            val_1[9] = val_6.a;
            UnityEngine.Color val_7 = UnityEngine.Color.cyan;
            val_1[10] = val_7;
            val_1[10] = val_7.g;
            val_1[11] = val_7.b;
            val_1[11] = val_7.a;
            UnityEngine.Vector2[] val_8 = new UnityEngine.Vector2[3];
            var val_29 = 0;
            do
            {
                UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  0f, y:  Dest.Math.Mathfex.EvalOverlappedStep(x:  0f, overlap:  0.5f, objectIndex:  0, objectCount:  3));
                mem2[0] = val_10.x;
                mem2[0] = val_10.y;
                int val_11 = val_29 / val_1.Length;
                val_11 = val_29 - (val_11 * val_1.Length);
                UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4], g = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4], b = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4], a = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4]};
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -1.162476E-27f, y = -1.162476E-27f}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
                UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, radius:  0.02f);
                val_29 = val_29 + 1;
            }
            while(val_29 != 3);
            
            var val_39 = 1;
            do
            {
                UnityEngine.Vector2[] val_38 = val_8[36];
                UnityEngine.Vector2[] val_37 = new UnityEngine.Vector2[3][36];
                var val_36 = 0;
                float val_15 = 1f * 0.05f;
                do
            {
                UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_15, y:  Dest.Math.Mathfex.EvalOverlappedStep(x:  val_15, overlap:  0.5f, objectIndex:  0, objectCount:  3));
                mem2[0] = val_17.x;
                mem2[0] = val_17.y;
                int val_18 = val_36 / val_1.Length;
                val_18 = val_36 - (val_18 * val_1.Length);
                UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4], g = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4], b = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4], a = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4]};
                UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_8[0x24] + -4, y = val_8[0x24] + -4 + 4}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
                UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
                UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_14[0x24] + -4, y = val_14[0x24] + -4 + 4}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
                UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, to:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
                UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_14[0x24] + -4, y = val_14[0x24] + -4 + 4}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
                UnityEngine.Vector3 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, radius:  0.02f);
                val_36 = val_36 + 1;
                mem2[0] = val_14[0x24] + -4;
                mem2[0] = val_14[0x24] + -4 + 4;
                val_37 = val_37 + 8;
                val_38 = val_38 + 8;
            }
            while(val_36 != 3);
            
                val_39 = val_39 + 1;
            }
            while(val_39 != 21);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DrawSmoothOverlappedStep(UnityEngine.Vector2 offset)
        {
            UnityEngine.Color[] val_1 = new UnityEngine.Color[6];
            UnityEngine.Color val_2 = UnityEngine.Color.red;
            val_1[0] = val_2;
            val_1[0] = val_2.g;
            val_1[1] = val_2.b;
            val_1[1] = val_2.a;
            UnityEngine.Color val_3 = UnityEngine.Color.green;
            val_1[2] = val_3;
            val_1[2] = val_3.g;
            val_1[3] = val_3.b;
            val_1[3] = val_3.a;
            UnityEngine.Color val_4 = UnityEngine.Color.blue;
            val_1[4] = val_4;
            val_1[4] = val_4.g;
            val_1[5] = val_4.b;
            val_1[5] = val_4.a;
            UnityEngine.Color val_5 = UnityEngine.Color.yellow;
            val_1[6] = val_5;
            val_1[6] = val_5.g;
            val_1[7] = val_5.b;
            val_1[7] = val_5.a;
            UnityEngine.Color val_6 = UnityEngine.Color.magenta;
            val_1[8] = val_6;
            val_1[8] = val_6.g;
            val_1[9] = val_6.b;
            val_1[9] = val_6.a;
            UnityEngine.Color val_7 = UnityEngine.Color.cyan;
            val_1[10] = val_7;
            val_1[10] = val_7.g;
            val_1[11] = val_7.b;
            val_1[11] = val_7.a;
            UnityEngine.Vector2[] val_8 = new UnityEngine.Vector2[3];
            var val_29 = 0;
            do
            {
                UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  0f, y:  Dest.Math.Mathfex.EvalSmoothOverlappedStep(x:  0f, overlap:  0.5f, objectIndex:  0, objectCount:  3));
                mem2[0] = val_10.x;
                mem2[0] = val_10.y;
                int val_11 = val_29 / val_1.Length;
                val_11 = val_29 - (val_11 * val_1.Length);
                UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4], g = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4], b = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4], a = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4]};
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = -1.162476E-27f, y = -1.162476E-27f}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
                UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, radius:  0.02f);
                val_29 = val_29 + 1;
            }
            while(val_29 != 3);
            
            var val_39 = 1;
            do
            {
                UnityEngine.Vector2[] val_38 = val_8[36];
                UnityEngine.Vector2[] val_37 = new UnityEngine.Vector2[3][36];
                var val_36 = 0;
                float val_15 = 1f * 0.05f;
                do
            {
                UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  val_15, y:  Dest.Math.Mathfex.EvalSmoothOverlappedStep(x:  val_15, overlap:  0.5f, objectIndex:  0, objectCount:  3));
                mem2[0] = val_17.x;
                mem2[0] = val_17.y;
                int val_18 = val_36 / val_1.Length;
                val_18 = val_36 - (val_18 * val_1.Length);
                UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4], g = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4], b = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4], a = val_1[((long)(int)(0 - ((0 / val_1.Length) * val_1.Length))) << 4]};
                UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_8[0x24] + -4, y = val_8[0x24] + -4 + 4}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
                UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
                UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_14[0x24] + -4, y = val_14[0x24] + -4 + 4}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
                UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, to:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
                UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_14[0x24] + -4, y = val_14[0x24] + -4 + 4}, b:  new UnityEngine.Vector2() {x = offset.x, y = offset.y});
                UnityEngine.Vector3 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y});
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, radius:  0.02f);
                val_36 = val_36 + 1;
                mem2[0] = val_14[0x24] + -4;
                mem2[0] = val_14[0x24] + -4 + 4;
                val_37 = val_37 + 8;
                val_38 = val_38 + 8;
            }
            while(val_36 != 3);
            
                val_39 = val_39 + 1;
            }
            while(val_39 != 21);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_MathfEx()
        {
        
        }
    
    }

}
