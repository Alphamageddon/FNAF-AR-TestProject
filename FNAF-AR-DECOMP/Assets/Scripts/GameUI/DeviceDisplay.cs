using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeviceDisplay : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image Icon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject SubIconContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image SubIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI TimerText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button Button;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject TimerContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.TheGame.Data.DeviceEntry _deviceEntry;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<Game.TheGame.Data.DeviceEntry> _callback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DeviceDisplay.TimerType _timerType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<GameUI.DeviceDisplay> Expired;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.DeviceEntry DeviceEntry { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.DeviceEntry get_DeviceEntry()
        {
            return (Game.TheGame.Data.DeviceEntry)this._deviceEntry;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitializeDevice(Game.TheGame.Data.DeviceEntry entry, UnityEngine.Sprite icon, UnityEngine.Sprite subIcon, System.Action<Game.TheGame.Data.DeviceEntry> callback)
        {
            this.Icon.sprite = icon;
            this.SubIcon.sprite = subIcon;
            this._callback = callback;
            UnityEngine.Object val_6 = 0;
            val_6 = UnityEngine.Object.op_Inequality(x:  subIcon, y:  val_6);
            this.SubIconContainer.SetActive(value:  val_6);
            this._deviceEntry = entry;
            this._timerType = this.DetermineTimerType();
            this.Button.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.DeviceDisplay::OnClick()));
            this.TimerContainer.SetActive(value:  (this._timerType != 0) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DeviceDisplay.TimerType DetermineTimerType()
        {
            if((System.String.op_Equality(a:  this._deviceEntry.deviceType, b:  "Lure")) == true)
            {
                    return 0;
            }
            
            if((System.String.op_Equality(a:  this._deviceEntry.deviceType, b:  "HomeInvasion")) != false)
            {
                    return 0;
            }
            
            if((System.String.op_Equality(a:  this._deviceEntry.deviceType, b:  "EMFMeter")) != false)
            {
                    return 0;
            }
            
            var val_5 = ((System.String.op_Equality(a:  this._deviceEntry.deviceType, b:  "SalvageScanner")) != true) ? (1 + 1) : 1;
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            this.ExpireIfNecessary();
            if(this._timerType != 2)
            {
                    if(this._timerType != 1)
            {
                    return;
            }
            
                GameUI.DeviceDisplay.DisplayTime(deviceEntry:  this._deviceEntry, timer:  this.TimerText);
                return;
            }
            
            GameUI.DeviceDisplay.DisplayCharges(deviceEntry:  this._deviceEntry, timer:  this.TimerText);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ExpireIfNecessary()
        {
            if(this._timerType != 2)
            {
                goto label_1;
            }
            
            if(this._deviceEntry.deviceState.scalar <= 0f)
            {
                goto label_4;
            }
            
            if(this._timerType == 2)
            {
                    return;
            }
            
            label_1:
            double val_2 = 1000;
            val_2 = (double)TheGame.ServerTime.GetCurrentTime() * val_2;
            if(this._deviceEntry.deviceState.expirationTimeStamp >= 0)
            {
                    return;
            }
            
            label_4:
            if(this.Expired == null)
            {
                    return;
            }
            
            this.Expired.Invoke(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void DisplayTime(Game.TheGame.Data.DeviceEntry deviceEntry, TMPro.TextMeshProUGUI timer)
        {
            var val_5;
            double val_5 = 1000;
            val_5 = (double)TheGame.ServerTime.GetCurrentTime() * val_5;
            System.TimeSpan val_3 = System.TimeSpan.FromMilliseconds(value:  deviceEntry.deviceState.expirationTimeStamp - val_5);
            if(val_3._ticks.Days >= 1)
            {
                    val_5 = "dd\\:hh\\:mm";
            }
            else
            {
                    val_5 = "hh\\:mm\\:ss";
            }
            
            timer.text = val_3._ticks;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void DisplayCharges(Game.TheGame.Data.DeviceEntry deviceEntry, TMPro.TextMeshProUGUI timer)
        {
            timer.text = deviceEntry.deviceState.scalar.ToString();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnClick()
        {
            if(this._callback == null)
            {
                    return;
            }
            
            this._callback.Invoke(obj:  this._deviceEntry);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceDisplay()
        {
        
        }
    
    }

}
