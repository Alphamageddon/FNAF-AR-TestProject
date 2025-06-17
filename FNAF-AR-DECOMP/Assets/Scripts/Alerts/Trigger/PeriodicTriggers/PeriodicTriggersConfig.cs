using UnityEngine;

namespace Alerts.Trigger.PeriodicTriggers
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PeriodicTriggersConfig
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool TriggersInitialized { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual System.Func<Alerts.Evaluate.AlertEvaluator[]> AllAlerts { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual float AlertPeriodSec { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual float AlertCheckChance { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual float AlertCooldownSec { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual bool get_TriggersInitialized()
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual System.Func<Alerts.Evaluate.AlertEvaluator[]> get_AllAlerts()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual float get_AlertPeriodSec()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual float get_AlertCheckChance()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public virtual float get_AlertCooldownSec()
        {
            35920 = new System.NotImplementedException();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PeriodicTriggersConfig()
        {
        
        }
    
    }

}
