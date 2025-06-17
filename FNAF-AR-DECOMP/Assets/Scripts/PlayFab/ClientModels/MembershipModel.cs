using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class MembershipModel : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsActive;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime MembershipExpiration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string MembershipId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> OverrideExpiration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<PlayFab.ClientModels.SubscriptionModel> Subscriptions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MembershipModel()
        {
        
        }
    
    }

}
