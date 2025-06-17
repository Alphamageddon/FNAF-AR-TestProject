using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetAssetUploadUrlResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AssetUploadUrl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FileName;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetAssetUploadUrlResponse()
        {
        
        }
    
    }

}
