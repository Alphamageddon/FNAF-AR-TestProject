using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class Phase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess Blackboard;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected SimpleTimer EndOfPhase;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase AttackPhase { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase get_AttackPhase(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Enter()
        {
            goto typeof(Game.AttackSequence.Animatronic.PhaseManagement.Phase).__il2cppRuntimeField_178;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase Update()
        {
            goto typeof(Game.AttackSequence.Animatronic.PhaseManagement.Phase).__il2cppRuntimeField_188;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Exit()
        {
            this.EndOfPhase.Reset();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void EnterPhase(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected abstract void ExitPhase(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess blackboard)
        {
            this.Blackboard = blackboard;
            this.EndOfPhase = new SimpleTimer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this.Blackboard = 0;
            this.EndOfPhase = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected Phase()
        {
        
        }
    
    }

}
