using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistPoint3Plane3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Plane;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            UnityEngine.Vector3 val_1 = this.Point.position;
            Dest.Math.Plane3 val_2 = this.Point.CreatePlane3(plane:  this.Plane);
            val_1.x.FiguresColor();
            val_1.x.DrawPlane(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, Constant = ???}, Plane:  this.Plane);
            val_1.x.ResultsColor();
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            string val_4 = Dest.Math.Distance.Point3Plane3(point: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, Constant = ???}, closestPoint: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})(Dest.Math.Distance.Point3Plane3(point: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, Constant = ???}, closestPoint: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) + "   " + val_1.x;
            val_4.LogInfo(value:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistPoint3Plane3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
