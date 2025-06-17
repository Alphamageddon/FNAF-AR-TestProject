using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistPoint3Rectangle3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Rectangle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            float val_11;
            UnityEngine.Vector3 val_1 = this.Point.position;
            Dest.Math.Rectangle3 val_2 = this.Point.CreateRectangle3(rectangle:  this.Rectangle);
            float val_7 = Dest.Math.Distance.Point3Rectangle3(point: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rectangle: ref  new Dest.Math.Rectangle3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Axis0 = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}, Axis1 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_4}, Normal = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extents = new UnityEngine.Vector2() {x = val_3, y = val_3}}, closestPoint: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_6.FiguresColor();
            val_6.DrawRectangle(rectangle: ref  new Dest.Math.Rectangle3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Axis0 = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}, Axis1 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_4}, Normal = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extents = new UnityEngine.Vector2() {x = val_3, y = val_3}});
            val_6.ResultsColor();
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            object[] val_9 = new object[5];
            if(val_9 == null)
            {
                goto label_2;
            }
            
            if(val_7 != 0)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_7 == 0)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_9[0] = val_7;
            val_9[1] = " ";
            if(0f >= _TYPE_MAX_)
            {
                    val_11 = Dest.Math.Distance.SqrPoint3Rectangle3(point: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, rectangle: ref  new Dest.Math.Rectangle3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Axis0 = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}, Axis1 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_4}, Normal = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extents = new UnityEngine.Vector2() {x = val_3, y = val_3}}, closestPoint: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            }
            
            val_9[2] = val_11;
            val_9[3] = " ";
            val_9[4] = val_1.x;
            string val_10 = +val_9;
            val_10.LogInfo(value:  val_10);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistPoint3Rectangle3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
