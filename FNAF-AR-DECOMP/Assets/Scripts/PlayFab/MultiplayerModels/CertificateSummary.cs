using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class CertificateSummary : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Thumbprint;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CertificateSummary()
        {
        
        }
    
    }

}
