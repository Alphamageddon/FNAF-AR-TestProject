using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class LinkXboxAccountRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> ForceLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string XboxToken;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkXboxAccountRequest()
        {
        
        }
    
    }

}
