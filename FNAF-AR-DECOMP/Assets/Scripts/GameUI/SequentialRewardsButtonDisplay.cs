using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SequentialRewardsButtonDisplay : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string DAY_HOUR_MIN = "dd\\:hh\\:mm";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string HOUR_MIN_SEC = "hh\\:mm\\:ss";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const double FLASH_INTERVAL = 0.5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI timerText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject readyPanel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject timerPanel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject timerTextParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject buttonParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action _showSequentialRewardsDialog;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            val_1.eventExposer.OnSequentialRewardsButtonReady(sequentialRewardsButtonDisplay:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowSequentialRewardsDialog()
        {
            if(this._showSequentialRewardsDialog == null)
            {
                    return;
            }
            
            this._showSequentialRewardsDialog.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowCountdown(System.TimeSpan diff, float flashTime)
        {
            var val_2 = (diff._ticks.Days < 1) ? "hh\\:mm\\:ss" : "dd\\:hh\\:mm";
            this.DisplayTime(timeString:  diff._ticks, shouldFlash:  (flashTime > 0f) ? 1 : 0, flashTime:  flashTime);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateDisplayState(GameUI.SequentialRewardsDisplayHandler.ButtonState buttonState, bool allowShow)
        {
            bool val_6 = allowShow;
            val_6 = ((buttonState != 0) ? 1 : 0) & val_6;
            this.buttonParent.gameObject.SetActive(value:  val_6);
            this.timerPanel.SetActive(value:  (buttonState != 2) ? 1 : 0);
            this.readyPanel.SetActive(value:  (buttonState == 2) ? 1 : 0);
            this.timerTextParent.SetActive(value:  (buttonState != 3) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DisplayTime(string timeString, bool shouldFlash, float flashTime)
        {
            TMPro.TextMeshProUGUI val_4;
            this.timerText.text = timeString;
            if(shouldFlash == false)
            {
                goto label_1;
            }
            
            if((double)flashTime >= 0)
            {
                goto label_2;
            }
            
            UnityEngine.Color val_1 = UnityEngine.Color.red;
            goto label_3;
            label_1:
            val_4 = this.timerText;
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            goto label_4;
            label_2:
            UnityEngine.Color val_3 = UnityEngine.Color.white;
            label_3:
            val_4 = this.timerText;
            label_4:
            if(val_4 == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetTimerActive(bool v)
        {
            v = v;
            this.timerPanel.SetActive(value:  v);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InjectDelegate(System.Action showSequentialRewardsDialog)
        {
            this._showSequentialRewardsDialog = showSequentialRewardsDialog;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SequentialRewardsButtonDisplay()
        {
        
        }
    
    }

}
