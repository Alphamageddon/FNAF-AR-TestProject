using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UpdateUserDataRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> Data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> KeysToRemove;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.UserDataPermission> Permission;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UpdateUserDataRequest()
        {
        
        }
    
    }

}
