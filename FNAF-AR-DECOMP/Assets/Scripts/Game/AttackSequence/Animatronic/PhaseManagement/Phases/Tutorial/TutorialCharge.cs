using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Tutorial
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TutorialCharge : BaseCharge
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void EnterPhase()
        {
            var val_5;
            bool val_9 = static_value_04281000;
            var val_6 = static_value_04281000 + 176;
            var val_7 = 0;
            val_6 = val_6 + 8;
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            var val_13 = X21;
            if((X21 + 286) == 0)
            {
                goto label_10;
            }
            
            var val_10 = X21 + 176;
            var val_11 = 0;
            val_10 = val_10 + 8;
            label_9:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            if(val_11 < (X21 + 286))
            {
                goto label_9;
            }
            
            goto label_10;
            label_8:
            var val_12 = val_10;
            val_12 = val_12 + 2;
            val_13 = val_13 + val_12;
            val_5 = val_13 + 296;
            label_10:
            var val_14 = 0;
            val_14 = val_14 + 1;
            var val_15 = 0;
            val_15 = val_15 + 1;
            Model.TeleportInFrontOfCamera(distanceFromCamera:  X21.Model.GetDistanceFromCamera());
            this.EnterPhase();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TutorialCharge()
        {
        
        }
    
    }

}
