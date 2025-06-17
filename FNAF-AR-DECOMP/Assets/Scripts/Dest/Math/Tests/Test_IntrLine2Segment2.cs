using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrLine2Segment2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
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
            Dest.Math.IntersectionTypes val_6 = 0;
            Dest.Math.Line2 val_1 = 48326.CreateLine2(line:  this.Line);
            Dest.Math.Segment2 val_2 = val_1.Center.x.CreateSegment2(p0:  this.SegmentStart, p1:  this.SegmentEnd);
            bool val_8 = Dest.Math.Intersection.FindLine2Segment2(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, P1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Center = new UnityEngine.Vector2() {x = val_5, y = val_5}, Direction = new UnityEngine.Vector2() {x = val_5, y = val_5}, Extent = val_3}, info: out  new Dest.Math.Line2Segment2Intr() {Point = new UnityEngine.Vector2() {x = 0f, y = 0f}});
            val_8.FiguresColor();
            val_8.DrawLine(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            val_8.DrawSegment(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, P1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Center = new UnityEngine.Vector2() {x = val_5, y = val_5}, Direction = new UnityEngine.Vector2() {x = val_5, y = val_5}, Extent = val_3});
            if(val_8 == false)
            {
                goto label_6;
            }
            
            val_8.ResultsColor();
            if(0 == 2)
            {
                goto label_4;
            }
            
            if(0 != 1)
            {
                goto label_6;
            }
            
            val_8.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            goto label_6;
            label_4:
            val_8.DrawSegment(p0:  new UnityEngine.Vector2() {x = val_4, y = val_4}, p1:  new UnityEngine.Vector2() {x = val_4, y = val_4});
            label_6:
            val_4 = val_6;
            val_4.LogInfo(value:  val_4);
            if((val_8 ^ (Dest.Math.Intersection.TestLine2Segment2(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, P1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Center = new UnityEngine.Vector2() {x = val_5, y = val_5}, Direction = new UnityEngine.Vector2() {x = val_5, y = val_5}, Extent = val_3}, intersectionType: out  val_6))) != false)
            {
                    val_4.LogError(value:  "test != find");
            }
            
            if(val_6 == 0)
            {
                    return;
            }
            
            val_4.LogError(value:  "intersectionType != info.IntersectionType");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrLine2Segment2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
