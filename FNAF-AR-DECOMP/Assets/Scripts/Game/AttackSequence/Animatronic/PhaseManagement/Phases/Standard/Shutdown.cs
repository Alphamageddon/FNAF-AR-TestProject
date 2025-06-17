using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Shutdown : BaseShutdown
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void EnterPhase()
        {
            var val_11;
            var val_14;
            var val_17;
            var val_20;
            bool val_18 = static_value_04281000;
            var val_15 = static_value_04281000 + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            val_11 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_1 = Model;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_11 = 15;
            val_14 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetCloakState(bool cloakEnabled);
            val_1.SetCloakState(cloakEnabled:  false);
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_14 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_4 = val_1.Model;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_14 = 18;
            val_17 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeCloakState(bool eyeCloakEnabled);
            val_4.SetEyeCloakState(eyeCloakEnabled:  false);
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_17 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_7 = val_4.Model;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_17 = 13;
            val_20 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::SetEyeColorMode(Animatronics.Animatronic3d.Model.Effects.EyeColorMode mode);
            val_7.SetEyeColorMode(mode:  1);
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_20 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_10 = val_7.Model;
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_20 = 14;
            val_10.SetEyeGlow(eyeGlowEnabled:  true);
            var val_26 = 0;
            val_26 = val_26 + 1;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_10.Model.SetAnimationTrigger(animationTrigger:  9, shouldSet:  true);
            this.RunSharedEnterPhase();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            var val_5;
            var val_6;
            var val_9;
            var val_12;
            val_5 = this;
            bool val_11 = static_value_04281000;
            var val_8 = static_value_04281000 + 176;
            var val_9 = 0;
            val_8 = val_8 + 8;
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            val_6 = 2;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_6 = 1;
            val_9 = public System.Boolean Animatronics.Animatronic3d.IAnimatronic3D::IsAnimationTagActive(Animatronics.Animatronic3d.Model.Animation.AnimationTag animationTag);
            if((Model.IsAnimationTagActive(animationTag:  1)) == true)
            {
                goto label_11;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_9 = 2;
            val_5 = this.Model;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_9 = 1;
            if((val_5.IsAnimationTagActive(animationTag:  9)) == false)
            {
                goto label_22;
            }
            
            label_11:
            val_12 = 0;
            return 11;
            label_22:
            val_12 = 11;
            return 11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
            this.RunSharedExitPhase();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Shutdown()
        {
            mem[1152921525478984944] = 10;
            val_1 = new System.Object();
        }
    
    }

}
