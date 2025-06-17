using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrAAB2Circle2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box_Point0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box_Point1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Circle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            Dest.Math.AAB2 val_1 = 48310.CreateAAB2(point0:  this.Box_Point0, point1:  this.Box_Point1);
            Dest.Math.Circle2 val_2 = val_1.Min.x.CreateCircle2(circle:  this.Circle);
            bool val_3 = Dest.Math.Intersection.TestAAB2Circle2(box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = ???, y = ???}, Max = new UnityEngine.Vector2() {x = ???, y = ???}}, circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Radius = ???});
            bool val_4 = val_3;
            val_3.FiguresColor();
            val_3.DrawAAB(box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = ???, y = ???}, Max = new UnityEngine.Vector2() {x = ???, y = ???}});
            val_3.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Radius = ???});
            val_4.LogInfo(value:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrAAB2Circle2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
