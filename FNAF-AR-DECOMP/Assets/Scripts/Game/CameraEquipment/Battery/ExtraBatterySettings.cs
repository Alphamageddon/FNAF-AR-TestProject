using UnityEngine;

namespace Game.CameraEquipment.Battery
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ExtraBatterySettings
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float CriticalBatteryLevel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float TotalRecharge;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public readonly float Duration;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ExtraBatterySettings(ProtoData.DEVICES_DATA.Types.ENTRY.Types.EFFECTS.Types.EXTRABATTERY rawSettings)
        {
            float val_4;
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
            this.CriticalBatteryLevel = (float)rawSettings.BatteryActivate;
            if(rawSettings == null)
            {
                goto label_2;
            }
            
            this.TotalRecharge = (float)rawSettings.BatteryBonus;
            val_4 = (float)rawSettings.BatteryDur;
            goto label_3;
            label_0:
            if(this != null)
            {
                goto label_4;
            }
            
            goto label_5;
            label_2:
            this.TotalRecharge = 0f;
            val_4 = 0f;
            label_3:
            this.Duration = val_4;
        }
    
    }

}
