using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ApprPlaneFit3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform[] Points;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            UnityEngine.Vector3[] val_1 = this.CreatePoints3(points:  this.Points);
            if(val_1.Length < 2)
            {
                    return;
            }
            
            Dest.Math.Plane3 val_2 = Dest.Math.Approximation.LeastSquaresPlaneFit3(points:  val_1);
            val_2.Normal.x.FiguresColor();
            val_2.Normal.x.DrawPoints(points:  val_1, size:  0.11f);
            val_2.Normal.x.ResultsColor();
            this = this.Points;
            0.DrawPlane(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, Constant = ???}, Plane:  this[0]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ApprPlaneFit3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
