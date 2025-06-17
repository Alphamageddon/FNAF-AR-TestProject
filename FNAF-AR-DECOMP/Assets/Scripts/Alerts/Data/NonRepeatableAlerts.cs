using UnityEngine;

namespace Alerts.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class NonRepeatableAlerts
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.HashSet<string> _nonRepeatableAlerts;
        
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
            
            bool val_4 = this._nonRepeatableAlerts.Add(item:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CanTriggerAlert(ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            string val_5;
            var val_6;
            val_5 = this;
            if(alertEntry.Repeatable == 1)
            {
                    val_6 = 1;
            }
            else
            {
                    val_5 = alertEntry.Logical;
                bool val_3 = this._nonRepeatableAlerts.Contains(item:  val_5);
                val_6 = val_3 ^ 1;
            }
            
            val_3 = val_6;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update(System.Collections.Generic.HashSet<string> newData)
        {
            this._nonRepeatableAlerts = newData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public NonRepeatableAlerts()
        {
            this._nonRepeatableAlerts = new System.Collections.Generic.HashSet<System.String>();
        }
    
    }

}
