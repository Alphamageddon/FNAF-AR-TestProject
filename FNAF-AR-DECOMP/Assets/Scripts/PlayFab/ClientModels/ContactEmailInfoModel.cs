using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ContactEmailInfoModel : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EmailAddress;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.EmailVerificationStatus> VerificationStatus;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ContactEmailInfoModel()
        {
        
        }
    
    }

}
