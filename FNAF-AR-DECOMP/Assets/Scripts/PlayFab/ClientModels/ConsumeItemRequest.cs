using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ConsumeItemRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CharacterId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int ConsumeCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ItemInstanceId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConsumeItemRequest()
        {
        
        }
    
    }

}
