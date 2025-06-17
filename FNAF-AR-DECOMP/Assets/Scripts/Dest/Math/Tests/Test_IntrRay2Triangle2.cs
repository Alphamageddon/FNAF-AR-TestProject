using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrRay2Triangle2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V2;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_3;
            float val_4;
            Dest.Math.IntersectionTypes val_5 = 0;
            Dest.Math.Ray2 val_1 = 48348.CreateRay2(ray:  this.Ray);
            Dest.Math.Triangle2 val_2 = val_1.Center.x.CreateTriangle2(v0:  this.V0, v1:  this.V1, v2:  this.V2);
            bool val_7 = Dest.Math.Intersection.FindRay2Triangle2(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, V1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, V2 = new UnityEngine.Vector2() {x = val_3, y = val_3}}, info: out  new Dest.Math.Ray2Triangle2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f}});
            val_7.FiguresColor();
            val_7.DrawRay(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            val_7.DrawTriangle(triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, V1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, V2 = new UnityEngine.Vector2() {x = val_3, y = val_3}});
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
            val_4 = val_5;
            val_4.LogInfo(value:  val_4);
            if((val_7 ^ (Dest.Math.Intersection.TestRay2Triangle2(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, V1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, V2 = new UnityEngine.Vector2() {x = val_3, y = val_3}}, intersectionType: out  val_5))) != false)
            {
                    val_4.LogError(value:  "test != find");
            }
            
            if(val_5 == 0)
            {
                    return;
            }
            
            val_4.LogError(value:  "intersectionType != info.IntersectionType");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrRay2Triangle2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
