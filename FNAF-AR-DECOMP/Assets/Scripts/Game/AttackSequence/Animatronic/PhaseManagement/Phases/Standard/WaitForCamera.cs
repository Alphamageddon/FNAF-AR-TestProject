using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WaitForCamera : BaseWaitForCamera
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void EnterPhase()
        {
            var val_2;
            var val_5 = X21;
            if((X21 + 286) == 0)
            {
                goto label_5;
            }
            
            var val_2 = X21 + 176;
            var val_3 = 0;
            val_2 = val_2 + 8;
            label_4:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            if(val_3 < (X21 + 286))
            {
                goto label_4;
            }
            
            goto label_5;
            label_3:
            var val_4 = val_2;
            val_4 = val_4 + 6;
            val_5 = val_5 + val_4;
            val_2 = val_5 + 296;
            label_5:
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_1 = X21.AttackProfile;
            StartTimer(time:  val_1.WaitForCameraTime);
            this.RunSharedEnterPhase();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            var val_4;
            var val_6;
            val_4 = this;
            bool val_7 = static_value_04281000;
            var val_4 = static_value_04281000 + 176;
            var val_5 = 0;
            val_4 = val_4 + 8;
            val_5 = val_5 + 1;
            val_4 = val_4 + 16;
            if(IsInCameraMode == false)
            {
                    return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)(this.IsExpired() != true) ? 9 : 0;
            }
            
            val_6 = 3;
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)(this.IsExpired() != true) ? 9 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WaitForCamera()
        {
            mem[1152921525479437104] = 2;
            val_1 = new System.Object();
        }
    
    }

}
