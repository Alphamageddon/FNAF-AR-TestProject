using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TMP_TextInfoDebugTool : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowCharacters;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowWords;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowLinks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowLines;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowMeshBounds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool ShowTextBounds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ObjectStats;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_Text m_TextComponent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform m_Transform;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMP_TextInfoDebugTool()
        {
        
        }
    
    }

}
