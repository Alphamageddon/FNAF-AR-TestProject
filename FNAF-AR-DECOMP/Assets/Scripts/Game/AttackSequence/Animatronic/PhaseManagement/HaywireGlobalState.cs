using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class HaywireGlobalState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.HaywireData Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Animatronic.PhaseManagement.ActivationState CircleState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Animatronic.PhaseManagement.ActivationState PauseState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Animatronic.PhaseManagement.ActivationState ChargeState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool FirstActivationRequest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Animatronic.PhaseManagement.ActivationState ActiveState;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int HaywireCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly SimpleTimer Cooldown;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsMultiwireActive;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int RemainingActivations;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UseMultiwire()
        {
            Game.ItemDefinition.Data.DataDefinitions.IntRangeData val_2;
            var val_3;
            val_2 = this;
            if(this.Config.Multiwire.Count.Min > 0)
            {
                    val_3 = 1;
                return (bool)(this.Config.Multiwire.Count.Max > 0) ? 1 : 0;
            }
            
            val_2 = this.Config.Multiwire.Count;
            return (bool)(this.Config.Multiwire.Count.Max > 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetMultiwire()
        {
            this.IsMultiwireActive = false;
            this.RemainingActivations = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public HaywireGlobalState(Game.ItemDefinition.Data.DataDefinitions.HaywireData config)
        {
            this.FirstActivationRequest = true;
            this.Cooldown = new SimpleTimer();
            this.Config = config;
            .Config = config.Circle;
            this.CircleState = new Game.AttackSequence.Animatronic.PhaseManagement.ActivationState();
            .Config = this.Config.Pause;
            this.PauseState = new Game.AttackSequence.Animatronic.PhaseManagement.ActivationState();
            .Config = this.Config.Charge;
            this.ChargeState = new Game.AttackSequence.Animatronic.PhaseManagement.ActivationState();
        }
    
    }

}
