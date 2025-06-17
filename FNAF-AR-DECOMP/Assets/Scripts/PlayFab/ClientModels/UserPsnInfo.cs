using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UserPsnInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PsnAccountId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PsnOnlineId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UserPsnInfo()
        {
        
        }
    
    }

}
