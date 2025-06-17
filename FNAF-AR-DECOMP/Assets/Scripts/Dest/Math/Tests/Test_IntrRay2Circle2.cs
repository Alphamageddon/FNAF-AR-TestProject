using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrRay2Circle2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Circle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            Dest.Math.Ray2 val_1 = 48343.CreateRay2(ray:  this.Ray);
            Dest.Math.Circle2 val_2 = val_1.Center.x.CreateCircle2(circle:  this.Circle);
            bool val_4 = Dest.Math.Intersection.FindRay2Circle2(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Radius = ???}, info: out  new Dest.Math.Ray2Circle2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f}});
            val_4.FiguresColor();
            val_4.DrawRay(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            val_4.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Radius = ???});
            if(val_4 == false)
            {
                goto label_5;
            }
            
            UnityEngine.Color val_5 = UnityEngine.Color.blue;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
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
            0.DrawSegment(p0:  new UnityEngine.Vector2() {x = 0f, y = 0f}, p1:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            0.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_6:
            0.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_5:
            0.LogInfo(value:  0);
            if((val_4 ^ (Dest.Math.Intersection.TestRay2Circle2(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Radius = ???}))) == false)
            {
                    return;
            }
            
            0.LogError(value:  "test != find");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrRay2Circle2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
