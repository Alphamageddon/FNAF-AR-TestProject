using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrLine3Plane3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Plane;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            Dest.Math.IntersectionTypes val_5 = 0;
            Dest.Math.Line3 val_1 = 48331.CreateLine3(line:  this.Line);
            Dest.Math.Plane3 val_4 = 48331.CreatePlane3(plane:  this.Plane);
            bool val_7 = Dest.Math.Intersection.FindLine3Plane3(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = val_3, y = ???, z = ???}, Constant = ???}, info: out  new Dest.Math.Line3Plane3Intr() {Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}});
            val_7.FiguresColor();
            val_7.DrawPlane(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = val_3, y = ???, z = ???}, Constant = ???}, Plane:  this.Plane);
            val_7.DrawLine(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}});
            if(val_7 != false)
            {
                    val_7.ResultsColor();
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            }
            
            val_3 = 0;
            string val_8 = val_3 + " " + 0f;
            val_8.LogInfo(value:  val_8);
            if(((Dest.Math.Intersection.TestLine3Plane3(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = val_3, y = ???, z = ???}, Constant = ???}, intersectionType: out  val_5)) ^ val_7) != false)
            {
                    val_8.LogError(value:  "test != find");
            }
            
            if(val_5 == 0)
            {
                    return;
            }
            
            val_8.LogError(value:  "intersectionType != info.IntersectionType");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrLine3Plane3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
