using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistRay3Ray3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_5;
            float val_6;
            Dest.Math.Ray3 val_1 = 48298.CreateRay3(ray:  this.Ray0);
            Dest.Math.Ray3 val_4 = 48298.CreateRay3(ray:  this.Ray1);
            float val_7 = Dest.Math.Distance.Ray3Ray3(ray0: ref  new Dest.Math.Ray3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, ray1: ref  new Dest.Math.Ray3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Direction = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}}, closestPoint0: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, closestPoint1: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_3.FiguresColor();
            val_3.DrawRay(ray: ref  new Dest.Math.Ray3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}});
            val_3.DrawRay(ray: ref  new Dest.Math.Ray3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Direction = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}});
            val_3.ResultsColor();
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            val_7.LogInfo(value:  val_7);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistRay3Ray3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
