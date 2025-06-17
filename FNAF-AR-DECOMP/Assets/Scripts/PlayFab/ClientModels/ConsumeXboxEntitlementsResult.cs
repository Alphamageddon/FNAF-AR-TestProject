using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class ConsumeXboxEntitlementsResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.ItemInstance> Items;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConsumeXboxEntitlementsResult()
        {
        
        }
    
    }

}
