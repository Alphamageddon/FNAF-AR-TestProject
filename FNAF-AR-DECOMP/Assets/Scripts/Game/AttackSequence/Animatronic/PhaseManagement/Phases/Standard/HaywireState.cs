using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HaywireState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState GlobalState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.HaywireData Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Duration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool LookAway;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float LookSwapTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasTriggeredCounter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CumulativeLookTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly SimpleTimer HiddenTimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly SimpleTimer LocateTimer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            this.Duration = 0f;
            this.LookAway = false;
            this.LookSwapTime = -1f;
            this.HasTriggeredCounter = false;
            this.CumulativeLookTime = 0f;
            this.HiddenTimer.Reset();
            this.LocateTimer.Reset();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HaywireState(Game.AttackSequence.Animatronic.PhaseManagement.HaywireGlobalState globalState)
        {
            this.HiddenTimer = new SimpleTimer();
            this.LocateTimer = new SimpleTimer();
            this.GlobalState = globalState;
            this.Config = globalState.Config;
        }
    
    }

}
