using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetTitleEnabledForMultiplayerServersStatusResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.MultiplayerModels.TitleMultiplayerServerEnabledStatus> Status;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetTitleEnabledForMultiplayerServersStatusResponse()
        {
        
        }
    
    }

}
