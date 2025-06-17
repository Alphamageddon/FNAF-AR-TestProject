using UnityEngine;

namespace Alerts.Evaluate.Preconditions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PreconditionPassiveCheckPhase : Precondition
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PreconditionPassiveCheckPhase()
        {
            val_1 = new System.Object();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PreconditionPassiveCheckPhase(Alerts.Domain domain, ProtoData.ALERT_DATA.Types.ENTRY alertEntry)
        {
            val_1 = new System.Object();
            mem[1152921525119900080] = domain;
            mem[1152921525119900088] = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool MeetsPrecondition()
        {
            var val_11;
            TheGame.GameDisplayChanger val_2 = X20.TheGameDomain.gameDisplayChanger;
            val_11 = 1;
            if((val_2.Preconditions.PreconditionPassiveCheckPhase - 1) > 5)
            {
                    return (bool)(val_2.GetDisplayType() == 2) ? 1 : 0;
            }
            
            var val_10 = 52949048 + ((val_5 - 1)) << 2;
            val_10 = val_10 + 52949048;
            goto (52949048 + ((val_5 - 1)) << 2 + 52949048);
        }
    
    }

}
