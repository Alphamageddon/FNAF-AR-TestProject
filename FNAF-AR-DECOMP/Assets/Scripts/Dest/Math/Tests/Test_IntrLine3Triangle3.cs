using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrLine3Triangle3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
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
            float val_4;
            float val_5;
            float val_6;
            Dest.Math.IntersectionTypes val_7 = 0;
            UnityEngine.Vector3 val_1 = this.Line.position;
            UnityEngine.Vector3 val_2 = this.Line.forward;
            Dest.Math.Triangle3 val_3 = 0.CreateTriangle3(v0:  this.V0, v1:  this.V1, v2:  this.V2);
            bool val_9 = Dest.Math.Intersection.FindLine3Triangle3(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, V1 = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}, V2 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_4}}, info: out  new Dest.Math.Line3Triangle3Intr() {Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, LineParameter = 0f, TriBary0 = 0f, TriBary1 = 0f, TriBary2 = val_6});
            val_9.FiguresColor();
            val_9.DrawLine(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}});
            val_9.DrawTriangle(triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, V1 = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}, V2 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_4}});
            if(val_9 != false)
            {
                    val_9.ResultsColor();
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            }
            
            val_6 = 0;
            val_6.LogInfo(value:  val_6);
            if(((Dest.Math.Intersection.TestLine3Triangle3(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, V1 = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}, V2 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_4}}, intersectionType: out  val_7)) ^ val_9) != false)
            {
                    val_6.LogError(value:  "test != find");
            }
            
            if(val_7 == 0)
            {
                    return;
            }
            
            val_6.LogError(value:  "intersectionType != info.IntersectionType");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrLine3Triangle3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
