using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_FollowSpline : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.PositionTangent[] _visualPoints;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _time;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _distance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _splineLength;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.CatmullRomSpline3 Spline;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Target;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ParametrizationCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ConstantSpeedTraversal;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float TimeSpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ConstantSpeed;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            var val_4;
            var val_5;
            Dest.Math.PositionTangent[] val_13;
            var val_14;
            var val_15;
            float val_16;
            Dest.Math.PositionTangent[] val_17;
            if(this.ConstantSpeedTraversal == false)
            {
                goto label_1;
            }
            
            this._splineLength = this.Spline.ParametrizeByArcLength(pointCount:  this.ParametrizationCount);
            val_13 = new Dest.Math.PositionTangent[0];
            val_14 = 0;
            this._visualPoints = val_13;
            goto label_3;
            label_15:
            int val_18 = this._visualPoints.Length;
            float val_19 = 0f;
            val_18 = val_18 - 1;
            val_19 = val_19 / (float)val_18;
            val_19 = this._splineLength * val_19;
            Dest.Math.PositionTangent val_3 = this.Spline.EvalPositionTangentParametrized(length:  val_19);
            val_15 = 0;
            var val_6 = this._visualPoints + (val_15 * 24);
            mem2[0] = val_4;
            mem2[0] = val_5;
            var val_8 = this._visualPoints + (val_15 * 24);
            UnityEngine.Vector3 val_9 = this.Spline.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = (val_15 * 24) + this._visualPoints + 32, y = (val_15 * 24) + this._visualPoints + 32 + 4, z = (val_15 * 24) + this._visualPoints + 40});
            val_16 = val_9.x;
            var val_10 = this._visualPoints + (val_15 * 24);
            mem2[0] = val_16;
            mem2[0] = val_9.y;
            mem2[0] = val_9.z;
            val_13 = this._visualPoints;
            val_14 = 1;
            label_3:
            if(val_14 < this._visualPoints.Length)
            {
                goto label_15;
            }
            
            return;
            label_1:
            val_17 = new Dest.Math.PositionTangent[0];
            val_14 = 0;
            this._visualPoints = val_17;
            goto label_28;
            label_32:
            if(this._visualPoints == null)
            {
                goto label_18;
            }
            
            label_30:
            int val_20 = this._visualPoints.Length;
            float val_21 = 0f;
            val_20 = val_20 - 1;
            val_21 = val_21 / (float)val_20;
            Dest.Math.PositionTangent val_12 = this.Spline.EvalPositionTangent(time:  val_21);
            val_15 = 0;
            var val_13 = this._visualPoints + (val_15 * 24);
            mem2[0] = val_4;
            mem2[0] = val_5;
            var val_15 = this._visualPoints + (val_15 * 24);
            UnityEngine.Vector3 val_16 = this.Spline.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = (val_15 * 24) + this._visualPoints + 32, y = (val_15 * 24) + this._visualPoints + 32 + 4, z = (val_15 * 24) + this._visualPoints + 40});
            val_16 = val_16.x;
            var val_17 = this._visualPoints + (val_15 * 24);
            mem2[0] = val_16;
            mem2[0] = val_16.y;
            mem2[0] = val_16.z;
            val_17 = this._visualPoints;
            val_14 = 1;
            goto label_28;
            label_18:
            if(this.Spline != null)
            {
                goto label_30;
            }
            
            goto label_30;
            label_28:
            if(val_14 < val_11.Length)
            {
                goto label_32;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            float val_7;
            if(this.ConstantSpeedTraversal == false)
            {
                goto label_0;
            }
            
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.ConstantSpeed * val_1;
            val_7 = this._distance + val_1;
            this._distance = val_7;
            if(val_7 > this._splineLength)
            {
                    val_7 = 0f;
                this._distance = 0f;
            }
            
            this.Spline.EvalPositionTangentParametrized(length:  val_7, positionTangent: out  new Dest.Math.PositionTangent() {Position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Tangent = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}});
            UnityEngine.Vector3 val_3 = this.Spline.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.Target.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            if(this.Target != null)
            {
                goto label_11;
            }
            
            label_12:
            label_11:
            this.Target.forward = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            return;
            label_0:
            float val_7 = this._time;
            float val_4 = UnityEngine.Time.deltaTime;
            val_4 = this.TimeSpeed * val_4;
            val_4 = val_7 + val_4;
            val_7 = (val_4 > 1f) ? 0f : (val_4);
            this._time = val_7;
            this.Spline.EvalPositionTangent(time:  val_7, positionTangent: out  new Dest.Math.PositionTangent() {Position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Tangent = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}});
            UnityEngine.Vector3 val_6 = this.Spline.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.Target.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            if(this.Target != null)
            {
                goto label_11;
            }
            
            goto label_12;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            if(this._visualPoints == null)
            {
                    return;
            }
            
            if(this._visualPoints.Length < 1)
            {
                    return;
            }
            
            do
            {
                var val_1 = this._visualPoints + (0 * 24);
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = (0 * 24) + this._visualPoints + 40 + 4, y = (0 * 24) + this._visualPoints + 48, z = (0 * 24) + this._visualPoints + 48 + 4}, d:  5f);
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (0 * 24) + this._visualPoints + 32, y = (0 * 24) + this._visualPoints + 32 + 4, z = (0 * 24) + this._visualPoints + 40}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = (0 * 24) + this._visualPoints + 32, y = (0 * 24) + this._visualPoints + 32 + 4, z = (0 * 24) + this._visualPoints + 40}, to:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = (0 * 24) + this._visualPoints + 32, y = (0 * 24) + this._visualPoints + 32 + 4, z = (0 * 24) + this._visualPoints + 40}, radius:  0.5f);
            }
            while((0 + 1) < this._visualPoints.Length);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_FollowSpline()
        {
        
        }
    
    }

}
