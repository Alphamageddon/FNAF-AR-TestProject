using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class GenericPlayFabIdPair : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.ClientModels.GenericServiceId GenericId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string PlayFabId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GenericPlayFabIdPair()
        {
        
        }
    
    }

}
