using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Base
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class BasePause : Phase
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
        protected void RunSharedEnterPhase()
        {
            var val_8;
            var val_9;
            var val_10;
            Game.AttackSequence.Static.PhaseStaticSettings val_11;
            bool val_13 = static_value_04281000;
            var val_10 = static_value_04281000 + 176;
            var val_11 = 0;
            val_10 = val_10 + 8;
            val_11 = val_11 + 1;
            val_10 = val_10 + 16;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_1 = Systems;
            var val_17 = X21;
            if((X21 + 286) == 0)
            {
                goto label_12;
            }
            
            var val_14 = X21 + 176;
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (X21 + 286))
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            var val_16 = val_14;
            val_16 = val_16 + 1;
            val_17 = val_17 + val_16;
            val_8 = val_17 + 296;
            label_12:
            var val_21 = X22;
            if((X22 + 286) == 0)
            {
                goto label_17;
            }
            
            var val_18 = X22 + 176;
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_16:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (X22 + 286))
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
            var val_20 = val_18;
            val_20 = val_20 + 5;
            val_21 = val_21 + val_20;
            val_9 = val_21 + 296;
            label_17:
            Game.AttackSequence.Static.StaticConfig val_3 = X22.StaticConfig;
            var val_25 = X23;
            if((X23 + 286) == 0)
            {
                goto label_23;
            }
            
            var val_22 = X23 + 176;
            var val_23 = 0;
            val_22 = val_22 + 8;
            label_22:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_23 = val_23 + 1;
            val_22 = val_22 + 16;
            if(val_23 < (X23 + 286))
            {
                goto label_22;
            }
            
            goto label_23;
            label_21:
            var val_24 = val_22;
            val_24 = val_24 + 6;
            val_25 = val_25 + val_24;
            val_10 = val_25 + 296;
            label_23:
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_4 = X23.AttackProfile;
            val_11 = val_3.Pause;
            val_1.AttackStatic.<Container>k__BackingField.UpdatePhaseStaticSettings(entityId:  X21.EntityId, settings:  val_11, shearModifier:  val_4.ShearModifier);
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_11 = 2;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_11 = 8;
            val_1.AttackStatic.<Container>k__BackingField.Model.RaiseAudioEventFromCpu(eventName:  19);
            var val_28 = 0;
            val_28 = val_28 + 1;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_9 = this.Systems;
            val_9.AttackDisruption.PauseDisruption();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void RunSharedExitPhase()
        {
            var val_5;
            var val_7;
            bool val_11 = static_value_04281000;
            var val_8 = static_value_04281000 + 176;
            var val_9 = 0;
            val_8 = val_8 + 8;
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            val_5 = 3;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_1 = Systems;
            var val_15 = X21;
            if((X21 + 286) == 0)
            {
                goto label_9;
            }
            
            var val_12 = X21 + 176;
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (X21 + 286))
            {
                goto label_11;
            }
            
            label_9:
            val_5 = 1;
            goto label_12;
            label_10:
            var val_14 = val_12;
            val_14 = val_14 + 1;
            val_15 = val_15 + val_14;
            val_7 = val_15 + 296;
            label_12:
            val_1.AttackStatic.<Container>k__BackingField.ClearPhaseStaticSettings(entityId:  X21.EntityId);
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_5 = 2;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_5 = 8;
            val_1.AttackStatic.<Container>k__BackingField.Model.RaiseAudioEventFromCpu(eventName:  20);
            var val_18 = 0;
            val_18 = val_18 + 1;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_7 = this.Systems;
            val_7.AttackDisruption.UnPauseDisruption();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected BasePause()
        {
            this.<AttackPhase>k__BackingField = 5;
            val_1 = new System.Object();
        }
    
    }

}
