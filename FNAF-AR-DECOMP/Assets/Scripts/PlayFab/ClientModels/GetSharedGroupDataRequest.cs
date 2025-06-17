using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetSharedGroupDataRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<bool> GetMembers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> Keys;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SharedGroupId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSharedGroupDataRequest()
        {
        
        }
    
    }

}
