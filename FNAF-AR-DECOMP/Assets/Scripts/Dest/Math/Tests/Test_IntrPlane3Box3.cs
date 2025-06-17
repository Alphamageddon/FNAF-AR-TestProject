using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrPlane3Box3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Plane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            Dest.Math.Plane3 val_1 = 48337.CreatePlane3(plane:  this.Plane);
            Dest.Math.Box3 val_2 = val_1.Normal.x.CreateBox3(box:  this.Box);
            bool val_7 = Dest.Math.Intersection.TestPlane3Box3(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = 0f, y = ???, z = ???}, Constant = ???}, box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Axis0 = new UnityEngine.Vector3() {x = val_6, y = val_4, z = val_4}, Axis1 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_5}, Axis2 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, Extents = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}});
            val_7.FiguresColor();
            val_7.DrawPlane(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = 0f, y = ???, z = ???}, Constant = ???}, Plane:  this.Plane);
            val_7.DrawBox(box: ref  new Dest.Math.Box3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Axis0 = new UnityEngine.Vector3() {x = val_6, y = val_4, z = val_4}, Axis1 = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_5}, Axis2 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, Extents = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}});
            string val_10 = "Intersection: "("Intersection: ") + val_7.ToString();
            val_10.LogInfo(value:  val_10);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrPlane3Box3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
