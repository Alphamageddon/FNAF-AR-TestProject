using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrRay2Segment2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform SegmentStart;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform SegmentEnd;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_3;
            float val_4;
            float val_5;
            Dest.Math.Ray2 val_1 = 48347.CreateRay2(ray:  this.Ray);
            Dest.Math.Segment2 val_2 = val_1.Center.x.CreateSegment2(p0:  this.SegmentStart, p1:  this.SegmentEnd);
            bool val_8 = Dest.Math.Intersection.FindRay2Segment2(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, P1 = new UnityEngine.Vector2() {x = val_5, y = val_5}, Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Direction = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extent = val_3}, info: out  new Dest.Math.Ray2Segment2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Parameter0 = 0f, Parameter1 = 0f});
            val_8.FiguresColor();
            val_8.DrawRay(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            val_8.DrawSegment(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, P1 = new UnityEngine.Vector2() {x = val_5, y = val_5}, Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Direction = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extent = val_3});
            if(val_8 != false)
            {
                    val_8.ResultsColor();
                if(0 != 1)
            {
                    val_8.DrawSegment(p0:  new UnityEngine.Vector2() {x = 0f, y = 0f}, p1:  new UnityEngine.Vector2() {x = 0f, y = 0f});
                val_8.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            }
            
                val_8.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            }
            
            val_5 = 0;
            val_5.LogInfo(value:  val_5);
            if(((Dest.Math.Intersection.TestRay2Segment2(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, P1 = new UnityEngine.Vector2() {x = val_5, y = val_5}, Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Direction = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extent = val_3}, intersectionType: out  0)) ^ val_8) != false)
            {
                    val_5.LogError(value:  "test != find");
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_5.LogError(value:  "intersectionType != info.IntersectionType");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrRay2Segment2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
