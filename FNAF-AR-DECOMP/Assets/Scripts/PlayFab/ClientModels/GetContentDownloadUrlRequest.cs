using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetContentDownloadUrlRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string HttpMethod;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Key;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> ThruCDN;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetContentDownloadUrlRequest()
        {
        
        }
    
    }

}
