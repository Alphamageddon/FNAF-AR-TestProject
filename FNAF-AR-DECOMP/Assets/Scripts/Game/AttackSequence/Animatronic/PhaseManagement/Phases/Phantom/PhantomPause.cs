using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PhantomPause : BasePause
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomPauseState _state;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void EnterPhase()
        {
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomPauseState val_4 = this._state;
            if(val_4 != null)
            {
                goto label_1;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_2 = val_4.AttackProfile;
            Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomPauseState val_3 = null;
            val_4 = val_3;
            val_3 = new Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomPauseState();
            .Config = val_2.PhantomPause;
            this._state = val_4;
            if(val_4 == null)
            {
                goto label_8;
            }
            
            label_1:
            this._state.Config.Seconds.StartTimer(time:  UnityEngine.Random.Range(min:  (Game.AttackSequence.Animatronic.PhaseManagement.Phases.Phantom.PhantomPauseState)[1152921525482293616].Config.Seconds.Min, max:  this._state.Config.Seconds.Max));
            this.RunSharedEnterPhase();
            return;
            label_8:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase UpdatePhase()
        {
            return (Game.AttackSequence.Animatronic.PhaseManagement.AttackPhase)(X19.IsExpired() != true) ? 12 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void ExitPhase()
        {
            this.RunSharedExitPhase();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PhantomPause()
        {
            mem[1152921525482622224] = 5;
            val_1 = new System.Object();
        }
    
    }

}
