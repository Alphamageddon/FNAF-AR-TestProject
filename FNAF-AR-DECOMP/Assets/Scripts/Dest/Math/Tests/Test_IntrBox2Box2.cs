using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrBox2Box2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_5;
            float val_6;
            Dest.Math.Box2 val_1 = 48313.CreateBox2(box:  this.Box0);
            Dest.Math.Box2 val_4 = 48313.CreateBox2(box:  this.Box1);
            bool val_7 = Dest.Math.Intersection.TestBox2Box2(box0: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_2, y = val_2}, Axis0 = new UnityEngine.Vector2() {x = val_2, y = val_2}, Axis1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extents = new UnityEngine.Vector2() {x = val_3, y = val_3}}, box1: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_5, y = val_5}, Axis0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, Axis1 = new UnityEngine.Vector2() {x = val_6, y = val_6}, Extents = new UnityEngine.Vector2() {x = val_6, y = val_6}});
            bool val_8 = val_7;
            val_7.FiguresColor();
            val_7.DrawBox(box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_2, y = val_2}, Axis0 = new UnityEngine.Vector2() {x = val_2, y = val_2}, Axis1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extents = new UnityEngine.Vector2() {x = val_3, y = val_3}});
            val_7.DrawBox(box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_5, y = val_5}, Axis0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, Axis1 = new UnityEngine.Vector2() {x = val_6, y = val_6}, Extents = new UnityEngine.Vector2() {x = val_6, y = val_6}});
            val_8.LogInfo(value:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrBox2Box2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
