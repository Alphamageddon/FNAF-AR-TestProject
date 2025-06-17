using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FootstepConfigData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float EffectDelay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly MoreMountains.NiceVibrations.HapticTypes VibrationType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly Game.ItemDefinition.Data.DataDefinitions.CameraShakeData CameraShake;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FootstepConfigData(ProtoData.ATTACK_DATA.Types.FOOTSTEPS.Types.FOOTSTEPCONFIG rawSettings)
        {
            CAMERASHAKE val_9;
            var val_10;
            val_9 = rawSettings;
            MoreMountains.NiceVibrations.HapticTypes val_5 = 0;
            var val_1 = (val_9 != 0) ? (this) : 0;
            if(val_9 != null)
            {
                    mem2[0] = (float)val_9.EffectDelay;
                this.VibrationType = 7;
                string val_3 = val_9.VibrationType;
            }
            else
            {
                    val_10 = 0;
                this.EffectDelay = 0f;
                this.VibrationType = 7;
            }
            
            if((System.Enum.TryParse<MoreMountains.NiceVibrations.HapticTypes>(value:  (val_10 == 0) ? "" : (val_10), ignoreCase:  true, result: out  val_5)) != false)
            {
                    this.VibrationType = val_5;
            }
            
            if(val_9 != null)
            {
                    val_9 = val_9.CameraShake;
            }
            
            this.CameraShake = new Game.ItemDefinition.Data.DataDefinitions.CameraShakeData(rawSettings:  val_9);
        }
    
    }

}
