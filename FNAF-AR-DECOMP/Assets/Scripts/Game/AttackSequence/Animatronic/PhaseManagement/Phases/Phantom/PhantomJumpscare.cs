using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PhantomJumpscare : BaseJumpscare
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void EnterPhase()
        {
            var val_3;
            bool val_6 = static_value_04281000;
            var val_3 = static_value_04281000 + 176;
            var val_4 = 0;
            val_3 = val_3 + 8;
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            val_3 = 2;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_3 = 27;
            Model.SetPhantomEffectAndAnimationState(state:  9);
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
            if((Model.IsAnimationTagActive(animationTag:  10)) == true)
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
            if((val_5.IsAnimationTagActive(animationTag:  6)) == false)
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
            var val_3 = 0;
            val_3 = val_3 + 1;
            if(this.Systems == null)
            {
                    return;
            }
            
            val_2.ThreatLevelFxController.SetStrength(strength:  0f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PhantomJumpscare()
        {
            mem[1152921525480386672] = 9;
            val_1 = new System.Object();
        }
    
    }

}
