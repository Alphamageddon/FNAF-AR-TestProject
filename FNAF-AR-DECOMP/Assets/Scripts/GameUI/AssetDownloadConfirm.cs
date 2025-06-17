using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AssetDownloadConfirm : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject dialogParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI title;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI body;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI buttonConfirmText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI buttonDenyText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button confirmButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button denyButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject sliderParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI sliderDisplayText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Slider slider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GenericDialogData _genericDialogData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PositiveButtonAction()
        {
            if(this._genericDialogData.positiveButtonAction == null)
            {
                    return;
            }
            
            this._genericDialogData.positiveButtonAction.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void NegativeButtonAction()
        {
            if(this._genericDialogData.negativeButtonAction == null)
            {
                    return;
            }
            
            this._genericDialogData.negativeButtonAction.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.GenericDialogData genericDialogData)
        {
            this._genericDialogData = genericDialogData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSliderPercent(float value)
        {
            if(this.slider == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowDialog()
        {
            this.title.text = this._genericDialogData.title;
            this.body.text = this._genericDialogData.message;
            this.buttonConfirmText.text = this._genericDialogData.positiveButtonText;
            this.buttonDenyText.text = this._genericDialogData.negativeButtonText;
            UnityEngine.GameObject val_1 = this.confirmButton.gameObject;
            if(this._genericDialogData.positiveButtonText == null)
            {
                goto label_10;
            }
            
            if(val_1 != null)
            {
                goto label_18;
            }
            
            label_19:
            label_18:
            val_1.SetActive(value:  true);
            UnityEngine.GameObject val_2 = this.denyButton.gameObject;
            if(this._genericDialogData.negativeButtonText == null)
            {
                goto label_14;
            }
            
            if(val_2 != null)
            {
                goto label_21;
            }
            
            label_22:
            label_21:
            val_2.SetActive(value:  true);
            this.dialogParent.SetActive(value:  true);
            return;
            label_10:
            var val_3 = (this._genericDialogData.positiveButtonAction != 0) ? 1 : 0;
            if(val_1 != null)
            {
                goto label_18;
            }
            
            goto label_19;
            label_14:
            var val_4 = (this._genericDialogData.negativeButtonAction != 0) ? 1 : 0;
            if(val_2 != null)
            {
                goto label_21;
            }
            
            goto label_22;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HideDialog()
        {
            this.dialogParent.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowSlider()
        {
            this.sliderParent.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HideSlider()
        {
            this.sliderParent.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.confirmButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.AssetDownloadConfirm::PositiveButtonAction()));
            this.confirmButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.AssetDownloadConfirm::PositiveButtonAction()));
            this.denyButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.AssetDownloadConfirm::NegativeButtonAction()));
            this.denyButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.AssetDownloadConfirm::NegativeButtonAction()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this.sliderParent.activeSelf == false)
            {
                    return;
            }
            
            this = this.sliderDisplayText;
            float val_5 = 100f;
            val_5 = V0.16B * val_5;
            this.text = UnityEngine.Mathf.RoundToInt(f:  val_5).ToString()(UnityEngine.Mathf.RoundToInt(f:  val_5).ToString()) + "%"("%");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AssetDownloadConfirm()
        {
        
        }
    
    }

}
