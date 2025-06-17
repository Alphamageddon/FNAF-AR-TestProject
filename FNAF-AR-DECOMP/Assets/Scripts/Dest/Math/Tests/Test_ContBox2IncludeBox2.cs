using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContBox2IncludeBox2 : Test_Base
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
            Dest.Math.Box2 val_1 = this.CreateBox2(box:  this.Box0);
            Dest.Math.Box2 val_4 = this.CreateBox2(box:  this.Box1);
            val_2.FiguresColor();
            val_2.DrawBox(box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_2, y = val_2}, Axis0 = new UnityEngine.Vector2() {x = val_2, y = val_2}, Axis1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extents = new UnityEngine.Vector2() {x = val_3, y = val_3}});
            val_2.DrawBox(box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_5, y = val_5}, Axis0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, Axis1 = new UnityEngine.Vector2() {x = val_6, y = val_6}, Extents = new UnityEngine.Vector2() {x = val_6, y = val_6}});
            val_2.ResultsColor();
            val_2.DrawBox(box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_2, y = val_2}, Axis0 = new UnityEngine.Vector2() {x = val_2, y = val_2}, Axis1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extents = new UnityEngine.Vector2() {x = val_3, y = val_3}});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContBox2IncludeBox2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
