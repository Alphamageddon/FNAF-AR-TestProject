using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistPoint3HollowCircle3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Circle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            float val_10;
            UnityEngine.Vector3 val_1 = this.Point.position;
            Dest.Math.Circle3 val_2 = this.Point.CreateCircle3(circle:  this.Circle);
            float val_7 = Dest.Math.Distance.Point3Circle3(point: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, circle: ref  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Axis0 = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}, Axis1 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_4}, Normal = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Radius = val_3}, closestPoint: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, solid:  false);
            val_6.FiguresColor();
            val_6.DrawCircle(circle: ref  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Axis0 = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}, Axis1 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_4}, Normal = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Radius = val_3}, count:  20);
            val_6.ResultsColor();
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            if(0 == 0)
            {
                goto label_2;
            }
            
            if(val_7 != 0)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_7 == 0)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            mem[32] = val_7;
            mem[36] = 268435459;
            mem[40] = " ";
            if(0f >= _TYPE_MAX_)
            {
                    val_10 = Dest.Math.Distance.SqrPoint3Circle3(point: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, circle: ref  new Dest.Math.Circle3() {Center = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, Axis0 = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}, Axis1 = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_4}, Normal = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Radius = val_3}, solid:  false);
            }
            
            mem[48] = val_10;
            mem[52] = 268435459;
            mem[56] = " ";
            mem[64] = val_1.x;
            mem[68] = 268435459;
            string val_9 = +0;
            val_9.LogInfo(value:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistPoint3HollowCircle3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
