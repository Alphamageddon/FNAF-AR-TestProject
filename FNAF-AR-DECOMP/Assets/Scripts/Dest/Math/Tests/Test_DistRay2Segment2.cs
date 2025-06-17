using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistRay2Segment2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_3;
            float val_4;
            float val_5;
            Dest.Math.Ray2 val_1 = 48297.CreateRay2(ray:  this.Ray);
            Dest.Math.Segment2 val_2 = val_1.Center.x.CreateSegment2(p0:  this.P0, p1:  this.P1);
            float val_6 = Dest.Math.Distance.Ray2Segment2(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, P1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Center = new UnityEngine.Vector2() {x = val_5, y = val_5}, Direction = new UnityEngine.Vector2() {x = val_5, y = val_5}, Extent = val_3}, closestPoint0: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, closestPoint1: out  new UnityEngine.Vector2() {x = 0f, y = 0f});
            0f.FiguresColor();
            0f.DrawRay(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            0f.DrawSegment(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, P1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Center = new UnityEngine.Vector2() {x = val_5, y = val_5}, Direction = new UnityEngine.Vector2() {x = val_5, y = val_5}, Extent = val_3});
            0f.ResultsColor();
            0f.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            0f.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_6.LogInfo(value:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistRay2Segment2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
