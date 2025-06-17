using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PhantomShutdown : BaseShutdown
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
            Model.SetPhantomEffectAndAnimationState(state:  8);
            this.RunSharedEnterPhase();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            var val_10;
            var val_11;
            var val_12;
            var val_15;
            val_10 = this;
            if(Started() != false)
            {
                    if(IsExpired() != false)
            {
                    val_11 = 11;
                return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)val_11;
            }
            
            }
            
            bool val_18 = static_value_04281000;
            var val_15 = static_value_04281000 + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            val_12 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_3 = Model;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_12 = 1;
            val_15 = public System.Boolean Animatronics.Animatronic3d.IAnimatronic3D::IsAnimationTagActive(Animatronics.Animatronic3d.Model.Animation.AnimationTag animationTag);
            if((val_3.IsAnimationTagActive(animationTag:  10)) != true)
            {
                    var val_20 = 0;
                val_20 = val_20 + 1;
                val_15 = 2;
                Animatronics.Animatronic3d.IAnimatronic3D val_7 = val_3.Model;
                var val_21 = 0;
                val_21 = val_21 + 1;
                val_15 = 1;
                if((val_7.IsAnimationTagActive(animationTag:  9)) != true)
            {
                    if(val_7.Started() != true)
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                var val_23 = 0;
                val_23 = val_23 + 1;
                this.StartTimer(time:  val_7.Model.GetPhantomShutdownEffectTime());
            }
            
            }
            
            }
            
            val_11 = 0;
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)val_11;
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
        public PhantomShutdown()
        {
            mem[1152921525483095088] = 10;
            val_1 = new System.Object();
        }
    
    }

}
