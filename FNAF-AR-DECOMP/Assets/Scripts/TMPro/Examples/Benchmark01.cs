using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Benchmark01 : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int BenchmarkType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TMP_FontAsset TMProFont;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Font TextMeshFont;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshPro m_textMeshPro;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextContainer m_textContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.TextMesh m_textMesh;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string label01 = "The <#0050FF>count is: </color>{0}";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string label02 = "The <color=#0050FF>count is: </color>";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material m_material01;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material m_material02;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator Start()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new Benchmark01.<Start>d__10();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Benchmark01()
        {
        
        }
    
    }

}
