using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrTriangle2Triangle2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform P2;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            float val_5;
            float val_6;
            Dest.Math.Triangle2 val_1 = 48372.CreateTriangle2(v0:  this.V0, v1:  this.V1, v2:  this.V2);
            Dest.Math.Triangle2 val_4 = 48372.CreateTriangle2(v0:  this.P0, v1:  this.P1, v2:  this.P2);
            bool val_8 = Dest.Math.Intersection.FindTriangle2Triangle2(triangle0: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, V1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, V2 = new UnityEngine.Vector2() {x = val_2, y = val_2}}, triangle1: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_6, y = val_6}, V1 = new UnityEngine.Vector2() {x = val_6, y = val_6}, V2 = new UnityEngine.Vector2() {x = val_5, y = val_5}}, info: out  new Dest.Math.Triangle2Triangle2Intr() {Point0 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point1 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point2 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point3 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point4 = new UnityEngine.Vector2() {x = 0f, y = 0f}, Point5 = new UnityEngine.Vector2() {x = 0f, y = val_6}});
            val_8.FiguresColor();
            val_8.DrawTriangle(triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, V1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, V2 = new UnityEngine.Vector2() {x = val_2, y = val_2}});
            val_8.DrawTriangle(triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_6, y = val_6}, V1 = new UnityEngine.Vector2() {x = val_6, y = val_6}, V2 = new UnityEngine.Vector2() {x = val_5, y = val_5}});
            if(val_8 == false)
            {
                goto label_3;
            }
            
            val_8.ResultsColor();
            if(0 < 1)
            {
                goto label_6;
            }
            
            var val_13 = 0;
            do
            {
                val_13 = val_13 + 1;
                var val_10 = val_13 - ((val_13 / 0) * 0);
                0.DrawSegment(p0:  new UnityEngine.Vector2() {x = val_6, y = V1.16B}, p1:  new UnityEngine.Vector2() {x = val_6, y = V1.16B});
                0.DrawPoint(position:  new UnityEngine.Vector2() {x = val_6, y = V1.16B});
            }
            while(val_13 < 0);
            
            goto label_6;
            label_3:
            label_6:
            val_3 = 0;
            val_6 = 0;
            string val_11 = val_3 + " " + 0;
            val_11.LogInfo(value:  val_11);
            if(((Dest.Math.Intersection.TestTriangle2Triangle2(triangle0: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, V1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, V2 = new UnityEngine.Vector2() {x = val_2, y = val_2}}, triangle1: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_6, y = val_6}, V1 = new UnityEngine.Vector2() {x = val_6, y = val_6}, V2 = new UnityEngine.Vector2() {x = val_5, y = val_5}})) ^ val_8) == false)
            {
                    return;
            }
            
            val_11.LogError(value:  "test != find");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrTriangle2Triangle2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
