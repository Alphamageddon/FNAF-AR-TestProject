using UnityEngine;

namespace Systems.Guide.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CameraUIIconAnimator : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image _image;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _cameraAlertToggleTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Sprite _cameraImageAlert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<bool> _isInAttack;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Func<TheGame.GameDisplayData.DisplayType, bool> _isDisplayType;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._image = this.GetComponent<UnityEngine.UI.Image>();
            Master.MasterDomain val_2 = Master.MasterDomain.GetDomain();
            val_2.eventExposer.OnNewCameraUIIconAnimator(cameraUIIconAnimator:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Func<bool> isInAttack, System.Func<TheGame.GameDisplayData.DisplayType, bool> isDisplayType, UnityEngine.Sprite cameraImageAlert, float cameraAlertToggleTime)
        {
            this._cameraAlertToggleTime = cameraAlertToggleTime;
            this._cameraImageAlert = cameraImageAlert;
            this._isInAttack = isInAttack;
            this._isDisplayType = isDisplayType;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            UnityEngine.Sprite val_6;
            var val_7;
            UnityEngine.Sprite val_8;
            val_6 = this;
            if(this._isInAttack.Invoke() != false)
            {
                    if((this._isDisplayType.Invoke(arg:  1)) == false)
            {
                goto label_4;
            }
            
            }
            
            val_7 = 0;
            goto label_5;
            label_4:
            val_7 = (this._isDisplayType.Invoke(arg:  7)) ^ 1;
            label_5:
            if(val_7 == false)
            {
                goto label_8;
            }
            
            float val_5 = this._cameraAlertToggleTime;
            val_5 = val_5 * 0.5f;
            if(UnityEngine.Time.time >= 0)
            {
                goto label_8;
            }
            
            val_6 = this._cameraImageAlert;
            val_8 = val_6;
            goto label_10;
            label_8:
            val_8 = 0;
            label_10:
            this._image.overrideSprite = val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraUIIconAnimator()
        {
        
        }
    
    }

}
