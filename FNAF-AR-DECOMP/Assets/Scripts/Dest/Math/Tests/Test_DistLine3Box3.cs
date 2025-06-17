using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistLine3Box3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_5;
            float val_6;
            float val_7;
            float val_8;
            Dest.Math.Line3 val_1 = 48275.CreateLine3(line:  this.Line);
            Dest.Math.Box3 val_4 = 48275.CreateBox3(box:  this.Box);
            val_3.FiguresColor();
            val_3.DrawLine(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}});
            val_3.DrawBox(box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Axis0 = new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_7}, Axis1 = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_6}, Axis2 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Extents = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}});
            val_3.ResultsColor();
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            object[] val_10 = new object[4];
            val_10[0] = "Dist: ";
            val_10[1] = Dest.Math.Distance.Line3Box3(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Axis0 = new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_7}, Axis1 = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_6}, Axis2 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Extents = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}}, info: out  new Dest.Math.Line3Box3Dist() {ClosestPoint0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, ClosestPoint1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, LineParameter = 0f});
            val_10[2] = " LineParam: ";
            val_10[3] = 0f;
            string val_11 = +val_10;
            val_11.LogInfo(value:  val_11);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistLine3Box3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
