using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SRNumberButton : Button, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float ExtraThreshold = 3;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const float Delay = 0.4;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _delayTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _downTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isDown;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double Amount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.SRNumberSpinner TargetField;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.OnPointerDown(eventData:  eventData);
            if(this.interactable == false)
            {
                    return;
            }
            
            this.Apply();
            this._isDown = true;
            float val_2 = UnityEngine.Time.realtimeSinceStartup;
            float val_3 = 0.4f;
            val_3 = val_2 + val_3;
            this._delayTime = val_3;
            this._downTime = val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.OnPointerUp(eventData:  eventData);
            this._isDown = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Update()
        {
            float val_5;
            float val_6;
            if(this._isDown == false)
            {
                    return;
            }
            
            val_5 = this._delayTime;
            if(val_5 > UnityEngine.Time.realtimeSinceStartup)
            {
                    return;
            }
            
            this.Apply();
            float val_2 = UnityEngine.Time.realtimeSinceStartup;
            val_2 = val_2 - this._downTime;
            val_6 = val_2 / 3f;
            int val_3 = UnityEngine.Mathf.RoundToInt(f:  val_6);
            val_5 = 0.2f;
            if(val_3 >= 1)
            {
                    val_6 = 0.5f;
                do
            {
                val_3 = val_3 - 1;
                val_5 = val_5 * val_6;
            }
            while(val_3 != 0);
            
            }
            
            float val_4 = UnityEngine.Time.realtimeSinceStartup;
            val_4 = val_5 + val_4;
            this._delayTime = val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Apply()
        {
            double val_7 = (System.Double.Parse(s:  this.TargetField.text)) + this.Amount;
            if(val_7 > this.TargetField.MaxValue)
            {
                    val_7 = this.TargetField.MaxValue;
            }
            
            this.TargetField.text = this.TargetField.MinValue.ToString();
            this.TargetField.onEndEdit.Invoke(arg0:  this.TargetField.text);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRNumberButton()
        {
            this.Amount = 1;
        }
    
    }

}
