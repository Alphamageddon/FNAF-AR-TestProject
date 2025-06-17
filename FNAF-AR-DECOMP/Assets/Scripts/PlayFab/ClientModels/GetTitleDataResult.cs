using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetTitleDataResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> Data;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetTitleDataResult()
        {
        
        }
    
    }

}
