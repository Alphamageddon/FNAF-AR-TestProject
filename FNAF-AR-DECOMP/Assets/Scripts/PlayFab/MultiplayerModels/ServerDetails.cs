using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ServerDetails : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string IPV4Address;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.Port> Ports;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Region;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ServerDetails()
        {
        
        }
    
    }

}
