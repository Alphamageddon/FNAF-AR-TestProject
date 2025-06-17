using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetMultiplayerServerDetailsResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.ConnectedPlayer> ConnectedPlayers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FQDN;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string IPV4Address;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> LastStateTransitionTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.Port> Ports;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Region;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ServerId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SessionId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string State;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string VmId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetMultiplayerServerDetailsResponse()
        {
        
        }
    
    }

}
