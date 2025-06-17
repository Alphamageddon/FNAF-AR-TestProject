using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistPoint3Box3 : Test_Base
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
            float val_7 = Dest.Math.Distance.Point3Box3(point: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Axis0 = new UnityEngine.Vector3() {x = val_6, y = val_4, z = val_4}, Axis1 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_5}, Axis2 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, Extents = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}}, closestPoint: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_1.x.FiguresColor();
            val_1.x.DrawBox(box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Axis0 = new UnityEngine.Vector3() {x = val_6, y = val_4, z = val_4}, Axis1 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_5}, Axis2 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, Extents = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}});
            val_1.x.ResultsColor();
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            val_7.LogInfo(value:  val_7);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistPoint3Box3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
