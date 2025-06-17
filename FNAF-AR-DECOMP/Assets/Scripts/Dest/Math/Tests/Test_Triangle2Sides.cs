using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_Triangle2Sides : Test_Base
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Point;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            float val_2;
            float val_3;
            var val_8;
            Dest.Math.Triangle2 val_1 = this.CreateTriangle2(v0:  this.V0, v1:  this.V1, v2:  this.V2);
            UnityEngine.Vector3 val_4 = this.Point.position;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            this.FiguresColor();
            this.DrawTriangle(triangle: ref  new Dest.Math.Triangle2() {V0 = new UnityEngine.Vector2() {x = val_3, y = val_3}, V1 = new UnityEngine.Vector2() {x = val_3, y = val_3}, V2 = new UnityEngine.Vector2() {x = val_2, y = val_2}});
            if(val_3 == 0)
            {
                goto label_4;
            }
            
            if( != 1)
            {
                goto label_5;
            }
            
            val_8 = ;
            goto label_6;
            label_4:
            val_8 = ;
            label_6:
            this.SetColor(side:  2106635696);
            label_5:
            this.DrawPoint(position:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            object[] val_6 = new object[6];
            val_6[0] = "Orientation: ";
            val_3 = ;
            val_6[1] = val_3;
            val_6[2] = "      CCWSide: ";
            val_6[3] = ;
            val_6[4] = "     CWSide: ";
            val_6[5] = ;
            this.LogInfo(value:  +val_6);
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
        public Test_Triangle2Sides()
        {
        
        }
    
    }

}
