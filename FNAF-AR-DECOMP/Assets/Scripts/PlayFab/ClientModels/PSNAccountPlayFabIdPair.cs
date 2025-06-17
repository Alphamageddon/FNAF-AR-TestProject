using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class PSNAccountPlayFabIdPair : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PSNAccountId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PSNAccountPlayFabIdPair()
        {
        
        }
    
    }

}
