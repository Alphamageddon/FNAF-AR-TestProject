using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_NumericalOdeSolver : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.Tests.Test_NumericalOdeSolver.OdeTask[] _odes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.Tests.Test_NumericalOdeSolver.OdeTypes OdeType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ExactSolution;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Euler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Midpoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string RungeKutta;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DrawEuler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DrawMidpoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool DrawKungeKutta;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            var val_11;
            Dest.Math.OdeFunction val_13;
            System.Func<System.Single, System.Single> val_16;
            var val_17;
            Dest.Math.OdeFunction val_19;
            System.Func<System.Single, System.Single> val_21;
            var val_22;
            Dest.Math.OdeFunction val_24;
            System.Func<System.Single, System.Single> val_26;
            OdeTask[] val_1 = new OdeTask[3];
            Test_NumericalOdeSolver.OdeTask val_2 = new Test_NumericalOdeSolver.OdeTask();
            if(val_2 != null)
            {
                    .t0 = 0f;
                .tEnd = 4f;
                .y0 = 1f;
            }
            else
            {
                    mem[16] = 0;
                .tEnd = 4f;
                mem[24] = 1065353216;
            }
            
            .step = 0.5f;
            val_11 = null;
            val_11 = null;
            val_13 = Test_NumericalOdeSolver.<>c.<>9__11_0;
            if(val_13 == null)
            {
                    Dest.Math.OdeFunction val_3 = null;
                val_13 = val_3;
                val_3 = new Dest.Math.OdeFunction(object:  Test_NumericalOdeSolver.<>c.__il2cppRuntimeField_static_fields, method:  System.Void Test_NumericalOdeSolver.<>c::<OnEnable>b__11_0(float t, float[] y, float[] F));
                val_11 = null;
                Test_NumericalOdeSolver.<>c.<>9__11_0 = val_13;
            }
            
            .Func = val_13;
            val_11 = null;
            val_16 = Test_NumericalOdeSolver.<>c.<>9__11_1;
            if(val_16 == null)
            {
                    System.Func<System.Single, System.Single> val_4 = null;
                val_16 = val_4;
                val_4 = new System.Func<System.Single, System.Single>(object:  Test_NumericalOdeSolver.<>c.__il2cppRuntimeField_static_fields, method:  System.Single Test_NumericalOdeSolver.<>c::<OnEnable>b__11_1(float t));
                Test_NumericalOdeSolver.<>c.<>9__11_1 = val_16;
            }
            
            .ExactSolution = val_16;
            .ScaleY = 0.1f;
            val_1[0] = val_2;
            Test_NumericalOdeSolver.OdeTask val_5 = new Test_NumericalOdeSolver.OdeTask();
            if(val_5 != null)
            {
                    .t0 = 0f;
                .tEnd = 4f;
                .y0 = 2f;
            }
            else
            {
                    mem[16] = 0;
                .tEnd = 4f;
                mem[24] = 1073741824;
            }
            
            .step = 0.3f;
            val_17 = null;
            val_17 = null;
            val_19 = Test_NumericalOdeSolver.<>c.<>9__11_2;
            if(val_19 == null)
            {
                    Dest.Math.OdeFunction val_6 = null;
                val_19 = val_6;
                val_6 = new Dest.Math.OdeFunction(object:  Test_NumericalOdeSolver.<>c.__il2cppRuntimeField_static_fields, method:  System.Void Test_NumericalOdeSolver.<>c::<OnEnable>b__11_2(float t, float[] y, float[] F));
                val_17 = null;
                Test_NumericalOdeSolver.<>c.<>9__11_2 = val_19;
            }
            
            .Func = val_19;
            val_17 = null;
            val_21 = Test_NumericalOdeSolver.<>c.<>9__11_3;
            if(val_21 == null)
            {
                    System.Func<System.Single, System.Single> val_7 = null;
                val_21 = val_7;
                val_7 = new System.Func<System.Single, System.Single>(object:  Test_NumericalOdeSolver.<>c.__il2cppRuntimeField_static_fields, method:  System.Single Test_NumericalOdeSolver.<>c::<OnEnable>b__11_3(float t));
                Test_NumericalOdeSolver.<>c.<>9__11_3 = val_21;
            }
            
            .ExactSolution = val_21;
            .ScaleY = 0.1f;
            val_1[1] = val_5;
            Test_NumericalOdeSolver.OdeTask val_8 = new Test_NumericalOdeSolver.OdeTask();
            if(val_8 != null)
            {
                    .t0 = 3.141593f;
            }
            else
            {
                    mem[16] = 1078530011;
            }
            
            .tEnd = 7f;
            .y0 = 146.1136f;
            .step = 0.3f;
            val_22 = null;
            val_22 = null;
            val_24 = Test_NumericalOdeSolver.<>c.<>9__11_4;
            if(val_24 == null)
            {
                    Dest.Math.OdeFunction val_9 = null;
                val_24 = val_9;
                val_9 = new Dest.Math.OdeFunction(object:  Test_NumericalOdeSolver.<>c.__il2cppRuntimeField_static_fields, method:  System.Void Test_NumericalOdeSolver.<>c::<OnEnable>b__11_4(float t, float[] y, float[] F));
                val_22 = null;
                Test_NumericalOdeSolver.<>c.<>9__11_4 = val_24;
            }
            
            .Func = val_24;
            val_22 = null;
            val_26 = Test_NumericalOdeSolver.<>c.<>9__11_5;
            if(val_26 == null)
            {
                    System.Func<System.Single, System.Single> val_10 = null;
                val_26 = val_10;
                val_10 = new System.Func<System.Single, System.Single>(object:  Test_NumericalOdeSolver.<>c.__il2cppRuntimeField_static_fields, method:  System.Single Test_NumericalOdeSolver.<>c::<OnEnable>b__11_5(float t));
                Test_NumericalOdeSolver.<>c.<>9__11_5 = val_26;
            }
            
            .ExactSolution = val_26;
            .ScaleY = 0.001f;
            val_1[2] = val_8;
            this._odes = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            var val_22;
            OdeTask val_22 = this._odes[this.OdeType];
            float[] val_1 = new float[1];
            val_22 = 1152921504689860608;
            System.Collections.Generic.List<UnityEngine.Vector2> val_2 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            if(this._odes[this.OdeType][0].tEnd >= this._odes[this.OdeType][0].t0)
            {
                    do
            {
                float val_23 = this._odes[this.OdeType][0].ScaleY;
                val_23 = (this._odes[this.OdeType][0].ExactSolution.Invoke(arg:  this._odes[this.OdeType][0].t0)) * val_23;
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  this._odes[this.OdeType][0].t0, y:  val_23);
                val_2.Add(item:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            }
            while((this._odes[this.OdeType][0].t0 + this._odes[this.OdeType][0].step) <= this._odes[this.OdeType][0].tEnd);
            
            }
            
            val_1[0] = this._odes[this.OdeType][0].y0;
            Dest.Math.OdeEuler val_6 = new Dest.Math.OdeEuler(dim:  1, step:  this._odes[this.OdeType][0].step, function:  this._odes[this.OdeType][0].Func);
            System.Collections.Generic.List<UnityEngine.Vector2> val_7 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            if(this._odes[this.OdeType][0].t0 <= this._odes[this.OdeType][0].tEnd)
            {
                    do
            {
                float val_25 = this._odes[this.OdeType][0].ScaleY;
                val_25 = val_1[0] * val_25;
                UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  this._odes[this.OdeType][0].t0, y:  val_25);
                val_7.Add(item:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            }
            while(this._odes[this.OdeType][0].t0 <= this._odes[this.OdeType][0].tEnd);
            
            }
            
            val_1[0] = this._odes[this.OdeType][0].y0;
            Dest.Math.OdeMidpoint val_9 = new Dest.Math.OdeMidpoint(dim:  1, step:  this._odes[this.OdeType][0].step, function:  this._odes[this.OdeType][0].Func);
            System.Collections.Generic.List<UnityEngine.Vector2> val_10 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            if(this._odes[this.OdeType][0].t0 < 0)
            {
                    do
            {
                float val_27 = this._odes[this.OdeType][0].ScaleY;
                val_27 = val_1[0] * val_27;
                UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  this._odes[this.OdeType][0].t0, y:  val_27);
                val_10.Add(item:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            }
            while(this._odes[this.OdeType][0].t0 < 0);
            
            }
            
            val_1[0] = this._odes[this.OdeType][0].y0;
            System.Collections.Generic.List<UnityEngine.Vector2> val_13 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            if(this._odes[this.OdeType][0].t0 < 0)
            {
                    val_22 = 1152921517377849056;
                do
            {
                float val_29 = this._odes[this.OdeType][0].ScaleY;
                val_29 = val_1[0] * val_29;
                UnityEngine.Vector2 val_14 = new UnityEngine.Vector2(x:  this._odes[this.OdeType][0].t0, y:  val_29);
                val_13.Add(item:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            }
            while(this._odes[this.OdeType][0].t0 < 0);
            
            }
            
            new Dest.Math.OdeRungeKutta4(dim:  1, step:  this._odes[this.OdeType][0].step, function:  this._odes[this.OdeType][0].Func).FiguresColor();
            this.DrawSegments(points:  val_2.ToArray());
            if(this.DrawEuler != false)
            {
                    UnityEngine.Color val_16 = UnityEngine.Color.blue;
                UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_16.r, g = val_16.g, b = val_16.b, a = val_16.a};
                this.DrawSegments(points:  val_7.ToArray());
            }
            
            if(this.DrawMidpoint != false)
            {
                    UnityEngine.Color val_18 = UnityEngine.Color.red;
                UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_18.r, g = val_18.g, b = val_18.b, a = val_18.a};
                this.DrawSegments(points:  val_10.ToArray());
            }
            
            if(this.DrawKungeKutta == false)
            {
                    return;
            }
            
            UnityEngine.Color val_20 = UnityEngine.Color.green;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_20.r, g = val_20.g, b = val_20.b, a = val_20.a};
            this.DrawSegments(points:  val_13.ToArray());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_NumericalOdeSolver()
        {
            this.ExactSolution = "is gray";
            this.Euler = "is blue";
            this.Midpoint = "is red";
            this.DrawEuler = true;
            this.DrawMidpoint = true;
            this.RungeKutta = "is green";
            this.DrawKungeKutta = true;
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
