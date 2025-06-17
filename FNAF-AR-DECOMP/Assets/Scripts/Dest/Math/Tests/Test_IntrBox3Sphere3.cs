using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrBox3Sphere3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Sphere;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_5;
            Dest.Math.Box3 val_1 = 48317.CreateBox3(box:  this.Box);
            Dest.Math.Sphere3 val_6 = 48317.CreateSphere3(sphere:  this.Sphere);
            bool val_7 = Dest.Math.Intersection.TestBox3Sphere3(box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, Axis0 = new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3}, Axis1 = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_4}, Axis2 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extents = new UnityEngine.Vector3() {x = val_2, y = val_2, z = val_2}}, sphere: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = val_2, y = val_4, z = val_3}, Radius = val_5});
            bool val_8 = val_7;
            val_7.FiguresColor();
            val_7.DrawBox(box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, Axis0 = new UnityEngine.Vector3() {x = val_5, y = val_3, z = val_3}, Axis1 = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_4}, Axis2 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Extents = new UnityEngine.Vector3() {x = val_2, y = val_2, z = val_2}});
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = val_2, y = val_4, z = val_3}, radius:  val_5);
            val_8.LogInfo(value:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrBox3Sphere3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
