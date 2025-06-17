using UnityEngine;

namespace Game.Devices.DeviceConfigs
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeviceConfigs : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.Devices.DeviceConfigs.DeviceCategoryIcon> deviceIcons;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.Devices.DeviceConfigs.DeviceCategoryIcon> deviceStackIcons;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Sprite GetSpriteForDeviceCategory(Game.ItemDefinition.Data.DataDefinitions.DeviceData.DeviceCategory category)
        {
            UnityEngine.Sprite val_4;
            .category = category;
            if((this.deviceIcons.Find(match:  new System.Predicate<Game.Devices.DeviceConfigs.DeviceCategoryIcon>(object:  new DeviceConfigs.<>c__DisplayClass2_0(), method:  System.Boolean DeviceConfigs.<>c__DisplayClass2_0::<GetSpriteForDeviceCategory>b__0(Game.Devices.DeviceConfigs.DeviceCategoryIcon x)))) == null)
            {
                    return val_4;
            }
            
            val_4 = val_3.sprite;
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Sprite GetStackSpriteForDeviceCategory(Game.ItemDefinition.Data.DataDefinitions.DeviceData.DeviceCategory category)
        {
            UnityEngine.Sprite val_4;
            .category = category;
            if((this.deviceStackIcons.Find(match:  new System.Predicate<Game.Devices.DeviceConfigs.DeviceCategoryIcon>(object:  new DeviceConfigs.<>c__DisplayClass3_0(), method:  System.Boolean DeviceConfigs.<>c__DisplayClass3_0::<GetStackSpriteForDeviceCategory>b__0(Game.Devices.DeviceConfigs.DeviceCategoryIcon x)))) == null)
            {
                    return val_4;
            }
            
            val_4 = val_3.sprite;
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceConfigs()
        {
            this.deviceIcons = new System.Collections.Generic.List<Game.Devices.DeviceConfigs.DeviceCategoryIcon>();
            this.deviceStackIcons = new System.Collections.Generic.List<Game.Devices.DeviceConfigs.DeviceCategoryIcon>();
        }
    
    }

}
