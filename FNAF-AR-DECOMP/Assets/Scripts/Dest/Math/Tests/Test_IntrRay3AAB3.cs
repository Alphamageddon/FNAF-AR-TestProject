using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrRay3AAB3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Ray;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box_Point0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box_Point1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_5;
            float val_6;
            Dest.Math.Ray3 val_1 = 48349.CreateRay3(ray:  this.Ray);
            Dest.Math.AAB3 val_4 = 48349.CreateAAB3(point0:  this.Box_Point0, point1:  this.Box_Point1);
            bool val_8 = Dest.Math.Intersection.FindRay3AAB3(ray: ref  new Dest.Math.Ray3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Max = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}}, info: out  new Dest.Math.Ray3AAB3Intr() {Point0 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, Point1 = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_6}});
            val_8.FiguresColor();
            val_8.DrawRay(ray: ref  new Dest.Math.Ray3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}});
            val_8.DrawAAB(box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Max = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}});
            if(val_8 == false)
            {
                goto label_5;
            }
            
            val_8.ResultsColor();
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
            if((val_8 ^ (Dest.Math.Intersection.TestRay3AAB3(ray: ref  new Dest.Math.Ray3() {Center = new UnityEngine.Vector3() {x = val_3, y = val_3, z = val_3}, Direction = new UnityEngine.Vector3() {x = val_3, y = val_2, z = val_2}}, box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Max = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}}))) == false)
            {
                    return;
            }
            
            val_3.LogError(value:  "test != find");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrRay3AAB3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
