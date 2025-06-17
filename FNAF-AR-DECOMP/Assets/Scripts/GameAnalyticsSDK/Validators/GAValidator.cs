using UnityEngine;

namespace GameAnalyticsSDK.Validators
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal static class GAValidator
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool StringMatch(string s, string pattern)
        {
            if(s == null)
            {
                    return false;
            }
            
            if(pattern == null)
            {
                    return false;
            }
            
            return System.Text.RegularExpressions.Regex.IsMatch(input:  s, pattern:  pattern);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateBusinessEvent(string currency, int amount, string cartType, string itemType, string itemId)
        {
            string val_8;
            var val_9;
            string val_10;
            var val_11;
            string val_12;
            var val_13;
            val_8 = itemId;
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateCurrency(currency:  currency)) == false)
            {
                goto label_1;
            }
            
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateShortString(shortString:  cartType, canBeEmpty:  true)) == false)
            {
                goto label_2;
            }
            
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartLength(eventPart:  itemType, allowNull:  false)) == false)
            {
                goto label_3;
            }
            
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartCharacters(eventPart:  itemType)) == false)
            {
                goto label_4;
            }
            
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartLength(eventPart:  val_8, allowNull:  false)) == false)
            {
                goto label_5;
            }
            
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartCharacters(eventPart:  val_8)) == false)
            {
                goto label_6;
            }
            
            val_9 = 1;
            return (bool)val_9;
            label_1:
            val_10 = currency;
            val_11 = "Validation fail - business event - currency: Cannot be (null) and need to be A-Z, 3 characters and in the standard at openexchangerates.org. Failed currency: ";
            goto label_14;
            label_2:
            val_10 = cartType;
            val_11 = "Validation fail - business event - cartType. Cannot be above 32 length. String: ";
            goto label_14;
            label_3:
            val_12 = "Validation fail - business event - itemType: Cannot be (null), empty or above 64 characters. String: ";
            goto label_10;
            label_4:
            val_12 = "Validation fail - business event - itemType: Cannot contain other characters than A-z, 0-9, -_., ()!?. String: ";
            label_10:
            val_10 = itemType;
            label_14:
            val_8 = val_12 + val_10;
            UnityEngine.Debug.Log(message:  val_8);
            val_9 = 0;
            return (bool)val_9;
            label_5:
            val_13 = "Validation fail - business event - itemId. Cannot be (null), empty or above 64 characters. String: ";
            goto label_14;
            label_6:
            val_13 = "Validation fail - business event - itemId: Cannot contain other characters than A-z, 0-9, -_., ()!?. String: ";
            goto label_14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateResourceEvent(GameAnalyticsSDK.GAResourceFlowType flowType, string currency, float amount, string itemType, string itemId)
        {
            object val_11;
            object val_12;
            var val_14;
            var val_15;
            val_11 = itemId;
            if((System.String.IsNullOrEmpty(value:  currency)) == false)
            {
                goto label_1;
            }
            
            label_16:
            val_12 = "Validation fail - resource event - currency: Cannot be (null)";
            goto label_4;
            label_1:
            if(flowType == 0)
            {
                    UnityEngine.Debug.Log(message:  "Validation fail - resource event - flowType: Invalid flowType");
            }
            
            if((GameAnalyticsSDK.State.GAState.HasAvailableResourceCurrency(_currency:  currency)) == false)
            {
                goto label_8;
            }
            
            if(amount > 0f)
            {
                goto label_9;
            }
            
            string val_3 = "Validation fail - resource event - amount: Float amount cannot be 0 or negative. Value: "("Validation fail - resource event - amount: Float amount cannot be 0 or negative. Value: ") + amount;
            goto label_10;
            label_8:
            label_27:
            label_10:
            val_11 = "Validation fail - resource event - currency: Not found in list of pre-defined resource currencies. String: "("Validation fail - resource event - currency: Not found in list of pre-defined resource currencies. String: ") + currency;
            val_12 = val_11;
            label_4:
            UnityEngine.Debug.Log(message:  val_12);
            return false;
            label_9:
            if((System.String.IsNullOrEmpty(value:  itemType)) == false)
            {
                goto label_13;
            }
            
            goto label_16;
            label_13:
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartLength(eventPart:  itemType, allowNull:  false)) == false)
            {
                goto label_17;
            }
            
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartCharacters(eventPart:  itemType)) == false)
            {
                goto label_18;
            }
            
            if((GameAnalyticsSDK.State.GAState.HasAvailableResourceItemType(_itemType:  itemType)) == false)
            {
                goto label_19;
            }
            
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartLength(eventPart:  val_11, allowNull:  false)) == false)
            {
                goto label_20;
            }
            
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartCharacters(eventPart:  val_11)) == false)
            {
                goto label_21;
            }
            
            return false;
            label_17:
            val_14 = "Validation fail - resource event - itemType: Cannot be (null), empty or above 64 characters. String: ";
            goto label_27;
            label_18:
            val_14 = "Validation fail - resource event - itemType: Cannot contain other characters than A-z, 0-9, -_., ()!?. String: ";
            goto label_27;
            label_19:
            val_14 = "Validation fail - resource event - itemType: Not found in list of pre-defined available resource itemTypes. String: ";
            goto label_27;
            label_20:
            val_15 = "Validation fail - resource event - itemId: Cannot be (null), empty or above 64 characters. String: ";
            goto label_27;
            label_21:
            val_15 = "Validation fail - resource event - itemId: Cannot contain other characters than A-z, 0-9, -_., ()!?. String: ";
            goto label_27;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateProgressionEvent(GameAnalyticsSDK.GAProgressionStatus progressionStatus, string progression01, string progression02, string progression03)
        {
            object val_16;
            string val_17;
            var val_18;
            var val_19;
            if(progressionStatus == 0)
            {
                goto label_1;
            }
            
            if((System.String.IsNullOrEmpty(value:  progression03)) != true)
            {
                    if((System.String.IsNullOrEmpty(value:  progression02)) != false)
            {
                    if((System.String.IsNullOrEmpty(value:  progression01)) == false)
            {
                goto label_24;
            }
            
            }
            
            }
            
            if(((System.String.IsNullOrEmpty(value:  progression02)) == true) || ((System.String.IsNullOrEmpty(value:  progression01)) == false))
            {
                goto label_6;
            }
            
            val_16 = "Validation fail - progression event: 02 found but not 01. Progression must be set as either 01, 01+02 or 01+02+03";
            goto label_24;
            label_6:
            if((System.String.IsNullOrEmpty(value:  progression01)) == false)
            {
                goto label_10;
            }
            
            val_16 = "Validation fail - progression event: progression01 not valid. Progressions must be set as either 01, 01+02 or 01+02+03";
            goto label_24;
            label_1:
            val_16 = "Validation fail - progression event: Invalid progression status.";
            label_24:
            label_27:
            UnityEngine.Debug.Log(message:  val_16);
            return false;
            label_10:
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartLength(eventPart:  progression01, allowNull:  false)) == false)
            {
                goto label_16;
            }
            
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartCharacters(eventPart:  progression01)) == false)
            {
                goto label_17;
            }
            
            if((System.String.IsNullOrEmpty(value:  progression02)) == false)
            {
                goto label_18;
            }
            
            label_29:
            if((System.String.IsNullOrEmpty(value:  progression03)) == false)
            {
                goto label_19;
            }
            
            return false;
            label_16:
            val_17 = "Validation fail - progression event - progression01: Cannot be (null), empty or above 64 characters. String: ";
            goto label_21;
            label_17:
            val_17 = "Validation fail - progression event - progression01: Cannot contain other characters than A-z, 0-9, -_., ()!?. String: ";
            label_21:
            label_35:
            string val_11 = val_17 + progression01;
            goto label_27;
            label_18:
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartLength(eventPart:  progression02, allowNull:  true)) == false)
            {
                goto label_28;
            }
            
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartCharacters(eventPart:  progression02)) == true)
            {
                goto label_29;
            }
            
            val_18 = "Validation fail - progression event - progression02: Cannot contain other characters than A-z, 0-9, -_., ()!?. String: ";
            goto label_35;
            label_19:
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartLength(eventPart:  progression03, allowNull:  true)) == false)
            {
                goto label_31;
            }
            
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartCharacters(eventPart:  progression03)) == true)
            {
                    return false;
            }
            
            val_19 = "Validation fail - progression event - progression03: Cannot contain other characters than A-z, 0-9, -_., ()!?. String: ";
            goto label_35;
            label_28:
            val_18 = "Validation fail - progression event - progression02: Cannot be empty or above 64 characters. String: ";
            goto label_35;
            label_31:
            val_19 = "Validation fail - progression event - progression03: Cannot be empty or above 64 characters. String: ";
            goto label_35;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateDesignEvent(string eventId)
        {
            string val_4;
            var val_5;
            string val_6;
            val_4 = eventId;
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventIdLength(eventId:  val_4)) == false)
            {
                goto label_1;
            }
            
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventIdCharacters(eventId:  val_4)) == false)
            {
                goto label_2;
            }
            
            val_5 = 1;
            return (bool)val_5;
            label_1:
            val_6 = "Validation fail - design event - eventId: Cannot be (null) or empty. Only 5 event parts allowed seperated by :. Each part need to be 32 characters or less. String: ";
            goto label_4;
            label_2:
            val_6 = "Validation fail - design event - eventId: Non valid characters. Only allowed A-z, 0-9, -_., ()!?. String: ";
            label_4:
            val_4 = val_6 + val_4;
            UnityEngine.Debug.Log(message:  val_4);
            val_5 = 0;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateErrorEvent(GameAnalyticsSDK.GAErrorSeverity severity, string message)
        {
            var val_2;
            object val_3;
            if(severity != 0)
            {
                    val_2 = 1;
                if((GameAnalyticsSDK.Validators.GAValidator.ValidateLongString(longString:  message, canBeEmpty:  true)) == true)
            {
                    return (bool)val_2;
            }
            
                val_3 = "Validation fail - error event - message: Message cannot be above 8192 characters.";
            }
            else
            {
                    val_3 = "Validation fail - error event - severity: Severity was unsupported value.";
            }
            
            UnityEngine.Debug.Log(message:  val_3);
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateAdEvent(GameAnalyticsSDK.GAAdAction adAction, GameAnalyticsSDK.GAAdType adType, string adSdkName, string adPlacement)
        {
            var val_3;
            object val_4;
            if(adAction == 0)
            {
                goto label_1;
            }
            
            if(adType == 0)
            {
                goto label_2;
            }
            
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateShortString(shortString:  adSdkName, canBeEmpty:  false)) == false)
            {
                goto label_3;
            }
            
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateString(s:  adPlacement, canBeEmpty:  false)) == false)
            {
                goto label_4;
            }
            
            val_3 = 1;
            return (bool)val_3;
            label_1:
            val_4 = "Validation fail - ad event - adAction: Ad action was unsupported value.";
            goto label_14;
            label_2:
            val_4 = "Validation fail - ad event - adType: Ad type was unsupported value.";
            goto label_14;
            label_3:
            val_4 = "Validation fail - ad event - message: Ad SDK name cannot be above 32 characters.";
            goto label_14;
            label_4:
            val_4 = "Validation fail - ad event - message: Ad placement cannot be above 64 characters.";
            label_14:
            UnityEngine.Debug.Log(message:  val_4);
            val_3 = 0;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateSdkErrorEvent(string gameKey, string gameSecret, GameAnalyticsSDK.GAErrorSeverity type)
        {
            var val_2;
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateKeys(gameKey:  gameKey, gameSecret:  gameSecret)) != false)
            {
                    if(type != 0)
            {
                    val_2 = 1;
                return (bool)val_2;
            }
            
                UnityEngine.Debug.Log(message:  "Validation fail - sdk error event - type: Type was unsupported value.");
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateKeys(string gameKey, string gameSecret)
        {
            var val_3;
            if((GameAnalyticsSDK.Validators.GAValidator.StringMatch(s:  gameKey, pattern:  "^[A-z0-9]{32}$")) != false)
            {
                    if((GameAnalyticsSDK.Validators.GAValidator.StringMatch(s:  gameSecret, pattern:  "^[A-z0-9]{40}$")) != false)
            {
                    val_3 = 1;
                return (bool)val_3;
            }
            
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateCurrency(string currency)
        {
            if((System.String.IsNullOrEmpty(value:  currency)) == false)
            {
                    return GameAnalyticsSDK.Validators.GAValidator.StringMatch(s:  currency, pattern:  "^[A-Z]{3}$");
            }
            
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateEventPartLength(string eventPart, bool allowNull)
        {
            var val_5;
            if(allowNull != false)
            {
                    if((System.String.IsNullOrEmpty(value:  eventPart)) != false)
            {
                    val_5 = 1;
                return (bool)(eventPart.Length < 65) ? 1 : 0;
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  eventPart)) == false)
            {
                    return (bool)(eventPart.Length < 65) ? 1 : 0;
            }
            
            val_5 = 0;
            return (bool)(eventPart.Length < 65) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateEventPartCharacters(string eventPart)
        {
            return GameAnalyticsSDK.Validators.GAValidator.StringMatch(s:  eventPart, pattern:  "^[A-Za-z0-9\\s\\-_\\.\\(\\)\\!\\?]{1,64}$");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateEventIdLength(string eventId)
        {
            if((System.String.IsNullOrEmpty(value:  eventId)) == false)
            {
                    return GameAnalyticsSDK.Validators.GAValidator.StringMatch(s:  eventId, pattern:  "^[^:]{1,64}(?::[^:]{1,64}){0,4}$");
            }
            
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateEventIdCharacters(string eventId)
        {
            if((System.String.IsNullOrEmpty(value:  eventId)) == false)
            {
                    return GameAnalyticsSDK.Validators.GAValidator.StringMatch(s:  eventId, pattern:  "^[A-Za-z0-9\\s\\-_\\.\\(\\)\\!\\?]{1,64}(:[A-Za-z0-9\\s\\-_\\.\\(\\)\\!\\?]{1,64}){0,4}$");
            }
            
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateBuild(string build)
        {
            return GameAnalyticsSDK.Validators.GAValidator.ValidateShortString(shortString:  build, canBeEmpty:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateUserId(string uId)
        {
            var val_2;
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateString(s:  uId, canBeEmpty:  false)) != false)
            {
                    val_2 = 1;
                return (bool)val_2;
            }
            
            UnityEngine.Debug.Log(message:  "Validation fail - user id: id cannot be (null), empty or above 64 characters.");
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateShortString(string shortString, bool canBeEmpty)
        {
            var val_5;
            if(canBeEmpty != false)
            {
                    if((System.String.IsNullOrEmpty(value:  shortString)) != false)
            {
                    val_5 = 1;
                return (bool)(shortString.Length < 33) ? 1 : 0;
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  shortString)) == false)
            {
                    return (bool)(shortString.Length < 33) ? 1 : 0;
            }
            
            val_5 = 0;
            return (bool)(shortString.Length < 33) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateString(string s, bool canBeEmpty)
        {
            var val_5;
            if(canBeEmpty != false)
            {
                    if((System.String.IsNullOrEmpty(value:  s)) != false)
            {
                    val_5 = 1;
                return (bool)(s.Length < 65) ? 1 : 0;
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  s)) == false)
            {
                    return (bool)(s.Length < 65) ? 1 : 0;
            }
            
            val_5 = 0;
            return (bool)(s.Length < 65) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateLongString(string longString, bool canBeEmpty)
        {
            var val_5;
            if(canBeEmpty != false)
            {
                    if((System.String.IsNullOrEmpty(value:  longString)) != false)
            {
                    val_5 = 1;
                return (bool)(longString.Length <= 8192) ? 1 : 0;
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  longString)) == false)
            {
                    return (bool)(longString.Length <= 8192) ? 1 : 0;
            }
            
            val_5 = 0;
            return (bool)(longString.Length <= 8192) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateConnectionType(string connectionType)
        {
            return GameAnalyticsSDK.Validators.GAValidator.StringMatch(s:  connectionType, pattern:  "^(wwan|wifi|lan|offline)$");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateCustomDimensions(string[] customDimensions)
        {
            return GameAnalyticsSDK.Validators.GAValidator.ValidateArrayOfStrings(maxCount:  20, maxStringLength:  32, allowNoValues:  false, logTag:  "custom dimensions", arrayOfStrings:  customDimensions);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateResourceCurrencies(string[] resourceCurrencies)
        {
            System.String[] val_4;
            var val_5;
            var val_6;
            val_4 = resourceCurrencies;
            val_5 = 0;
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateArrayOfStrings(maxCount:  20, maxStringLength:  64, allowNoValues:  false, logTag:  "resource currencies", arrayOfStrings:  val_4)) == false)
            {
                    return (bool)val_5;
            }
            
            val_6 = 0;
            label_5:
            if(val_6 >= resourceCurrencies.Length)
            {
                goto label_3;
            }
            
            string val_4 = val_4[0];
            val_6 = val_6 + 1;
            if((GameAnalyticsSDK.Validators.GAValidator.StringMatch(s:  val_4, pattern:  "^[A-Za-z]+$")) == true)
            {
                goto label_5;
            }
            
            val_4 = "resource currencies validation failed: a resource currency can only be A-Z, a-z. String was: "("resource currencies validation failed: a resource currency can only be A-Z, a-z. String was: ") + val_4;
            UnityEngine.Debug.Log(message:  val_4);
            val_5 = 0;
            return (bool)val_5;
            label_3:
            val_5 = 1;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateResourceItemTypes(string[] resourceItemTypes)
        {
            System.String[] val_4;
            var val_5;
            val_4 = resourceItemTypes;
            val_5 = 0;
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateArrayOfStrings(maxCount:  20, maxStringLength:  32, allowNoValues:  false, logTag:  "resource item types", arrayOfStrings:  val_4)) == false)
            {
                    return (bool)val_5;
            }
            
            var val_5 = 0;
            label_5:
            if(val_5 >= resourceItemTypes.Length)
            {
                goto label_3;
            }
            
            string val_4 = val_4[0];
            val_5 = val_5 + 1;
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateEventPartCharacters(eventPart:  val_4)) == true)
            {
                goto label_5;
            }
            
            val_4 = "resource item types validation failed: a resource item type cannot contain other characters than A-z, 0-9, -_., ()!?. String was: "("resource item types validation failed: a resource item type cannot contain other characters than A-z, 0-9, -_., ()!?. String was: ") + val_4;
            UnityEngine.Debug.Log(message:  val_4);
            val_5 = 0;
            return (bool)val_5;
            label_3:
            val_5 = 1;
            return (bool)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateDimension01(string dimension01)
        {
            string val_4;
            object val_5;
            var val_6;
            val_4 = dimension01;
            if((System.String.IsNullOrEmpty(value:  val_4)) != false)
            {
                    val_5 = "Validation failed - custom dimension01 - value cannot be empty.";
            }
            else
            {
                    if((GameAnalyticsSDK.State.GAState.HasAvailableCustomDimensions01(_dimension01:  val_4)) != false)
            {
                    val_6 = 1;
                return (bool)val_6;
            }
            
                val_4 = "Validation failed - custom dimension 01 - value was not found in list of custom dimensions 01 in the Settings object. \nGiven dimension value: "("Validation failed - custom dimension 01 - value was not found in list of custom dimensions 01 in the Settings object. \nGiven dimension value: ") + val_4;
                val_5 = val_4;
            }
            
            UnityEngine.Debug.Log(message:  val_5);
            val_6 = 0;
            return (bool)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateDimension02(string dimension02)
        {
            string val_4;
            object val_5;
            var val_6;
            val_4 = dimension02;
            if((System.String.IsNullOrEmpty(value:  val_4)) != false)
            {
                    val_5 = "Validation failed - custom dimension01 - value cannot be empty.";
            }
            else
            {
                    if((GameAnalyticsSDK.State.GAState.HasAvailableCustomDimensions02(_dimension02:  val_4)) != false)
            {
                    val_6 = 1;
                return (bool)val_6;
            }
            
                val_4 = "Validation failed - custom dimension 02 - value was not found in list of custom dimensions 02 in the Settings object. \nGiven dimension value: "("Validation failed - custom dimension 02 - value was not found in list of custom dimensions 02 in the Settings object. \nGiven dimension value: ") + val_4;
                val_5 = val_4;
            }
            
            UnityEngine.Debug.Log(message:  val_5);
            val_6 = 0;
            return (bool)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateDimension03(string dimension03)
        {
            string val_4;
            object val_5;
            var val_6;
            val_4 = dimension03;
            if((System.String.IsNullOrEmpty(value:  val_4)) != false)
            {
                    val_5 = "Validation failed - custom dimension01 - value cannot be empty.";
            }
            else
            {
                    if((GameAnalyticsSDK.State.GAState.HasAvailableCustomDimensions03(_dimension03:  val_4)) != false)
            {
                    val_6 = 1;
                return (bool)val_6;
            }
            
                val_4 = "Validation failed - custom dimension 03 - value was not found in list of custom dimensions 03 in the Settings object. \nGiven dimension value: "("Validation failed - custom dimension 03 - value was not found in list of custom dimensions 03 in the Settings object. \nGiven dimension value: ") + val_4;
                val_5 = val_4;
            }
            
            UnityEngine.Debug.Log(message:  val_5);
            val_6 = 0;
            return (bool)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateArrayOfStrings(long maxCount, long maxStringLength, bool allowNoValues, string logTag, string[] arrayOfStrings)
        {
            object val_8;
            long val_9;
            object val_10;
            System.Object[] val_11;
            string val_12;
            var val_13;
            val_8 = arrayOfStrings;
            val_9 = maxCount;
            object val_2 = ((System.String.IsNullOrEmpty(value:  logTag)) != true) ? "Array" : logTag;
            if(val_8 == null)
            {
                goto label_1;
            }
            
            if(allowNoValues != true)
            {
                    if(arrayOfStrings.Length == 0)
            {
                goto label_3;
            }
            
            }
            
            if((val_9 < 1) || ((long)arrayOfStrings.Length <= val_9))
            {
                goto label_5;
            }
            
            object[] val_3 = new object[6];
            val_3[0] = val_2;
            val_3[1] = " validation failed: array cannot exceed ";
            val_3[2] = val_9;
            val_10 = " values. It has ";
            val_3[3] = val_10;
            val_3[4] = arrayOfStrings.Length;
            val_11 = val_3;
            val_3[5] = " values.";
            goto label_25;
            label_1:
            val_12 = " validation failed: array cannot be null. ";
            goto label_35;
            label_5:
            if(arrayOfStrings.Length < 1)
            {
                goto label_27;
            }
            
            label_33:
            val_9 = 0;
            string val_9 = val_8[val_9];
            if(val_9 == null)
            {
                goto label_30;
            }
            
            int val_4 = val_9.Length;
            if(val_4 == 0)
            {
                goto label_30;
            }
            
            if(maxStringLength >= 1)
            {
                    if((long)val_4 > maxStringLength)
            {
                goto label_32;
            }
            
            }
            
            if((val_9 + 1) < arrayOfStrings.Length)
            {
                goto label_33;
            }
            
            label_27:
            val_13 = 1;
            return (bool)val_13;
            label_3:
            val_12 = " validation failed: array cannot be empty. ";
            goto label_35;
            label_30:
            val_12 = " validation failed: contained an empty string.";
            label_35:
            string val_6 = val_2 + val_12;
            goto label_36;
            label_32:
            object[] val_7 = new object[5];
            val_7[0] = val_2;
            val_7[1] = " validation failed: a string exceeded max allowed length (which is: ";
            val_7[2] = maxStringLength;
            val_10 = "). String was: ";
            val_7[3] = val_10;
            val_7[4] = val_9;
            val_11 = val_7;
            label_25:
            label_36:
            val_8 = +val_7;
            UnityEngine.Debug.Log(message:  val_8);
            val_13 = 0;
            return (bool)val_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateFacebookId(string facebookId)
        {
            var val_2;
            if((GameAnalyticsSDK.Validators.GAValidator.ValidateString(s:  facebookId, canBeEmpty:  false)) != false)
            {
                    val_2 = 1;
                return (bool)val_2;
            }
            
            UnityEngine.Debug.Log(message:  "Validation fail - facebook id: id cannot be (null), empty or above 64 characters.");
            val_2 = 0;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateGender(string gender)
        {
            string val_9;
            var val_10;
            string val_11;
            val_9 = gender;
            if((System.String.op_Equality(a:  val_9, b:  "")) == false)
            {
                goto label_1;
            }
            
            label_10:
            val_9 = "Validation fail - gender: Has to be \'male\' or \'female\'.Given gender:"("Validation fail - gender: Has to be \'male\' or \'female\'.Given gender:") + val_9;
            UnityEngine.Debug.Log(message:  val_9);
            val_10 = 0;
            return (bool)val_10;
            label_1:
            val_11 = 1.ToString();
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1});
            if((System.String.op_Equality(a:  val_9, b:  val_11)) == true)
            {
                goto label_7;
            }
            
            val_11 = 2.ToString();
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 2});
            if((System.String.op_Equality(a:  val_9, b:  val_11)) == false)
            {
                goto label_10;
            }
            
            label_7:
            val_10 = 1;
            return (bool)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateBirthyear(int birthYear)
        {
            var val_2;
            if((birthYear >> 4) >= 625)
            {
                    UnityEngine.Debug.Log(message:  "Validation fail - birthYear: Cannot be (null) or invalid range.");
                val_2 = 0;
                return (bool)val_2;
            }
            
            val_2 = 1;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool ValidateClientTs(long clientTs)
        {
            if(clientTs != (-9223372036854775808))
            {
                    return (bool)(clientTs != 9223372036854775807) ? 1 : 0;
            }
            
            return false;
        }
    
    }

}
