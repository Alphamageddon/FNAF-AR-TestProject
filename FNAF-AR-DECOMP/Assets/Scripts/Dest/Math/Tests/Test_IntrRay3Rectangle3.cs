using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrRay3Rectangle3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Rectangle;
        
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
            Dest.Math.Ray3 val_1 = 48354.CreateRay3(ray:  this.Ray);
            Dest.Math.Rectangle3 val_4 = 48354.CreateRectangle3(rectangle:  this.Rectangle);
            bool val_9 = Dest.Math.Intersection.FindRay3Rectangle3(ray: ref  new Dest.Math.Ray3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, rectangle: ref  new Dest.Math.Rectangle3() {Center = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Axis0 = new UnityEngine.Vector3() {x = val_8, y = val_6, z = val_6}, Axis1 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_7}, Normal = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}, Extents = new UnityEngine.Vector2() {x = val_5, y = val_5}}, info: out  new Dest.Math.Ray3Rectangle3Intr() {Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_8}});
            val_9.FiguresColor();
            val_9.DrawRectangle(rectangle: ref  new Dest.Math.Rectangle3() {Center = new UnityEngine.Vector3() {x = val_8, y = val_8, z = val_8}, Axis0 = new UnityEngine.Vector3() {x = val_8, y = val_6, z = val_6}, Axis1 = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_7}, Normal = new UnityEngine.Vector3() {x = val_7, y = val_7, z = val_7}, Extents = new UnityEngine.Vector2() {x = val_5, y = val_5}});
            val_9.DrawRay(ray: ref  new Dest.Math.Ray3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}});
            if(val_9 != false)
            {
                    val_9.ResultsColor();
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            }
            
            val_8 = 0;
            val_8.LogInfo(value:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrRay3Rectangle3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
