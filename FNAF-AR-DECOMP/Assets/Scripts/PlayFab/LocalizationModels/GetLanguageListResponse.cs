using UnityEngine;

namespace PlayFab.LocalizationModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetLanguageListResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> LanguageList;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetLanguageListResponse()
        {
        
        }
    
    }

}
