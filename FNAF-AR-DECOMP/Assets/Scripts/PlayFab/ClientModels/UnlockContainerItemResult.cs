using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class UnlockContainerItemResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.ItemInstance> GrantedItems;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UnlockedItemInstanceId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UnlockedWithItemInstanceId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, uint> VirtualCurrency;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnlockContainerItemResult()
        {
        
        }
    
    }

}
