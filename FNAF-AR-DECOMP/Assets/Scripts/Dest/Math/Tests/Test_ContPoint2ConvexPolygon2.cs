using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContPoint2ConvexPolygon2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform[] ConvexPolygon;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            Dest.Math.Polygon2 val_12;
            Dest.Math.Orientations val_4 = 0;
            UnityEngine.Vector3 val_1 = this.Point.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            val_12 = 0.CreatePolygon2(polygon:  this.ConvexPolygon);
            bool val_5 = val_12.IsConvex(orientation: out  val_4, threshold:  1E-05f);
            if(val_5 == false)
            {
                goto label_5;
            }
            
            if(val_4 != 1)
            {
                goto label_7;
            }
            
            bool val_6 = val_12.ContainsConvexCCW(point:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            goto label_8;
            label_5:
            val_5.FiguresColor();
            val_5.DrawPolygon(polygon:  val_12);
            val_5.DrawPoint(position:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            val_5.LogError(value:  "polygon is non-convex");
            return;
            label_7:
            bool val_7 = val_12.ContainsConvexCW(point:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            label_8:
            val_7.FiguresColor();
            val_7.DrawPolygon(polygon:  val_12);
            if(val_7 != false)
            {
                    val_7.ResultsColor();
            }
            
            val_7.DrawPoint(position:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            object[] val_9 = new object[4];
            val_12 = val_9;
            val_12[0] = "Orientation: ";
            val_12[1] = val_4;
            val_12[2] = "     Contained: ";
            val_12[3] = val_7.ToString();
            string val_11 = +val_9;
            val_11.LogInfo(value:  val_11);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContPoint2ConvexPolygon2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
