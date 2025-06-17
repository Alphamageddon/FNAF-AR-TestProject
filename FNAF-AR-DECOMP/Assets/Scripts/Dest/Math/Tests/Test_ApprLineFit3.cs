using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ApprLineFit3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform[] Points;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_3;
            float val_4;
            UnityEngine.Vector3[] val_1 = this.CreatePoints3(points:  this.Points);
            if(val_1.Length < 2)
            {
                    return;
            }
            
            Dest.Math.Line3 val_2 = Dest.Math.Approximation.LeastsSquaresLineFit3(points:  val_1);
            val_1.FiguresColor();
            val_1.DrawPoints(points:  val_1, size:  0.11f);
            val_1.ResultsColor();
            val_1.DrawLine(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Direction = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_3}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ApprLineFit3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
