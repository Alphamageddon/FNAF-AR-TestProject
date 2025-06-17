using UnityEngine;

namespace Alerts.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FiredAlerts
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<string> _firedAlerts;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAlertTriggered(ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            string val_5;
            if(alertEntry != null)
            {
                    val_5 = alertEntry.Logical;
            }
            else
            {
                    val_5 = 0.Logical;
            }
            
            if(alertEntry.Repeatable != 0)
            {
                    return;
            }
            
            bool val_4 = this._firedAlerts.Add(item:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool WasAlertPreviouslyTriggered(string alertId)
        {
            if(this._firedAlerts != null)
            {
                    return this._firedAlerts.Contains(item:  alertId);
            }
            
            return this._firedAlerts.Contains(item:  alertId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(System.Collections.Generic.HashSet<string> newData)
        {
            this._firedAlerts = newData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FiredAlerts()
        {
            this._firedAlerts = new System.Collections.Generic.HashSet<System.String>();
        }
    
    }

}
