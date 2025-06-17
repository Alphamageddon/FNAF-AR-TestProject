using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrSegment3Plane3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Plane;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_5;
            Dest.Math.Segment3 val_1 = 48366.CreateSegment3(p0:  this.P0, p1:  this.P1);
            Dest.Math.Plane3 val_6 = 48366.CreatePlane3(plane:  this.Plane);
            bool val_9 = Dest.Math.Intersection.FindSegment3Plane3(segment: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, P1 = new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3}, Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_4}, Direction = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extent = val_2}, plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_5}, Constant = ???}, info: out  new Dest.Math.Segment3Plane3Intr() {Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, SegmentParameter = 0f});
            val_9.FiguresColor();
            val_9.DrawPlane(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_5}, Constant = ???}, Plane:  this.Plane);
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, to:  new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3});
            if(val_9 != false)
            {
                    0.ResultsColor();
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            }
            
            val_5 = 0;
            string val_10 = val_5 + " " + 0f;
            val_10.LogInfo(value:  val_10);
            if(((Dest.Math.Intersection.TestSegment3Plane3(segment: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, P1 = new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3}, Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_4}, Direction = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extent = val_2}, plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_5}, Constant = ???}, intersectionType: out  0)) ^ val_9) != false)
            {
                    val_10.LogError(value:  "test != find");
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            val_10.LogError(value:  "intersectionType != info.IntersectionType");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrSegment3Plane3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
