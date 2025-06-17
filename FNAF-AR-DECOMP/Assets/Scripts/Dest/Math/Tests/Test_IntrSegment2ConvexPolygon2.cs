using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrSegment2ConvexPolygon2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform[] ConvexPolygon;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_4;
            Dest.Math.Segment2 val_1 = 48360.CreateSegment2(p0:  this.P0, p1:  this.P1);
            Dest.Math.Polygon2 val_5 = 48360.CreatePolygon2(polygon:  this.ConvexPolygon);
            bool val_7 = Dest.Math.Intersection.FindSegment2ConvexPolygon2(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, P1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Center = new UnityEngine.Vector2() {x = val_3, y = val_3}, Direction = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extent = val_2}, convexPolygon:  val_5, info: out  new Dest.Math.Segment2ConvexPolygon2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Parameter0 = 0f, Parameter1 = val_4});
            val_7.FiguresColor();
            val_7.DrawSegment(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, P1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Center = new UnityEngine.Vector2() {x = val_3, y = val_3}, Direction = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extent = val_2});
            val_7.DrawPolygon(polygon:  val_5);
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
            val_4 = 0;
            val_4.LogInfo(value:  val_4);
            if((val_7 ^ (Dest.Math.Intersection.TestSegment2ConvexPolygon2(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, P1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Center = new UnityEngine.Vector2() {x = val_3, y = val_3}, Direction = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extent = val_2}, convexPolygon:  val_5))) != false)
            {
                    val_4.LogError(value:  "test != find");
            }
            
            bool val_9 = val_5.IsConvex(threshold:  1E-05f);
            if(val_9 == true)
            {
                    return;
            }
            
            val_9.LogError(value:  "Polygon is non-convex");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrSegment2ConvexPolygon2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
