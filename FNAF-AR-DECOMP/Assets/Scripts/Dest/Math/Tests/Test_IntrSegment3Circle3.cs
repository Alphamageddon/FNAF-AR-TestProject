using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrSegment3Circle3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Circle;
        
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
            Dest.Math.Segment3 val_1 = 48365.CreateSegment3(p0:  this.P0, p1:  this.P1);
            Dest.Math.Circle3 val_6 = 48365.CreateCircle3(circle:  this.Circle);
            bool val_11 = Dest.Math.Intersection.FindSegment3Circle3(segment: ref  new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, P1 = new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_4}, Center = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Extent = val_2}, circle: ref  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_10}, Axis0 = new UnityEngine.Vector3() {x = val_10, y = val_8, z = val_8}, Axis1 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_9}, Normal = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_9}, Radius = val_7}, info: out  new Dest.Math.Segment3Circle3Intr() {Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_10}});
            val_11.FiguresColor();
            val_11.DrawCircle(circle: ref  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_10}, Axis0 = new UnityEngine.Vector3() {x = val_10, y = val_8, z = val_8}, Axis1 = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_9}, Normal = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_9}, Radius = val_7}, count:  20);
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, to:  new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_4});
            if(val_11 != false)
            {
                    0.ResultsColor();
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            }
            
            val_5 = 0;
            val_5.LogInfo(value:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrSegment3Circle3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
