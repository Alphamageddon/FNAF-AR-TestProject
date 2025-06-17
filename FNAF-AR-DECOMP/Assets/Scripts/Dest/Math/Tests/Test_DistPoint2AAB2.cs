using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistPoint2AAB2 : Test_Base
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
            float val_8;
            UnityEngine.Vector3 val_1 = this.Point.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            Dest.Math.AAB2 val_3 = 0.CreateAAB2(point0:  this.Box_Point0, point1:  this.Box_Point1);
            float val_4 = Dest.Math.Distance.Point2AAB2(point: ref  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, Max = new UnityEngine.Vector2() {x = val_1.z, y = ???}}, closestPoint: out  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_2.x.FiguresColor();
            val_2.x.DrawAAB(box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, Max = new UnityEngine.Vector2() {x = val_1.z, y = ???}});
            val_2.x.ResultsColor();
            val_2.x.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            object[] val_6 = new object[5];
            if(val_6 == null)
            {
                goto label_4;
            }
            
            if(val_4 != 0)
            {
                goto label_5;
            }
            
            goto label_8;
            label_4:
            if(val_4 == 0)
            {
                goto label_8;
            }
            
            label_5:
            label_8:
            val_6[0] = val_4;
            val_6[1] = " ";
            if(0f >= _TYPE_MAX_)
            {
                    val_8 = Dest.Math.Distance.SqrPoint2AAB2(point: ref  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, Max = new UnityEngine.Vector2() {x = val_1.z, y = ???}});
            }
            
            val_6[2] = val_8;
            val_6[3] = " ";
            val_6[4] = val_2.x;
            string val_7 = +val_6;
            val_7.LogInfo(value:  val_7);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistPoint2AAB2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
