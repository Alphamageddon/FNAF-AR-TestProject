using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrAAB3Sphere3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box_Point0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box_Point1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Sphere;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            Dest.Math.AAB3 val_1 = 48312.CreateAAB3(point0:  this.Box_Point0, point1:  this.Box_Point1);
            Dest.Math.Sphere3 val_4 = 48312.CreateSphere3(sphere:  this.Sphere);
            bool val_5 = Dest.Math.Intersection.TestAAB3Sphere3(box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Max = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, sphere: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = val_3, y = ???, z = ???}, Radius = ???});
            bool val_6 = val_5;
            val_5.FiguresColor();
            val_5.DrawAAB(box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Max = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}});
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = val_3, y = ???, z = ???}, radius:  ???);
            val_6.LogInfo(value:  val_6);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrAAB3Sphere3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
