using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrLine3Circle3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Circle;
        
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
            Dest.Math.Line3 val_1 = 48330.CreateLine3(line:  this.Line);
            Dest.Math.Circle3 val_4 = 48330.CreateCircle3(circle:  this.Circle);
            bool val_9 = Dest.Math.Intersection.FindLine3Circle3(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, circle: ref  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Axis0 = new UnityEngine.Vector3() {x = val_8, y = val_6, z = val_6}, Axis1 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_7}, Normal = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}, Radius = val_5}, info: out  new Dest.Math.Line3Circle3Intr() {Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_8}});
            val_9.FiguresColor();
            val_9.DrawCircle(circle: ref  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Axis0 = new UnityEngine.Vector3() {x = val_8, y = val_6, z = val_6}, Axis1 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_7}, Normal = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}, Radius = val_5}, count:  20);
            val_9.DrawLine(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}});
            if(val_9 != false)
            {
                    val_9.ResultsColor();
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            }
            
            val_8 = 0;
            val_8.LogInfo(value:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrLine3Circle3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
