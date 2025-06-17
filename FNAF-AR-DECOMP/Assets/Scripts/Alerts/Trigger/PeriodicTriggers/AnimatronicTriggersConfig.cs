using UnityEngine;

namespace Alerts.Trigger.PeriodicTriggers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicTriggersConfig : PeriodicTriggersConfig
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Alerts.Domain _domain;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool TriggersInitialized { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override System.Func<Alerts.Evaluate.AlertEvaluator[]> AllAlerts { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float AlertPeriodSec { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float AlertCheckChance { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float AlertCooldownSec { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool get_TriggersInitialized()
        {
            var val_2;
            if((this._domain.<DesignData>k__BackingField._configDataLoaded) != false)
            {
                    var val_1 = ((this._domain.<DesignData>k__BackingField._alertDataLoaded) == true) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override System.Func<Alerts.Evaluate.AlertEvaluator[]> get_AllAlerts()
        {
            return (System.Func<Alerts.Evaluate.AlertEvaluator[]>)new System.Func<Alerts.Evaluate.AlertEvaluator[]>(object:  this._domain.<AllEligibleAlerts>k__BackingField, method:  public Alerts.Evaluate.AlertEvaluator[] Alerts.Data.AllEligibleAlerts::GetAnimatronicAlerts());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float get_AlertPeriodSec()
        {
            return (float)(float)this._domain.<DesignData>k__BackingField.<ConfigDataEntry>k__BackingField.AnimatronicAlerts.AnimatronicAlertPeriodSec;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float get_AlertCheckChance()
        {
            return (float)(float)this._domain.<DesignData>k__BackingField.<ConfigDataEntry>k__BackingField.AnimatronicAlerts.AnimatronicAlertCheckChance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override float get_AlertCooldownSec()
        {
            return (float)(float)this._domain.<DesignData>k__BackingField.<ConfigDataEntry>k__BackingField.AnimatronicAlerts.AnimatronicAlertCooldownSec;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicTriggersConfig()
        {
            val_1 = new System.Object();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicTriggersConfig(Alerts.Domain domain)
        {
            val_1 = new System.Object();
            this._domain = domain;
        }
    
    }

}
