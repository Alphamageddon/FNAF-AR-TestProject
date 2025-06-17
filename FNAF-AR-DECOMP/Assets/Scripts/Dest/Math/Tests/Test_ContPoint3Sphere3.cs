using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContPoint3Sphere3 : Test_Base
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
            val_1.x.FiguresColor();
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, radius:  ???);
            if(( & 1) != 0)
            {
                    0.ResultsColor();
            }
            
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, radius:  0.11f);
            false.LogInfo(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContPoint3Sphere3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
