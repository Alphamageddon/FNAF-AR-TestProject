using UnityEngine;

namespace PlayFab.MultiplayerModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ListVirtualMachineSummariesResponse : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int PageSize;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SkipToken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.MultiplayerModels.VirtualMachineSummary> VirtualMachines;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ListVirtualMachineSummariesResponse()
        {
        
        }
    
    }

}
