using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrRay3Triangle3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray;
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
            float val_5;
            float val_6;
            float val_7;
            Dest.Math.IntersectionTypes val_8 = 0;
            Dest.Math.Ray3 val_1 = 48356.CreateRay3(ray:  this.Ray);
            Dest.Math.Triangle3 val_4 = 48356.CreateTriangle3(v0:  this.V0, v1:  this.V1, v2:  this.V2);
            bool val_10 = Dest.Math.Intersection.FindRay3Triangle3(ray: ref  new Dest.Math.Ray3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}, V1 = new UnityEngine.Vector3() {x = val_7, y = val_6, z = val_6}, V2 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_5}}, info: out  new Dest.Math.Ray3Triangle3Intr() {Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, RayParameter = 0f, TriBary0 = 0f, TriBary1 = 0f});
            val_10.FiguresColor();
            val_10.DrawRay(ray: ref  new Dest.Math.Ray3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}});
            val_10.DrawTriangle(triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}, V1 = new UnityEngine.Vector3() {x = val_7, y = val_6, z = val_6}, V2 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_5}});
            if(val_10 != false)
            {
                    val_10.ResultsColor();
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            }
            
            val_7 = 0;
            val_7.LogInfo(value:  val_7);
            if(((Dest.Math.Intersection.TestRay3Triangle3(ray: ref  new Dest.Math.Ray3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, triangle: ref  new Dest.Math.Triangle3() {V0 = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}, V1 = new UnityEngine.Vector3() {x = val_7, y = val_6, z = val_6}, V2 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_5}}, intersectionType: out  val_8)) ^ val_10) != false)
            {
                    val_7.LogError(value:  "test != find");
            }
            
            if(val_8 == 0)
            {
                    return;
            }
            
            val_7.LogError(value:  "intersectionType != info.IntersectionType");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrRay3Triangle3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
