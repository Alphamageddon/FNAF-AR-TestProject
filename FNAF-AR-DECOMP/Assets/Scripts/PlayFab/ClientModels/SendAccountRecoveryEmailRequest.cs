using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SendAccountRecoveryEmailRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Email;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string EmailTemplateId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string TitleId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SendAccountRecoveryEmailRequest()
        {
        
        }
    
    }

}
