using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContPoint2Circle2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Circle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            UnityEngine.Vector3 val_1 = this.Point.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            Dest.Math.Circle2 val_3 = 0.CreateCircle2(circle:  this.Circle);
            val_2.x.FiguresColor();
            val_2.x.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, Radius = val_1.z});
            if(( & 1) != 0)
            {
                    val_2.x.ResultsColor();
            }
            
            val_2.x.DrawPoint(position:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            false.LogInfo(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContPoint2Circle2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
