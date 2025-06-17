using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class HaywireActivator
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool CanActivate(Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState haywireState, float angle)
        {
            var val_2;
            if(haywireState == null)
            {
                    return (bool)val_2;
            }
            
            if(haywireState.ActiveState != null)
            {
                    var val_1 = (haywireState.ActiveState.Config.AllowedHalfAngle >= angle) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CalculateActivation(Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState haywireState, Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase sourcePhase)
        {
            SimpleTimer val_3;
            Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData val_4;
            Game.AttackSequence.Animatronic.PhaseManagement.ActivationState val_5;
            if(haywireState.FirstActivationRequest != false)
            {
                    haywireState.Cooldown.StartTimer(time:  haywireState.Config.Cooldown);
                haywireState.FirstActivationRequest = false;
            }
            
            val_3 = haywireState.Cooldown;
            if(val_3.Started() != false)
            {
                    val_3 = haywireState.Cooldown;
                if(val_3.IsExpired() == false)
            {
                    return;
            }
            
            }
            
            if(sourcePhase == 7)
            {
                goto label_8;
            }
            
            if(sourcePhase == 5)
            {
                goto label_9;
            }
            
            if(sourcePhase != 4)
            {
                    return;
            }
            
            val_4 = haywireState.Config.Circle;
            val_5 = haywireState.CircleState;
            goto label_14;
            label_8:
            val_4 = haywireState.Config.Charge;
            val_5 = haywireState.ChargeState;
            goto label_14;
            label_9:
            val_4 = haywireState.Config.Pause;
            val_5 = haywireState.PauseState;
            label_14:
            if(mem[haywireState.Config.Pause] == 0)
            {
                    return;
            }
            
            if(mem[haywireState.PauseState] == 0)
            {
                    return;
            }
            
            Game.AttackSequence.Animatronic.PhaseManagement.HaywireActivator.CalculateActivation(phaseSettingsData:  mem[haywireState.Config.Pause], activationState:  mem[haywireState.PauseState], haywireState:  haywireState);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void CalculateActivation(Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData phaseSettingsData, Game.AttackSequence.Animatronic.PhaseManagement.ActivationState activationState, Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState haywireState)
        {
            Game.AttackSequence.Animatronic.PhaseManagement.ActivationState val_7;
            int val_8;
            Game.ItemDefinition.Data.DataDefinitions.HaywireData val_9;
            Game.ItemDefinition.Data.DataDefinitions.RandomChanceData val_10;
            int val_13;
            float val_14;
            Game.ItemDefinition.Data.DataDefinitions.RangeData val_15;
            val_7 = activationState;
            if(phaseSettingsData.UseMax == false)
            {
                goto label_1;
            }
            
            if(haywireState != null)
            {
                    val_8 = haywireState.HaywireCount;
            }
            else
            {
                    val_8 = 1;
            }
            
            val_9 = haywireState.Config;
            if(haywireState.Config.MaxCount <= 1f)
            {
                goto label_5;
            }
            
            label_1:
            val_9 = phaseSettingsData.ActivationChance;
            if(val_9 == null)
            {
                goto label_6;
            }
            
            val_10 = val_9;
            var val_1 = (phaseSettingsData.ActivationChance.Modifier < 0f) ? 1 : 0;
            goto label_12;
            label_5:
            if((UnityEngine.Random.Range(min:  0.0001f, max:  1f)) <= 0f)
            {
                goto label_8;
            }
            
            haywireState.ActiveState = 0;
            if(val_7 != null)
            {
                goto label_9;
            }
            
            val_7 = 28;
            val_13 = 0;
            goto label_10;
            label_6:
            val_10 = phaseSettingsData.ActivationChance;
            var val_3 = (phaseSettingsData.ActivationChance.Modifier < 0f) ? 1 : 0;
            if(val_10 == null)
            {
                goto label_11;
            }
            
            val_9 = val_10;
            goto label_12;
            label_8:
            haywireState.IsMultiwireActive = false;
            haywireState.RemainingActivations = 0;
            goto label_13;
            label_11:
            val_9 = phaseSettingsData.ActivationChance;
            if(val_9 == null)
            {
                goto label_27;
            }
            
            label_12:
            if(val_7 == null)
            {
                goto label_15;
            }
            
            if((val_3 & 1) == 0)
            {
                goto label_16;
            }
            
            label_18:
            float val_7 = (float)activationState.TimesActivated;
            val_7 = phaseSettingsData.ActivationChance.Modifier * val_7;
            val_14 = phaseSettingsData.ActivationChance.Chance - val_7;
            goto label_17;
            label_15:
            if((val_3 & 1) != 0)
            {
                goto label_18;
            }
            
            label_16:
            float val_8 = (float)activationState.TimesNotActivated;
            val_8 = phaseSettingsData.ActivationChance.Modifier * val_8;
            val_14 = phaseSettingsData.ActivationChance.Chance + val_8;
            label_17:
            float val_4 = UnityEngine.Random.Range(min:  0.0001f, max:  1f);
            if(haywireState == null)
            {
                goto label_19;
            }
            
            if(val_4 > val_14)
            {
                goto label_20;
            }
            
            haywireState.IsMultiwireActive = false;
            haywireState.RemainingActivations = 0;
            haywireState.ActiveState = val_7;
            goto label_21;
            label_19:
            if(val_4 <= val_14)
            {
                goto label_22;
            }
            
            label_20:
            haywireState.ActiveState = 0;
            label_9:
            val_13 = activationState.TimesNotActivated;
            label_10:
            mem2[0] = val_13 + 1;
            return;
            label_22:
            haywireState.IsMultiwireActive = false;
            haywireState.RemainingActivations = 0;
            label_13:
            haywireState.ActiveState = val_7;
            if(val_7 == null)
            {
                goto label_24;
            }
            
            label_21:
            int val_9 = activationState.TimesActivated;
            val_9 = val_9 + 1;
            activationState.TimesActivated = val_9;
            goto label_25;
            label_24:
            val_9 = 15026800;
            mem[24] = 15026801;
            label_25:
            activationState.TimesNotActivated = 0;
            val_15 = phaseSettingsData.TriggerPercent;
            if(phaseSettingsData.TriggerPercent != null)
            {
                goto label_26;
            }
            
            val_15 = phaseSettingsData.TriggerPercent;
            if(val_15 == null)
            {
                goto label_27;
            }
            
            label_26:
            activationState.TriggerPercent = UnityEngine.Random.Range(min:  phaseSettingsData.TriggerPercent.Min, max:  phaseSettingsData.TriggerPercent.Max);
            if(phaseSettingsData.AddToMax == false)
            {
                    return;
            }
            
            int val_10 = haywireState.HaywireCount;
            val_10 = val_10 + 1;
            haywireState.HaywireCount = val_10;
            return;
            label_27:
        }
    
    }

}
