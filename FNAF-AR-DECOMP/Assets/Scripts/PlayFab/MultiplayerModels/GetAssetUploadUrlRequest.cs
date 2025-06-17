using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetAssetUploadUrlRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FileName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetAssetUploadUrlRequest()
        {
        
        }
    
    }

}
