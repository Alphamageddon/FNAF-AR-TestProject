using UnityEngine;

namespace Game.AttackSequence.Static
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PhaseStaticSettings
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.StaticValueRange BaseAngle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.StaticEffectSettings BaseEffects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.StaticValueRange Angle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.StaticEffectSettings Effects;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.StaticValueRange FlashlightAngle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.StaticEffectSettings FlashlightEffects;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PhaseStaticSettings(ProtoData.STATIC_DATA.Types.ENTRY.Types.PHASESTATIC rawSettings)
        {
            EFFECTS val_15;
            RANGESETTINGS val_16;
            RANGESETTINGS val_17;
            RANGESETTINGS val_18;
            val_15 = rawSettings;
            if(val_15 != null)
            {
                    val_16 = val_15.BaseAngle;
            }
            else
            {
                    val_16 = 0;
            }
            
            this.BaseAngle = new Game.AttackSequence.Static.StaticValueRange(rawSettings:  val_16);
            if(val_15 != null)
            {
                    this.BaseEffects = new Game.AttackSequence.Static.StaticEffectSettings(rawSettings:  val_15.BaseEffects);
                val_17 = val_15.Angle;
            }
            else
            {
                    val_17 = 0;
                this.BaseEffects = new Game.AttackSequence.Static.StaticEffectSettings(rawSettings:  0);
            }
            
            this.Angle = new Game.AttackSequence.Static.StaticValueRange(rawSettings:  val_17);
            if(val_15 != null)
            {
                    this.Effects = new Game.AttackSequence.Static.StaticEffectSettings(rawSettings:  val_15.Effects);
                val_18 = val_15.FlashlightAngle;
            }
            else
            {
                    val_18 = 0;
                this.Effects = new Game.AttackSequence.Static.StaticEffectSettings(rawSettings:  0);
            }
            
            this.FlashlightAngle = new Game.AttackSequence.Static.StaticValueRange(rawSettings:  val_18);
            if(val_15 != null)
            {
                    val_15 = val_15.FlashlightEffects;
            }
            
            this.FlashlightEffects = new Game.AttackSequence.Static.StaticEffectSettings(rawSettings:  val_15);
        }
    
    }

}
