using UnityEngine;

namespace Game.Devices.DeviceConfigs
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class DeviceCategoryIcon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.DeviceData.DeviceCategory Category;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Sprite sprite;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceCategoryIcon()
        {
        
        }
    
    }

}
