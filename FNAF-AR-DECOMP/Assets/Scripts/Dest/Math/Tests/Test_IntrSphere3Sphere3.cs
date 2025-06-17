using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrSphere3Sphere3 : Test_Base
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
            object val_5;
            float val_10;
            float val_11;
            float val_12;
            var val_16;
            float val_17;
            Dest.Math.Sphere3 val_1 = CreateSphere3(sphere:  this.Sphere0);
            Dest.Math.Sphere3 val_2 = val_1.Center.x.CreateSphere3(sphere:  this.Sphere1);
            val_16 = Dest.Math.Intersection.TestSphere3Sphere3(sphere0: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, Radius = ???}, sphere1: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, Radius = ???});
            bool val_4 = Dest.Math.Intersection.FindSphere3Sphere3(sphere0: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, Radius = ???}, sphere1: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, Radius = ???}, info: out  new Dest.Math.Sphere3Sphere3Intr() {Circle = new Dest.Math.Circle3() {Center = new UnityEngine.Vector3(), Axis0 = new UnityEngine.Vector3(), Axis1 = new UnityEngine.Vector3(), Normal = new UnityEngine.Vector3()}, ContactPoint = new UnityEngine.Vector3()});
            val_4.FiguresColor();
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, radius:  ???);
            val_17 = ???;
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = ???, y = val_17, z = ???}, radius:  ???);
            if(val_4 == false)
            {
                goto label_15;
            }
            
            0.ResultsColor();
            if(val_5 != 7)
            {
                goto label_4;
            }
            
            label_11:
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, radius:  ???);
            goto label_15;
            label_4:
            if(val_5 == 1)
            {
                goto label_6;
            }
            
            val_16 = val_16 & ((val_5 != 7) ? 1 : 0);
            if(val_5 != 4)
            {
                goto label_7;
            }
            
            val_17 = ???;
            goto label_8;
            label_7:
            val_16 = val_16 & ((val_5 != 1) ? 1 : 0);
            if(val_5 != 6)
            {
                goto label_9;
            }
            
            val_17 = ???;
            label_8:
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = ???, y = val_17, z = ???}, radius:  ???);
            label_6:
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12}, radius:  0.11f);
            label_15:
            val_5.LogInfo(value:  val_5);
            if(val_4 ^ val_16 == false)
            {
                    return;
            }
            
            val_5.LogError(value:  "test != find");
            return;
            label_9:
            val_16 = val_16 & ((val_5 != 4) ? 1 : 0);
            if(val_5 == 3)
            {
                goto label_11;
            }
            
            val_16 = (val_16 & ((val_5 != 6) ? 1 : 0)) & ((val_5 != 3) ? 1 : 0);
            if(val_5 == 2)
            {
                goto label_12;
            }
            
            if(val_5 != 5)
            {
                goto label_15;
            }
            
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = ???, y = ???, z = ???}, radius:  ???);
            goto label_15;
            label_12:
            0.DrawCircle(circle: ref  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3(), Axis0 = new UnityEngine.Vector3(), Axis1 = new UnityEngine.Vector3(), Normal = new UnityEngine.Vector3()}, count:  20);
            goto label_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrSphere3Sphere3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
