using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Base
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class BaseShutdown : Phase
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
            var val_11;
            var val_15;
            var val_16;
            var val_18;
            var val_20;
            var val_22;
            bool val_19 = static_value_04281000;
            var val_16 = static_value_04281000 + 176;
            var val_17 = 0;
            val_16 = val_16 + 8;
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            val_11 = 3;
            if(Systems != null)
            {
                    val_1.AttackDisruption.StopDisruption();
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_11 = 3;
            if(val_1.AttackDisruption.Systems != null)
            {
                    val_3.AttackSurge.StopSurgeEffect();
                val_3.AttackSurge._settings = 0;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_11 = 3;
            if(val_3.AttackSurge.Systems == null)
            {
                goto label_20;
            }
            
            var val_25 = X21;
            if((X21 + 286) == 0)
            {
                goto label_22;
            }
            
            var val_22 = X21 + 176;
            var val_23 = 0;
            val_22 = val_22 + 8;
            label_24:
            if(((X21 + 176 + 8) + -8) == null)
            {
                goto label_23;
            }
            
            val_23 = val_23 + 1;
            val_22 = val_22 + 16;
            if(val_23 < (X21 + 286))
            {
                goto label_24;
            }
            
            label_22:
            val_15 = 1;
            goto label_25;
            label_23:
            var val_24 = val_22;
            val_24 = val_24 + 1;
            val_25 = val_25 + val_24;
            val_16 = val_25 + 296;
            label_25:
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_15 = 6;
            val_18 = public System.Void Game.CameraEquipment.Battery.IBattery::RemoveBatteryDrain(string id);
            val_5.Battery.RemoveBatteryDrain(id:  X21.EntityId);
            label_20:
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_18 = 3;
            if(val_5.Battery.Systems != null)
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_20 = 4;
                val_22 = public System.Void Game.CameraEquipment.Battery.IBattery::SetExtraBatteryBlocker(bool isBlocked);
                val_9.Battery.SetExtraBatteryBlocker(isBlocked:  true);
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_22 = 3;
            if(val_9.Battery.Systems != null)
            {
                    val_12.Encounter.EncounterWon();
            }
            
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_22 = 2;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_22 = 8;
            this.Model.RaiseAudioEventFromCpu(eventName:  4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void RunSharedExitPhase()
        {
            var val_3;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_3 = 3;
            if(this.Systems == null)
            {
                    return;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_3 = 4;
            val_2.Mask.SetMaskAvailable(shouldMaskBeAvailable:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected BaseShutdown()
        {
            this.<AttackPhase>k__BackingField = 10;
            val_1 = new System.Object();
        }
    
    }

}
