using UnityEngine;

namespace Systems.Guide.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GuideArrowBehaviour : MonoBehaviour, IGuideArrow
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RectTransform _rectTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Target;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RectTransform RectTransform { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RectTransform get_RectTransform()
        {
            UnityEngine.RectTransform val_3;
            if(this._rectTransform == 0)
            {
                    this._rectTransform = this.GetComponent<UnityEngine.RectTransform>();
                return val_3;
            }
            
            val_3 = this._rectTransform;
            return val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this.Target == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.Target.position;
            this.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowWithTarget(UnityEngine.Vector3 worldPos, UnityEngine.Vector2 canvasOffset, float rotation, float scaling)
        {
            this.gameObject.SetActive(value:  true);
            this.transform.position = new UnityEngine.Vector3() {x = worldPos.x, y = worldPos.y, z = worldPos.z};
            UnityEngine.RectTransform val_3 = this.RectTransform;
            UnityEngine.Vector2 val_4 = val_3.anchoredPosition;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = canvasOffset.x, y = canvasOffset.y});
            val_3.anchoredPosition = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  rotation);
            this.RectTransform.localEulerAngles = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  scaling);
            this.RectTransform.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Hide()
        {
            this.gameObject.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GuideArrowBehaviour()
        {
        
        }
    
    }

}
