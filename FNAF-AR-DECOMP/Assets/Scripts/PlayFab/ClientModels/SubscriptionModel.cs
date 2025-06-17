using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class SubscriptionModel : PlayFabBaseModel
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime Expiration;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime InitialSubscriptionTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsActive;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<PlayFab.ClientModels.SubscriptionProviderStatus> Status;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SubscriptionId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SubscriptionItemId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SubscriptionProvider;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SubscriptionModel()
        {
        
        }
    
    }

}
