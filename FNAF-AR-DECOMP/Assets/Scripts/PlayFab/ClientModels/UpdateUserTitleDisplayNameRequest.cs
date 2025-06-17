using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UpdateUserTitleDisplayNameRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DisplayName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UpdateUserTitleDisplayNameRequest()
        {
        
        }
    
    }

}
