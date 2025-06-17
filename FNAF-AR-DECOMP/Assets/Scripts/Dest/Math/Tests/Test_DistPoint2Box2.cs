using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistPoint2Box2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_4;
            float val_5;
            UnityEngine.Vector3 val_1 = this.Point.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            Dest.Math.Box2 val_3 = 0.CreateBox2(box:  this.Box);
            float val_6 = Dest.Math.Distance.Point2Box2(point: ref  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_5, y = val_5}, Axis0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, Axis1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extents = new UnityEngine.Vector2() {x = val_4, y = val_4}}, closestPoint: out  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_2.x.FiguresColor();
            val_2.x.DrawBox(box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_5, y = val_5}, Axis0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, Axis1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extents = new UnityEngine.Vector2() {x = val_4, y = val_4}});
            val_2.x.ResultsColor();
            val_2.x.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_6.LogInfo(value:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistPoint2Box2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
