using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CreateRemoteUserRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BuildId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> ExpirationTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Region;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Username;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string VmId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CreateRemoteUserRequest()
        {
        
        }
    
    }

}
