using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrPlane3Sphere3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Plane;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Sphere;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            var val_6 = this;
            Dest.Math.Plane3 val_1 = 48339.CreatePlane3(plane:  this.Plane);
            Dest.Math.Sphere3 val_2 = val_1.Normal.x.CreateSphere3(sphere:  this.Sphere);
            bool val_4 = Dest.Math.Intersection.FindPlane3Sphere3(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = 0f, y = ???, z = ???}, Constant = ???}, sphere: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = 0f, y = ???, z = ???}, Radius = ???}, info: out  new Dest.Math.Plane3Sphere3Intr() {Circle = new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Radius = 0f}});
            val_4.FiguresColor();
            val_4.DrawPlane(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = 0f, y = ???, z = ???}, Constant = ???}, Plane:  this.Plane);
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = 0f, y = ???, z = ???}, radius:  ???);
            if((val_4 != false) && (0 == 8))
            {
                    0.ResultsColor();
                0.DrawCircle(circle: ref  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Axis1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Radius = 0f}, count:  20);
            }
            
            0.LogInfo(value:  0);
            if(((Dest.Math.Intersection.TestPlane3Sphere3(plane: ref  new Dest.Math.Plane3() {Normal = new UnityEngine.Vector3() {x = 0f, y = ???, z = ???}, Constant = ???}, sphere: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = 0f, y = ???, z = ???}, Radius = ???})) ^ val_4) == false)
            {
                    return;
            }
            
            0.LogError(value:  "test != find");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrPlane3Sphere3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
