using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrSegment2AAB2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
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
            float val_4;
            Dest.Math.Segment2 val_1 = 48357.CreateSegment2(p0:  this.P0, p1:  this.P1);
            Dest.Math.AAB2 val_5 = 48357.CreateAAB2(point0:  this.Box_Point0, point1:  this.Box_Point1);
            bool val_7 = Dest.Math.Intersection.FindSegment2AAB2(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, P1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Direction = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extent = val_2}, box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = val_4, y = val_3}, Max = new UnityEngine.Vector2() {x = ???, y = ???}}, info: out  new Dest.Math.Segment2AAB2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f, y = val_4}});
            val_7.FiguresColor();
            val_7.DrawSegment(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, P1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Direction = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extent = val_2});
            val_7.DrawAAB(box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = val_4, y = val_3}, Max = new UnityEngine.Vector2() {x = ???, y = ???}});
            if(val_7 == false)
            {
                goto label_5;
            }
            
            val_7.ResultsColor();
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
            val_7.DrawSegment(p0:  new UnityEngine.Vector2() {x = 0f, y = 0f}, p1:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_7.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_6:
            val_7.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_5:
            val_3 = 0;
            val_3.LogInfo(value:  val_3);
            if((val_7 ^ (Dest.Math.Intersection.TestSegment2AAB2(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, P1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Direction = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extent = val_2}, box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = val_4, y = val_3}, Max = new UnityEngine.Vector2() {x = ???, y = ???}}))) == false)
            {
                    return;
            }
            
            val_3.LogError(value:  "test != find");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrSegment2AAB2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
