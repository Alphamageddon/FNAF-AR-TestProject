using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UserFacebookInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FacebookId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FullName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UserFacebookInfo()
        {
        
        }
    
    }

}
