using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TMP_ExampleScript_01 : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.Examples.TMP_ExampleScript_01.objectType ObjectType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isStatic;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_Text m_text;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string k_label = "The count is <#0080ff>{0}</color>";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int count;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            TMPro.TMP_Text val_11;
            var val_12;
            var val_13;
            if(this.ObjectType == 0)
            {
                goto label_1;
            }
            
            val_11 = this.GetComponent<TMPro.TextMeshProUGUI>();
            if(val_11 != null)
            {
                goto label_5;
            }
            
            val_12 = this.gameObject;
            val_13 = 1152921524655219696;
            goto label_4;
            label_1:
            val_11 = this.GetComponent<TMPro.TextMeshPro>();
            if(val_11 != null)
            {
                goto label_5;
            }
            
            val_12 = this.gameObject;
            val_13 = 1152921524654081472;
            label_4:
            val_11 = val_12.AddComponent<TMPro.TextMeshPro>();
            label_5:
            this.m_text = val_11;
            val_11.font = UnityEngine.Resources.Load<TMPro.TMP_FontAsset>(path:  "Fonts & Materials/Anton SDF");
            UnityEngine.Material val_7 = UnityEngine.Resources.Load<UnityEngine.Material>(path:  "Fonts & Materials/Anton SDF - Drop Shadow");
            this.m_text.fontSize = 120f;
            this.m_text.text = "A <#0080ff>simple</color> line of text.";
            UnityEngine.Vector2 val_8 = this.m_text.GetPreferredValues(width:  Infinityf, height:  Infinityf);
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_8.x, y:  val_8.y);
            this.m_text.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this.isStatic == true)
            {
                    return;
            }
            
            this.m_text.SetText(text:  "The count is <#0080ff>{0}</color>", arg0:  0f);
            int val_1 = this.count;
            val_1 = val_1 + 1;
            this.count = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMP_ExampleScript_01()
        {
        
        }
    
    }

}
