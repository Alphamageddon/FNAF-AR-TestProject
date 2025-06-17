using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrSegment3Sphere3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Sphere;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_5;
            Dest.Math.Segment3 val_1 = 48369.CreateSegment3(p0:  this.P0, p1:  this.P1);
            Dest.Math.Sphere3 val_6 = 48369.CreateSphere3(sphere:  this.Sphere);
            bool val_8 = Dest.Math.Intersection.FindSegment3Sphere3(segment: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, P1 = new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3}, Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_4}, Direction = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extent = val_2}, sphere: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_5}, Radius = ???}, info: out  new Dest.Math.Segment3Sphere3Intr() {Point0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Point1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, SegmentParameter0 = 0f, SegmentParameter1 = val_4});
            val_8.FiguresColor();
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, to:  new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3});
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_5}, radius:  ???);
            if(val_8 == false)
            {
                goto label_5;
            }
            
            0.ResultsColor();
            if(0 == 2)
            {
                goto label_4;
            }
            
            if(0 != 1)
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            label_6:
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            label_5:
            val_5 = 0;
            val_5.LogInfo(value:  val_5);
            if((val_8 ^ (Dest.Math.Intersection.TestSegment3Sphere3(segment: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, P1 = new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3}, Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_4}, Direction = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extent = val_2}, sphere: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_5}, Radius = ???}))) == false)
            {
                    return;
            }
            
            val_5.LogError(value:  "test != find");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrSegment3Sphere3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
