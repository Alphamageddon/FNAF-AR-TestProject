using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UnlinkWindowsHelloAccountRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PublicKeyHint;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnlinkWindowsHelloAccountRequest()
        {
        
        }
    
    }

}
