using UnityEngine;

namespace PlayFab.SharedModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabLoginResultCommon : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.PlayFabAuthenticationContext AuthenticationContext;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabLoginResultCommon()
        {
            val_1 = new System.Object();
        }
    
    }

}
