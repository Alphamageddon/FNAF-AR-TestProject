using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_Triangle2 : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V1;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform V2;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float c0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float c1;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDrawGizmos()
        {
            UnityEngine.Vector3 val_1 = this.V0.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = this.V1.position;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = this.V2.position;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Color val_7 = UnityEngine.Color.gray;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, to:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, to:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, to:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Color val_14 = UnityEngine.Color.blue;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_14.r, g = val_14.g, b = val_14.b, a = val_14.a};
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.c0, y = this.c1});
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, radius:  0.25f);
            object[] val_16 = new object[6];
            val_16[0] = "orientation: ";
            val_16[1] = ;
            val_16[2] = "     Angles: ";
            val_16[3] = Dest.Math.Vector3ex.ToStringEx(vector:  new UnityEngine.Vector3() {x = 1E-05f, y = val_12.y, z = val_12.z});
            val_16[4] = "    Bary: ";
            val_16[5] = Dest.Math.Vector3ex.ToStringEx(vector:  new UnityEngine.Vector3() {x = this.c0, y = this.c1, z = val_14.b});
            Dest.Math.Logger.LogInfo(value:  +val_16);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_Triangle2()
        {
        
        }
    
    }

}
