using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ListPartyQosServersResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int PageSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.QosServer> QosServers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SkipToken;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListPartyQosServersResponse()
        {
        
        }
    
    }

}
