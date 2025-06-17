using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SRSpinner : Selectable, IDragHandler, IEventSystemHandler, IBeginDragHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _dragDelta;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.UI.SRSpinner.SpinEvent _onSpinDecrement;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRF.UI.SRSpinner.SpinEvent _onSpinIncrement;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DragThreshold;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.SRSpinner.SpinEvent OnSpinIncrement { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.SRSpinner.SpinEvent OnSpinDecrement { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.SRSpinner.SpinEvent get_OnSpinIncrement()
        {
            return (SpinEvent)this._onSpinIncrement;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_OnSpinIncrement(SRF.UI.SRSpinner.SpinEvent value)
        {
            this._onSpinIncrement = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRF.UI.SRSpinner.SpinEvent get_OnSpinDecrement()
        {
            return (SpinEvent)this._onSpinDecrement;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_OnSpinDecrement(SRF.UI.SRSpinner.SpinEvent value)
        {
            this._onSpinDecrement = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this._dragDelta = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.interactable == false)
            {
                    return;
            }
            
            float val_5 = this._dragDelta;
            UnityEngine.Vector2 val_2 = eventData.delta;
            val_5 = val_5 + val_2.x;
            this._dragDelta = val_5;
            if(System.Math.Abs(val_5) <= this.DragThreshold)
            {
                    return;
            }
            
            float val_3 = UnityEngine.Mathf.Sign(f:  this._dragDelta);
            float val_7 = System.Math.Abs(this._dragDelta);
            val_7 = val_7 / this.DragThreshold;
            int val_4 = UnityEngine.Mathf.FloorToInt(f:  val_7);
            if(val_3 > 0f)
            {
                    this.OnIncrement(amount:  val_4);
            }
            else
            {
                    this.OnDecrement(amount:  val_4);
            }
            
            float val_8 = this.DragThreshold;
            val_8 = val_8 * (float)val_4;
            val_8 = val_3 * val_8;
            val_8 = this._dragDelta - val_8;
            this._dragDelta = val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnIncrement(int amount)
        {
            int val_1 = amount;
            if(val_1 < 1)
            {
                    return;
            }
            
            do
            {
                this._onSpinIncrement.Invoke();
                val_1 = val_1 - 1;
            }
            while(val_1 != 0);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDecrement(int amount)
        {
            int val_1 = amount;
            if(val_1 < 1)
            {
                    return;
            }
            
            do
            {
                this._onSpinDecrement.Invoke();
                val_1 = val_1 - 1;
            }
            while(val_1 != 0);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRSpinner()
        {
            this._onSpinDecrement = new SRSpinner.SpinEvent();
            this._onSpinIncrement = new SRSpinner.SpinEvent();
            this.DragThreshold = 20f;
        }
    
    }

}
