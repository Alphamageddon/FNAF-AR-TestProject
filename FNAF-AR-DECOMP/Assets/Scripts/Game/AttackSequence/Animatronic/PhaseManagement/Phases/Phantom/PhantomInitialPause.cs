using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PhantomInitialPause : BaseInitialPause
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void EnterPhase()
        {
            bool val_5 = static_value_04281000;
            var val_2 = static_value_04281000 + 176;
            var val_3 = 0;
            val_2 = val_2 + 8;
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_1 = Systems;
            val_1.ThreatLevelFxController.SetStrength(strength:  1f);
            this.RunSharedEnterPhase();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)(X19.IsExpired() != true) ? 12 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
            this.RunSharedExitPhase();
            bool val_8 = static_value_04281000;
            var val_5 = static_value_04281000 + 176;
            var val_6 = 0;
            val_5 = val_5 + 8;
            val_6 = val_6 + 1;
            val_5 = val_5 + 16;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_1 = AttackProfile;
            var val_9 = 0;
            val_9 = val_9 + 1;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_3 = val_1.TeleportReposition.AttackProfile;
            Game.AttackSequence.Animatronic.TeleportReposition.PhantomTeleport(blackboard:  this, distance:  UnityEngine.Random.Range(min:  val_1.TeleportReposition.DistanceFromCamera.Min, max:  val_3.TeleportReposition.DistanceFromCamera.Max));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PhantomInitialPause()
        {
            mem[1152921525479917968] = 3;
            val_1 = new System.Object();
        }
    
    }

}
