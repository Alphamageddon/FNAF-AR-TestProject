using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GooglePlayFabIdPair : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GoogleId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GooglePlayFabIdPair()
        {
        
        }
    
    }

}
