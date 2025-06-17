using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Components
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VertexDebugger : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Triangles;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Tangents;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Start()
        {
            System.Object[] val_24;
            var val_25;
            int val_26;
            var val_27;
            var val_28;
            UnityEngine.MeshFilter val_1 = this.GetComponent<UnityEngine.MeshFilter>();
            if((UnityEngine.Object.op_Implicit(exists:  val_1)) == false)
            {
                    return;
            }
            
            UnityEngine.Mesh val_3 = val_1.mesh;
            if(val_3 != null)
            {
                    val_24 = val_3.vertices;
            }
            else
            {
                    val_24 = 0.vertices;
            }
            
            UnityEngine.Vector4[] val_6 = val_3.tangents;
            val_25 = 0;
            goto label_7;
            label_27:
            UnityEngine.GameObject val_7 = UnityEngine.GameObject.CreatePrimitive(type:  0);
            string val_8 = 0.ToString();
            if(val_7 != null)
            {
                    val_7.name = val_8;
            }
            else
            {
                    0.name = val_8;
            }
            
            val_7.transform.SetParent(parent:  this.transform, worldPositionStays:  false);
            val_7.transform.localPosition = new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 1.85775E-36f};
            UnityEngine.Vector3 val_13 = this.transform.position;
            var val_14 = val_24 + (0 * 12);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = (0 * 12) + val_5 + 32, y = (0 * 12) + val_5 + 32 + 4, z = (0 * 12) + val_5 + 40});
            UnityEngine.Vector3 val_17 = this.transform.position;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 1.85775E-36f});
            val_26 = val_6.Length;
            if(0 >= val_26)
            {
                    val_26 = val_6.Length;
            }
            
            val_27 = 0;
            UnityEngine.Vector4 val_25 = val_6[0];
            if(0 >= val_26)
            {
                    val_27 = 0;
                val_26 = val_6.Length;
            }
            
            UnityEngine.Vector4 val_26 = val_6[0];
            UnityEngine.Vector4 val_27 = val_6[0];
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  0.5f);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            UnityEngine.Color val_21 = UnityEngine.Color.red;
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, end:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, color:  new UnityEngine.Color() {r = val_21.r, g = val_21.b, b = 10000f, a = val_3}, duration:  val_15.y);
            val_25 = 1;
            label_7:
            if(val_25 < val_5.Length)
            {
                goto label_27;
            }
            
            System.Int32[] val_22 = val_3.triangles;
            this.Triangles = "";
            val_28 = 2;
            goto label_29;
            label_58:
            object[] val_23 = new object[7];
            val_24 = val_23;
            if(val_24 == null)
            {
                goto label_30;
            }
            
            if(this.Triangles != null)
            {
                goto label_31;
            }
            
            goto label_34;
            label_30:
            if(this.Triangles == null)
            {
                goto label_34;
            }
            
            label_31:
            label_34:
            val_24[0] = this.Triangles;
            val_24[1] = val_22[277002560];
            val_24[2] = ",";
            val_24[3] = val_22[4];
            val_24[4] = ",";
            val_24[5] = val_22[8];
            val_24[6] = "\r\n";
            val_28 = 5;
            this.Triangles = +val_23;
            label_29:
            if(3 < val_22.Length)
            {
                goto label_58;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VertexDebugger()
        {
        
        }
    
    }

}
