using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UserOpenIdInfo : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ConnectionId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Issuer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Subject;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UserOpenIdInfo()
        {
        
        }
    
    }

}
