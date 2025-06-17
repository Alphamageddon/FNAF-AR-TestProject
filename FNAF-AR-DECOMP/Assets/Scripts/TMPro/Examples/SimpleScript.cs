using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SimpleScript : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshPro m_textMeshPro;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string label = "The <#0050FF>count is: </color>{0:2}";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float m_frame;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.m_textMeshPro = this.gameObject.AddComponent<TMPro.TextMeshPro>();
            this.m_textMeshPro.fontSize = 48f;
            this.m_textMeshPro.alignment = 2;
            this.m_textMeshPro.enableWordWrapping = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.m_textMeshPro.SetText(text:  "The <#0050FF>count is: </color>{0:2}", arg0:  this.m_frame);
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.m_frame + val_1;
            this.m_frame = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SimpleScript()
        {
        
        }
    
    }

}
