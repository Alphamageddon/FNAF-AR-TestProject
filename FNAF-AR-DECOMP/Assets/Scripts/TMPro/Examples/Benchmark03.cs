using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Benchmark03 : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SpawnType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumberOfNPC;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Font TheFont;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            UnityEngine.Font val_9;
            var val_10;
            float val_11;
            if(this.NumberOfNPC < 1)
            {
                    return;
            }
            
            var val_9 = 0;
            label_19:
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
            val_9 = val_1.transform;
            if(this.SpawnType == 0)
            {
                goto label_3;
            }
            
            val_9.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.TextMesh val_3 = val_1.AddComponent<UnityEngine.TextMesh>();
            val_3.GetComponent<UnityEngine.Renderer>().sharedMaterial = this.TheFont.material;
            val_9 = this.TheFont;
            if(val_3 == null)
            {
                goto label_9;
            }
            
            val_3.font = val_9;
            val_3.anchor = 4;
            goto label_10;
            label_3:
            val_9.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            TMPro.TextMeshPro val_6 = val_1.AddComponent<TMPro.TextMeshPro>();
            if(val_6 == null)
            {
                goto label_13;
            }
            
            val_6.alignment = 2;
            val_10 = 96f;
            val_6.fontSize = 96f;
            goto label_14;
            label_9:
            val_3.font = val_9;
            val_3.anchor = 4;
            label_10:
            val_3.fontSize = 96;
            UnityEngine.Color val_7 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            val_11 = val_7.b;
            if(val_3 != null)
            {
                    val_3.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_11, a = val_7.a};
            }
            else
            {
                    val_3.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_11, a = val_7.a};
            }
            
            val_3.text = "@";
            goto label_17;
            label_13:
            0.alignment = 2;
            val_10 = 96f;
            0.fontSize = 96f;
            label_14:
            0.text = "@";
            UnityEngine.Color val_8 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            val_11 = val_8.g;
            label_17:
            val_9 = val_9 + 1;
            if(val_9 < this.NumberOfNPC)
            {
                goto label_19;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Benchmark03()
        {
            this.NumberOfNPC = 12;
        }
    
    }

}
