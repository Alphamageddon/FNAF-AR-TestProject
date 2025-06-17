using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AddOrUpdateContactEmailRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EmailAddress;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AddOrUpdateContactEmailRequest()
        {
        
        }
    
    }

}
