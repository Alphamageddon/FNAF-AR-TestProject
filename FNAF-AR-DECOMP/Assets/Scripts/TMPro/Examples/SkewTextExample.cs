using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SkewTextExample : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_Text m_TextComponent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AnimationCurve VertexCurve;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CurveScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ShearAmount;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.m_TextComponent = this.gameObject.GetComponent<TMPro.TMP_Text>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.WarpText());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AnimationCurve CopyAnimationCurve(UnityEngine.AnimationCurve curve)
        {
            UnityEngine.AnimationCurve val_1 = new UnityEngine.AnimationCurve();
            val_1.keys = curve.keys;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator WarpText()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new SkewTextExample.<WarpText>d__7();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SkewTextExample()
        {
            UnityEngine.Keyframe[] val_1 = new UnityEngine.Keyframe[5];
            val_1[0] = 0;
            val_1[0] = 0;
            val_1[1] = 0;
            val_1[1] = 0;
            val_1[2] = 0;
            val_1[2] = 0;
            val_1[3] = 0;
            val_1[3] = 0;
            val_1[4] = 0;
            val_1[4] = 0;
            this.VertexCurve = new UnityEngine.AnimationCurve(keys:  val_1);
            this.CurveScale = 1f;
            this.ShearAmount = 1f;
        }
    
    }

}
