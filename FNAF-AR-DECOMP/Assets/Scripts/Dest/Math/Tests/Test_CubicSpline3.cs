using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_CubicSpline3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.CurveFrame[] _frames;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float[] _curvatures;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.CubicSpline3 Spline;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ParametrizationCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DrawTangents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DrawNormals;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DrawCurvatures;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CurvatureIndex;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            Dest.Math.CurveFrame[] val_7;
            this._frames = new Dest.Math.CurveFrame[0];
            this._curvatures = new float[0];
            if(this.ParametrizationCount < 1)
            {
                    return;
            }
            
            var val_12 = 0;
            label_14:
            float val_11 = 0f;
            val_11 = val_11 / ((float)this.ParametrizationCount - 1);
            Dest.Math.CurveFrame val_6 = (this._frames + (0 * 48)) + 32;
            this.Spline.EvalFrame(time:  val_11, frame: out  new Dest.Math.CurveFrame() {Position = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Tangent = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Normal = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Binormal = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}});
            val_7 = this._frames;
            if(this._frames != null)
            {
                goto label_6;
            }
            
            val_7 = this._frames;
            if(val_7 == null)
            {
                goto label_7;
            }
            
            label_6:
            var val_7 = val_7 + (0 * 48);
            UnityEngine.Vector3 val_8 = this.Spline.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = (0 * 48) + this._frames + 32, y = (0 * 48) + this._frames + 32 + 4, z = (0 * 48) + this._frames + 40});
            var val_9 = this._frames + (0 * 48);
            mem2[0] = val_8.x;
            mem2[0] = val_8.y;
            mem2[0] = val_8.z;
            this._curvatures[0] = this.Spline.EvalCurvature(time:  val_11);
            val_12 = val_12 + 1;
            if(val_12 < this.ParametrizationCount)
            {
                goto label_14;
            }
            
            return;
            label_7:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            int val_12;
            Dest.Math.CurveFrame[] val_13;
            float val_14;
            int val_15;
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            val_12 = this;
            val_13 = this._frames;
            if(val_13 == null)
            {
                    return;
            }
            
            if(this.ParametrizationCount < 1)
            {
                goto label_2;
            }
            
            val_14 = 0.05f;
            var val_15 = 0;
            val_15 = 48;
            goto label_3;
            label_16:
            val_13 = this._frames;
            label_3:
            var val_1 = val_13 + (0 * val_15);
            val_16 = mem[(0 * val_15) + this._frames + 32];
            val_16 = (0 * val_15) + this._frames + 32;
            val_17 = mem[(0 * val_15) + this._frames + 40];
            val_17 = (0 * val_15) + this._frames + 40;
            UnityEngine.Color val_2 = UnityEngine.Color.red;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            if(this.DrawTangents != false)
            {
                    var val_3 = this._frames + (0 * val_15);
                val_18 = mem[(0 * val_15) + this._frames + 44];
                val_18 = (0 * val_15) + this._frames + 44;
                val_19 = mem[(0 * val_15) + this._frames + 52];
                val_19 = (0 * val_15) + this._frames + 52;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18, y = (0 * val_15) + this._frames + 44 + 4, z = val_19}, d:  0.5f);
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16, y = (0 * val_15) + this._frames + 32 + 4, z = val_17}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_16, y = (0 * val_15) + this._frames + 32 + 4, z = val_17}, to:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            }
            
            UnityEngine.Color val_6 = UnityEngine.Color.green;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
            if(this.DrawNormals != false)
            {
                    var val_7 = this._frames + (0 * val_15);
                val_18 = mem[(0 * val_15) + this._frames + 56];
                val_18 = (0 * val_15) + this._frames + 56;
                val_19 = mem[(0 * val_15) + this._frames + 64];
                val_19 = (0 * val_15) + this._frames + 64;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18, y = (0 * val_15) + this._frames + 56 + 4, z = val_19}, d:  0.5f);
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16, y = (0 * val_15) + this._frames + 32 + 4, z = val_17}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_16, y = (0 * val_15) + this._frames + 32 + 4, z = val_17}, to:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            }
            
            UnityEngine.Color val_10 = UnityEngine.Color.white;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a};
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = val_16, y = (0 * val_15) + this._frames + 32 + 4, z = val_17}, radius:  val_14);
            val_15 = val_15 + 1;
            if(val_15 < this.ParametrizationCount)
            {
                goto label_16;
            }
            
            label_2:
            if(this.DrawCurvatures == false)
            {
                    return;
            }
            
            UnityEngine.Color val_11 = UnityEngine.Color.yellow;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
            val_15 = this.CurvatureIndex;
            var val_16 = 48;
            val_16 = this._frames + (val_15 * val_16);
            val_17 = mem[(this.CurvatureIndex * 48) + this._frames + 32 + 4];
            val_17 = (this.CurvatureIndex * 48) + this._frames + 32 + 4;
            val_14 = mem[(this.CurvatureIndex * 48) + this._frames + 56];
            val_14 = (this.CurvatureIndex * 48) + this._frames + 56;
            val_19 = mem[(this.CurvatureIndex * 48) + this._frames + 64];
            val_19 = (this.CurvatureIndex * 48) + this._frames + 64;
            val_16 = mem[(this.CurvatureIndex * 48) + this._frames + 64 + 4];
            val_16 = (this.CurvatureIndex * 48) + this._frames + 64 + 4;
            val_12 = this.CurvatureIndex;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14, y = (this.CurvatureIndex * 48) + this._frames + 56 + 4, z = val_19}, d:  1f / this._curvatures[val_12]);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (this.CurvatureIndex * 48) + this._frames + 32, y = val_17, z = (this.CurvatureIndex * 48) + this._frames + 40}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            0.DrawCircle(circle: ref  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Radius = 0f}, count:  100);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_CubicSpline3()
        {
            this.DrawCurvatures = true;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
