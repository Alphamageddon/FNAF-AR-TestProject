using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrRay2Polygon2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform[] Polygon;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            Dest.Math.Ray2 val_1 = 48345.CreateRay2(ray:  this.Ray);
            Dest.Math.Polygon2 val_2 = val_1.Center.x.CreatePolygon2(polygon:  this.Polygon);
            bool val_3 = Dest.Math.Intersection.FindRay2Polygon2(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, polygon:  val_2, info: out  new Dest.Math.Ray2Polygon2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Parameter0 = 0f});
            val_3.FiguresColor();
            val_3.DrawRay(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            val_3.DrawPolygon(polygon:  val_2);
            if(val_3 == false)
            {
                goto label_5;
            }
            
            val_3.ResultsColor();
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
            val_3.DrawSegment(p0:  new UnityEngine.Vector2() {x = 0f, y = 0f}, p1:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_3.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_6:
            val_3.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_5:
            0.LogInfo(value:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrRay2Polygon2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
