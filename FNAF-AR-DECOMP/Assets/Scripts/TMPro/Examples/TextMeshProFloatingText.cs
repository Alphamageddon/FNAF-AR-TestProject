using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TextMeshProFloatingText : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Font TheFont;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject m_floatingText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshPro m_textMeshPro;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.TextMesh m_textMesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform m_transform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform m_floatingText_Transform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform m_cameraTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 lastPOS;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Quaternion lastRotation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int SpawnType;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.m_transform = this.transform;
            this.m_floatingText = new UnityEngine.GameObject(name:  this.name + " floating text");
            this.m_cameraTransform = UnityEngine.Camera.main.transform;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            float val_26;
            float val_27;
            TMPro.TextMeshPro val_28;
            if(this.SpawnType != 1)
            {
                    if(this.SpawnType != 0)
            {
                    return;
            }
            
                TMPro.TextMeshPro val_1 = this.m_floatingText.AddComponent<TMPro.TextMeshPro>();
                this.m_textMeshPro = val_1;
                UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  3f, y:  3f);
                val_1.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
                UnityEngine.Transform val_4 = this.m_floatingText.transform;
                this.m_floatingText_Transform = val_4;
                UnityEngine.Vector3 val_5 = this.m_transform.position;
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_4.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
                this.m_textMeshPro.alignment = 2;
                int val_7 = UnityEngine.Random.Range(min:  0, max:  255);
                int val_8 = UnityEngine.Random.Range(min:  0, max:  255);
                int val_9 = UnityEngine.Random.Range(min:  0, max:  255);
                UnityEngine.Color val_10 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
                val_26 = val_10.r;
                val_27 = val_10.b;
                this.m_textMeshPro.fontSize = 24f;
                this.m_textMeshPro.enableKerning = false;
                val_28 = this.m_textMeshPro;
                val_28.text = System.String.alignConst;
                System.Collections.IEnumerator val_11 = this.DisplayTextMeshProFloatingText();
            }
            else
            {
                    UnityEngine.Transform val_12 = this.m_floatingText.transform;
                this.m_floatingText_Transform = val_12;
                UnityEngine.Vector3 val_13 = this.m_transform.position;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_12.position = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
                UnityEngine.TextMesh val_15 = this.m_floatingText.AddComponent<UnityEngine.TextMesh>();
                this.m_textMesh = val_15;
                val_15.font = UnityEngine.Resources.Load<UnityEngine.Font>(path:  "Fonts/ARIAL");
                this.m_textMesh.GetComponent<UnityEngine.Renderer>().sharedMaterial = this.m_textMesh.font.material;
                val_28 = UnityEngine.Random.Range(min:  0, max:  255);
                int val_21 = UnityEngine.Random.Range(min:  0, max:  255);
                int val_22 = UnityEngine.Random.Range(min:  0, max:  255);
                UnityEngine.Color val_23 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
                val_26 = val_23.r;
                val_27 = val_23.b;
                this.m_textMesh.color = new UnityEngine.Color() {r = val_26, g = val_23.g, b = val_27, a = val_23.a};
                this.m_textMesh.anchor = 7;
                this.m_textMesh.fontSize = 24;
            }
            
            UnityEngine.Coroutine val_25 = this.StartCoroutine(routine:  this.DisplayTextMeshFloatingText());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.IEnumerator DisplayTextMeshProFloatingText()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new TextMeshProFloatingText.<DisplayTextMeshProFloatingText>d__12();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.IEnumerator DisplayTextMeshFloatingText()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new TextMeshProFloatingText.<DisplayTextMeshFloatingText>d__13();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TextMeshProFloatingText()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.lastPOS = val_1;
            mem[1152921524666525188] = val_1.y;
            mem[1152921524666525192] = val_1.z;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            this.lastRotation = val_2;
            mem[1152921524666525200] = val_2.y;
            mem[1152921524666525204] = val_2.z;
            mem[1152921524666525208] = val_2.w;
        }
    
    }

}
