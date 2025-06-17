using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Benchmark02 : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SpawnType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumberOfNPC;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.Examples.TextMeshProFloatingText floatingText_Script;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            UnityEngine.Transform val_38;
            float val_39;
            float val_40;
            var val_41;
            if(this.NumberOfNPC < 1)
            {
                    return;
            }
            
            var val_34 = 0;
            label_45:
            if(this.SpawnType == 2)
            {
                goto label_2;
            }
            
            if(this.SpawnType == 1)
            {
                goto label_3;
            }
            
            if(this.SpawnType != 0)
            {
                goto label_39;
            }
            
            UnityEngine.GameObject val_1 = null;
            val_34 = val_1;
            val_1 = new UnityEngine.GameObject();
            float val_3 = UnityEngine.Random.Range(min:  -95f, max:  95f);
            float val_4 = UnityEngine.Random.Range(min:  -95f, max:  95f);
            val_1.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_35 = val_1.AddComponent<TMPro.TextMeshPro>();
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  0.5f, y:  0f);
            val_35.rectTransform.pivot = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            if(val_35 == null)
            {
                goto label_11;
            }
            
            val_35.alignment = 2;
            val_36 = 96f;
            val_35.fontSize = 96f;
            goto label_12;
            label_3:
            UnityEngine.GameObject val_8 = new UnityEngine.GameObject();
            float val_10 = UnityEngine.Random.Range(min:  -95f, max:  95f);
            float val_11 = UnityEngine.Random.Range(min:  -95f, max:  95f);
            val_8.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_35 = val_8.AddComponent<UnityEngine.TextMesh>();
            UnityEngine.Font val_13 = UnityEngine.Resources.Load<UnityEngine.Font>(path:  "Fonts/ARIAL");
            if(val_35 == null)
            {
                goto label_16;
            }
            
            val_35.font = val_13;
            val_37 = val_35.GetComponent<UnityEngine.Renderer>();
            goto label_17;
            label_2:
            UnityEngine.GameObject val_15 = null;
            val_34 = val_15;
            val_15 = new UnityEngine.GameObject();
            val_15.AddComponent<UnityEngine.Canvas>().worldCamera = UnityEngine.Camera.main;
            val_15.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            float val_20 = UnityEngine.Random.Range(min:  -95f, max:  95f);
            float val_21 = UnityEngine.Random.Range(min:  -95f, max:  95f);
            val_15.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_35 = new UnityEngine.GameObject().AddComponent<TMPro.TextMeshProUGUI>();
            val_38 = val_15.transform;
            val_35.rectTransform.SetParent(parent:  val_38, worldPositionStays:  false);
            UnityEngine.Color val_26 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            val_39 = val_26.r;
            val_40 = val_26.b;
            if(val_35 == null)
            {
                goto label_29;
            }
            
            val_35.alignment = 2;
            val_35.fontSize = 96f;
            goto label_42;
            label_16:
            val_35.font = val_13;
            val_37 = 0.GetComponent<UnityEngine.Renderer>();
            label_17:
            val_38 = val_35.font.material;
            val_37.sharedMaterial = val_38;
            if(val_35 != null)
            {
                    val_35.anchor = 7;
            }
            else
            {
                    val_35.anchor = 7;
            }
            
            val_35.fontSize = 96;
            UnityEngine.Color val_30 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            val_40 = val_30.g;
            val_39 = val_30.a;
            if(val_35 != null)
            {
                    val_35.color = new UnityEngine.Color() {r = val_30.r, g = val_40, b = val_30.b, a = val_39};
            }
            else
            {
                    val_35.color = new UnityEngine.Color() {r = val_30.r, g = val_40, b = val_30.b, a = val_39};
            }
            
            val_35.text = "!";
            this.floatingText_Script = val_8.AddComponent<TMPro.Examples.TextMeshProFloatingText>();
            val_31.SpawnType = 1;
            goto label_39;
            label_11:
            val_35.alignment = 2;
            val_36 = 96f;
            val_35.fontSize = 96f;
            label_12:
            val_35.enableKerning = false;
            UnityEngine.Color val_32 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            val_39 = val_32.g;
            val_40 = val_32.b;
            val_41 = 0;
            if(val_35 == null)
            {
                    val_41 = 1;
            }
            
            if(val_41 != 0)
            {
                goto label_41;
            }
            
            goto label_42;
            label_29:
            val_35.alignment = 2;
            val_35.fontSize = 96f;
            label_41:
            label_42:
            val_35.text = "!";
            this.floatingText_Script = val_15.AddComponent<TMPro.Examples.TextMeshProFloatingText>();
            val_33.SpawnType = 0;
            label_39:
            val_34 = val_34 + 1;
            if(val_34 < this.NumberOfNPC)
            {
                goto label_45;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Benchmark02()
        {
            this.NumberOfNPC = 12;
        }
    
    }

}
