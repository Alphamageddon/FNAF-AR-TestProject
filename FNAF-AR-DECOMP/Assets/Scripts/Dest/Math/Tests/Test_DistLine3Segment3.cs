using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistLine3Segment3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        
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
            Dest.Math.Line3 val_1 = 48278.CreateLine3(line:  this.Line);
            Dest.Math.Segment3 val_4 = 48278.CreateSegment3(p0:  this.P0, p1:  this.P1);
            float val_9 = Dest.Math.Distance.Line3Segment3(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, segment: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, P1 = new UnityEngine.Vector3() {x = val_8, y = val_6, z = val_6}, Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_7}, Direction = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}, Extent = val_5}, closestPoint0: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, closestPoint1: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_3.FiguresColor();
            val_3.DrawLine(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, to:  new UnityEngine.Vector3() {x = val_8, y = val_6, z = val_6});
            0.ResultsColor();
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            val_9.LogInfo(value:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistLine3Segment3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
