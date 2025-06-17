using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AddGenericIDRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.GenericServiceId GenericId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AddGenericIDRequest()
        {
        
        }
    
    }

}
