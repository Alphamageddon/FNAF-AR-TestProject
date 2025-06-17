using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Base
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ChargeState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.ChargeData Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly SimpleTimer HaywireTimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumShocksRemaining;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool WillJumpscare;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool StartedDecloak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool StartedCloak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float JumpscareRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float DecloakRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CloakRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float BlockExtraBatteryRange;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool WillDelayJumpscare;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float JumpscareDelaySeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool WillSkipDelayedJumpscare;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool WaitingForJumpscareDelay;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            this.HaywireTimer.Reset();
            this.JumpscareDelaySeconds = 0f;
            this.WillSkipDelayedJumpscare = false;
            this.WaitingForJumpscareDelay = false;
            this.WillJumpscare = false;
            this.StartedDecloak = false;
            this.StartedCloak = false;
            this.NumShocksRemaining = 0;
            this.WillDelayJumpscare = false;
            this.JumpscareRange = 0f;
            this.DecloakRange = 0f;
            this.CloakRange = 0f;
            this.BlockExtraBatteryRange = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ChargeState(Game.ItemDefinition.Data.DataDefinitions.ChargeData config)
        {
            this.HaywireTimer = new SimpleTimer();
            this.Config = config;
        }
    
    }

}
