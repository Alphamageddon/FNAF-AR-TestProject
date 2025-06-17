using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VertexShakeA : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float AngleMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float SpeedMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ScaleMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float RotationMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_Text m_TextComponent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool hasTextChanged;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.m_TextComponent = this.GetComponent<TMPro.TMP_Text>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Add(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void TMPro.Examples.VertexShakeA::ON_TEXT_CHANGED(UnityEngine.Object obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void TMPro.Examples.VertexShakeA::ON_TEXT_CHANGED(UnityEngine.Object obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.AnimateVertexColors());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ON_TEXT_CHANGED(UnityEngine.Object obj)
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.m_TextComponent)) == false)
            {
                    return;
            }
            
            this.hasTextChanged = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator AnimateVertexColors()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new VertexShakeA.<AnimateVertexColors>d__11();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VertexShakeA()
        {
            this.AngleMultiplier = 1;
        }
    
    }

}
