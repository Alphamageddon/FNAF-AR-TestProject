using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrRay2AAB2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box_Point0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box_Point1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            Dest.Math.Ray2 val_1 = 48341.CreateRay2(ray:  this.Ray);
            Dest.Math.AAB2 val_2 = val_1.Center.x.CreateAAB2(point0:  this.Box_Point0, point1:  this.Box_Point1);
            bool val_4 = Dest.Math.Intersection.FindRay2AAB2(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = ???, y = ???}, Max = new UnityEngine.Vector2() {x = ???, y = ???}}, info: out  new Dest.Math.Ray2AAB2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f, y = ???}});
            val_4.FiguresColor();
            val_4.DrawRay(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            val_4.DrawAAB(box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = ???, y = ???}, Max = new UnityEngine.Vector2() {x = ???, y = ???}});
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
            if((val_4 ^ (Dest.Math.Intersection.TestRay2AAB2(ray: ref  new Dest.Math.Ray2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = ???, y = ???}, Max = new UnityEngine.Vector2() {x = ???, y = ???}}))) == false)
            {
                    return;
            }
            
            0.LogError(value:  "test != find");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrRay2AAB2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
