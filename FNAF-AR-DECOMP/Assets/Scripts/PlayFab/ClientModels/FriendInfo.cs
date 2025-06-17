using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class FriendInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserFacebookInfo FacebookInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FriendPlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserGameCenterInfo GameCenterInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.PlayerProfileModel Profile;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserPsnInfo PSNInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserSteamInfo SteamInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> Tags;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TitleDisplayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Username;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserXboxInfo XboxInfo;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FriendInfo()
        {
        
        }
    
    }

}
