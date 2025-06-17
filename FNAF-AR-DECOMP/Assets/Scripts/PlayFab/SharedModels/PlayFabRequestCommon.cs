using UnityEngine;

namespace PlayFab.SharedModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabRequestCommon : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.PlayFabAuthenticationContext AuthenticationContext;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabRequestCommon()
        {
            val_1 = new System.Object();
        }
    
    }

}
