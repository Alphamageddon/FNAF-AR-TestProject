using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistLine3Ray3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_5;
            float val_6;
            Dest.Math.Line3 val_1 = 48277.CreateLine3(line:  this.Line);
            Dest.Math.Ray3 val_4 = 48277.CreateRay3(ray:  this.Ray);
            float val_7 = Dest.Math.Distance.Line3Ray3(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, ray: ref  new Dest.Math.Ray3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Direction = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}}, closestPoint0: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, closestPoint1: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_3.FiguresColor();
            val_3.DrawLine(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}});
            val_3.DrawRay(ray: ref  new Dest.Math.Ray3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Direction = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}});
            val_3.ResultsColor();
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            val_7.LogInfo(value:  val_7);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistLine3Ray3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
