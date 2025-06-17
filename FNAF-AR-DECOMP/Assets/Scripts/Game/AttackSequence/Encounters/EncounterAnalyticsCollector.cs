using UnityEngine;

namespace Game.AttackSequence.Encounters
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EncounterAnalyticsCollector
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int numShocksFired;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int numFlashlightActivations;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Encounters.RelativeDirection lastChargerRelativeDirection;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EncounterAnalyticsCollector()
        {
        
        }
    
    }

}
