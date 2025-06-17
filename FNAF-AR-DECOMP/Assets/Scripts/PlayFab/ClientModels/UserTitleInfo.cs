using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UserTitleInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AvatarUrl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime Created;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DisplayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> FirstLogin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> isBanned;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> LastLogin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.UserOrigination> Origination;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.EntityKey TitlePlayerAccount;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UserTitleInfo()
        {
        
        }
    
    }

}
