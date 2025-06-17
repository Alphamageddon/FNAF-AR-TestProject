using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PhantomWalkState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.PhantomWalkData Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasManifested;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float AnimatedSpeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float JumpscareRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float BurnTimeAllowed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float BurnTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasTriggeredCounter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool WasBurning;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            this.HasManifested = false;
            this.HasTriggeredCounter = false;
            this.WasBurning = false;
            this.BurnTimeAllowed = 0f;
            this.BurnTime = 0f;
            this.AnimatedSpeed = 0f;
            this.JumpscareRange = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PhantomWalkState(Game.ItemDefinition.Data.DataDefinitions.PhantomWalkData config)
        {
            this.Config = config;
        }
    
    }

}
