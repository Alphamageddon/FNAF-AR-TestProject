using UnityEngine;

namespace Game.CameraEquipment.Shocker
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ShockerSettings
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float ShockerCooldown;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ShockerSettings(ProtoData.CONFIG_DATA.Types.ENTRY.Types.SHOCKERBEHAVIOR rawSettings)
        {
            if(rawSettings == null)
            {
                goto label_0;
            }
            
            if(this != null)
            {
                goto label_2;
            }
            
            label_3:
            label_2:
            this.ShockerCooldown = (float)rawSettings.ShockerCooldownTimer;
            return;
            label_0:
            if(this != null)
            {
                goto label_2;
            }
            
            goto label_3;
        }
    
    }

}
