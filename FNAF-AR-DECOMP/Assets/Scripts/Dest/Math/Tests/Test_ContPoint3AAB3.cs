using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContPoint3AAB3 : Test_Base
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
            float val_3;
            float val_4;
            UnityEngine.Vector3 val_1 = this.Point.position;
            Dest.Math.AAB3 val_2 = this.Point.CreateAAB3(point0:  this.Box_Point0, point1:  this.Box_Point1);
            val_3.FiguresColor();
            val_3.DrawAAB(box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Max = new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_4}});
            if(( & 1) != 0)
            {
                    val_3.ResultsColor();
            }
            
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, radius:  0.11f);
            val_3 = false;
            val_3.LogInfo(value:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContPoint3AAB3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
