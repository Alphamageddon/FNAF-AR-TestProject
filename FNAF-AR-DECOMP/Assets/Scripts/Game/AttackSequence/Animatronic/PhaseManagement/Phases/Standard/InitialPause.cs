using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InitialPause : BaseInitialPause
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void EnterPhase()
        {
            var val_6;
            var val_10;
            var val_13;
            var val_16;
            bool val_17 = static_value_04281000;
            var val_14 = static_value_04281000 + 176;
            var val_15 = 0;
            val_14 = val_14 + 8;
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            val_6 = 3;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_1 = Systems;
            val_1.ThreatLevelFxController.SetStrength(strength:  0f);
            this.RunSharedEnterPhase();
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_6 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_3 = val_1.ThreatLevelFxController.Model;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_6 = 0;
            val_10 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetAnimationMode(Animatronics.Animatronic3d.Model.Animation.AnimationMode animationMode);
            val_3.SetAnimationMode(animationMode:  0);
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_10 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_6 = val_3.Model;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_10 = 15;
            val_13 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetCloakState(bool cloakEnabled);
            val_6.SetCloakState(cloakEnabled:  true);
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_13 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_9 = val_6.Model;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_13 = 18;
            val_16 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeCloakState(bool eyeCloakEnabled);
            val_9.SetEyeCloakState(eyeCloakEnabled:  true);
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_16 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_12 = val_9.Model;
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_16 = 14;
            val_12.SetEyeGlow(eyeGlowEnabled:  false);
            Game.AttackSequence.Animatronic.TeleportReposition.NormalTeleport(blackboard:  val_12);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)(X19.IsExpired() != true) ? 4 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
            this.RunSharedExitPhase();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InitialPause()
        {
            mem[1152921525475897104] = 3;
            val_1 = new System.Object();
        }
    
    }

}
