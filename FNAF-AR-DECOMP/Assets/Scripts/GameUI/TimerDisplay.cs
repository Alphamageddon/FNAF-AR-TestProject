using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TimerDisplay : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string DAY_HOUR_MIN = "dd\\:hh\\:mm";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string HOUR_MIN_SEC = "hh\\:mm\\:ss";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _hideWhenZero;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _timeToStartFlashing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _flashInterval;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _hideSelfObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _flashWhenComplete;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _displayText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long _endTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.TimerDisplay.TimerDisplayState _currentState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _previousSecondsDisplayed;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.TimeSpan GetRemainingTime()
        {
            return System.TimeSpan.FromSeconds(value:  (double)this._endTime - TheGame.ServerTime.GetCurrentTime());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateState(System.TimeSpan timeSpan)
        {
            var val_3;
            double val_1 = timeSpan._ticks.TotalSeconds;
            if(val_1 > (double)this._timeToStartFlashing)
            {
                    val_3 = 0;
            }
            else
            {
                    if(val_1 > 0f)
            {
                    val_3 = 3;
            }
            else
            {
                    if(this._hideWhenZero != false)
            {
                    val_3 = 2;
            }
            
            }
            
            }
            
            this._currentState = (this._flashWhenComplete == true) ? 3 : (0 + 1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateText(System.TimeSpan timeSpan)
        {
            TMPro.TextMeshProUGUI val_6;
            var val_7;
            var val_9;
            val_6 = this;
            if(this._displayText == 0)
            {
                    return;
            }
            
            int val_3 = UnityEngine.Mathf.RoundToInt(f:  (float)timeSpan._ticks.TotalSeconds);
            if(val_3 == this._previousSecondsDisplayed)
            {
                    return;
            }
            
            this._previousSecondsDisplayed = val_3;
            if(timeSpan._ticks.TotalDays > 1)
            {
                    val_6 = this._displayText;
                val_7 = "dd\\:hh\\:mm";
            }
            else
            {
                    val_6 = this._displayText;
                if(timeSpan._ticks.TotalSeconds > 0f)
            {
                    val_7 = "hh\\:mm\\:ss";
            }
            else
            {
                    val_9 = null;
                val_9 = null;
            }
            
            }
            
            val_6.text = System.TimeSpan.Zero;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateVisibility()
        {
            TimerDisplayState val_5;
            if(this._hideSelfObject == 0)
            {
                    val_5 = this.gameObject;
                var val_3 = (this._currentState != 2) ? 1 : 0;
            }
            else
            {
                    val_5 = this._currentState;
            }
            
            this._hideSelfObject.SetActive(value:  (val_5 != 2) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateColor()
        {
            TMPro.TextMeshProUGUI val_6;
            if(this._currentState != 3)
            {
                goto label_0;
            }
            
            float val_2 = this._flashInterval + this._flashInterval;
            if(UnityEngine.Time.time >= 0)
            {
                goto label_1;
            }
            
            UnityEngine.Color val_3 = UnityEngine.Color.red;
            goto label_2;
            label_0:
            val_6 = this._displayText;
            UnityEngine.Color val_4 = UnityEngine.Color.white;
            goto label_3;
            label_1:
            UnityEngine.Color val_5 = UnityEngine.Color.white;
            label_2:
            val_6 = this._displayText;
            label_3:
            if(val_6 == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEndTime(long t)
        {
            this._endTime = t;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            if(TheGame.ServerTime.IsInitialized() == false)
            {
                    return;
            }
            
            System.TimeSpan val_2 = this.GetRemainingTime();
            this.UpdateState(timeSpan:  new System.TimeSpan() {_ticks = val_2._ticks});
            this.UpdateText(timeSpan:  new System.TimeSpan() {_ticks = val_2._ticks});
            this.UpdateVisibility();
            this.UpdateColor();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TimerDisplay()
        {
            this._timeToStartFlashing = 3.190147E+38f;
            this._flashInterval = 0.5f;
            this._flashWhenComplete = true;
        }
    
    }

}
