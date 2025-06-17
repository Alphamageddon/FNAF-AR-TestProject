using UnityEngine;

namespace SRDebugger.UI.Controls
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MultiTapButton : Button
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _lastTap;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _tapCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int RequiredTapCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ResetTime;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_1 = UnityEngine.Time.unscaledTime;
            val_1 = val_1 - this._lastTap;
            if(val_1 > this.ResetTime)
            {
                    this._tapCount = 0;
            }
            
            int val_3 = this._tapCount;
            this._lastTap = UnityEngine.Time.unscaledTime;
            val_3 = val_3 + 1;
            this._tapCount = val_3;
            if(val_3 != this.RequiredTapCount)
            {
                    return;
            }
            
            this.OnPointerClick(eventData:  eventData);
            this._tapCount = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MultiTapButton()
        {
            this.RequiredTapCount = 3;
            this.ResetTime = 0.5f;
        }
    
    }

}
