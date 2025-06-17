using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_DistSegment2Segment2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform R0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform R1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_6;
            float val_7;
            float val_8;
            Dest.Math.Segment2 val_1 = 48300.CreateSegment2(p0:  this.P0, p1:  this.P1);
            Dest.Math.Segment2 val_5 = 48300.CreateSegment2(p0:  this.R0, p1:  this.R1);
            float val_9 = Dest.Math.Distance.Segment2Segment2(segment0: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, P1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Direction = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extent = val_2}, segment1: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_7, y = val_7}, P1 = new UnityEngine.Vector2() {x = val_7, y = val_7}, Center = new UnityEngine.Vector2() {x = val_8, y = val_8}, Direction = new UnityEngine.Vector2() {x = val_8, y = val_8}, Extent = val_6}, closestPoint0: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, closestPoint1: out  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_3.FiguresColor();
            val_3.DrawSegment(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, P1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, Center = new UnityEngine.Vector2() {x = val_4, y = val_4}, Direction = new UnityEngine.Vector2() {x = val_4, y = val_4}, Extent = val_2});
            val_3.DrawSegment(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_7, y = val_7}, P1 = new UnityEngine.Vector2() {x = val_7, y = val_7}, Center = new UnityEngine.Vector2() {x = val_8, y = val_8}, Direction = new UnityEngine.Vector2() {x = val_8, y = val_8}, Extent = val_6});
            val_3.ResultsColor();
            val_3.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_3.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_9.LogInfo(value:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_DistSegment2Segment2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
