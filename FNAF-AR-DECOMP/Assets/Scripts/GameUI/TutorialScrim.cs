using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TutorialScrim : MonoBehaviour, ITutorialScrim
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly UnityEngine.Color MASK_INACTIVE_COLOR;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static readonly UnityEngine.Color MASK_ACTIVE_COLOR;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image maskingImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image highlightWindowImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject duplicatedButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action onTapAction;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Init()
        {
            var val_1;
            this.maskingImage.enabled = false;
            val_1 = null;
            val_1 = null;
            this.maskingImage.color = new UnityEngine.Color() {r = GameUI.TutorialScrim.MASK_INACTIVE_COLOR, g = GameUI.TutorialScrim.MASK_INACTIVE_COLOR.__il2cppRuntimeField_4, b = GameUI.TutorialScrim.MASK_INACTIVE_COLOR.__il2cppRuntimeField_8, a = GameUI.TutorialScrim.MASK_INACTIVE_COLOR.__il2cppRuntimeField_C};
            this.highlightWindowImage.enabled = false;
            this.onTapAction = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ConfigureBlocking(bool isBlocking)
        {
            isBlocking = isBlocking;
            this.maskingImage.enabled = isBlocking;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ConfigureMasking(bool isMasking)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_1 = null;
            if(isMasking != false)
            {
                    val_2 = null;
                val_3 = 1152921505244868624;
                val_4 = 1152921505244868628;
                val_5 = 1152921505244868632;
                val_6 = 1152921505244868636;
            }
            else
            {
                    val_7 = null;
                val_4 = 1152921505244868612;
                val_5 = 1152921505244868616;
                val_6 = 1152921505244868620;
            }
            
            this.maskingImage.color = new UnityEngine.Color() {r = GameUI.TutorialScrim.__il2cppRuntimeField_static_fields, g = mem[1152921505244868612], b = mem[1152921505244868616], a = mem[1152921505244868620]};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ConfigureHighlight(UnityEngine.UI.Image targetElement)
        {
            var val_22;
            bool val_23;
            float val_24;
            float val_25;
            var val_26;
            var val_27;
            val_22 = this;
            UnityEngine.Object val_22 = 0;
            val_23 = UnityEngine.Object.op_Inequality(x:  targetElement, y:  val_22);
            val_22 = val_23;
            this.highlightWindowImage.enabled = val_22;
            UnityEngine.Color val_2 = UnityEngine.Color.clear;
            val_24 = val_2.r;
            val_25 = val_2.b;
            this.highlightWindowImage.color = new UnityEngine.Color() {r = val_24, g = val_2.g, b = val_25, a = val_2.a};
            if(this.duplicatedButton != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.duplicatedButton);
            }
            
            if(val_23 == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_6 = targetElement.rectTransform.position;
            this.highlightWindowImage.rectTransform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector2 val_9 = targetElement.rectTransform.sizeDelta;
            this.highlightWindowImage.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
            UnityEngine.GameObject val_12 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  targetElement.gameObject, parent:  this.maskingImage.transform);
            this.duplicatedButton = val_12;
            UnityEngine.Vector3 val_15 = targetElement.transform.position;
            val_25 = val_15.z;
            val_12.transform.position = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_25};
            val_23 = this.duplicatedButton.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Vector2 val_18 = targetElement.rectTransform.sizeDelta;
            val_24 = val_18.x;
            val_23.sizeDelta = new UnityEngine.Vector2() {x = val_24, y = val_18.y};
            val_26 = 0;
            goto label_30;
            label_34:
            val_23 = this.duplicatedButton.GetComponentsInChildren<UnityEngine.UI.Image>()[0];
            val_26 = 1;
            label_30:
            if(val_26 < val_19.Length)
            {
                goto label_34;
            }
            
            val_27 = 0;
            goto label_36;
            label_40:
            val_23 = this.duplicatedButton.GetComponentsInChildren<UnityEngine.UI.Text>()[0];
            val_27 = 1;
            label_36:
            if(val_27 < val_20.Length)
            {
                goto label_40;
            }
            
            val_22 = this.duplicatedButton.GetComponentsInChildren<UnityEngine.UI.Button>();
            if(val_20.Length < 1)
            {
                    return;
            }
            
            var val_23 = 0;
            do
            {
                val_23 = val_22[0];
                val_23.interactable = false;
                val_23 = val_23 + 1;
            }
            while(val_23 < val_20.Length);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ConfigureTapOverride(System.Action onTapAction)
        {
            this.onTapAction = onTapAction;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnClick()
        {
            if(this.onTapAction == null)
            {
                    return;
            }
            
            this.onTapAction.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TutorialScrim()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static TutorialScrim()
        {
            GameUI.TutorialScrim.MASK_INACTIVE_COLOR = 0;
            GameUI.TutorialScrim.MASK_ACTIVE_COLOR = 0;
            GameUI.TutorialScrim.MASK_INACTIVE_COLOR.__il2cppRuntimeField_14 = 0;
            GameUI.TutorialScrim.MASK_INACTIVE_COLOR.__il2cppRuntimeField_1C = 0;
        }
    
    }

}
