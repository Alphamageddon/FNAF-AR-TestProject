using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_ContPoint2Triangle2 : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
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
            float val_4;
            float val_5;
            var val_19;
            bool val_20;
            object val_21;
            val_19 = this;
            UnityEngine.Vector3 val_1 = this.Point.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            Dest.Math.Triangle2 val_3 = 0.CreateTriangle2(v0:  this.V0, v1:  this.V1, v2:  this.V2);
            if(val_5 == 0)
            {
                goto label_4;
            }
            
            if(2037089808 != 1)
            {
                goto label_5;
            }
            
            bool val_6 = val_5.Contains(point:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            bool val_7 = val_6;
            bool val_8 = val_5.ContainsCCW(point:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            val_19 = val_8;
            val_8.FiguresColor();
            val_8.DrawTriangle(triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, V1 = new UnityEngine.Vector2() {x = val_5, y = val_5}, V2 = new UnityEngine.Vector2() {x = val_4, y = val_4}});
            if(val_6 != false)
            {
                    val_8.ResultsColor();
            }
            
            val_8.DrawPoint(position:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            object[] val_9 = new object[4];
            val_9[0] = "Orientation: ";
            val_5 = 1;
            val_9[1] = val_5;
            val_9[2] = "    Contained: ";
            val_9[3] = val_7.ToString();
            string val_11 = +val_9;
            val_11.LogInfo(value:  val_11);
            val_20 = val_7;
            goto label_20;
            label_4:
            bool val_12 = val_5.Contains(point:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            bool val_13 = val_12;
            bool val_14 = val_5.ContainsCW(point:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            val_19 = val_14;
            val_14.FiguresColor();
            val_14.DrawTriangle(triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_5, y = val_5}, V1 = new UnityEngine.Vector2() {x = val_5, y = val_5}, V2 = new UnityEngine.Vector2() {x = val_4, y = val_4}});
            if(val_12 != false)
            {
                    val_14.ResultsColor();
            }
            
            val_14.DrawPoint(position:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            object[] val_15 = new object[4];
            val_15[0] = "Orientation: ";
            val_5 = 0;
            val_15[1] = val_5;
            val_15[2] = "    Contained: ";
            val_15[3] = val_13.ToString();
            string val_17 = +val_15;
            val_17.LogInfo(value:  val_17);
            val_20 = val_13;
            label_20:
            if(val_20 == val_19)
            {
                    return;
            }
            
            val_21 = "cont != cont1";
            goto label_36;
            label_5:
            val_21 = "Triangle is degenerate";
            label_36:
            val_5.LogError(value:  val_21);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_ContPoint2Triangle2()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
