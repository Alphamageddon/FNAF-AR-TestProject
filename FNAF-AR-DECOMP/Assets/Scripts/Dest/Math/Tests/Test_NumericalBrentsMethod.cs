using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_NumericalBrentsMethod : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Dest.Math.Tests.Test_NumericalBrentsMethod.Funcs FuncType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float From;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float To;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float Func(float x)
        {
            float val_8;
            var val_9;
            float val_10;
            float val_11;
            val_8 = x;
            val_9 = this;
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
                    return (float)val_10;
            }
            
            float val_8 = 0.5f;
            float val_1 = val_8 * val_8;
            val_8 = val_8 * val_8;
            val_1 = val_1 * val_8;
            val_8 = val_8 * val_8;
            val_10 = val_1 + val_8;
            val_11 = 2f;
            goto label_4;
            label_1:
            val_9 = ???;
            val_8 = ???;
            label_2:
            val_10 = (val_8 * val_8) * val_8;
            val_11 = val_8 * (-2f);
            label_4:
            val_10 = val_10 + val_11;
            return (float)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            object val_6;
            48387.FiguresColor();
            System.Func<System.Single, System.Single> val_1 = new System.Func<System.Single, System.Single>(object:  this, method:  System.Single Dest.Math.Tests.Test_NumericalBrentsMethod::Func(float x));
            val_1.DrawFunc(func:  val_1, from:  this.From, to:  this.To, count:  100);
            bool val_3 = Dest.Math.RootFinder.BrentsMethod(function:  new System.Func<System.Single, System.Single>(object:  this, method:  System.Single Dest.Math.Tests.Test_NumericalBrentsMethod::Func(float x)), x0:  this.From, x1:  this.To, root: out  new Dest.Math.BrentsRoot() {X = 0f, ExceededMaxIterations = false}, maxIterations:  128, negativeTolerance:  -1E-05f, positiveTolerance:  1E-05f, stepTolerance:  1E-05f, segmentTolerance:  1E-05f);
            if(val_3 != false)
            {
                    val_3.ResultsColor();
                new UnityEngine.Vector2(x:  0f, y:  0f).DrawPoint(position:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                val_6 = "Root: "("Root: ") + 0f;
            }
            else
            {
                    val_6 = "No root";
            }
            
            val_3.LogInfo(value:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_NumericalBrentsMethod()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
