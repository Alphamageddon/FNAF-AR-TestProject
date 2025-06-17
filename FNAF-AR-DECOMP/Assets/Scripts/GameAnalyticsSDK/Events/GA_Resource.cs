using UnityEngine;

namespace GameAnalyticsSDK.Events
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GA_Resource
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewEvent(GameAnalyticsSDK.GAResourceFlowType flowType, string currency, float amount, string itemType, string itemId, System.Collections.Generic.IDictionary<string, object> fields)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.AddResourceEvent(flowType:  flowType, currency:  currency, amount:  amount, itemType:  itemType, itemId:  itemId, fields:  fields);
        }
    
    }

}
