using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrLine2ConvexPolygon2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform[] ConvexPolygon;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            Dest.Math.Line2 val_1 = 48323.CreateLine2(line:  this.Line);
            Dest.Math.Polygon2 val_2 = val_1.Center.x.CreatePolygon2(polygon:  this.ConvexPolygon);
            bool val_4 = Dest.Math.Intersection.FindLine2ConvexPolygon2(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, convexPolygon:  val_2, info: out  new Dest.Math.Line2ConvexPolygon2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Parameter0 = 0f, Parameter1 = 0f});
            val_4.FiguresColor();
            val_4.DrawLine(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            val_4.DrawPolygon(polygon:  val_2);
            if(val_4 == false)
            {
                goto label_5;
            }
            
            val_4.ResultsColor();
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
            val_4.DrawSegment(p0:  new UnityEngine.Vector2() {x = 0f, y = 0f}, p1:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_4.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_6:
            val_4.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_5:
            0.LogInfo(value:  0);
            if((val_4 ^ (Dest.Math.Intersection.TestLine2ConvexPolygon2(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, convexPolygon:  val_2))) != false)
            {
                    0.LogError(value:  "test != find");
            }
            
            bool val_6 = val_2.IsConvex(threshold:  1E-05f);
            if(val_6 == true)
            {
                    return;
            }
            
            val_6.LogError(value:  "Polygon is non-convex");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrLine2ConvexPolygon2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
