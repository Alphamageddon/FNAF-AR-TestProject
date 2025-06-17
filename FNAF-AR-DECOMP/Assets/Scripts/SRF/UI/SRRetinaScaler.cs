using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SRRetinaScaler : SRMonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _retinaScale;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _thresholdDpi;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _disablePixelPerfect;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ThresholdDpi { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float RetinaScale { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_ThresholdDpi()
        {
            return (int)this._thresholdDpi;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float get_RetinaScale()
        {
            return (float)this._retinaScale;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            float val_7;
            float val_8;
            float val_1 = UnityEngine.Screen.dpi;
            if(val_1 <= 0f)
            {
                    return;
            }
            
            if(val_1 <= (float)this._thresholdDpi)
            {
                    return;
            }
            
            UnityEngine.UI.CanvasScaler val_2 = this.GetComponent<UnityEngine.UI.CanvasScaler>();
            if(val_2 != null)
            {
                    val_2.uiScaleMode = 0;
                val_7 = this._retinaScale;
                val_8 = val_2.scaleFactor;
            }
            else
            {
                    val_2.uiScaleMode = 0;
                float val_4 = val_2.scaleFactor;
                val_7 = this._retinaScale;
                val_8 = val_4;
            }
            
            val_4 = val_7 * val_8;
            val_2.scaleFactor = val_4;
            if(this._disablePixelPerfect == false)
            {
                    return;
            }
            
            this.GetComponent<UnityEngine.Canvas>().pixelPerfect = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRRetinaScaler()
        {
            this._retinaScale = 2f;
            this._thresholdDpi = 250;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
