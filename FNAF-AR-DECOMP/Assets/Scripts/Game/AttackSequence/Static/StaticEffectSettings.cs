using UnityEngine;

namespace Game.AttackSequence.Static
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StaticEffectSettings
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly float Shear;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly float Audio;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StaticEffectSettings(ProtoData.STATIC_DATA.Types.ENTRY.Types.EFFECTS rawSettings)
        {
            float val_3;
            if(rawSettings == null)
            {
                goto label_0;
            }
            
            if(this != null)
            {
                goto label_4;
            }
            
            label_5:
            label_4:
            this.Shear = (float)rawSettings.Shear;
            if(rawSettings == null)
            {
                goto label_2;
            }
            
            val_3 = (float)rawSettings.Audio;
            goto label_3;
            label_0:
            if(this != null)
            {
                goto label_4;
            }
            
            goto label_5;
            label_2:
            val_3 = 0f;
            label_3:
            this.Audio = val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetModifiedShear(float modifier)
        {
            modifier = this.Shear * modifier;
            return (float)modifier;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GetModifiedAudio(float modifier)
        {
            modifier = this.Audio * modifier;
            return (float)modifier;
        }
    
    }

}
