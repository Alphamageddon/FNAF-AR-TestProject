using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class CameraShakeData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float Magnitude;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float Roughness;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float FadeIn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float FadeOut;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CameraShakeData(ProtoData.ATTACK_DATA.Types.CAMERASHAKE rawSettings)
        {
            float val_5;
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
            this.Magnitude = (float)rawSettings.Magnitude;
            if(rawSettings == null)
            {
                goto label_2;
            }
            
            this.Roughness = (float)rawSettings.Roughness;
            this.FadeIn = (float)rawSettings.FadeIn;
            val_5 = (float)rawSettings.FadeOut;
            goto label_3;
            label_0:
            if(this != null)
            {
                goto label_4;
            }
            
            goto label_5;
            label_2:
            this.Roughness = 0f;
            this.FadeIn = 0f;
            val_5 = 0f;
            label_3:
            this.FadeOut = val_5;
        }
    
    }

}
