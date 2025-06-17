using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UserAccountInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserAndroidDeviceInfo AndroidDeviceInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime Created;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserCustomIdInfo CustomIdInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserFacebookInfo FacebookInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserFacebookInstantGamesIdInfo FacebookInstantGamesIdInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserGameCenterInfo GameCenterInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserGoogleInfo GoogleInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserIosDeviceInfo IosDeviceInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserKongregateInfo KongregateInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserNintendoSwitchDeviceIdInfo NintendoSwitchDeviceIdInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.UserOpenIdInfo> OpenIdInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserPrivateAccountInfo PrivateInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserPsnInfo PsnInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserSteamInfo SteamInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserTitleInfo TitleInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserTwitchInfo TwitchInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Username;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserWindowsHelloInfo WindowsHelloInfo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.UserXboxInfo XboxInfo;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UserAccountInfo()
        {
        
        }
    
    }

}
