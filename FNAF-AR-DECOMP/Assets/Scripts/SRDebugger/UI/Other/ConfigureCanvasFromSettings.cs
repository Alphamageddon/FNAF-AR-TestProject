using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ConfigureCanvasFromSettings : SRMonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Canvas _canvas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.CanvasScaler _canvasScaler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _originalScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _lastSetScale;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._canvas = this.GetComponent<UnityEngine.Canvas>();
            this._canvasScaler = this.GetComponent<UnityEngine.UI.CanvasScaler>();
            SRDebugger.Internal.SRDebuggerUtil.ConfigureCanvas(canvas:  this._canvas);
            this._originalScale = this._canvasScaler.scaleFactor;
            this.SetScaleFactor();
            this._lastSetScale = this._canvasScaler.scaleFactor;
            if(SRDebug.Instance == null)
            {
                    return;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            SRDebug.Instance.Settings.add_PropertyChanged(value:  new System.ComponentModel.PropertyChangedEventHandler(object:  this, method:  System.Void SRDebugger.UI.Other.ConfigureCanvasFromSettings::SettingsOnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetScaleFactor()
        {
            float val_12;
            var val_13;
            float val_14;
            UnityEngine.ScreenOrientation val_1 = UnityEngine.Screen.orientation;
            if((val_1 - 1) < 2)
            {
                goto label_1;
            }
            
            val_12 = 1f;
            if((val_1 != 3) || (UnityEngine.Screen.width < 1335))
            {
                goto label_6;
            }
            
            val_13 = 0;
            int val_4 = UnityEngine.Screen.width;
            val_14 = 1334f;
            goto label_4;
            label_1:
            if(UnityEngine.Screen.width >= 751)
            {
                goto label_5;
            }
            
            val_12 = 1f;
            goto label_6;
            label_5:
            val_13 = 0;
            val_14 = 750f;
            label_4:
            val_12 = (float)UnityEngine.Screen.width / val_14;
            label_6:
            if(SRDebug.Instance == null)
            {
                    return;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            SRDebugger.Settings val_10 = SRDebug.Instance.Settings;
            float val_11 = this._originalScale * val_10._uiScale;
            val_11 = val_12 * val_11;
            this._canvasScaler.scaleFactor = val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SettingsOnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if(this._canvasScaler.scaleFactor != this._lastSetScale)
            {
                    this._originalScale = this._canvasScaler.scaleFactor;
            }
            
            this.SetScaleFactor();
            this._lastSetScale = this._canvasScaler.scaleFactor;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConfigureCanvasFromSettings()
        {
        
        }
    
    }

}
