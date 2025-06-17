using UnityEngine;

namespace Alerts.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CooldownTimers
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain _domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, long> _cooldownTimers;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private CooldownTimers()
        {
            this._cooldownTimers = new System.Collections.Generic.Dictionary<System.String, System.Int64>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CooldownTimers(Alerts.Domain domain)
        {
            this._cooldownTimers = new System.Collections.Generic.Dictionary<System.String, System.Int64>();
            this._domain = domain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAlertTriggered(ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            float val_5 = alertEntry.CooldownSec;
            float val_4 = (this._domain._debugAlertEvalSpeedup <= 0f) ? 0.001f : this._domain._debugAlertEvalSpeedup;
            val_4 = (float)val_5 / val_4;
            val_5 = val_4 + (float)TheGame.ServerTime.GetCurrentTime();
            if(val_5 <= 0f)
            {
                    return;
            }
            
            this._cooldownTimers.set_Item(key:  alertEntry.Logical, value:  (long)val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CanTriggerAlert(ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            var val_6;
            var val_7;
            val_6 = this;
            string val_1 = alertEntry.Logical;
            if((this._cooldownTimers.ContainsKey(key:  val_1)) != false)
            {
                    val_6 = this._cooldownTimers.Item[val_1];
                var val_5 = (val_6 <= TheGame.ServerTime.GetCurrentTime()) ? 1 : 0;
                return (bool)val_7;
            }
            
            val_7 = 1;
            return (bool)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(System.Collections.Generic.Dictionary<string, long> newData)
        {
            this._cooldownTimers = newData;
        }
    
    }

}
