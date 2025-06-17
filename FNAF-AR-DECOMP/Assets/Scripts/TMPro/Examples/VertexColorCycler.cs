using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VertexColorCycler : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_Text m_TextComponent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.m_TextComponent = this.GetComponent<TMPro.TMP_Text>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.AnimateVertexColors());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator AnimateVertexColors()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new VertexColorCycler.<AnimateVertexColors>d__3();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VertexColorCycler()
        {
        
        }
    
    }

}
