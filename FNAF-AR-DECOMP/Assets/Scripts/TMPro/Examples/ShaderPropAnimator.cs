using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ShaderPropAnimator : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Renderer m_Renderer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Material m_Material;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AnimationCurve GlowCurve;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float m_frame;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            UnityEngine.Renderer val_1 = this.GetComponent<UnityEngine.Renderer>();
            this.m_Renderer = val_1;
            this.m_Material = val_1.material;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.AnimateProperties());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator AnimateProperties()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new ShaderPropAnimator.<AnimateProperties>d__6();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ShaderPropAnimator()
        {
        
        }
    
    }

}
