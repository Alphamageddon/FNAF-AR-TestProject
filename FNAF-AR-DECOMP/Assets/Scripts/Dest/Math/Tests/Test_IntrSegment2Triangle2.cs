using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrSegment2Triangle2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V2;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_6;
            float val_7;
            Dest.Math.IntersectionTypes val_8 = 0;
            Dest.Math.Segment2 val_1 = 48362.CreateSegment2(p0:  this.P0, p1:  this.P1);
            Dest.Math.Triangle2 val_5 = 48362.CreateTriangle2(v0:  this.V0, v1:  this.V1, v2:  this.V2);
            bool val_10 = Dest.Math.Intersection.FindSegment2Triangle2(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, P1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Center = new UnityEngine.Vector2() {x = val_3, y = val_3}, Direction = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extent = val_2}, triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_7, y = val_7}, V1 = new UnityEngine.Vector2() {x = val_7, y = val_7}, V2 = new UnityEngine.Vector2() {x = val_6, y = val_6}}, info: out  new Dest.Math.Segment2Triangle2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f}});
            val_10.FiguresColor();
            val_10.DrawSegment(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, P1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Center = new UnityEngine.Vector2() {x = val_3, y = val_3}, Direction = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extent = val_2});
            val_10.DrawTriangle(triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_7, y = val_7}, V1 = new UnityEngine.Vector2() {x = val_7, y = val_7}, V2 = new UnityEngine.Vector2() {x = val_6, y = val_6}});
            if(val_10 == false)
            {
                goto label_5;
            }
            
            val_10.ResultsColor();
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
            val_10.DrawSegment(p0:  new UnityEngine.Vector2() {x = 0f, y = 0f}, p1:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            val_10.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_6:
            val_10.DrawPoint(position:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            label_5:
            val_4 = val_8;
            val_4.LogInfo(value:  val_4);
            if((val_10 ^ (Dest.Math.Intersection.TestSegment2Triangle2(segment: ref  new Dest.Math.Segment2() {P0 = new UnityEngine.Vector2() {x = val_4, y = val_4}, P1 = new UnityEngine.Vector2() {x = val_4, y = val_4}, Center = new UnityEngine.Vector2() {x = val_3, y = val_3}, Direction = new UnityEngine.Vector2() {x = val_3, y = val_3}, Extent = val_2}, triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_7, y = val_7}, V1 = new UnityEngine.Vector2() {x = val_7, y = val_7}, V2 = new UnityEngine.Vector2() {x = val_6, y = val_6}}, intersectionType: out  val_8))) != false)
            {
                    val_4.LogError(value:  "test != find");
            }
            
            if(val_8 == 0)
            {
                    return;
            }
            
            val_4.LogError(value:  "intersectionType != info.IntersectionType");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrSegment2Triangle2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
