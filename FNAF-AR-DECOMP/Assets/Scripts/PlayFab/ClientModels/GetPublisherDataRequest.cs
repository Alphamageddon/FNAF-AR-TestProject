using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GetPublisherDataRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<string> Keys;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetPublisherDataRequest()
        {
        
        }
    
    }

}
