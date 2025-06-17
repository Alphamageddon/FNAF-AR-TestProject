using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AddUsernamePasswordRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Email;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Password;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Username;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AddUsernamePasswordRequest()
        {
        
        }
    
    }

}
