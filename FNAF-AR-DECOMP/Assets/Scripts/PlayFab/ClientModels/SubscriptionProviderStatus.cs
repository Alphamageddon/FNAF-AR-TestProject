using UnityEngine;

namespace PlayFab.ClientModels
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public enum SubscriptionProviderStatus
    {
        // Fields
        NoError = 0
        ,Cancelled = 1
        ,UnknownError = 2
        ,BillingError = 3
        ,ProductUnavailable = 4
        ,CustomerDidNotAcceptPriceChange = 5
        ,FreeTrial = 6
        ,PaymentPending = 7
        
    
    }

}
