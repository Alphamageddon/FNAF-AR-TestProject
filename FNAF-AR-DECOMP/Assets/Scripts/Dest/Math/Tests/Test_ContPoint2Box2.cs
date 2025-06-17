using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContPoint2Box2 : Test_Base
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
            val_4.FiguresColor();
            val_4.DrawBox(box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Axis0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Axis1 = new UnityEngine.Vector2() {x = val_5, y = val_5}, Extents = new UnityEngine.Vector2() {x = val_5, y = val_5}});
            if(( & 1) != 0)
            {
                    val_4.ResultsColor();
            }
            
            val_4.DrawPoint(position:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            val_4 = false;
            val_4.LogInfo(value:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContPoint2Box2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
