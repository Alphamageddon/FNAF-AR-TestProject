using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NumberChanger : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TextMeshProUGUI numberText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float duration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _startNumber;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _endNumber;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldCountDown;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _startTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _lastNumber;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsComplete>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hasStarted;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsComplete { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsComplete()
        {
            return (bool)this.<IsComplete>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsComplete(bool value)
        {
            this.<IsComplete>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitValues(int startNumber, int endNumber)
        {
            this._startNumber = startNumber;
            this._endNumber = endNumber;
            this._shouldCountDown = (startNumber > endNumber) ? 1 : 0;
            this.SetNumber(newNumber:  startNumber);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ChangeNumber()
        {
            this._hasStarted = true;
            this._startTime = UnityEngine.Time.time;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            int val_7;
            var val_8;
            if(this._hasStarted == false)
            {
                    return;
            }
            
            bool val_7 = this.<IsComplete>k__BackingField;
            val_7 = val_7 + 3;
            var val_8 = ~val_7;
            val_8 = val_8 & 3;
            if(val_8 != 0)
            {
                    return;
            }
            
            val_7 = this._endNumber;
            if((this._startNumber != val_7) && (this.duration > 0f))
            {
                    float val_1 = UnityEngine.Time.time;
                val_1 = val_1 - this._startTime;
                float val_4 = UnityEngine.Mathf.SmoothStep(from:  (float)this._startNumber, to:  (float)this._endNumber, t:  (UnityEngine.Mathf.Max(a:  val_1, b:  0f)) / this.duration);
                if(this._shouldCountDown != false)
            {
                    val_8 = this;
                int val_5 = this.CountDown(value:  val_4);
            }
            else
            {
                    val_8 = this;
            }
            
                val_7 = this.CountUp(value:  val_4);
            }
            
            this.SetNumber(newNumber:  val_7);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int CountUp(float value)
        {
            return UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.FloorToInt(f:  value), min:  this._startNumber, max:  this._endNumber);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int CountDown(float value)
        {
            return UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.CeilToInt(f:  value), min:  this._endNumber, max:  this._startNumber);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetNumber(int newNumber)
        {
            if(this._hasStarted != false)
            {
                    if(this._lastNumber == newNumber)
            {
                    return;
            }
            
            }
            
            this._lastNumber = newNumber;
            this.numberText.text = this._lastNumber.ToString();
            if(this._lastNumber != this._endNumber)
            {
                    return;
            }
            
            this.<IsComplete>k__BackingField = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NumberChanger()
        {
        
        }
    
    }

}
