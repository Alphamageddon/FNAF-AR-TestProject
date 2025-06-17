using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContPoint2AAB2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box_Point0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box_Point1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            UnityEngine.Vector3 val_1 = this.Point.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            Dest.Math.AAB2 val_3 = 0.CreateAAB2(point0:  this.Box_Point0, point1:  this.Box_Point1);
            val_2.x.FiguresColor();
            val_2.x.DrawAAB(box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, Max = new UnityEngine.Vector2() {x = val_1.z, y = ???}});
            if(( & 1) != 0)
            {
                    val_2.x.ResultsColor();
            }
            
            val_2.x.DrawPoint(position:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            false.LogInfo(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContPoint2AAB2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
