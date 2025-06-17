using UnityEngine;

namespace GameAnalyticsSDK.Events
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GA_Ads
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewEvent(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement, long duration)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.AddAdEventWithDuration(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement, duration:  duration);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewEvent(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement, GameAnalyticsSDK.GAAdError noAdReason)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.AddAdEventWithReason(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement, noAdReason:  noAdReason);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NewEvent(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.AddAdEvent(adAction:  adAction, adType:  adType, adSdkName:  adSdkName, adPlacement:  adPlacement);
        }
    
    }

}
