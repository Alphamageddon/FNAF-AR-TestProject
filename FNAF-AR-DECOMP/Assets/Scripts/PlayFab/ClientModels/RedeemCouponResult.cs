using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class RedeemCouponResult : PlayFabResultCommon
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.ItemInstance> GrantedItems;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public RedeemCouponResult()
        {
        
        }
    
    }

}
