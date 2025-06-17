using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ListVirtualMachineSummariesRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string BuildId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<int> PageSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Region;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SkipToken;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListVirtualMachineSummariesRequest()
        {
        
        }
    
    }

}
