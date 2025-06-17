using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrBox2Circle2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Circle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            Dest.Math.Box2 val_1 = 48314.CreateBox2(box:  this.Box);
            Dest.Math.Circle2 val_4 = 48314.CreateCircle2(circle:  this.Circle);
            bool val_5 = Dest.Math.Intersection.TestBox2Circle2(box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_2, y = val_2}, Axis0 = new UnityEngine.Vector2() {x = val_2, y = val_2}, Axis1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extents = new UnityEngine.Vector2() {x = val_3, y = val_3}}, circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = val_3, y = val_2}, Radius = ???});
            bool val_6 = val_5;
            val_5.FiguresColor();
            val_5.DrawBox(box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_2, y = val_2}, Axis0 = new UnityEngine.Vector2() {x = val_2, y = val_2}, Axis1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extents = new UnityEngine.Vector2() {x = val_3, y = val_3}});
            val_5.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = val_3, y = val_2}, Radius = ???});
            val_6.LogInfo(value:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrBox2Circle2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
