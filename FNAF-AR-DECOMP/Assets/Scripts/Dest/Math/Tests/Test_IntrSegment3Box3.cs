using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrSegment3Box3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box;
        
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
            Dest.Math.Segment3 val_1 = 48364.CreateSegment3(p0:  this.P0, p1:  this.P1);
            Dest.Math.Box3 val_6 = 48364.CreateBox3(box:  this.Box);
            bool val_12 = Dest.Math.Intersection.FindSegment3Box3(segment: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, P1 = new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_5}, Center = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Extent = val_2}, box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_10}, Axis0 = new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_9}, Axis1 = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_8}, Axis2 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Extents = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}}, info: out  new Dest.Math.Segment3Box3Intr() {Point0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Point1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_10}});
            val_12.FiguresColor();
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, to:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_5});
            0.DrawBox(box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_10}, Axis0 = new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_9}, Axis1 = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_8}, Axis2 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Extents = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}});
            if(val_12 == false)
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
            val_10 = 0;
            val_10.LogInfo(value:  val_10);
            if((val_12 ^ (Dest.Math.Intersection.TestSegment3Box3(segment: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, P1 = new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_5}, Center = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Extent = val_2}, box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_10}, Axis0 = new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_9}, Axis1 = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_8}, Axis2 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Extents = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}}))) == false)
            {
                    return;
            }
            
            val_10.LogError(value:  "test != find");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrSegment3Box3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
