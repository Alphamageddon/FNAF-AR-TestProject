using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrSegment2Box2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_6;
            float val_7;
            Dest.Math.Segment2 val_1 = 48358.CreateSegment2(p0:  this.P0, p1:  this.P1);
            Dest.Math.Box2 val_5 = 48358.CreateBox2(box:  this.Box);
            bool val_9 = Dest.Math.Intersection.FindSegment2Box2(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, P1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Direction = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extent = val_2}, box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_6, y = val_6}, Axis0 = new UnityEngine.Vector2() {x = val_6, y = val_6}, Axis1 = new UnityEngine.Vector2() {x = val_7, y = val_7}, Extents = new UnityEngine.Vector2() {x = val_7, y = val_7}}, info: out  new Dest.Math.Segment2Box2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f, y = val_6}});
            val_9.FiguresColor();
            val_9.DrawSegment(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, P1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Direction = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extent = val_2});
            val_9.DrawBox(box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_6, y = val_6}, Axis0 = new UnityEngine.Vector2() {x = val_6, y = val_6}, Axis1 = new UnityEngine.Vector2() {x = val_7, y = val_7}, Extents = new UnityEngine.Vector2() {x = val_7, y = val_7}});
            if(val_9 == false)
            {
                goto label_5;
            }
            
            val_9.ResultsColor();
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
            val_9.DrawSegment(p0:  new UnityEngine.Vector2() {x = 0f, y = 0f}, p1:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_9.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_6:
            val_9.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_5:
            val_3 = 0;
            val_3.LogInfo(value:  val_3);
            if((val_9 ^ (Dest.Math.Intersection.TestSegment2Box2(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, P1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Direction = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extent = val_2}, box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_6, y = val_6}, Axis0 = new UnityEngine.Vector2() {x = val_6, y = val_6}, Axis1 = new UnityEngine.Vector2() {x = val_7, y = val_7}, Extents = new UnityEngine.Vector2() {x = val_7, y = val_7}}))) == false)
            {
                    return;
            }
            
            val_3.LogError(value:  "test != find");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrSegment2Box2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
