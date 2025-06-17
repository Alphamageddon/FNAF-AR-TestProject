using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ApprLineFit2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform[] Points;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            UnityEngine.Vector2[] val_1 = this.CreatePoints2(points:  this.Points);
            if(val_1.Length < 2)
            {
                    return;
            }
            
            Dest.Math.Line2 val_2 = Dest.Math.Approximation.LeastSquaresLineFit2(points:  val_1);
            val_2.Center.x.FiguresColor();
            val_2.Center.x.DrawPoints(points:  val_1, size:  0.11f);
            val_2.Center.x.ResultsColor();
            val_2.Center.x.DrawLine(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ApprLineFit2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
