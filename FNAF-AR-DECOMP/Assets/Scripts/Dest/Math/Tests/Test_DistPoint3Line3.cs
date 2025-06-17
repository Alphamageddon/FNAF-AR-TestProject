using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistPoint3Line3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_3;
            float val_4;
            UnityEngine.Vector3 val_1 = this.Point.position;
            Dest.Math.Line3 val_2 = this.Point.CreateLine3(line:  this.Line);
            val_4.FiguresColor();
            val_4.DrawLine(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Direction = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_3}});
            val_4.ResultsColor();
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            string val_6 = Dest.Math.Distance.Point3Line3(point: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Direction = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_3}}, closestPoint: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})(Dest.Math.Distance.Point3Line3(point: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Direction = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_3}}, closestPoint: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) + "   " + val_1.x;
            val_6.LogInfo(value:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistPoint3Line3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
