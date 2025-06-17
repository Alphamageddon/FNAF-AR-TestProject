using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SRNumberSpinner : InputField
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _currentValue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _dragStartAmount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private double _dragStep;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DragSensitivity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double MaxValue;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double MinValue;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            this.Awake();
            if(this.contentType == 2)
            {
                    return;
            }
            
            if(this.contentType == 3)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  "[SRNumberSpinner] contentType must be integer or decimal. Defaulting to integer");
            this.contentType = 3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.interactable == false)
            {
                    return;
            }
            
            if(eventData.dragging != false)
            {
                    return;
            }
            
            UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(selected:  this.gameObject, pointer:  eventData);
            this.OnPointerClick(eventData:  eventData);
            if(this != null)
            {
                    if(this.active != false)
            {
                    this.UpdateLabel();
                eventData.Use();
                return;
            }
            
            }
            
            this.OnSelect(eventData:  eventData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_21;
            string val_22;
            float val_23;
            val_22 = eventData;
            if(this.interactable == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_2 = val_22.delta;
            val_23 = System.Math.Abs(val_2.y);
            UnityEngine.Vector2 val_3 = val_22.delta;
            if(val_23 <= System.Math.Abs(val_3.x))
            {
                goto label_6;
            }
            
            UnityEngine.Transform val_5 = this.transform.parent;
            val_21 = 1152921504851574784;
            if(val_5 == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_8 = UnityEngine.EventSystems.ExecuteEvents.GetEventHandler<UnityEngine.EventSystems.IBeginDragHandler>(root:  val_5.gameObject);
            if(val_22 == null)
            {
                goto label_14;
            }
            
            val_22.pointerDrag = val_8;
            goto label_15;
            label_6:
            val_22.Use();
            val_22 = this.text;
            double val_10 = System.Double.Parse(s:  val_22);
            this._currentValue = val_10;
            this._dragStartAmount = val_10;
            this._dragStep = System.Math.Max(val1:  (this.contentType == 2) ? 10 : 1, val2:  this._dragStartAmount * 0.0500000007450581);
            if(this.isFocused == false)
            {
                    return;
            }
            
            this.DeactivateInputField();
            return;
            label_14:
            0.pointerDrag = val_8;
            label_15:
            if(val_22.pointerDrag == 0)
            {
                    return;
            }
            
            bool val_20 = UnityEngine.EventSystems.ExecuteEvents.Execute<UnityEngine.EventSystems.IBeginDragHandler>(target:  val_22.pointerDrag, eventData:  val_22, functor:  UnityEngine.EventSystems.ExecuteEvents.beginDragHandler);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_5;
            float val_10;
            double val_11;
            float val_12;
            double val_13;
            if(this.interactable == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_2 = eventData.delta;
            val_10 = val_2.x;
            double val_10 = System.Math.Abs(this._dragStep);
            val_10 = val_10 * (double)val_10;
            double val_11 = (double)this.DragSensitivity;
            val_11 = val_10 * val_11;
            val_11 = this._currentValue + val_11;
            this._currentValue = val_11;
            double val_3 = System.Math.Round(value:  val_11, digits:  2);
            this._currentValue = val_3;
            if(val_3 > this.MaxValue)
            {
                    val_11 = this.MaxValue;
                mem2[0] = this.MaxValue;
            }
            
            if(val_11 < 0)
            {
                    mem2[0] = this.MinValue;
            }
            
            if(this.contentType != 2)
            {
                goto label_7;
            }
            
            val_10 = mem[this._currentValue];
            val_10 = this._currentValue;
            if(val_10 >= 0f)
            {
                goto label_10;
            }
            
            if(val_10 != (-0.5))
            {
                goto label_11;
            }
            
            val_12 = val_5;
            val_13 = -1;
            goto label_12;
            label_7:
            string val_6 = this._currentValue.ToString();
            goto label_13;
            label_10:
            if(val_10 != 0.5)
            {
                goto label_14;
            }
            
            val_12 = val_5;
            val_13 = 1;
            label_12:
            val_13 = val_12 + val_13;
            val_12 = (((long)val_12 & 1) != 0) ? (val_12) : (val_13);
            goto label_16;
            label_11:
            double val_7 = val_10 + (-0.5);
            goto label_16;
            label_14:
            label_16:
            label_13:
            this.text = (int)val_10 + 0.5.ToString();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.interactable == false)
            {
                    return;
            }
            
            eventData.Use();
            if(this._dragStartAmount == this._currentValue)
            {
                    return;
            }
            
            this.DeactivateInputField();
            this.SendOnSubmit();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRNumberSpinner()
        {
            this.DragSensitivity = 0.01f;
            mem2[0] = ;
        }
    
    }

}
