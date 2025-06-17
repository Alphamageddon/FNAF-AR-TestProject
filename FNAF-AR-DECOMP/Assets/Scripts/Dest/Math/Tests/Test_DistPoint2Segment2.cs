using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistPoint2Segment2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_4;
            float val_5;
            float val_6;
            UnityEngine.Vector3 val_1 = this.Point.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            Dest.Math.Segment2 val_3 = 0.CreateSegment2(p0:  this.P0, p1:  this.P1);
            val_5.FiguresColor();
            val_5.DrawSegment(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, P1 = new UnityEngine.Vector2() {x = val_5, y = val_5}, Center = new UnityEngine.Vector2() {x = val_6, y = val_6}, Direction = new UnityEngine.Vector2() {x = val_6, y = val_6}, Extent = val_4});
            val_5.ResultsColor();
            val_5.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            string val_8 = Dest.Math.Distance.Point2Segment2(point: ref  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, P1 = new UnityEngine.Vector2() {x = val_5, y = val_5}, Center = new UnityEngine.Vector2() {x = val_6, y = val_6}, Direction = new UnityEngine.Vector2() {x = val_6, y = val_6}, Extent = val_4}, closestPoint: out  new UnityEngine.Vector2() {x = 0f, y = 0f})(Dest.Math.Distance.Point2Segment2(point: ref  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, P1 = new UnityEngine.Vector2() {x = val_5, y = val_5}, Center = new UnityEngine.Vector2() {x = val_6, y = val_6}, Direction = new UnityEngine.Vector2() {x = val_6, y = val_6}, Extent = val_4}, closestPoint: out  new UnityEngine.Vector2() {x = 0f, y = 0f})) + "   " + val_2.x;
            val_8.LogInfo(value:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistPoint2Segment2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
