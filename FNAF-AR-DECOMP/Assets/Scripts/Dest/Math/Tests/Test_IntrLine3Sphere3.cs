using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrLine3Sphere3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Sphere;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            Dest.Math.Line3 val_1 = 48334.CreateLine3(line:  this.Line);
            Dest.Math.Sphere3 val_4 = 48334.CreateSphere3(sphere:  this.Sphere);
            bool val_6 = Dest.Math.Intersection.FindLine3Sphere3(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, sphere: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = val_3, y = ???, z = ???}, Radius = ???}, info: out  new Dest.Math.Line3Sphere3Intr() {Point0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Point1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, LineParameter0 = 0f, LineParameter1 = val_3});
            val_6.FiguresColor();
            val_6.DrawLine(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}});
            UnityEngine.Gizmos.DrawWireSphere(center:  new UnityEngine.Vector3() {x = val_3, y = ???, z = ???}, radius:  ???);
            if(val_6 == false)
            {
                goto label_5;
            }
            
            0.ResultsColor();
            if(0 == 2)
            {
                goto label_4;
            }
            
            if(0 != 1)
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, to:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            label_6:
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            label_5:
            val_3 = 0;
            val_3.LogInfo(value:  val_3);
            if((val_6 ^ (Dest.Math.Intersection.TestLine3Sphere3(line: ref  new Dest.Math.Line3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, sphere: ref  new Dest.Math.Sphere3() {Center = new UnityEngine.Vector3() {x = val_3, y = ???, z = ???}, Radius = ???}))) == false)
            {
                    return;
            }
            
            val_3.LogError(value:  "test != find");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrLine3Sphere3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
