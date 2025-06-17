using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_Interpolation : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _timer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Readme;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.Tests.Test_Interpolation.Types Type;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AnimationCurve Curve;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 From;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector2 To;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Speed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Time;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float Func(float value)
        {
            if(value <= _TYPE_MAX_)
            {
                    return (float)value;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = val_1 * this.Speed;
            val_1 = this._timer + val_1;
            this._timer = val_1;
            if(val_1 <= this.Time)
            {
                    return;
            }
            
            val_1 = val_1 - this.Time;
            this._timer = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            var val_12;
            if(this.Type <= 6)
            {
                    var val_10 = 52957136 + (this.Type) << 2;
                val_10 = val_10 + 52957136;
            }
            else
            {
                    val_12 = 0;
                float val_2 = this._timer / this.Time;
                UnityEngine.Color val_5 = UnityEngine.Color.blue;
                UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
                UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.From, y = this.To});
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, radius:  0.5f);
                UnityEngine.Vector3 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.To, y = val_6.y});
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, radius:  0.5f);
                UnityEngine.Color val_8 = UnityEngine.Color.white;
                UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
                UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = Invoke(arg1:  this.From, arg2:  this.To, arg3:  val_2), y = Invoke(arg1:  this.To, arg2:  V11.16B, arg3:  val_2)});
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, radius:  0.25f);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_Interpolation()
        {
            this.Readme = "Press Play To Launch";
            this = new UnityEngine.MonoBehaviour();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <OnDrawGizmos>b__11_0(float v0, float v1, float factor)
        {
            return Dest.Math.Mathfex.CurveInterp(value0:  v0, value1:  v1, factor:  factor, curve:  this.Curve);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float <OnDrawGizmos>b__11_1(float v0, float v1, float factor)
        {
            return Dest.Math.Mathfex.FuncInterp(value0:  v0, value1:  v1, factor:  factor, func:  new System.Func<System.Single, System.Single>(object:  this, method:  System.Single Dest.Math.Tests.Test_Interpolation::Func(float value)));
        }
    
    }

}
