using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UploadCertificateRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.MultiplayerModels.Certificate GameCertificate;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UploadCertificateRequest()
        {
        
        }
    
    }

}
