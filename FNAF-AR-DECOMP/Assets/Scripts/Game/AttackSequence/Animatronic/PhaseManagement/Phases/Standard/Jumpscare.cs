using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Jumpscare : BaseJumpscare
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
            val_10.Model.SetAnimationTrigger(animationTrigger:  6, shouldSet:  true);
            this.RunSharedEnterPhase();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            var val_13;
            var val_14;
            var val_17;
            var val_20;
            var val_23;
            var val_26;
            var val_29;
            val_13 = this;
            bool val_27 = static_value_04281000;
            var val_24 = static_value_04281000 + 176;
            var val_25 = 0;
            val_24 = val_24 + 8;
            val_25 = val_25 + 1;
            val_24 = val_24 + 16;
            val_14 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_1 = Model;
            var val_28 = 0;
            val_28 = val_28 + 1;
            val_14 = 1;
            val_17 = public System.Boolean Animatronics.Animatronic3d.IAnimatronic3D::IsAnimationTagActive(Animatronics.Animatronic3d.Model.Animation.AnimationTag animationTag);
            if((val_1.IsAnimationTagActive(animationTag:  2)) == true)
            {
                    return 0;
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_17 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_5 = val_1.Model;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_17 = 1;
            val_20 = public System.Boolean Animatronics.Animatronic3d.IAnimatronic3D::IsAnimationTagActive(Animatronics.Animatronic3d.Model.Animation.AnimationTag animationTag);
            if((val_5.IsAnimationTagActive(animationTag:  10)) == true)
            {
                    return 0;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_20 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_9 = val_5.Model;
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_20 = 1;
            val_23 = public System.Boolean Animatronics.Animatronic3d.IAnimatronic3D::IsAnimationTagActive(Animatronics.Animatronic3d.Model.Animation.AnimationTag animationTag);
            if((val_9.IsAnimationTagActive(animationTag:  4)) == true)
            {
                    return 0;
            }
            
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_23 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_13 = val_9.Model;
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_23 = 1;
            val_26 = public System.Boolean Animatronics.Animatronic3d.IAnimatronic3D::IsAnimationTagActive(Animatronics.Animatronic3d.Model.Animation.AnimationTag animationTag);
            if((val_13.IsAnimationTagActive(animationTag:  3)) == true)
            {
                    return 0;
            }
            
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_26 = 2;
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_26 = 1;
            val_29 = public System.Boolean Animatronics.Animatronic3d.IAnimatronic3D::IsAnimationTagActive(Animatronics.Animatronic3d.Model.Animation.AnimationTag animationTag);
            if((val_13.Model.IsAnimationTagActive(animationTag:  1)) != true)
            {
                    var val_37 = 0;
                val_37 = val_37 + 1;
                val_29 = 2;
                val_13 = this.Model;
                var val_38 = 0;
                val_38 = val_38 + 1;
                val_29 = 1;
                if((val_13.IsAnimationTagActive(animationTag:  6)) == false)
            {
                    return 0;
            }
            
            }
            
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
            this.RunSharedExitPhase();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Jumpscare()
        {
            mem[1152921525476390864] = 9;
            val_1 = new System.Object();
        }
    
    }

}
