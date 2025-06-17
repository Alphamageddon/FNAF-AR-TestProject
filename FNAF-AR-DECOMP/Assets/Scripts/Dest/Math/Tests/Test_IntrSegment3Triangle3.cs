using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrSegment3Triangle3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V2;
        
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
            Dest.Math.IntersectionTypes val_10 = 0;
            Dest.Math.Segment3 val_1 = 48370.CreateSegment3(p0:  this.P0, p1:  this.P1);
            Dest.Math.Triangle3 val_6 = 48370.CreateTriangle3(v0:  this.V0, v1:  this.V1, v2:  this.V2);
            bool val_12 = Dest.Math.Intersection.FindSegment3Triangle3(segment: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, P1 = new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3}, Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_4}, Direction = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extent = val_2}, triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_9}, V1 = new UnityEngine.Vector3() {x = val_9, y = val_8, z = val_8}, V2 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_7}}, info: out  new Dest.Math.Segment3Triangle3Intr() {Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, SegmentParameter = 0f, TriBary0 = 0f, TriBary1 = 0f});
            val_12.FiguresColor();
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, to:  new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3});
            0.DrawTriangle(triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_9}, V1 = new UnityEngine.Vector3() {x = val_9, y = val_8, z = val_8}, V2 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_7}});
            if(val_12 != false)
            {
                    0.ResultsColor();
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            }
            
            val_5 = 0;
            val_9 = 0;
            string val_13 = val_5 + " " + 0f;
            val_13.LogInfo(value:  val_13);
            if(((Dest.Math.Intersection.TestSegment3Triangle3(segment: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, P1 = new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3}, Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_4}, Direction = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extent = val_2}, triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_9}, V1 = new UnityEngine.Vector3() {x = val_9, y = val_8, z = val_8}, V2 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_7}}, intersectionType: out  val_10)) ^ val_12) != false)
            {
                    val_13.LogError(value:  "test != find");
            }
            
            if(val_10 == 0)
            {
                    return;
            }
            
            val_13.LogError(value:  "intersectionType != info.IntersectionType");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrSegment3Triangle3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
