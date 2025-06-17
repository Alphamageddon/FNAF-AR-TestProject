using UnityEngine;

namespace GameAnalyticsSDK.Events
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GA_Setup
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetAvailableCustomDimensions01(System.Collections.Generic.List<string> customDimensions)
        {
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateCustomDimensions(customDimensions:  customDimensions.ToArray())) == false)
            {
                    return;
            }
            
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetAvailableCustomDimensions01(list:  GA_MiniJSON.Serializer.Serialize(obj:  customDimensions));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetAvailableCustomDimensions02(System.Collections.Generic.List<string> customDimensions)
        {
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateCustomDimensions(customDimensions:  customDimensions.ToArray())) == false)
            {
                    return;
            }
            
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetAvailableCustomDimensions02(list:  GA_MiniJSON.Serializer.Serialize(obj:  customDimensions));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetAvailableCustomDimensions03(System.Collections.Generic.List<string> customDimensions)
        {
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateCustomDimensions(customDimensions:  customDimensions.ToArray())) == false)
            {
                    return;
            }
            
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetAvailableCustomDimensions03(list:  GA_MiniJSON.Serializer.Serialize(obj:  customDimensions));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetAvailableResourceCurrencies(System.Collections.Generic.List<string> resourceCurrencies)
        {
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateResourceCurrencies(resourceCurrencies:  resourceCurrencies.ToArray())) == false)
            {
                    return;
            }
            
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetAvailableResourceCurrencies(list:  GA_MiniJSON.Serializer.Serialize(obj:  resourceCurrencies));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetAvailableResourceItemTypes(System.Collections.Generic.List<string> resourceItemTypes)
        {
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateResourceItemTypes(resourceItemTypes:  resourceItemTypes.ToArray())) == false)
            {
                    return;
            }
            
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetAvailableResourceItemTypes(list:  GA_MiniJSON.Serializer.Serialize(obj:  resourceItemTypes));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetInfoLog(bool enabled)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetInfoLog(enabled:  enabled);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetVerboseLog(bool enabled)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetVerboseLog(enabled:  enabled);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetFacebookId(string facebookId)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetFacebookId(facebookId:  facebookId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetGender(GameAnalyticsSDK.GAGender gender)
        {
            string val_3;
            var val_4;
            long val_5;
            val_3 = gender;
            if(val_3 != 2)
            {
                    if(val_3 != 1)
            {
                    return;
            }
            
                val_4 = null;
                val_5 = 1;
            }
            else
            {
                    val_4 = null;
                val_5 = 2;
            }
            
            val_3 = val_5.ToString();
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_5});
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetGender(gender:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetBirthYear(int birthYear)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetBirthYear(birthYear:  birthYear);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetCustomDimension01(string customDimension)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetCustomDimension01(customDimension:  customDimension);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetCustomDimension02(string customDimension)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetCustomDimension02(customDimension:  customDimension);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetCustomDimension03(string customDimension)
        {
            GameAnalyticsSDK.Wrapper.GA_Wrapper.SetCustomDimension03(customDimension:  customDimension);
        }
    
    }

}
