using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrCircle2Circle2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Circle0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Circle1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            Dest.Math.Circle2 val_1 = 48318.CreateCircle2(circle:  this.Circle0);
            Dest.Math.Circle2 val_2 = val_1.Center.x.CreateCircle2(circle:  this.Circle1);
            bool val_3 = Dest.Math.Intersection.FindCircle2Circle2(circle0: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Radius = ???}, circle1: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Radius = ???}, info: out  new Dest.Math.Circle2Circle2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f, y = ???}});
            val_3.FiguresColor();
            val_3.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Radius = ???});
            val_3.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = ???, y = ???}, Radius = ???});
            if(val_3 == false)
            {
                goto label_8;
            }
            
            val_3.ResultsColor();
            if(0 != 1)
            {
                goto label_8;
            }
            
            if(0 == 2)
            {
                goto label_5;
            }
            
            if(0 != 1)
            {
                goto label_8;
            }
            
            goto label_7;
            label_5:
            val_3.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_7:
            val_3.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_8:
            string val_4 = 0 + " " + 0;
            val_4.LogInfo(value:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrCircle2Circle2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
