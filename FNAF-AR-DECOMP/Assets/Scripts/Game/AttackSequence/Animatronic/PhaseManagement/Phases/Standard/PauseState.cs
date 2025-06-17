using UnityEngine;

namespace Game.AttackSequence.Animatronic.PhaseManagement.Phases.Standard
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PauseState
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.PauseData Config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 SavedPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 SavedForward;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly SimpleTimer HaywireTimer;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.SavedPosition = val_1;
            mem[1152921525476506956] = val_1.y;
            mem[1152921525476506960] = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.forward;
            this.SavedForward = val_2;
            mem[1152921525476506968] = val_2.y;
            mem[1152921525476506972] = val_2.z;
            this.HaywireTimer.Reset();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PauseState(Game.ItemDefinition.Data.DataDefinitions.PauseData config)
        {
            this.HaywireTimer = new SimpleTimer();
            this.Config = config;
        }
    
    }

}
