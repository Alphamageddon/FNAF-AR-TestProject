using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_Line2Sides : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Line;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform AABMin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform AABMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Box;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Circle;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_6;
            float val_7;
            Dest.Math.Line2 val_1 = 48374.CreateLine2(line:  this.Line);
            UnityEngine.Vector3 val_2 = this.Point.position;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            Dest.Math.AAB2 val_4 = 0.CreateAAB2(point0:  this.AABMin, point1:  this.AABMax);
            Dest.Math.Box2 val_5 = val_4.Min.x.CreateBox2(box:  this.Box);
            Dest.Math.Circle2 val_8 = val_4.Min.x.CreateCircle2(circle:  this.Circle);
            0f.FiguresColor();
            0f.DrawLine(line: ref  new Dest.Math.Line2() {Center = new UnityEngine.Vector2() {x = 0f, y = ???}, Direction = new UnityEngine.Vector2() {x = ???, y = ???}});
            0f.SetColor(side:  2106184688);
            0f.DrawPoint(position:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            0f.SetColor(side:  2106184688);
            0f.DrawAAB(box: ref  new Dest.Math.AAB2() {Min = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, Max = new UnityEngine.Vector2() {x = val_2.z, y = ???}});
            0f.SetColor(side:  2106184688);
            0f.DrawBox(box: ref  new Dest.Math.Box2() {Center = new UnityEngine.Vector2() {x = val_7, y = val_7}, Axis0 = new UnityEngine.Vector2() {x = val_7, y = val_7}, Axis1 = new UnityEngine.Vector2() {x = val_6, y = val_6}, Extents = new UnityEngine.Vector2() {x = val_6, y = val_6}});
            0f.SetColor(side:  2106184688);
            0f.DrawCircle(circle: ref  new Dest.Math.Circle2() {Center = new UnityEngine.Vector2() {x = val_6, y = val_7}, Radius = val_2.z});
            object[] val_9 = new object[18];
            val_9[0] = "PointSignedDistance: ";
            val_9[1] = val_3.x;
            val_9[2] = " PointNeg: ";
            val_9[3] = 0.ToString();
            val_9[4] = " PointPos: ";
            val_9[5] = 0.ToString();
            val_9[6] = "     AABNeg: ";
            val_9[7] = 0.ToString();
            val_9[8] = " AABPos: ";
            val_9[9] = 0.ToString();
            val_9[10] = "     BoxNeg: ";
            val_9[11] = 0.ToString();
            val_9[12] = " BoxPos: ";
            val_9[13] = 0.ToString();
            val_9[14] = "     CircleNeg: ";
            val_9[15] = 0.ToString();
            val_9[16] = " CirclePos: ";
            val_9[17] = 0.ToString();
            string val_18 = +val_9;
            val_18.LogInfo(value:  val_18);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetColor(int side)
        {
            if((side & 2147483648) != 0)
            {
                goto label_0;
            }
            
            if(side == 0)
            {
                goto label_1;
            }
            
            UnityEngine.Color val_1 = UnityEngine.Color.red;
            goto label_2;
            label_0:
            UnityEngine.Color val_2 = UnityEngine.Color.blue;
            label_2:
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            return;
            label_1:
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_Line2Sides()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
