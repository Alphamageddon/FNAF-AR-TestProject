using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Tutorial
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TutorialWaitForCamera : BaseWaitForCamera
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void EnterPhase()
        {
            bool val_6 = static_value_04281000;
            var val_3 = static_value_04281000 + 176;
            var val_4 = 0;
            val_3 = val_3 + 8;
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_1 = Systems;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_1.Battery.RestoreCharge(restoreAmount:  1f);
            this.RunSharedEnterPhase();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)(this.IsInCameraMode != true) ? 3 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TutorialWaitForCamera()
        {
            mem[1152921525468710800] = 2;
            val_1 = new System.Object();
        }
    
    }

}
