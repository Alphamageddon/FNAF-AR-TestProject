using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Base
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class BaseInitialPause : Phase
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
            var val_17;
            var val_18;
            var val_19;
            Game.AttackSequence.Static.PhaseStaticSettings val_20;
            Game.ItemDefinition.Data.DataDefinitions.BatteryData val_27;
            Game.ItemDefinition.Data.DataDefinitions.RangeData val_32;
            bool val_27 = static_value_04281000;
            var val_24 = static_value_04281000 + 176;
            var val_25 = 0;
            val_24 = val_24 + 8;
            val_25 = val_25 + 1;
            val_24 = val_24 + 16;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_1 = Systems;
            var val_31 = X21;
            if((X21 + 286) == 0)
            {
                goto label_12;
            }
            
            var val_28 = X21 + 176;
            var val_29 = 0;
            val_28 = val_28 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_29 = val_29 + 1;
            val_28 = val_28 + 16;
            if(val_29 < (X21 + 286))
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            var val_30 = val_28;
            val_30 = val_30 + 1;
            val_31 = val_31 + val_30;
            val_17 = val_31 + 296;
            label_12:
            string val_2 = X21.EntityId;
            var val_35 = X22;
            if((X22 + 286) == 0)
            {
                goto label_17;
            }
            
            var val_32 = X22 + 176;
            var val_33 = 0;
            val_32 = val_32 + 8;
            label_16:
            if(((X22 + 176 + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_33 = val_33 + 1;
            val_32 = val_32 + 16;
            if(val_33 < (X22 + 286))
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
            var val_34 = val_32;
            val_34 = val_34 + 5;
            val_35 = val_35 + val_34;
            val_18 = val_35 + 296;
            label_17:
            Game.AttackSequence.Static.StaticConfig val_3 = X22.StaticConfig;
            var val_39 = X23;
            if((X23 + 286) == 0)
            {
                goto label_23;
            }
            
            var val_36 = X23 + 176;
            var val_37 = 0;
            val_36 = val_36 + 8;
            label_22:
            if(((X23 + 176 + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_37 = val_37 + 1;
            val_36 = val_36 + 16;
            if(val_37 < (X23 + 286))
            {
                goto label_22;
            }
            
            goto label_23;
            label_21:
            var val_38 = val_36;
            val_38 = val_38 + 6;
            val_39 = val_39 + val_38;
            val_19 = val_39 + 296;
            label_23:
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_4 = X23.AttackProfile;
            val_20 = val_3.InitialPause;
            val_1.AttackStatic.<Container>k__BackingField.UpdatePhaseStaticSettings(entityId:  val_2, settings:  val_20, shearModifier:  val_4.ShearModifier);
            var val_40 = 0;
            val_40 = val_40 + 1;
            val_20 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_6 = val_1.AttackStatic.<Container>k__BackingField.Model;
            var val_41 = 0;
            val_41 = val_41 + 1;
            val_20 = 8;
            val_6.RaiseAudioEventFromCpu(eventName:  16);
            var val_42 = 0;
            val_42 = val_42 + 1;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_9 = val_6.Systems;
            var val_43 = 0;
            val_43 = val_43 + 1;
            string val_11 = val_2.EntityId;
            var val_44 = 0;
            val_44 = val_44 + 1;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_13 = val_3.InitialPause.AttackProfile;
            var val_45 = 0;
            val_45 = val_45 + 1;
            val_27 = val_13.Battery;
            val_9.Battery.SetBatteryDrain(id:  val_11, drainSettings:  val_27);
            var val_46 = 0;
            val_46 = val_46 + 1;
            val_27 = 3;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_16 = val_9.Battery.Systems;
            var val_47 = 0;
            val_47 = val_47 + 1;
            val_27 = 6;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_18 = val_11.AttackProfile;
            var val_48 = 0;
            val_48 = val_48 + 1;
            val_27 = 4;
            val_16.Mask.SetMaskAvailable(shouldMaskBeAvailable:  (val_18.IsMaskAvailable == true) ? 1 : 0);
            var val_49 = 0;
            val_49 = val_49 + 1;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_22 = val_16.Mask.AttackProfile;
            val_32 = val_22.InitialPause.Seconds;
            if(val_22.InitialPause.Seconds != null)
            {
                goto label_82;
            }
            
            val_32 = val_22.InitialPause.Seconds;
            if(val_32 == null)
            {
                goto label_83;
            }
            
            label_82:
            this.StartTimer(time:  UnityEngine.Random.Range(min:  val_22.InitialPause.Seconds.Min, max:  val_22.InitialPause.Seconds.Max));
            return;
            label_83:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void RunSharedExitPhase()
        {
            var val_8;
            var val_10;
            bool val_17 = static_value_04281000;
            var val_14 = static_value_04281000 + 176;
            var val_15 = 0;
            val_14 = val_14 + 8;
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            val_8 = 3;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_1 = Systems;
            var val_21 = X21;
            if((X21 + 286) == 0)
            {
                goto label_9;
            }
            
            var val_18 = X21 + 176;
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_11:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (X21 + 286))
            {
                goto label_11;
            }
            
            label_9:
            val_8 = 1;
            goto label_12;
            label_10:
            var val_20 = val_18;
            val_20 = val_20 + 1;
            val_21 = val_21 + val_20;
            val_10 = val_21 + 296;
            label_12:
            string val_2 = X21.EntityId;
            val_1.AttackStatic.<Container>k__BackingField.ClearPhaseStaticSettings(entityId:  val_2);
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_8 = 2;
            Animatronics.Animatronic3d.IAnimatronic3D val_4 = val_1.AttackStatic.<Container>k__BackingField.Model;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_8 = 8;
            val_4.RaiseAudioEventFromCpu(eventName:  17);
            var val_24 = 0;
            val_24 = val_24 + 1;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_7 = val_4.Systems;
            var val_25 = 0;
            val_25 = val_25 + 1;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_9 = val_2.AttackProfile;
            val_7.AttackDisruption.StartDisruption(settings:  val_9.Disruption);
            var val_26 = 0;
            val_26 = val_26 + 1;
            Game.AttackSequence.Animatronic.AttackAnimatronicExternalSystems val_11 = val_7.AttackDisruption.Systems;
            var val_27 = 0;
            val_27 = val_27 + 1;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_13 = val_7.AttackDisruption.AttackProfile;
            val_11.AttackSurge._settings = val_13.Surge;
            val_11.AttackSurge._timesActivated = 0;
            val_11.AttackSurge._timesNotActivated = 0;
            val_11.AttackSurge._cancelingAccruedDuration = 0f;
            val_11.AttackSurge.StartCooldownTimer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected BaseInitialPause()
        {
            this.<AttackPhase>k__BackingField = 3;
            val_1 = new System.Object();
        }
    
    }

}
