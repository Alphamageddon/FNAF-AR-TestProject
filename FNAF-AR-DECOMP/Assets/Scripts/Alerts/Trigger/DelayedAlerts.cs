using UnityEngine;

namespace Alerts.Trigger
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DelayedAlerts
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain _domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Alerts.Trigger.DelayedAlerts.AlertTriggerInfo> delayedAlerts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Trigger.AlertTriggerer _alertTriggerer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DelayedAlerts()
        {
            this.delayedAlerts = new System.Collections.Generic.List<AlertTriggerInfo>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DelayedAlerts(Alerts.Domain domain)
        {
            this.delayedAlerts = new System.Collections.Generic.List<AlertTriggerInfo>();
            this._domain = domain;
            this._alertTriggerer = new Alerts.Trigger.AlertTriggerer(domain:  domain);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerDelayedAlert(ProtoData.ALERT_DATA.Types.ENTRY alertEntry, float delayDeltaTime)
        {
            float val_4;
            DelayedAlerts.AlertTriggerInfo val_1 = new DelayedAlerts.AlertTriggerInfo();
            if(val_1 != null)
            {
                    .alertEntry = alertEntry;
                val_4 = UnityEngine.Time.time;
            }
            else
            {
                    mem[16] = alertEntry;
                float val_3 = UnityEngine.Time.time;
                val_4 = val_3;
            }
            
            val_3 = val_4 + delayDeltaTime;
            .triggerTime = val_3;
            this.delayedAlerts.Add(item:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            goto label_1;
            label_10:
            AlertTriggerInfo val_1 = this.delayedAlerts.Item[0];
            if(val_1.triggerTime <= UnityEngine.Time.time)
            {
                    this._alertTriggerer._alertEntry = val_1.alertEntry;
                this._alertTriggerer._displayRestrictionChecker._alertEntry = val_1.alertEntry;
                this.delayedAlerts.RemoveAt(index:  0);
                this._alertTriggerer.TriggerTheAlert();
            }
            
            0 = (-1) + 1;
            label_1:
            if(0 < this.delayedAlerts.Count)
            {
                goto label_10;
            }
        
        }
    
    }

}
