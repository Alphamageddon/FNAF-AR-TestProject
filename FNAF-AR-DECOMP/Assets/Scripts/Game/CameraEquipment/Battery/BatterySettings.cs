using UnityEngine;

namespace Game.CameraEquipment.Battery
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class BatterySettings
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float BaseRecharge;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float EssenceFlashlightDrain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly int AllowedExtraBatteries;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public BatterySettings(ProtoData.CONFIG_DATA.Types.ENTRY.Types.BATTERYBEHAVIOR rawSettings)
        {
            float val_5;
            if(rawSettings == null)
            {
                goto label_1;
            }
            
            if(this != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            this.BaseRecharge = (float)rawSettings.BatteryBaseRecharge;
            if(rawSettings == null)
            {
                goto label_3;
            }
            
            this.EssenceFlashlightDrain = (float)rawSettings.EssenceFlashlightDrain;
            val_5 = (float)rawSettings.AllowedExtraBatteries;
            goto label_4;
            label_1:
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_6;
            label_3:
            this.EssenceFlashlightDrain = 0f;
            val_5 = 0f;
            label_4:
            this.AllowedExtraBatteries = UnityEngine.Mathf.RoundToInt(f:  val_5);
        }
    
    }

}
