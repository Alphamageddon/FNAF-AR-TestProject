using UnityEngine;

namespace Alerts.Evaluate.Preconditions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PreconditionCanTriggerAlert : Precondition
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PreconditionCanTriggerAlert()
        {
            val_1 = new System.Object();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PreconditionCanTriggerAlert(Alerts.Domain domain, ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            val_1 = new System.Object();
            mem[1152921525117673904] = domain;
            mem[1152921525117673912] = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool MeetsPrecondition()
        {
            if((X20 + 56.CanTriggerAlert(alertEntry:  X21)) == false)
            {
                    return false;
            }
            
            if((X20 + 56 + 64) != 0)
            {
                    return X20 + 56 + 64.CanTriggerAlert(alertEntry:  this);
            }
            
            return X20 + 56 + 64.CanTriggerAlert(alertEntry:  this);
        }
    
    }

}
