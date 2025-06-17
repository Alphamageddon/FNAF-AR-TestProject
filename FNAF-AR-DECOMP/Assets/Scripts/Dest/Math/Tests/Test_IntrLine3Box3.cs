using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrLine3Box3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box;
        
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
            Dest.Math.Line3 val_1 = 48329.CreateLine3(line:  this.Line);
            Dest.Math.Box3 val_4 = 48329.CreateBox3(box:  this.Box);
            bool val_10 = Dest.Math.Intersection.FindLine3Box3(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Axis0 = new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_7}, Axis1 = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_6}, Axis2 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Extents = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}}, info: out  new Dest.Math.Line3Box3Intr() {Point0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Point1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_8}});
            val_10.FiguresColor();
            val_10.DrawLine(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}});
            val_10.DrawBox(box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Axis0 = new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_7}, Axis1 = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_6}, Axis2 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Extents = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}});
            if(val_10 == false)
            {
                goto label_5;
            }
            
            val_10.ResultsColor();
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
            val_8 = 0;
            val_8.LogInfo(value:  val_8);
            if((val_10 ^ (Dest.Math.Intersection.TestLine3Box3(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Axis0 = new UnityEngine.Vector3() {x = val_8, y = val_7, z = val_7}, Axis1 = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_6}, Axis2 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Extents = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}}))) == false)
            {
                    return;
            }
            
            val_8.LogError(value:  "test != find");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrLine3Box3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
