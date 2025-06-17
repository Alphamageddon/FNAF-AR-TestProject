using UnityEngine;

namespace Alerts.Evaluate.Preconditions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PreconditionOtherAlerts : Precondition
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PreconditionOtherAlerts()
        {
            val_1 = new System.Object();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PreconditionOtherAlerts(Alerts.Domain domain, ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            val_1 = new System.Object();
            mem[1152921525119110704] = domain;
            mem[1152921525119110712] = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool MeetsPrecondition()
        {
            if(this.MeetsReqHasCompleted() == false)
            {
                    return false;
            }
            
            return this.MeetsReqHasNotCompleted();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool MeetsReqHasCompleted()
        {
            PRECONDITIONS val_1 = X20.Preconditions;
            if(val_1.PreconditionRequirements == null)
            {
                    return true;
            }
            
            PRECONDITIONREQUIREMENTS val_4 = val_1.Preconditions.PreconditionRequirements;
            if(val_4.PreconditionLogicalCompletions == null)
            {
                    return true;
            }
            
            PRECONDITIONLOGICALCOMPLETIONS val_8 = val_4.Preconditions.PreconditionRequirements.PreconditionLogicalCompletions;
            if(val_8.PreconditionReqHasCompleted == null)
            {
                    return true;
            }
            
            PRECONDITIONLOGICALCOMPLETIONS val_12 = val_8.Preconditions.PreconditionRequirements.PreconditionLogicalCompletions;
            if(val_12 != null)
            {
                    return val_12.WasAlertPreviouslyTriggered(alertId:  val_12.PreconditionReqHasCompleted);
            }
            
            return val_12.WasAlertPreviouslyTriggered(alertId:  val_12.PreconditionReqHasCompleted);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool MeetsReqHasNotCompleted()
        {
            string val_16;
            var val_17;
            val_16 = this;
            PRECONDITIONS val_1 = X20.Preconditions;
            if(val_1.PreconditionRequirements != null)
            {
                    PRECONDITIONREQUIREMENTS val_4 = val_1.Preconditions.PreconditionRequirements;
                if(val_4.PreconditionLogicalCompletions != null)
            {
                    PRECONDITIONLOGICALCOMPLETIONS val_8 = val_4.Preconditions.PreconditionRequirements.PreconditionLogicalCompletions;
                if(val_8.PreconditionReqHasNotCompleted != null)
            {
                    PRECONDITIONLOGICALCOMPLETIONS val_12 = val_8.Preconditions.PreconditionRequirements.PreconditionLogicalCompletions;
                val_16 = val_12.PreconditionReqHasNotCompleted;
                val_17 = (val_12.WasAlertPreviouslyTriggered(alertId:  val_16)) ^ 1;
                return (bool)val_17 & 1;
            }
            
            }
            
            }
            
            val_17 = 1;
            return (bool)val_17 & 1;
        }
    
    }

}
