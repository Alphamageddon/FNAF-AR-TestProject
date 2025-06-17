using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DragHandle : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.CanvasScaler _canvasScaler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _delta;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _startValue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform.Axis Axis;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Invert;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float MaxSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.LayoutElement TargetLayoutElement;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform TargetRectTransform;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float Mult { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float get_Mult()
        {
            return (float)(this.Invert == true) ? -1f : 1f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.Verify() == false)
            {
                    return;
            }
            
            this._startValue = this.GetCurrentValue();
            this._delta = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_12;
            if(this.Verify() == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_2 = eventData.delta;
            val_12 = ((this.Axis == 0) ? val_2.x : val_2.y) + 0f;
            if(this._canvasScaler != 0)
            {
                    val_12 = val_12 / this._canvasScaler.scaleFactor;
            }
            
            float val_6 = (this.Invert == true) ? -1f : 1f;
            val_6 = val_12 * val_6;
            float val_7 = this._delta + val_6;
            this._delta = val_7;
            this.SetCurrentValue(value:  UnityEngine.Mathf.Clamp(value:  this._startValue + val_7, min:  this.GetMinSize(), max:  (this.MaxSize > 0f) ? this.MaxSize : 3.402823E+38f));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.Verify() == false)
            {
                    return;
            }
            
            this.SetCurrentValue(value:  UnityEngine.Mathf.Max(a:  this._startValue + this._delta, b:  this.GetMinSize()));
            this._delta = 0f;
            this.CommitCurrentValue();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            bool val_1 = this.Verify();
            this._canvasScaler = this.GetComponentInParent<UnityEngine.UI.CanvasScaler>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool Verify()
        {
            var val_3;
            if(this.TargetLayoutElement == 0)
            {
                    if(this.TargetRectTransform == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  "DragHandle: TargetLayoutElement and TargetRectTransform are both null. Disabling behaviour.");
                this.enabled = false;
                val_3 = 0;
                return (bool)val_3;
            }
            
            }
            
            val_3 = 1;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetCurrentValue()
        {
            if(this.TargetLayoutElement == 0)
            {
                goto label_3;
            }
            
            if(this.Axis == 0)
            {
                goto typeof(UnityEngine.UI.LayoutElement).__il2cppRuntimeField_358;
            }
            
            goto typeof(UnityEngine.UI.LayoutElement).__il2cppRuntimeField_358;
            label_3:
            if(this.TargetRectTransform != 0)
            {
                    UnityEngine.Vector2 val_3 = this.TargetRectTransform.sizeDelta;
                if(this.Axis != 0)
            {
                    return (float)val_3.x;
            }
            
                return (float)val_3.x;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetCurrentValue(float value)
        {
            if(this.TargetLayoutElement == 0)
            {
                goto label_3;
            }
            
            if(this.Axis == 0)
            {
                goto typeof(UnityEngine.UI.LayoutElement).__il2cppRuntimeField_368;
            }
            
            goto typeof(UnityEngine.UI.LayoutElement).__il2cppRuntimeField_368;
            label_3:
            if(this.TargetRectTransform != 0)
            {
                    UnityEngine.Vector2 val_3 = this.TargetRectTransform.sizeDelta;
                this.TargetRectTransform.sizeDelta = new UnityEngine.Vector2() {x = (this.Axis == 0) ? value : val_3.x, y = (this.Axis == 0) ? val_3.y : value};
                return;
            }
            
            System.InvalidOperationException val_6 = new System.InvalidOperationException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CommitCurrentValue()
        {
            UnityEngine.UI.LayoutElement val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_6 = this.TargetLayoutElement;
            if(val_6 == 0)
            {
                    return;
            }
            
            val_6 = this.TargetLayoutElement;
            val_7 = val_6.transform;
            if(val_7 != null)
            {
                    if(null == null)
            {
                goto label_6;
            }
            
            }
            
            label_6:
            if(this.Axis != 0)
            {
                    if((val_7 != null) && (null != null))
            {
                    val_8 = 0;
            }
            
                UnityEngine.Vector2 val_4 = val_8.sizeDelta;
                val_9 = val_4.y;
                if(val_6 != null)
            {
                    return;
            }
            
                return;
            }
            
            if((val_7 != null) && (null != null))
            {
                    val_10 = 0;
            }
            
            UnityEngine.Vector2 val_5 = val_10.sizeDelta;
            val_9 = val_5.x;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetMinSize()
        {
            if(this.TargetLayoutElement == 0)
            {
                    return 0f;
            }
            
            UnityEngine.UI.LayoutElement val_3 = 1152921504966377472 + ((this.Axis != 0) ? 528 : 496);
            return this.TargetLayoutElement.Equals(other:  mem[(1152921504966377472 + this.Axis != null ? 528 : 496) + 296 + 8]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float GetMaxSize()
        {
            return (float)(this.MaxSize > 0f) ? this.MaxSize : 3.402823E+38f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DragHandle()
        {
            this.MaxSize = -1f;
        }
    
    }

}
