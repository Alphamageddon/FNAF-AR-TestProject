using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ActivationState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TimesActivated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TimesNotActivated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float TriggerPercent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ActivationState(Game.ItemDefinition.Data.DataDefinitions.HaywirePhaseSettingsData config)
        {
            this.Config = config;
        }
    
    }

}
