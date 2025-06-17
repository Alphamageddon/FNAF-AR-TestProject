using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrBox3Capsule3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Radius;
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
            Dest.Math.Box3 val_1 = 48316.CreateBox3(box:  this.Box);
            Dest.Math.Capsule3 val_6 = 48316.CreateCapsule3(p0:  this.P0, p1:  this.P1, radius:  this.Radius);
            bool val_11 = Dest.Math.Intersection.TestBox3Capsule3(box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, Axis0 = new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3}, Axis1 = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_4}, Axis2 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extents = new UnityEngine.Vector3() {x = val_2, y = val_2, z = val_2}}, capsule: ref  new Dest.Math.Capsule3() {Segment = new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_10}, P1 = new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_9}, Center = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_8}, Direction = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Extent = val_7}, Radius = val_7});
            val_11.FiguresColor();
            val_11.DrawBox(box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, Axis0 = new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3}, Axis1 = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_4}, Axis2 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extents = new UnityEngine.Vector3() {x = val_2, y = val_2, z = val_2}});
            val_11.DrawCapsule(capsule: ref  new Dest.Math.Capsule3() {Segment = new Dest.Math.Segment3() {P0 = new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_10}, P1 = new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_9}, Center = new UnityEngine.Vector3() {x = val_9, y = val_9, z = val_8}, Direction = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Extent = val_7}, Radius = val_7});
            string val_14 = "Intr: "("Intr: ") + val_11.ToString();
            val_14.LogInfo(value:  val_14);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrBox3Capsule3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
