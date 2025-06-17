using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PhantomPauseState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.PhantomPauseData Config;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PhantomPauseState(Game.ItemDefinition.Data.DataDefinitions.PhantomPauseData config)
        {
            this.Config = config;
        }
    
    }

}
