using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class FacebookPlayFabIdPair : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FacebookId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FacebookPlayFabIdPair()
        {
        
        }
    
    }

}
