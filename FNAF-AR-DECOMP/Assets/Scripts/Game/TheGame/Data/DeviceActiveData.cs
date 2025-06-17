using UnityEngine;

namespace Game.TheGame.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeviceActiveData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.TheGame.Data.DeviceEntry> Lure;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.TheGame.Data.DeviceEntry> Battery;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.TheGame.Data.DeviceEntry> Shocker;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.TheGame.Data.DeviceEntry> Transponder;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.TheGame.Data.DeviceEntry> Scanner;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.TheGame.Data.DeviceEntry> Jammer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.TheGame.Data.DeviceEntry> Meter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.TheGame.Data.DeviceEntry> HomeInvasion;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceActiveData()
        {
        
        }
    
    }

}
