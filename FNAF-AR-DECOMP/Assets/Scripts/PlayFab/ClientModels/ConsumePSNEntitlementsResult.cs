using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ConsumePSNEntitlementsResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.ItemInstance> ItemsGranted;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConsumePSNEntitlementsResult()
        {
        
        }
    
    }

}
