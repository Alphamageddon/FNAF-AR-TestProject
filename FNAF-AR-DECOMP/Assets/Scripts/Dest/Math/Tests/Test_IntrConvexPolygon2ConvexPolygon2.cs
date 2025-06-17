using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_IntrConvexPolygon2ConvexPolygon2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform[] Points0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform[] Points1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            object val_17;
            Dest.Math.Orientations val_3 = 0;
            Dest.Math.Orientations val_6 = 0;
            Dest.Math.Polygon2 val_1 = 48319.CreatePolygon2(polygon:  this.Points0);
            Dest.Math.Polygon2 val_2 = val_1.CreatePolygon2(polygon:  this.Points1);
            bool val_5 = val_1.IsConvex(orientation: out  val_3, threshold:  1E-05f);
            bool val_7 = val_2.IsConvex(orientation: out  val_6, threshold:  1E-05f);
            bool val_8 = val_7;
            val_7.FiguresColor();
            val_7.DrawPolygon(polygon:  val_1);
            val_7.DrawPolygon(polygon:  val_2);
            bool val_17 = val_5;
            val_17 = val_17 & val_8;
            if(((val_17 != false) && (val_3 == 1)) && (val_6 == 1))
            {
                    val_17 = "Intersection: "("Intersection: ") + Dest.Math.Intersection.TestConvexPolygon2ConvexPolygon2(convexPolygon0:  val_1, convexPolygon1:  val_2).ToString()(Dest.Math.Intersection.TestConvexPolygon2ConvexPolygon2(convexPolygon0:  val_1, convexPolygon1:  val_2).ToString());
                Dest.Math.Logger.LogInfo(value:  val_17);
                return;
            }
            
            object[] val_13 = new object[8];
            val_13[0] = "Polygons are incorrect.   Pol0Convex: ";
            val_13[1] = val_5.ToString();
            val_13[2] = "   Pol0Ori: ";
            val_13[3] = val_3;
            val_13[4] = "   Pol1Convex: ";
            val_13[5] = val_8.ToString();
            val_13[6] = "   Pol1Ori: ";
            val_13[7] = val_6;
            val_17 = +val_13;
            Dest.Math.Logger.LogError(value:  val_17);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_IntrConvexPolygon2ConvexPolygon2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
