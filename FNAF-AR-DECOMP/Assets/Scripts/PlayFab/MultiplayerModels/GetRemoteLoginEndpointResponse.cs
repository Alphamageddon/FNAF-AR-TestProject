using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetRemoteLoginEndpointResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string IPV4Address;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Port;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetRemoteLoginEndpointResponse()
        {
        
        }
    
    }

}
