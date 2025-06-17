using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContSphere3IncludeSphere3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Sphere0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Sphere1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            Dest.Math.Sphere3 val_1 = this.CreateSphere3(sphere:  this.Sphere0);
            Dest.Math.Sphere3 val_2 = val_1.Center.x.CreateSphere3(sphere:  this.Sphere1);
            V0.16B.Include(sphere:  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = 0f, y = 0f}});
            V0.16B.FiguresColor();
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, radius:  V3.16B);
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, radius:  V3.16B);
            0.ResultsColor();
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, radius:  V3.16B);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContSphere3IncludeSphere3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
