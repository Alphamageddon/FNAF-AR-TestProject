using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrSegment2Circle2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Circle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_4;
            Dest.Math.Segment2 val_1 = 48359.CreateSegment2(p0:  this.P0, p1:  this.P1);
            Dest.Math.Circle2 val_5 = 48359.CreateCircle2(circle:  this.Circle);
            bool val_7 = Dest.Math.Intersection.FindSegment2Circle2(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, P1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Direction = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extent = val_2}, circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = val_4, y = val_3}, Radius = ???}, info: out  new Dest.Math.Segment2Circle2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f}});
            val_7.FiguresColor();
            val_7.DrawSegment(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, P1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Direction = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extent = val_2});
            val_7.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = val_4, y = val_3}, Radius = ???});
            if(val_7 == false)
            {
                goto label_5;
            }
            
            val_7.ResultsColor();
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
            val_7.DrawSegment(p0:  new UnityEngine.Vector2() {x = 0f, y = 0f}, p1:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_7.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_6:
            val_7.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_5:
            val_3 = 0;
            val_3.LogInfo(value:  val_3);
            if((val_7 ^ (Dest.Math.Intersection.TestSegment2Circle2(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, P1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Direction = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extent = val_2}, circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = val_4, y = val_3}, Radius = ???}))) == false)
            {
                    return;
            }
            
            val_3.LogError(value:  "test != find");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrSegment2Circle2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
