using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ToggleController : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool isOn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool requestOn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color onColorBg;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Color offColorBg;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Image toggleBgImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform toggle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject handle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float handleOffset;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject onIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject offIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float speed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RectTransform handleTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float handleSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float onPosX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float offPosX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float t;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool switching;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StartToggle()
        {
            float val_1 = this.t;
            val_1 = 1f - val_1;
            this.isOn = this.requestOn;
            this.t = val_1;
            this.switching = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateToggle()
        {
            float val_12;
            UnityEngine.GameObject val_13;
            UnityEngine.RectTransform val_14;
            float val_15;
            float val_16;
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.speed * val_1;
            val_1 = this.t + val_1;
            float val_2 = UnityEngine.Mathf.Clamp(value:  val_1, min:  0f, max:  1f);
            this.t = val_2;
            if(this.isOn != false)
            {
                    UnityEngine.Color val_3 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.offColorBg, g = 0f, b = 1f}, b:  new UnityEngine.Color() {r = this.onColorBg}, t:  val_2);
                val_12 = val_3.b;
                this.toggleBgImage.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_12, a = val_3.a};
                UnityEngine.CanvasGroup val_4 = this.SmoothTransparency(alphaObj:  this.onIcon, startAlpha:  0f, endAlpha:  1f);
                val_13 = this.offIcon;
                UnityEngine.CanvasGroup val_5 = this.SmoothTransparency(alphaObj:  val_13, startAlpha:  1f, endAlpha:  0f);
                val_14 = this.handleTransform;
                val_16 = this.onPosX;
                val_15 = this.offPosX;
            }
            else
            {
                    UnityEngine.Color val_6 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.onColorBg, g = 0f, b = 1f}, b:  new UnityEngine.Color() {r = this.offColorBg}, t:  val_2);
                val_12 = val_6.b;
                this.toggleBgImage.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_12, a = val_6.a};
                UnityEngine.CanvasGroup val_7 = this.SmoothTransparency(alphaObj:  this.onIcon, startAlpha:  1f, endAlpha:  0f);
                val_13 = this.offIcon;
                UnityEngine.CanvasGroup val_8 = this.SmoothTransparency(alphaObj:  val_13, startAlpha:  0f, endAlpha:  1f);
                val_14 = this.handleTransform;
                val_15 = this.onPosX;
                val_16 = this.offPosX;
            }
            
            UnityEngine.Vector3 val_9 = this.SmoothMove(toggleHandle:  val_13, startPosX:  val_15, endPosX:  val_16);
            val_14.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            if(this.t < 1f)
            {
                    return;
            }
            
            this.switching = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 SmoothMove(UnityEngine.GameObject toggleHandle, float startPosX, float endPosX)
        {
            float val_1 = UnityEngine.Mathf.Lerp(a:  startPosX, b:  endPosX, t:  this.t);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Color SmoothColor(UnityEngine.Color startCol, UnityEngine.Color endCol)
        {
            UnityEngine.Color val_1 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = startCol.r, g = startCol.g, b = startCol.b, a = startCol.a}, b:  new UnityEngine.Color() {r = endCol.r, g = endCol.g, b = endCol.b, a = endCol.a}, t:  this.t);
            return new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.CanvasGroup SmoothTransparency(UnityEngine.GameObject alphaObj, float startAlpha, float endAlpha)
        {
            UnityEngine.CanvasGroup val_2 = alphaObj.gameObject.GetComponent<UnityEngine.CanvasGroup>();
            val_2.alpha = UnityEngine.Mathf.Lerp(a:  startAlpha, b:  endAlpha, t:  this.t);
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.handleTransform = this.handle.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Vector2 val_3 = this.handle.GetComponent<UnityEngine.RectTransform>().sizeDelta;
            this.handleSize = val_3.x;
            UnityEngine.Vector2 val_4 = this.toggle.sizeDelta;
            float val_5 = this.handleSize;
            val_4.x = val_4.x * 0.5f;
            val_5 = val_5 * 0.5f;
            val_4.x = val_4.x - val_5;
            val_4.x = val_4.x - this.handleOffset;
            this.onPosX = val_4.x;
            this.offPosX = -val_4.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            if(this.onIcon.activeSelf != false)
            {
                    if(this.offIcon.activeSelf == true)
            {
                goto label_3;
            }
            
            }
            
            this.onIcon.SetActive(value:  true);
            this.offIcon.SetActive(value:  true);
            label_3:
            this.t = 1f;
            this.UpdateToggle();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(((this.requestOn == true) ? 1 : 0) != ((this.isOn == true) ? 1 : 0))
            {
                    float val_3 = this.t;
                this.isOn = this.requestOn;
                val_3 = 1f - val_3;
                this.t = val_3;
                this.switching = true;
                this.UpdateToggle();
                return;
            }
            
            if(this.switching == false)
            {
                    return;
            }
            
            this.UpdateToggle();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ToggleController()
        {
        
        }
    
    }

}
