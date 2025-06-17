using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetTitleNewsResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.TitleNewsItem> News;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetTitleNewsResult()
        {
        
        }
    
    }

}
