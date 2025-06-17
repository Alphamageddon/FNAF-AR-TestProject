using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrSegment2Segment2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Seg0Start;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Seg0End;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Seg1Start;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Seg1End;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_6;
            float val_7;
            float val_8;
            Dest.Math.Segment2 val_1 = 48361.CreateSegment2(p0:  this.Seg0Start, p1:  this.Seg0End);
            Dest.Math.Segment2 val_5 = 48361.CreateSegment2(p0:  this.Seg1Start, p1:  this.Seg1End);
            bool val_11 = Dest.Math.Intersection.FindSegment2Segment2(segment0: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, P1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Center = new UnityEngine.Vector2() {x = val_3, y = val_3}, Direction = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extent = val_2}, segment1: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_7, y = val_7}, P1 = new UnityEngine.Vector2() {x = val_7, y = val_7}, Center = new UnityEngine.Vector2() {x = val_8, y = val_8}, Direction = new UnityEngine.Vector2() {x = val_8, y = val_8}, Extent = val_6}, info: out  new Dest.Math.Segment2Segment2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Parameter0 = 0f, Parameter1 = 0f});
            val_11.FiguresColor();
            val_11.DrawSegment(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, P1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Center = new UnityEngine.Vector2() {x = val_3, y = val_3}, Direction = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extent = val_2});
            val_11.DrawSegment(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_7, y = val_7}, P1 = new UnityEngine.Vector2() {x = val_7, y = val_7}, Center = new UnityEngine.Vector2() {x = val_8, y = val_8}, Direction = new UnityEngine.Vector2() {x = val_8, y = val_8}, Extent = val_6});
            if(val_11 == false)
            {
                goto label_5;
            }
            
            val_11.ResultsColor();
            if(0 == 2)
            {
                goto label_4;
            }
            
            if(0 != 1)
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            val_11.DrawSegment(p0:  new UnityEngine.Vector2() {x = 0f, y = 0f}, p1:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_11.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_6:
            val_11.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_5:
            val_4 = 0;
            val_4.LogInfo(value:  val_4);
            if((val_11 ^ (Dest.Math.Intersection.TestSegment2Segment2(segment0: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, P1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Center = new UnityEngine.Vector2() {x = val_3, y = val_3}, Direction = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extent = val_2}, segment1: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_7, y = val_7}, P1 = new UnityEngine.Vector2() {x = val_7, y = val_7}, Center = new UnityEngine.Vector2() {x = val_8, y = val_8}, Direction = new UnityEngine.Vector2() {x = val_8, y = val_8}, Extent = val_6}, intersectionType: out  0))) != false)
            {
                    val_4.LogError(value:  "test != find");
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_4.LogError(value:  "intersectionType != info.IntersectionType");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrSegment2Segment2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
