using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class RolloverContainerRegistryCredentialsResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DnsName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Password;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Username;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RolloverContainerRegistryCredentialsResponse()
        {
        
        }
    
    }

}
