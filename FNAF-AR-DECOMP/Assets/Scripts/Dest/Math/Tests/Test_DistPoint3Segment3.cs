using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistPoint3Segment3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            UnityEngine.Vector3 val_1 = this.Point.position;
            Dest.Math.Segment3 val_2 = this.Point.CreateSegment3(p0:  this.P0, p1:  this.P1);
            val_6.FiguresColor();
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, to:  new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5});
            0.ResultsColor();
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            string val_8 = Dest.Math.Distance.Point3Segment3(point: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, segment: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, P1 = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}, Center = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_4}, Direction = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extent = val_3}, closestPoint: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})(Dest.Math.Distance.Point3Segment3(point: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, segment: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, P1 = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}, Center = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_4}, Direction = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extent = val_3}, closestPoint: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) + "   " + val_1.x;
            val_8.LogInfo(value:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistPoint3Segment3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
