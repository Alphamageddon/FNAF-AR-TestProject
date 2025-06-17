using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrLine2Box2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_3;
            float val_4;
            Dest.Math.Line2 val_1 = 48321.CreateLine2(line:  this.Line);
            Dest.Math.Box2 val_2 = val_1.Center.x.CreateBox2(box:  this.Box);
            bool val_6 = Dest.Math.Intersection.FindLine2Box2(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Axis0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Axis1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extents = new UnityEngine.Vector2() {x = val_3, y = val_3}}, info: out  new Dest.Math.Line2Box2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f, y = val_4}});
            val_6.FiguresColor();
            val_6.DrawLine(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            val_6.DrawBox(box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Axis0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Axis1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extents = new UnityEngine.Vector2() {x = val_3, y = val_3}});
            if(val_6 == false)
            {
                goto label_5;
            }
            
            val_6.ResultsColor();
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
            val_6.DrawSegment(p0:  new UnityEngine.Vector2() {x = 0f, y = 0f}, p1:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_6.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_6:
            val_6.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_5:
            val_4 = 0;
            val_4.LogInfo(value:  val_4);
            if((val_6 ^ (Dest.Math.Intersection.TestLine2Box2(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}}, box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Axis0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Axis1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extents = new UnityEngine.Vector2() {x = val_3, y = val_3}}))) == false)
            {
                    return;
            }
            
            val_4.LogError(value:  "test != find");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrLine2Box2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
