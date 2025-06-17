using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_Polygon2 : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform[] Points;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            var val_29;
            float val_30;
            var val_32;
            Dest.Math.Orientations val_16 = 0;
            System.Collections.Generic.List<UnityEngine.Vector2> val_1 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            val_29 = 0;
            goto label_1;
            label_11:
            UnityEngine.Transform val_29 = this.Points[0];
            if(val_29 != 0)
            {
                    UnityEngine.Vector3 val_3 = val_29.position;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                val_30 = val_4.x;
                val_1.Add(item:  new UnityEngine.Vector2() {x = val_30, y = val_4.y});
            }
            
            val_29 = 1;
            label_1:
            if(val_29 < this.Points.Length)
            {
                goto label_11;
            }
            
            Dest.Math.Polygon2 val_6 = new Dest.Math.Polygon2(vertices:  val_1.ToArray());
            UnityEngine.Color val_7 = UnityEngine.Color.gray;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
            val_32 = 0;
            goto label_14;
            label_19:
            if(val_32 >= val_6.VertexCount)
            {
                goto label_15;
            }
            
            label_20:
            UnityEngine.Vector2 val_11 = val_6.Item[0];
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
            val_30 = val_12.x;
            UnityEngine.Vector2 val_13 = val_6.Item[val_6.VertexCount - 1];
            UnityEngine.Vector3 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_30, y = val_12.y, z = val_12.z}, to:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            val_32 = 1;
            label_14:
            if(val_6 == null)
            {
                goto label_19;
            }
            
            if(val_32 < val_6.VertexCount)
            {
                goto label_20;
            }
            
            bool val_18 = val_6.IsConvex(orientation: out  val_16, threshold:  1E-05f);
            goto label_21;
            label_15:
            label_21:
            object[] val_23 = new object[10];
            val_23[0] = "Area: ";
            val_23[1] = val_6.CalcArea();
            val_23[2] = "     Per: ";
            val_23[3] = val_6.CalcPerimeter();
            val_23[4] = "     Convex: ";
            val_23[5] = val_6.IsConvex(orientation: out  val_16, threshold:  1E-05f).ToString();
            val_23[6] = "     Orient: ";
            val_23[7] = val_16;
            val_23[8] = "     ZeroCorners: ";
            val_23[9] = val_6.HasZeroCorners(threshold:  1E-05f).ToString();
            Dest.Math.Logger.LogInfo(value:  +val_23);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_Polygon2()
        {
        
        }
    
    }

}
