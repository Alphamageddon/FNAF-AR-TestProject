using UnityEngine;

namespace Game.AttackSequence.Static
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StaticFadeSettings
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float FadeIn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float FadeOut;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StaticFadeSettings(ProtoData.STATIC_DATA.Types.ENTRY.Types.FADESETTINGS rawSettings)
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
            this.FadeIn = (float)rawSettings.FadeIn;
            if(rawSettings == null)
            {
                goto label_2;
            }
            
            val_3 = (float)rawSettings.FadeOut;
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
            this.FadeOut = val_3;
        }
    
    }

}
