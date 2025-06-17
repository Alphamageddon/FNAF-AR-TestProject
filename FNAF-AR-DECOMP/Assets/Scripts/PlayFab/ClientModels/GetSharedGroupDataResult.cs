using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetSharedGroupDataResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, PlayFab.ClientModels.SharedGroupDataRecord> Data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> Members;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSharedGroupDataResult()
        {
        
        }
    
    }

}
