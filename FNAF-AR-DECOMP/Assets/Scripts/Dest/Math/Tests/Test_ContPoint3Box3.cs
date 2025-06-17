using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContPoint3Box3 : Test_Base
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
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            UnityEngine.Vector3 val_1 = this.Point.position;
            Dest.Math.Box3 val_2 = this.Point.CreateBox3(box:  this.Box);
            bool val_7 = val_6.Contains(point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            val_7.FiguresColor();
            val_7.DrawBox(box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Axis0 = new UnityEngine.Vector3() {x = val_6, y = val_4, z = val_4}, Axis1 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_5}, Axis2 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, Extents = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}});
            if(val_7 != false)
            {
                    val_7.ResultsColor();
            }
            
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, radius:  0.11f);
            val_6 = val_7;
            val_6.LogInfo(value:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContPoint3Box3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
