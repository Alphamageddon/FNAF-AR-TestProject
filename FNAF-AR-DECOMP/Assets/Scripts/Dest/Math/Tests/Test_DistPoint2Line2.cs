using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistPoint2Line2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            UnityEngine.Vector3 val_1 = this.Point.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            Dest.Math.Line2 val_3 = 0.CreateLine2(line:  this.Line);
            val_2.x.FiguresColor();
            val_2.x.DrawLine(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, Direction = new UnityEngine.Vector2() {x = val_1.z, y = ???}});
            val_2.x.ResultsColor();
            val_2.x.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            string val_5 = Dest.Math.Distance.Point2Line2(point: ref  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, Direction = new UnityEngine.Vector2() {x = val_1.z, y = ???}}, closestPoint: out  new UnityEngine.Vector2() {x = 0f, y = 0f})(Dest.Math.Distance.Point2Line2(point: ref  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, Direction = new UnityEngine.Vector2() {x = val_1.z, y = ???}}, closestPoint: out  new UnityEngine.Vector2() {x = 0f, y = 0f})) + "   " + val_2.x;
            val_5.LogInfo(value:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistPoint2Line2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
