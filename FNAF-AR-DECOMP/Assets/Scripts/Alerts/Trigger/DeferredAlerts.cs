using UnityEngine;

namespace Alerts.Trigger
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeferredAlerts
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain _domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<ProtoData.ALERT_DATA.Types.ENTRY> deferredAlerts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Evaluate.DisplayRestrictionChecker _displayRestrictionChecker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Trigger.AlertTriggerer _alertTriggerer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DeferredAlerts()
        {
            this.deferredAlerts = new System.Collections.Generic.List<ENTRY>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeferredAlerts(Alerts.Domain domain)
        {
            this.deferredAlerts = new System.Collections.Generic.List<ENTRY>();
            this._domain = domain;
            ._domain = domain;
            this._displayRestrictionChecker = new Alerts.Evaluate.DisplayRestrictionChecker();
            this._alertTriggerer = new Alerts.Trigger.AlertTriggerer(domain:  domain);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerDeferredAlert(ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            if(alertEntry.UI.UIDefer != 0)
            {
                    return;
            }
            
            this.deferredAlerts.Add(item:  alertEntry);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Update()
        {
            goto label_1;
            label_11:
            ENTRY val_1 = this.deferredAlerts.Item[0];
            this._displayRestrictionChecker._alertEntry = val_1;
            if(this._displayRestrictionChecker.CanDisplay() != false)
            {
                    this._alertTriggerer._alertEntry = val_1;
                this._alertTriggerer._displayRestrictionChecker._alertEntry = val_1;
                this.deferredAlerts.RemoveAt(index:  0);
                this._alertTriggerer.TriggerTheAlert();
            }
            
            0 = (-1) + 1;
            label_1:
            if(0 < this.deferredAlerts.Count)
            {
                goto label_11;
            }
        
        }
    
    }

}
