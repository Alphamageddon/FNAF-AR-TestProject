using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContPoint2Polygon2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform[] Polygon;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            UnityEngine.Vector3 val_1 = this.Point.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            Dest.Math.Polygon2 val_3 = 0.CreatePolygon2(polygon:  this.Polygon);
            bool val_4 = val_3.ContainsSimple(point:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            bool val_5 = val_4;
            val_4.FiguresColor();
            val_4.DrawPolygon(polygon:  val_3);
            if(val_4 != false)
            {
                    val_4.ResultsColor();
            }
            
            val_4.DrawPoint(position:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            val_5.LogInfo(value:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContPoint2Polygon2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
