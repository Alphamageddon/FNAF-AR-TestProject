using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GlimpseState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.GlimpseData Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly SimpleTimer ExitTimer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            this.ExitTimer.Reset();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GlimpseState(Game.ItemDefinition.Data.DataDefinitions.GlimpseData config)
        {
            this.ExitTimer = new SimpleTimer();
            this.Config = config;
        }
    
    }

}
