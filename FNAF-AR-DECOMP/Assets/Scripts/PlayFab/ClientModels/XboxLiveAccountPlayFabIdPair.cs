using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class XboxLiveAccountPlayFabIdPair : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string XboxLiveAccountId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public XboxLiveAccountPlayFabIdPair()
        {
        
        }
    
    }

}
