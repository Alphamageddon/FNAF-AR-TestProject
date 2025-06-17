using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LinkWindowsHelloAccountRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DeviceName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> ForceLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PublicKey;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UserName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkWindowsHelloAccountRequest()
        {
        
        }
    
    }

}
