using UnityEngine;

namespace Game.AttackSequence.Static
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AdditiveStaticSettings
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly bool IsPositional;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.StaticFadeSettings FadeSettings;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.StaticValueRange Duration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.AttackSequence.Static.StaticEffectSettings Effects;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AdditiveStaticSettings(ProtoData.STATIC_DATA.Types.ENTRY.Types.ADDITIVESTATIC rawSettings)
        {
            EFFECTS val_10;
            RANGESETTINGS val_11;
            val_10 = rawSettings;
            if(val_10 == null)
            {
                goto label_1;
            }
            
            if(this != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            this.IsPositional = val_10.IsPositional;
            if(val_10 == null)
            {
                goto label_3;
            }
            
            this.FadeSettings = new Game.AttackSequence.Static.StaticFadeSettings(rawSettings:  val_10.FadeSettings);
            val_11 = val_10.Duration;
            goto label_4;
            label_1:
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_6;
            label_3:
            val_11 = 0;
            this.FadeSettings = new Game.AttackSequence.Static.StaticFadeSettings(rawSettings:  0);
            label_4:
            this.Duration = new Game.AttackSequence.Static.StaticValueRange(rawSettings:  val_11);
            if(val_10 != null)
            {
                    val_10 = val_10.Effects;
            }
            
            this.Effects = new Game.AttackSequence.Static.StaticEffectSettings(rawSettings:  val_10);
        }
    
    }

}
