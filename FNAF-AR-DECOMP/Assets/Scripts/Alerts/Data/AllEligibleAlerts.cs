using UnityEngine;

namespace Alerts.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AllEligibleAlerts
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain _domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isInitialized;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Alerts.Data.AllEligibleAlerts.AlertList _animatronicAlerts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Alerts.Data.AllEligibleAlerts.AlertList _passiveAlerts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Alerts.Data.AllEligibleAlerts.AlertList _derivedAlerts;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AllEligibleAlerts()
        {
            this._animatronicAlerts = new AllEligibleAlerts.AlertList();
            this._passiveAlerts = new AllEligibleAlerts.AlertList();
            this._derivedAlerts = new AllEligibleAlerts.AlertList();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AllEligibleAlerts(Alerts.Domain domain)
        {
            this._animatronicAlerts = new AllEligibleAlerts.AlertList();
            this._passiveAlerts = new AllEligibleAlerts.AlertList();
            this._derivedAlerts = new AllEligibleAlerts.AlertList();
            this._domain = domain;
            domain._masterDomain.MasterDataDomain.GetAccessToData.GetAlertDataAsync(returnAlertDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.ALERT_DATA>(object:  this, method:  System.Void Alerts.Data.AllEligibleAlerts::SetAlertData(ProtoData.ALERT_DATA alertData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetAlertData(ProtoData.ALERT_DATA alertData)
        {
            this.ResetAlertsWithAlertData(alertData:  alertData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ResetAlertsWithAlertData(ProtoData.ALERT_DATA alertData)
        {
            var val_10;
            var val_11;
            System.Collections.Generic.IEnumerator<T> val_2 = alertData.Entries.GetEnumerator();
            label_16:
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            T val_6 = val_2.Current;
            if(val_6.Server != 0f)
            {
                goto label_16;
            }
            
            new Alerts.Evaluate.AlertEvaluator() = new Alerts.Evaluate.AlertEvaluator(domain:  this._domain, alertEntry:  val_6);
            this.StoreAlertBasedOnTrigger(alertEvaluator:  new Alerts.Evaluate.AlertEvaluator());
            goto label_16;
            label_8:
            val_10 = 0;
            val_11 = 78;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_2.Dispose();
            }
            
            this._isInitialized = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StoreAlertBasedOnTrigger(Alerts.Evaluate.AlertEvaluator alertEvaluator)
        {
            TRIGGER val_1 = alertEvaluator._alertEntry.Trigger;
            if(val_1 != 0)
            {
                    if(val_1 != 1)
            {
                    return;
            }
            
                this.StoreAnimatronicAlert(alertEvaluator:  alertEvaluator);
                return;
            }
            
            this.StorePassiveAlert(alertEvaluator:  alertEvaluator);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StoreAnimatronicAlert(Alerts.Evaluate.AlertEvaluator alertEvaluator)
        {
            this._animatronicAlerts.AddAlert(alertEvaluator:  alertEvaluator);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StorePassiveAlert(Alerts.Evaluate.AlertEvaluator alertEvaluator)
        {
            this._passiveAlerts.AddAlert(alertEvaluator:  alertEvaluator);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Evaluate.AlertEvaluator[] GetAnimatronicAlerts()
        {
            if(this._animatronicAlerts != null)
            {
                    return this._animatronicAlerts.GetAlerts();
            }
            
            return this._animatronicAlerts.GetAlerts();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Alerts.Evaluate.AlertEvaluator[] GetPassiveAlerts()
        {
            if(this._passiveAlerts != null)
            {
                    return this._passiveAlerts.GetAlerts();
            }
            
            return this._passiveAlerts.GetAlerts();
        }
    
    }

}
