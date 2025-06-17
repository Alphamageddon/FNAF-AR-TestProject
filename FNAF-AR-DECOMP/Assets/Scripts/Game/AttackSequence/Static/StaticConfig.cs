using UnityEngine;

namespace Game.AttackSequence.Static
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StaticConfig
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.PhaseStaticSettings InitialPause;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.PhaseStaticSettings Circle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.PhaseStaticSettings Pause;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.PhaseStaticSettings Charge;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.PhaseStaticSettings PhantomWalk;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.PhaseStaticSettings Jumpscare;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.AdditiveStaticSettings WalkFootsteps;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.AdditiveStaticSettings RunFootsteps;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StaticConfig(ProtoData.STATIC_DATA.Types.ENTRY entry)
        {
            ADDITIVESTATIC val_20;
            PHASESTATIC val_21;
            PHASESTATIC val_22;
            PHASESTATIC val_23;
            ADDITIVESTATIC val_24;
            val_20 = entry;
            if(val_20 != null)
            {
                    val_21 = val_20.InitialPause;
            }
            else
            {
                    val_21 = 0;
            }
            
            this.InitialPause = new Game.AttackSequence.Static.PhaseStaticSettings(rawSettings:  val_21);
            if(val_20 != null)
            {
                    this.Circle = new Game.AttackSequence.Static.PhaseStaticSettings(rawSettings:  val_20.Circle);
                val_22 = val_20.Pause;
            }
            else
            {
                    val_22 = 0;
                this.Circle = new Game.AttackSequence.Static.PhaseStaticSettings(rawSettings:  0);
            }
            
            this.Pause = new Game.AttackSequence.Static.PhaseStaticSettings(rawSettings:  val_22);
            if(val_20 != null)
            {
                    this.Charge = new Game.AttackSequence.Static.PhaseStaticSettings(rawSettings:  val_20.Charge);
                val_23 = val_20.PhantomWalk;
            }
            else
            {
                    val_23 = 0;
                this.Charge = new Game.AttackSequence.Static.PhaseStaticSettings(rawSettings:  0);
            }
            
            this.PhantomWalk = new Game.AttackSequence.Static.PhaseStaticSettings(rawSettings:  val_23);
            if(val_20 != null)
            {
                    this.Jumpscare = new Game.AttackSequence.Static.PhaseStaticSettings(rawSettings:  val_20.Jumpscare);
                val_24 = val_20.WalkFootsteps;
            }
            else
            {
                    val_24 = 0;
                this.Jumpscare = new Game.AttackSequence.Static.PhaseStaticSettings(rawSettings:  0);
            }
            
            this.WalkFootsteps = new Game.AttackSequence.Static.AdditiveStaticSettings(rawSettings:  val_24);
            if(val_20 != null)
            {
                    val_20 = val_20.RunFootsteps;
            }
            
            this.RunFootsteps = new Game.AttackSequence.Static.AdditiveStaticSettings(rawSettings:  val_20);
        }
    
    }

}
