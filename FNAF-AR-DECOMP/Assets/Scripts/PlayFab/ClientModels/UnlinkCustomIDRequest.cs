using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UnlinkCustomIDRequest : PlayFabRequestCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CustomId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnlinkCustomIDRequest()
        {
        
        }
    
    }

}
