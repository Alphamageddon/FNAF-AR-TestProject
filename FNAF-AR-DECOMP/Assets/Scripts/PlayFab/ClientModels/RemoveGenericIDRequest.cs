using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class RemoveGenericIDRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.GenericServiceId GenericId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RemoveGenericIDRequest()
        {
        
        }
    
    }

}
