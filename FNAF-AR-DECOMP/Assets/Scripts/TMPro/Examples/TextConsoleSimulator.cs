using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TextConsoleSimulator : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_Text m_TextComponent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool hasTextChanged;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.m_TextComponent = this.gameObject.GetComponent<TMPro.TMP_Text>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.RevealCharacters(textComponent:  this.m_TextComponent));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Add(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void TMPro.Examples.TextConsoleSimulator::ON_TEXT_CHANGED(UnityEngine.Object obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void TMPro.Examples.TextConsoleSimulator::ON_TEXT_CHANGED(UnityEngine.Object obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ON_TEXT_CHANGED(UnityEngine.Object obj)
        {
            this.hasTextChanged = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator RevealCharacters(TMPro.TMP_Text textComponent)
        {
            TextConsoleSimulator.<RevealCharacters>d__7 val_1 = new TextConsoleSimulator.<RevealCharacters>d__7();
            .<>1__state = 0;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .textComponent = textComponent;
            return (System.Collections.IEnumerator)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator RevealWords(TMPro.TMP_Text textComponent)
        {
            .<>1__state = 0;
            .textComponent = textComponent;
            return (System.Collections.IEnumerator)new TextConsoleSimulator.<RevealWords>d__8();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TextConsoleSimulator()
        {
        
        }
    
    }

}
