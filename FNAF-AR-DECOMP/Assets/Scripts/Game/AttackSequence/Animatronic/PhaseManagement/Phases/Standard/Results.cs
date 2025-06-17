using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Results : Phase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase <AttackPhase>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase AttackPhase { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase get_AttackPhase()
        {
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)this.<AttackPhase>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void EnterPhase()
        {
            var val_8;
            bool val_14 = static_value_04281000;
            var val_11 = static_value_04281000 + 176;
            var val_12 = 0;
            val_11 = val_11 + 8;
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(Systems == null)
            {
                goto label_6;
            }
            
            var val_18 = X21;
            if((X21 + 286) == 0)
            {
                goto label_12;
            }
            
            var val_15 = X21 + 176;
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < (X21 + 286))
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            var val_17 = val_15;
            val_17 = val_17 + 1;
            val_18 = val_18 + val_17;
            val_8 = val_18 + 296;
            label_12:
            val_1.AttackStatic.<Container>k__BackingField.ClearPhaseStaticSettings(entityId:  X21.EntityId);
            label_6:
            var val_19 = 0;
            val_19 = val_19 + 1;
            if((val_1.AttackStatic.<Container>k__BackingField.Systems) != null)
            {
                    var val_20 = 0;
                val_20 = val_20 + 1;
                val_4.Flashlight.SetFlashlightState(setOn:  false, shouldPlayAudio:  false);
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            Animatronics.Animatronic3d.IAnimatronic3D val_7 = val_4.Flashlight.Model;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_7.StopMoving();
            val_7.StartTimer(time:  0.25f);
            var val_23 = 0;
            val_23 = val_23 + 1;
            if(this.Systems == null)
            {
                    return;
            }
            
            val_10.Encounter.ReadyForUi();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)X19.IsExpired();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Results()
        {
            this.<AttackPhase>k__BackingField = 11;
            val_1 = new System.Object();
        }
    
    }

}
