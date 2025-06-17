using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LongPressButton : Button
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _handled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button.ButtonClickedEvent _onLongPress;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _pressed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _pressedTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LongPressDuration;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button.ButtonClickedEvent onLongPress { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Button.ButtonClickedEvent get_onLongPress()
        {
            return (ButtonClickedEvent)this._onLongPress;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_onLongPress(UnityEngine.UI.Button.ButtonClickedEvent value)
        {
            this._onLongPress = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.OnPointerExit(eventData:  eventData);
            this._pressed = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.OnPointerDown(eventData:  eventData);
            if(eventData.button != 0)
            {
                    return;
            }
            
            this._pressed = true;
            this._handled = false;
            this._pressedTime = UnityEngine.Time.realtimeSinceStartup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this._handled != true)
            {
                    this.OnPointerUp(eventData:  eventData);
            }
            
            this._pressed = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this._handled != false)
            {
                    return;
            }
            
            this.OnPointerClick(eventData:  eventData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(this._pressed == false)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            val_1 = val_1 - this._pressedTime;
            if(val_1 < this.LongPressDuration)
            {
                    return;
            }
            
            this._pressed = false;
            this._handled = true;
            this._onLongPress.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LongPressButton()
        {
            this._onLongPress = new Button.ButtonClickedEvent();
            this.LongPressDuration = 0.9f;
        }
    
    }

}
