using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CircleState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.CircleData Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly SimpleTimer SpeedChangeTimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly SimpleTimer HaywireTimer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UseMinSpeed;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            this.SpeedChangeTimer.Reset();
            this.HaywireTimer.Reset();
            this.UseMinSpeed = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CircleState(Game.ItemDefinition.Data.DataDefinitions.CircleData config)
        {
            this.SpeedChangeTimer = new SimpleTimer();
            this.HaywireTimer = new SimpleTimer();
            this.Config = config;
        }
    
    }

}
