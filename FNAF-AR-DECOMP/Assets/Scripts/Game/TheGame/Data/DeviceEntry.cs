using UnityEngine;

namespace Game.TheGame.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeviceEntry
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string deviceId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string deviceType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string deviceConfigId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.TheGame.Data.DeviceState deviceState;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceEntry()
        {
        
        }
    
    }

}
