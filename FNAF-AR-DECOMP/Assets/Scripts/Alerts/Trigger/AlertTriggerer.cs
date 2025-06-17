using UnityEngine;

namespace Alerts.Trigger
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AlertTriggerer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain _domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.ALERT_DATA.Types.ENTRY _alertEntry;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Evaluate.DisplayRestrictionChecker _displayRestrictionChecker;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AlertTriggerer()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AlertTriggerer(Alerts.Domain domain)
        {
            this._domain = domain;
            ._domain = domain;
            this._displayRestrictionChecker = new Alerts.Evaluate.DisplayRestrictionChecker();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAlertToUse(ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            this._alertEntry = alertEntry;
            this._displayRestrictionChecker._alertEntry = alertEntry;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TriggerTheAlert()
        {
            if(this.CheckAndHandleDisplayRestriction() != false)
            {
                    return;
            }
            
            this.NotifyAlertTriggered();
            this.DisplayAlert();
            this._domain.<triggerAlertHandler>k__BackingField.TriggerAlert(alertId:  this._alertEntry.Logical, debugValue:  (this._domain._debugAlertEvalSpeedup <= 0f) ? 0.001f : this._domain._debugAlertEvalSpeedup);
            this.TriggerAnyDelayedAlerts();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool CheckAndHandleDisplayRestriction()
        {
            ALERT_DATA.Types.ENTRY val_2;
            var val_3;
            val_2 = this;
            if(this._displayRestrictionChecker.CanDisplay() != false)
            {
                    val_3 = 0;
                return (bool)val_3;
            }
            
            val_2 = this._alertEntry;
            this._domain.<DeferredAlerts>k__BackingField.TriggerDeferredAlert(alertEntry:  val_2);
            val_3 = 1;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void NotifyAlertTriggered()
        {
            this._domain.<NonRepeatableAlerts>k__BackingField.SetAlertTriggered(alertEntry:  this._alertEntry);
            this._domain.<CooldownTimers>k__BackingField.SetAlertTriggered(alertEntry:  this._alertEntry);
            this._domain.<FiredAlerts>k__BackingField.SetAlertTriggered(alertEntry:  this._alertEntry);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DisplayAlert()
        {
            if(this._alertEntry.Channel == 1)
            {
                    TheGame.Domain val_2 = this._domain.TheGameDomain;
                val_2.masterDomain.serverDomain.sendInboxAlertMessageRequester.SendMessage(alertId:  this._alertEntry.Logical);
                return;
            }
            
            if(this._alertEntry.Channel != 0)
            {
                    return;
            }
            
            TheGame.Domain val_5 = this._domain.TheGameDomain;
            GameUI.Domain val_6 = val_5.masterDomain.gameUIDomain;
            val_6.gameUIData.serverGameUIDataModel.SetPopDownDataFromAlertEntry(alertEntry:  this._alertEntry);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TriggerAnyDelayedAlerts()
        {
            TRIGGER val_2 = this._alertEntry.EventBody.Trigger;
            if(val_2 == null)
            {
                    return;
            }
            
            if(val_2.TriggerLogical == null)
            {
                    return;
            }
            
            this._domain.<DelayedAlerts>k__BackingField.TriggerDelayedAlert(alertEntry:  this._domain.<DesignData>k__BackingField.GetAlertEntryForId(id:  val_2.TriggerLogical), delayDeltaTime:  UnityEngine.Random.Range(min:  (float)val_2.TriggerDelayMinSec, max:  (float)val_2.TriggerDelayMaxSec));
        }
    
    }

}
