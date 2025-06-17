using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_NumericalIntegrator : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.Tests.Test_NumericalIntegrator.Funcs FuncType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float a;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float b;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TrapezoidSamples;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int RombergOrder;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float Func(float x)
        {
            double val_1;
            var val_2;
            val_1 = x;
            val_2 = this;
            if(this.FuncType == 2)
            {
                goto label_1;
            }
            
            if(this.FuncType == 1)
            {
                goto label_2;
            }
            
            if(this.FuncType != 0)
            {
                    return (float)val_2;
            }
            
            if(0f < _TYPE_MAX_)
            {
                    return (float)val_2;
            }
            
            val_2 = ???;
            val_1 = ???;
            label_1:
            float val_1 = val_1;
            val_1 = val_1 + 2f;
            return (float)val_2;
            label_2:
            float val_2 = 0.1f;
            val_2 = val_1 * val_2;
            val_2 = val_2 * val_1;
            return (float)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float Integral()
        {
            float val_5;
            float val_6;
            float val_7;
            if(this.FuncType == 2)
            {
                goto label_1;
            }
            
            if(this.FuncType == 1)
            {
                goto label_2;
            }
            
            if(this.FuncType != 0)
            {
                    return (float)val_6;
            }
            
            val_5 = this.b;
            float val_5 = this.a;
            val_5 = val_5 + val_5;
            val_6 = (val_5 + val_5) / 3f;
            val_7 = val_5 / 3f;
            goto label_6;
            label_1:
            val_5 = this.b;
            val_6 = (val_5 + val_5) - val_5;
            val_7 = (this.a + this.a) - this.a;
            label_6:
            val_7 = val_6 - val_7;
            return (float)val_6;
            label_2:
            val_5 = this.b;
            float val_6 = this.a;
            val_6 = val_6 * 0.03333334f;
            val_6 = (val_5 * 0.03333334f) - val_6;
            return (float)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            48390.FiguresColor();
            System.Func<System.Single, System.Single> val_1 = new System.Func<System.Single, System.Single>(object:  this, method:  System.Single Dest.Math.Tests.Test_NumericalIntegrator::Func(float x));
            val_1.DrawFunc(func:  val_1, from:  this.a, to:  this.b, count:  100);
            object[] val_2 = new object[8];
            val_2[0] = "Analytical: ";
            val_2[1] = this.Integral();
            val_2[2] = "     Trapezoid: ";
            val_2[3] = Dest.Math.Integrator.TrapezoidRule(function:  new System.Func<System.Single, System.Single>(object:  this, method:  System.Single Dest.Math.Tests.Test_NumericalIntegrator::Func(float x)), a:  this.a, b:  this.b, sampleCount:  this.TrapezoidSamples);
            val_2[4] = "     Romberg: ";
            val_2[5] = Dest.Math.Integrator.RombergIntegral(function:  new System.Func<System.Single, System.Single>(object:  this, method:  System.Single Dest.Math.Tests.Test_NumericalIntegrator::Func(float x)), a:  this.a, b:  this.b, order:  this.RombergOrder);
            val_2[6] = "     Gaussian: ";
            val_2[7] = Dest.Math.Integrator.GaussianQuadrature(function:  new System.Func<System.Single, System.Single>(object:  this, method:  System.Single Dest.Math.Tests.Test_NumericalIntegrator::Func(float x)), a:  this.a, b:  this.b);
            string val_10 = +val_2;
            val_10.LogInfo(value:  val_10);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_NumericalIntegrator()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
