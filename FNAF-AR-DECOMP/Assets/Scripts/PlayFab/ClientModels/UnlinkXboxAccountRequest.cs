using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UnlinkXboxAccountRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string XboxToken;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnlinkXboxAccountRequest()
        {
        
        }
    
    }

}
