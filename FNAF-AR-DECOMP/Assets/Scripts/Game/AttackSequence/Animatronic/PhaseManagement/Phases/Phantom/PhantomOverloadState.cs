using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PhantomOverloadState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.PhantomOverloadData Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasOverloadEffectTriggered;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasRepositionTriggered;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly SimpleTimer OverloadTimer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            this.HasOverloadEffectTriggered = false;
            this.HasRepositionTriggered = false;
            this.OverloadTimer.Reset();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PhantomOverloadState(Game.ItemDefinition.Data.DataDefinitions.PhantomOverloadData config)
        {
            this.OverloadTimer = new SimpleTimer();
            this.Config = config;
        }
    
    }

}
