using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistPoint3AAB3 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box_Point0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box_Point1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_3;
            float val_4;
            float val_9;
            UnityEngine.Vector3 val_1 = this.Point.position;
            Dest.Math.AAB3 val_2 = this.Point.CreateAAB3(point0:  this.Box_Point0, point1:  this.Box_Point1);
            float val_5 = Dest.Math.Distance.Point3AAB3(point: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Max = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_3}}, closestPoint: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_4.FiguresColor();
            val_4.DrawAAB(box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Max = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_3}});
            val_4.ResultsColor();
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, radius:  0.11f);
            object[] val_7 = new object[5];
            if(val_7 == null)
            {
                goto label_2;
            }
            
            if(val_5 != 0)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_5 == 0)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_7[0] = val_5;
            val_7[1] = " ";
            if(0f >= _TYPE_MAX_)
            {
                    val_9 = Dest.Math.Distance.SqrPoint3AAB3(point: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, box: ref  new Dest.Math.AAB3() {Min = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, Max = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_3}});
            }
            
            val_7[2] = val_9;
            val_7[3] = " ";
            val_7[4] = val_1.x;
            string val_8 = +val_7;
            val_8.LogInfo(value:  val_8);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistPoint3AAB3()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
