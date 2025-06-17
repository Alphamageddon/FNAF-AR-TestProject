using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistPoint3Sphere3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Sphere;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            UnityEngine.Vector3 val_1 = this.Point.position;
            Dest.Math.Sphere3 val_2 = this.Point.CreateSphere3(sphere:  this.Sphere);
            float val_3 = Dest.Math.Distance.Point3Sphere3(point: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, sphere: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, Radius = ???}, closestPoint: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_1.x.FiguresColor();
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, radius:  ???);
            0.ResultsColor();
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            val_3.LogInfo(value:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistPoint3Sphere3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
