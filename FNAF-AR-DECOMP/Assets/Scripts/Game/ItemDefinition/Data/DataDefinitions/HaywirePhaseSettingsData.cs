using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HaywirePhaseSettingsData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData ActivationChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RangeData TriggerPercent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool TeleportToCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float AllowedHalfAngle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool AddToMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool UseMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData CircleChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.RandomChanceData PauseChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool ForceCircleAfterPause;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HaywirePhaseSettingsData(ProtoData.ATTACK_DATA.Types.HAYWIRE.Types.PHASESETTINGS rawSettings)
        {
            CHANCE val_20;
            CHANCE val_21;
            bool val_22;
            if(rawSettings != null)
            {
                    val_20 = rawSettings.Activation;
            }
            else
            {
                    val_20 = 0;
            }
            
            this.ActivationChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_20);
            if(rawSettings != null)
            {
                    this.TriggerPercent = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  rawSettings.TriggerPercent);
                this.TeleportToCamera = rawSettings.TeleportToCamera;
                this.AllowedHalfAngle = (float)rawSettings.AllowedHalfAngle;
                this.AddToMax = rawSettings.AddToMax;
                this.UseMax = rawSettings.UseMax;
                val_21 = rawSettings.GoToCircle;
            }
            else
            {
                    val_21 = 0;
                this.TriggerPercent = new Game.ItemDefinition.Data.DataDefinitions.RangeData(rawSettings:  0);
                this.TeleportToCamera = false;
                this.AllowedHalfAngle = 0f;
                this.AddToMax = false;
                this.UseMax = false;
            }
            
            this.CircleChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_21);
            if(rawSettings != null)
            {
                    val_21 = rawSettings.GoToPause;
                this.PauseChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  val_21);
                val_22 = rawSettings.ForceCircleAfterPause;
            }
            else
            {
                    val_22 = false;
                this.PauseChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(rawSettings:  0);
            }
            
            this.ForceCircleAfterPause = val_22;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HaywirePhaseSettingsData(Game.ItemDefinition.Data.DataDefinitions.RandomChanceData activationChance, Game.ItemDefinition.Data.DataDefinitions.RangeData triggerPercent, bool teleportToCamera, float allowedHalfAngle, bool addToMax, bool useMax, Game.ItemDefinition.Data.DataDefinitions.RandomChanceData circleChance, Game.ItemDefinition.Data.DataDefinitions.RandomChanceData pauseChance, bool forceCircleAfterPause)
        {
            val_1 = new System.Object();
            this.ActivationChance = activationChance;
            this.TriggerPercent = val_1;
            this.AllowedHalfAngle = allowedHalfAngle;
            this.CircleChance = circleChance;
            this.PauseChance = pauseChance;
            this.TeleportToCamera = teleportToCamera;
            this.AddToMax = addToMax;
            this.UseMax = useMax;
            this.ForceCircleAfterPause = forceCircleAfterPause;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HaywirePhaseSettingsData(Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData phaseSettings, string chanceKey, string modifierKey, System.Collections.Generic.Dictionary<string, float> mods)
        {
            val_1 = new System.Object();
            if(phaseSettings != null)
            {
                    this.ActivationChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(chance:  phaseSettings.ActivationChance, chanceKey:  string val_1 = chanceKey, modifierKey:  modifierKey, mods:  mods);
                this.TriggerPercent = phaseSettings.TriggerPercent;
                this.TeleportToCamera = phaseSettings.TeleportToCamera;
                this.AllowedHalfAngle = phaseSettings.AllowedHalfAngle;
                this.AddToMax = phaseSettings.AddToMax;
                this.UseMax = phaseSettings.UseMax;
                this.CircleChance = phaseSettings.CircleChance;
                this.PauseChance = phaseSettings.PauseChance;
            }
            else
            {
                    this.ActivationChance = new Game.ItemDefinition.Data.DataDefinitions.RandomChanceData(chance:  11993091, chanceKey:  val_1, modifierKey:  modifierKey, mods:  mods);
                this.TriggerPercent = 15026800;
                this.TeleportToCamera = false;
                this.AllowedHalfAngle = 0f;
                this.AddToMax = false;
                this.UseMax = false;
                this.CircleChance = 0;
                this.PauseChance = 4194311;
            }
            
            this.ForceCircleAfterPause = phaseSettings.ForceCircleAfterPause;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return System.String.Format(format:  "{{\"ActivationChance\":{0}}}", arg0:  this.ActivationChance);
        }
    
    }

}
