using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistSegment3Segment3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform R0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform R1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_5;
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            Dest.Math.Segment3 val_1 = 48302.CreateSegment3(p0:  this.P0, p1:  this.P1);
            Dest.Math.Segment3 val_6 = 48302.CreateSegment3(p0:  this.R0, p1:  this.R1);
            float val_11 = Dest.Math.Distance.Segment3Segment3(segment0: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, P1 = new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_5}, Center = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Extent = val_2}, segment1: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_10}, P1 = new UnityEngine.Vector3() {x = val_10, y = val_8, z = val_8}, Center = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_9}, Direction = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_9}, Extent = val_7}, closestPoint0: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, closestPoint1: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_4.FiguresColor();
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, to:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_5});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_10}, to:  new UnityEngine.Vector3() {x = val_10, y = val_8, z = val_8});
            0.ResultsColor();
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            val_11.LogInfo(value:  val_11);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistSegment3Segment3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
