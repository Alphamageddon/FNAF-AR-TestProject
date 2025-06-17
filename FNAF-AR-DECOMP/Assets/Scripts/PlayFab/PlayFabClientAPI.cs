using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PlayFabClientAPI
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFabClientAPI()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsClientLoggedIn()
        {
            null = null;
            bool val_1 = System.String.IsNullOrEmpty(value:  PlayFab.PlayFabSettings.staticPlayer.ClientSessionTicket);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ForgetAllCredentials()
        {
            null = null;
            PlayFab.PlayFabSettings.staticPlayer.EntityType = 0;
            PlayFab.PlayFabSettings.staticPlayer.ClientSessionTicket = 0;
            PlayFab.PlayFabSettings.staticPlayer.EntityToken = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AcceptTrade(PlayFab.ClientModels.AcceptTradeRequest request, System.Action<PlayFab.ClientModels.AcceptTradeResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.AcceptTradeResponse>(apiEndpoint:  "/Client/AcceptTrade", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddFriend(PlayFab.ClientModels.AddFriendRequest request, System.Action<PlayFab.ClientModels.AddFriendResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.AddFriendResult>(apiEndpoint:  "/Client/AddFriend", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddGenericID(PlayFab.ClientModels.AddGenericIDRequest request, System.Action<PlayFab.ClientModels.AddGenericIDResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.AddGenericIDResult>(apiEndpoint:  "/Client/AddGenericID", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddOrUpdateContactEmail(PlayFab.ClientModels.AddOrUpdateContactEmailRequest request, System.Action<PlayFab.ClientModels.AddOrUpdateContactEmailResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.AddOrUpdateContactEmailResult>(apiEndpoint:  "/Client/AddOrUpdateContactEmail", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddSharedGroupMembers(PlayFab.ClientModels.AddSharedGroupMembersRequest request, System.Action<PlayFab.ClientModels.AddSharedGroupMembersResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.AddSharedGroupMembersResult>(apiEndpoint:  "/Client/AddSharedGroupMembers", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddUsernamePassword(PlayFab.ClientModels.AddUsernamePasswordRequest request, System.Action<PlayFab.ClientModels.AddUsernamePasswordResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.AddUsernamePasswordResult>(apiEndpoint:  "/Client/AddUsernamePassword", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AddUserVirtualCurrency(PlayFab.ClientModels.AddUserVirtualCurrencyRequest request, System.Action<PlayFab.ClientModels.ModifyUserVirtualCurrencyResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.ModifyUserVirtualCurrencyResult>(apiEndpoint:  "/Client/AddUserVirtualCurrency", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AndroidDevicePushNotificationRegistration(PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationRequest request, System.Action<PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationResult>(apiEndpoint:  "/Client/AndroidDevicePushNotificationRegistration", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void AttributeInstall(PlayFab.ClientModels.AttributeInstallRequest request, System.Action<PlayFab.ClientModels.AttributeInstallResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.AttributeInstallResult>(apiEndpoint:  "/Client/AttributeInstall", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CancelTrade(PlayFab.ClientModels.CancelTradeRequest request, System.Action<PlayFab.ClientModels.CancelTradeResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.CancelTradeResponse>(apiEndpoint:  "/Client/CancelTrade", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ConfirmPurchase(PlayFab.ClientModels.ConfirmPurchaseRequest request, System.Action<PlayFab.ClientModels.ConfirmPurchaseResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.ConfirmPurchaseResult>(apiEndpoint:  "/Client/ConfirmPurchase", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ConsumeItem(PlayFab.ClientModels.ConsumeItemRequest request, System.Action<PlayFab.ClientModels.ConsumeItemResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.ConsumeItemResult>(apiEndpoint:  "/Client/ConsumeItem", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ConsumePSNEntitlements(PlayFab.ClientModels.ConsumePSNEntitlementsRequest request, System.Action<PlayFab.ClientModels.ConsumePSNEntitlementsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.ConsumePSNEntitlementsResult>(apiEndpoint:  "/Client/ConsumePSNEntitlements", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ConsumeXboxEntitlements(PlayFab.ClientModels.ConsumeXboxEntitlementsRequest request, System.Action<PlayFab.ClientModels.ConsumeXboxEntitlementsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.ConsumeXboxEntitlementsResult>(apiEndpoint:  "/Client/ConsumeXboxEntitlements", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CreateSharedGroup(PlayFab.ClientModels.CreateSharedGroupRequest request, System.Action<PlayFab.ClientModels.CreateSharedGroupResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.CreateSharedGroupResult>(apiEndpoint:  "/Client/CreateSharedGroup", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ExecuteCloudScript(PlayFab.ClientModels.ExecuteCloudScriptRequest request, System.Action<PlayFab.ClientModels.ExecuteCloudScriptResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.ExecuteCloudScriptResult>(apiEndpoint:  "/Client/ExecuteCloudScript", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ExecuteCloudScript<TOut>(PlayFab.ClientModels.ExecuteCloudScriptRequest request, System.Action<PlayFab.ClientModels.ExecuteCloudScriptResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_4;
            var val_5;
            mem2[0] = resultCallback;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() == false)
            {
                goto label_5;
            }
            
            if(request != null)
            {
                    if(resultCallback != null)
            {
                goto label_7;
            }
            
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = PlayFab.PlayFabSettings.staticPlayer;
            label_7:
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.ExecuteCloudScriptResult>(apiEndpoint:  "/Client/ExecuteCloudScript", request:  request, authType:  2, resultCallback:  new System.Action<PlayFab.ClientModels.ExecuteCloudScriptResult>(object:  __RuntimeMethodHiddenParam + 48, method:  __RuntimeMethodHiddenParam + 48 + 16), errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_4, apiSettings:  0, instanceApi:  0);
            return;
            label_5:
            PlayFab.PlayFabException val_3 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetAccountInfo(PlayFab.ClientModels.GetAccountInfoRequest request, System.Action<PlayFab.ClientModels.GetAccountInfoResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetAccountInfoResult>(apiEndpoint:  "/Client/GetAccountInfo", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetAllUsersCharacters(PlayFab.ClientModels.ListUsersCharactersRequest request, System.Action<PlayFab.ClientModels.ListUsersCharactersResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<System.Object>(apiEndpoint:  "/Client/GetAllUsersCharacters", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetCatalogItems(PlayFab.ClientModels.GetCatalogItemsRequest request, System.Action<PlayFab.ClientModels.GetCatalogItemsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetCatalogItemsResult>(apiEndpoint:  "/Client/GetCatalogItems", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetCharacterData(PlayFab.ClientModels.GetCharacterDataRequest request, System.Action<PlayFab.ClientModels.GetCharacterDataResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetCharacterDataResult>(apiEndpoint:  "/Client/GetCharacterData", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetCharacterInventory(PlayFab.ClientModels.GetCharacterInventoryRequest request, System.Action<PlayFab.ClientModels.GetCharacterInventoryResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetCharacterInventoryResult>(apiEndpoint:  "/Client/GetCharacterInventory", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetCharacterLeaderboard(PlayFab.ClientModels.GetCharacterLeaderboardRequest request, System.Action<PlayFab.ClientModels.GetCharacterLeaderboardResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetCharacterLeaderboardResult>(apiEndpoint:  "/Client/GetCharacterLeaderboard", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetCharacterReadOnlyData(PlayFab.ClientModels.GetCharacterDataRequest request, System.Action<PlayFab.ClientModels.GetCharacterDataResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetCharacterDataResult>(apiEndpoint:  "/Client/GetCharacterReadOnlyData", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetCharacterStatistics(PlayFab.ClientModels.GetCharacterStatisticsRequest request, System.Action<PlayFab.ClientModels.GetCharacterStatisticsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetCharacterStatisticsResult>(apiEndpoint:  "/Client/GetCharacterStatistics", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetContentDownloadUrl(PlayFab.ClientModels.GetContentDownloadUrlRequest request, System.Action<PlayFab.ClientModels.GetContentDownloadUrlResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetContentDownloadUrlResult>(apiEndpoint:  "/Client/GetContentDownloadUrl", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetCurrentGames(PlayFab.ClientModels.CurrentGamesRequest request, System.Action<PlayFab.ClientModels.CurrentGamesResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.CurrentGamesResult>(apiEndpoint:  "/Client/GetCurrentGames", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetFriendLeaderboard(PlayFab.ClientModels.GetFriendLeaderboardRequest request, System.Action<PlayFab.ClientModels.GetLeaderboardResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetLeaderboardResult>(apiEndpoint:  "/Client/GetFriendLeaderboard", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetFriendLeaderboardAroundPlayer(PlayFab.ClientModels.GetFriendLeaderboardAroundPlayerRequest request, System.Action<PlayFab.ClientModels.GetFriendLeaderboardAroundPlayerResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetFriendLeaderboardAroundPlayerResult>(apiEndpoint:  "/Client/GetFriendLeaderboardAroundPlayer", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetFriendsList(PlayFab.ClientModels.GetFriendsListRequest request, System.Action<PlayFab.ClientModels.GetFriendsListResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetFriendsListResult>(apiEndpoint:  "/Client/GetFriendsList", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetGameServerRegions(PlayFab.ClientModels.GameServerRegionsRequest request, System.Action<PlayFab.ClientModels.GameServerRegionsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GameServerRegionsResult>(apiEndpoint:  "/Client/GetGameServerRegions", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetLeaderboard(PlayFab.ClientModels.GetLeaderboardRequest request, System.Action<PlayFab.ClientModels.GetLeaderboardResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetLeaderboardResult>(apiEndpoint:  "/Client/GetLeaderboard", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetLeaderboardAroundCharacter(PlayFab.ClientModels.GetLeaderboardAroundCharacterRequest request, System.Action<PlayFab.ClientModels.GetLeaderboardAroundCharacterResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetLeaderboardAroundCharacterResult>(apiEndpoint:  "/Client/GetLeaderboardAroundCharacter", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetLeaderboardAroundPlayer(PlayFab.ClientModels.GetLeaderboardAroundPlayerRequest request, System.Action<PlayFab.ClientModels.GetLeaderboardAroundPlayerResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetLeaderboardAroundPlayerResult>(apiEndpoint:  "/Client/GetLeaderboardAroundPlayer", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetLeaderboardForUserCharacters(PlayFab.ClientModels.GetLeaderboardForUsersCharactersRequest request, System.Action<PlayFab.ClientModels.GetLeaderboardForUsersCharactersResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetLeaderboardForUsersCharactersResult>(apiEndpoint:  "/Client/GetLeaderboardForUserCharacters", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPaymentToken(PlayFab.ClientModels.GetPaymentTokenRequest request, System.Action<PlayFab.ClientModels.GetPaymentTokenResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPaymentTokenResult>(apiEndpoint:  "/Client/GetPaymentToken", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPhotonAuthenticationToken(PlayFab.ClientModels.GetPhotonAuthenticationTokenRequest request, System.Action<PlayFab.ClientModels.GetPhotonAuthenticationTokenResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPhotonAuthenticationTokenResult>(apiEndpoint:  "/Client/GetPhotonAuthenticationToken", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayerCombinedInfo(PlayFab.ClientModels.GetPlayerCombinedInfoRequest request, System.Action<PlayFab.ClientModels.GetPlayerCombinedInfoResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayerCombinedInfoResult>(apiEndpoint:  "/Client/GetPlayerCombinedInfo", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayerProfile(PlayFab.ClientModels.GetPlayerProfileRequest request, System.Action<PlayFab.ClientModels.GetPlayerProfileResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayerProfileResult>(apiEndpoint:  "/Client/GetPlayerProfile", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayerSegments(PlayFab.ClientModels.GetPlayerSegmentsRequest request, System.Action<PlayFab.ClientModels.GetPlayerSegmentsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayerSegmentsResult>(apiEndpoint:  "/Client/GetPlayerSegments", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayerStatistics(PlayFab.ClientModels.GetPlayerStatisticsRequest request, System.Action<PlayFab.ClientModels.GetPlayerStatisticsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayerStatisticsResult>(apiEndpoint:  "/Client/GetPlayerStatistics", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayerStatisticVersions(PlayFab.ClientModels.GetPlayerStatisticVersionsRequest request, System.Action<PlayFab.ClientModels.GetPlayerStatisticVersionsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayerStatisticVersionsResult>(apiEndpoint:  "/Client/GetPlayerStatisticVersions", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayerTags(PlayFab.ClientModels.GetPlayerTagsRequest request, System.Action<PlayFab.ClientModels.GetPlayerTagsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayerTagsResult>(apiEndpoint:  "/Client/GetPlayerTags", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayerTrades(PlayFab.ClientModels.GetPlayerTradesRequest request, System.Action<PlayFab.ClientModels.GetPlayerTradesResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayerTradesResponse>(apiEndpoint:  "/Client/GetPlayerTrades", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayFabIDsFromFacebookIDs(PlayFab.ClientModels.GetPlayFabIDsFromFacebookIDsRequest request, System.Action<PlayFab.ClientModels.GetPlayFabIDsFromFacebookIDsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayFabIDsFromFacebookIDsResult>(apiEndpoint:  "/Client/GetPlayFabIDsFromFacebookIDs", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayFabIDsFromFacebookInstantGamesIds(PlayFab.ClientModels.GetPlayFabIDsFromFacebookInstantGamesIdsRequest request, System.Action<PlayFab.ClientModels.GetPlayFabIDsFromFacebookInstantGamesIdsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayFabIDsFromFacebookInstantGamesIdsResult>(apiEndpoint:  "/Client/GetPlayFabIDsFromFacebookInstantGamesIds", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayFabIDsFromGameCenterIDs(PlayFab.ClientModels.GetPlayFabIDsFromGameCenterIDsRequest request, System.Action<PlayFab.ClientModels.GetPlayFabIDsFromGameCenterIDsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayFabIDsFromGameCenterIDsResult>(apiEndpoint:  "/Client/GetPlayFabIDsFromGameCenterIDs", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayFabIDsFromGenericIDs(PlayFab.ClientModels.GetPlayFabIDsFromGenericIDsRequest request, System.Action<PlayFab.ClientModels.GetPlayFabIDsFromGenericIDsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayFabIDsFromGenericIDsResult>(apiEndpoint:  "/Client/GetPlayFabIDsFromGenericIDs", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayFabIDsFromGoogleIDs(PlayFab.ClientModels.GetPlayFabIDsFromGoogleIDsRequest request, System.Action<PlayFab.ClientModels.GetPlayFabIDsFromGoogleIDsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayFabIDsFromGoogleIDsResult>(apiEndpoint:  "/Client/GetPlayFabIDsFromGoogleIDs", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayFabIDsFromKongregateIDs(PlayFab.ClientModels.GetPlayFabIDsFromKongregateIDsRequest request, System.Action<PlayFab.ClientModels.GetPlayFabIDsFromKongregateIDsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayFabIDsFromKongregateIDsResult>(apiEndpoint:  "/Client/GetPlayFabIDsFromKongregateIDs", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayFabIDsFromNintendoSwitchDeviceIds(PlayFab.ClientModels.GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest request, System.Action<PlayFab.ClientModels.GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>(apiEndpoint:  "/Client/GetPlayFabIDsFromNintendoSwitchDeviceIds", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayFabIDsFromPSNAccountIDs(PlayFab.ClientModels.GetPlayFabIDsFromPSNAccountIDsRequest request, System.Action<PlayFab.ClientModels.GetPlayFabIDsFromPSNAccountIDsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayFabIDsFromPSNAccountIDsResult>(apiEndpoint:  "/Client/GetPlayFabIDsFromPSNAccountIDs", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayFabIDsFromSteamIDs(PlayFab.ClientModels.GetPlayFabIDsFromSteamIDsRequest request, System.Action<PlayFab.ClientModels.GetPlayFabIDsFromSteamIDsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayFabIDsFromSteamIDsResult>(apiEndpoint:  "/Client/GetPlayFabIDsFromSteamIDs", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayFabIDsFromTwitchIDs(PlayFab.ClientModels.GetPlayFabIDsFromTwitchIDsRequest request, System.Action<PlayFab.ClientModels.GetPlayFabIDsFromTwitchIDsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayFabIDsFromTwitchIDsResult>(apiEndpoint:  "/Client/GetPlayFabIDsFromTwitchIDs", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPlayFabIDsFromXboxLiveIDs(PlayFab.ClientModels.GetPlayFabIDsFromXboxLiveIDsRequest request, System.Action<PlayFab.ClientModels.GetPlayFabIDsFromXboxLiveIDsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPlayFabIDsFromXboxLiveIDsResult>(apiEndpoint:  "/Client/GetPlayFabIDsFromXboxLiveIDs", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPublisherData(PlayFab.ClientModels.GetPublisherDataRequest request, System.Action<PlayFab.ClientModels.GetPublisherDataResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPublisherDataResult>(apiEndpoint:  "/Client/GetPublisherData", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPurchase(PlayFab.ClientModels.GetPurchaseRequest request, System.Action<PlayFab.ClientModels.GetPurchaseResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetPurchaseResult>(apiEndpoint:  "/Client/GetPurchase", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetSharedGroupData(PlayFab.ClientModels.GetSharedGroupDataRequest request, System.Action<PlayFab.ClientModels.GetSharedGroupDataResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetSharedGroupDataResult>(apiEndpoint:  "/Client/GetSharedGroupData", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetStoreItems(PlayFab.ClientModels.GetStoreItemsRequest request, System.Action<PlayFab.ClientModels.GetStoreItemsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetStoreItemsResult>(apiEndpoint:  "/Client/GetStoreItems", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetTime(PlayFab.ClientModels.GetTimeRequest request, System.Action<PlayFab.ClientModels.GetTimeResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetTimeResult>(apiEndpoint:  "/Client/GetTime", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetTitleData(PlayFab.ClientModels.GetTitleDataRequest request, System.Action<PlayFab.ClientModels.GetTitleDataResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetTitleDataResult>(apiEndpoint:  "/Client/GetTitleData", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetTitleNews(PlayFab.ClientModels.GetTitleNewsRequest request, System.Action<PlayFab.ClientModels.GetTitleNewsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetTitleNewsResult>(apiEndpoint:  "/Client/GetTitleNews", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetTitlePublicKey(PlayFab.ClientModels.GetTitlePublicKeyRequest request, System.Action<PlayFab.ClientModels.GetTitlePublicKeyResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_1;
            var val_2;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_2 = null;
            val_2 = null;
            val_1 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetTitlePublicKeyResult>(apiEndpoint:  "/Client/GetTitlePublicKey", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetTradeStatus(PlayFab.ClientModels.GetTradeStatusRequest request, System.Action<PlayFab.ClientModels.GetTradeStatusResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetTradeStatusResponse>(apiEndpoint:  "/Client/GetTradeStatus", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetUserData(PlayFab.ClientModels.GetUserDataRequest request, System.Action<PlayFab.ClientModels.GetUserDataResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetUserDataResult>(apiEndpoint:  "/Client/GetUserData", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetUserInventory(PlayFab.ClientModels.GetUserInventoryRequest request, System.Action<PlayFab.ClientModels.GetUserInventoryResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetUserInventoryResult>(apiEndpoint:  "/Client/GetUserInventory", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetUserPublisherData(PlayFab.ClientModels.GetUserDataRequest request, System.Action<PlayFab.ClientModels.GetUserDataResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetUserDataResult>(apiEndpoint:  "/Client/GetUserPublisherData", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetUserPublisherReadOnlyData(PlayFab.ClientModels.GetUserDataRequest request, System.Action<PlayFab.ClientModels.GetUserDataResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetUserDataResult>(apiEndpoint:  "/Client/GetUserPublisherReadOnlyData", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetUserReadOnlyData(PlayFab.ClientModels.GetUserDataRequest request, System.Action<PlayFab.ClientModels.GetUserDataResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetUserDataResult>(apiEndpoint:  "/Client/GetUserReadOnlyData", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetWindowsHelloChallenge(PlayFab.ClientModels.GetWindowsHelloChallengeRequest request, System.Action<PlayFab.ClientModels.GetWindowsHelloChallengeResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_1;
            var val_2;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_2 = null;
            val_2 = null;
            val_1 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GetWindowsHelloChallengeResponse>(apiEndpoint:  "/Client/GetWindowsHelloChallenge", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GrantCharacterToUser(PlayFab.ClientModels.GrantCharacterToUserRequest request, System.Action<PlayFab.ClientModels.GrantCharacterToUserResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.GrantCharacterToUserResult>(apiEndpoint:  "/Client/GrantCharacterToUser", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkAndroidDeviceID(PlayFab.ClientModels.LinkAndroidDeviceIDRequest request, System.Action<PlayFab.ClientModels.LinkAndroidDeviceIDResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LinkAndroidDeviceIDResult>(apiEndpoint:  "/Client/LinkAndroidDeviceID", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkCustomID(PlayFab.ClientModels.LinkCustomIDRequest request, System.Action<PlayFab.ClientModels.LinkCustomIDResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LinkCustomIDResult>(apiEndpoint:  "/Client/LinkCustomID", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkFacebookAccount(PlayFab.ClientModels.LinkFacebookAccountRequest request, System.Action<PlayFab.ClientModels.LinkFacebookAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LinkFacebookAccountResult>(apiEndpoint:  "/Client/LinkFacebookAccount", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkFacebookInstantGamesId(PlayFab.ClientModels.LinkFacebookInstantGamesIdRequest request, System.Action<PlayFab.ClientModels.LinkFacebookInstantGamesIdResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LinkFacebookInstantGamesIdResult>(apiEndpoint:  "/Client/LinkFacebookInstantGamesId", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkGameCenterAccount(PlayFab.ClientModels.LinkGameCenterAccountRequest request, System.Action<PlayFab.ClientModels.LinkGameCenterAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LinkGameCenterAccountResult>(apiEndpoint:  "/Client/LinkGameCenterAccount", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkGoogleAccount(PlayFab.ClientModels.LinkGoogleAccountRequest request, System.Action<PlayFab.ClientModels.LinkGoogleAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LinkGoogleAccountResult>(apiEndpoint:  "/Client/LinkGoogleAccount", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkIOSDeviceID(PlayFab.ClientModels.LinkIOSDeviceIDRequest request, System.Action<PlayFab.ClientModels.LinkIOSDeviceIDResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LinkIOSDeviceIDResult>(apiEndpoint:  "/Client/LinkIOSDeviceID", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkKongregate(PlayFab.ClientModels.LinkKongregateAccountRequest request, System.Action<PlayFab.ClientModels.LinkKongregateAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LinkKongregateAccountResult>(apiEndpoint:  "/Client/LinkKongregate", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkNintendoSwitchDeviceId(PlayFab.ClientModels.LinkNintendoSwitchDeviceIdRequest request, System.Action<PlayFab.ClientModels.LinkNintendoSwitchDeviceIdResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LinkNintendoSwitchDeviceIdResult>(apiEndpoint:  "/Client/LinkNintendoSwitchDeviceId", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkOpenIdConnect(PlayFab.ClientModels.LinkOpenIdConnectRequest request, System.Action<PlayFab.ClientModels.EmptyResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.EmptyResult>(apiEndpoint:  "/Client/LinkOpenIdConnect", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkPSNAccount(PlayFab.ClientModels.LinkPSNAccountRequest request, System.Action<PlayFab.ClientModels.LinkPSNAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LinkPSNAccountResult>(apiEndpoint:  "/Client/LinkPSNAccount", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkSteamAccount(PlayFab.ClientModels.LinkSteamAccountRequest request, System.Action<PlayFab.ClientModels.LinkSteamAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LinkSteamAccountResult>(apiEndpoint:  "/Client/LinkSteamAccount", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkTwitch(PlayFab.ClientModels.LinkTwitchAccountRequest request, System.Action<PlayFab.ClientModels.LinkTwitchAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LinkTwitchAccountResult>(apiEndpoint:  "/Client/LinkTwitch", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkWindowsHello(PlayFab.ClientModels.LinkWindowsHelloAccountRequest request, System.Action<PlayFab.ClientModels.LinkWindowsHelloAccountResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LinkWindowsHelloAccountResponse>(apiEndpoint:  "/Client/LinkWindowsHello", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LinkXboxAccount(PlayFab.ClientModels.LinkXboxAccountRequest request, System.Action<PlayFab.ClientModels.LinkXboxAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LinkXboxAccountResult>(apiEndpoint:  "/Client/LinkXboxAccount", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithAndroidDeviceID(PlayFab.ClientModels.LoginWithAndroidDeviceIDRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithAndroidDeviceID", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithCustomID(PlayFab.ClientModels.LoginWithCustomIDRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithCustomID", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithEmailAddress(PlayFab.ClientModels.LoginWithEmailAddressRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithEmailAddress", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithFacebook(PlayFab.ClientModels.LoginWithFacebookRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithFacebook", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithFacebookInstantGamesId(PlayFab.ClientModels.LoginWithFacebookInstantGamesIdRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithFacebookInstantGamesId", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithGameCenter(PlayFab.ClientModels.LoginWithGameCenterRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithGameCenter", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithGoogleAccount(PlayFab.ClientModels.LoginWithGoogleAccountRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithGoogleAccount", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithIOSDeviceID(PlayFab.ClientModels.LoginWithIOSDeviceIDRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithIOSDeviceID", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithKongregate(PlayFab.ClientModels.LoginWithKongregateRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithKongregate", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithNintendoSwitchDeviceId(PlayFab.ClientModels.LoginWithNintendoSwitchDeviceIdRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithNintendoSwitchDeviceId", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithOpenIdConnect(PlayFab.ClientModels.LoginWithOpenIdConnectRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithOpenIdConnect", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithPlayFab(PlayFab.ClientModels.LoginWithPlayFabRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithPlayFab", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithPSN(PlayFab.ClientModels.LoginWithPSNRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithPSN", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithSteam(PlayFab.ClientModels.LoginWithSteamRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithSteam", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithTwitch(PlayFab.ClientModels.LoginWithTwitchRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithTwitch", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithWindowsHello(PlayFab.ClientModels.LoginWithWindowsHelloRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithWindowsHello", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LoginWithXbox(PlayFab.ClientModels.LoginWithXboxRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/LoginWithXbox", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Matchmake(PlayFab.ClientModels.MatchmakeRequest request, System.Action<PlayFab.ClientModels.MatchmakeResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.MatchmakeResult>(apiEndpoint:  "/Client/Matchmake", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void OpenTrade(PlayFab.ClientModels.OpenTradeRequest request, System.Action<PlayFab.ClientModels.OpenTradeResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.OpenTradeResponse>(apiEndpoint:  "/Client/OpenTrade", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void PayForPurchase(PlayFab.ClientModels.PayForPurchaseRequest request, System.Action<PlayFab.ClientModels.PayForPurchaseResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.PayForPurchaseResult>(apiEndpoint:  "/Client/PayForPurchase", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void PurchaseItem(PlayFab.ClientModels.PurchaseItemRequest request, System.Action<PlayFab.ClientModels.PurchaseItemResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.PurchaseItemResult>(apiEndpoint:  "/Client/PurchaseItem", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RedeemCoupon(PlayFab.ClientModels.RedeemCouponRequest request, System.Action<PlayFab.ClientModels.RedeemCouponResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.RedeemCouponResult>(apiEndpoint:  "/Client/RedeemCoupon", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RefreshPSNAuthToken(PlayFab.ClientModels.RefreshPSNAuthTokenRequest request, System.Action<PlayFab.ClientModels.EmptyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.EmptyResponse>(apiEndpoint:  "/Client/RefreshPSNAuthToken", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RegisterForIOSPushNotification(PlayFab.ClientModels.RegisterForIOSPushNotificationRequest request, System.Action<PlayFab.ClientModels.RegisterForIOSPushNotificationResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.RegisterForIOSPushNotificationResult>(apiEndpoint:  "/Client/RegisterForIOSPushNotification", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RegisterPlayFabUser(PlayFab.ClientModels.RegisterPlayFabUserRequest request, System.Action<PlayFab.ClientModels.RegisterPlayFabUserResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.RegisterPlayFabUserResult>(apiEndpoint:  "/Client/RegisterPlayFabUser", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RegisterWithWindowsHello(PlayFab.ClientModels.RegisterWithWindowsHelloRequest request, System.Action<PlayFab.ClientModels.LoginResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_2;
            var val_3;
            string val_4;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_5;
            }
            
            }
            
            val_3 = null;
            val_3 = null;
            val_2 = PlayFab.PlayFabSettings.staticPlayer;
            label_5:
            val_4 = request.TitleId;
            request.TitleId = PlayFab.PlayFabSettings.TitleId;
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.LoginResult>(apiEndpoint:  "/Client/RegisterWithWindowsHello", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_2, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RemoveContactEmail(PlayFab.ClientModels.RemoveContactEmailRequest request, System.Action<PlayFab.ClientModels.RemoveContactEmailResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.RemoveContactEmailResult>(apiEndpoint:  "/Client/RemoveContactEmail", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RemoveFriend(PlayFab.ClientModels.RemoveFriendRequest request, System.Action<PlayFab.ClientModels.RemoveFriendResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.RemoveFriendResult>(apiEndpoint:  "/Client/RemoveFriend", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RemoveGenericID(PlayFab.ClientModels.RemoveGenericIDRequest request, System.Action<PlayFab.ClientModels.RemoveGenericIDResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.RemoveGenericIDResult>(apiEndpoint:  "/Client/RemoveGenericID", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RemoveSharedGroupMembers(PlayFab.ClientModels.RemoveSharedGroupMembersRequest request, System.Action<PlayFab.ClientModels.RemoveSharedGroupMembersResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.RemoveSharedGroupMembersResult>(apiEndpoint:  "/Client/RemoveSharedGroupMembers", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ReportDeviceInfo(PlayFab.ClientModels.DeviceInfoRequest request, System.Action<PlayFab.ClientModels.EmptyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.EmptyResponse>(apiEndpoint:  "/Client/ReportDeviceInfo", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ReportPlayer(PlayFab.ClientModels.ReportPlayerClientRequest request, System.Action<PlayFab.ClientModels.ReportPlayerClientResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.ReportPlayerClientResult>(apiEndpoint:  "/Client/ReportPlayer", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RestoreIOSPurchases(PlayFab.ClientModels.RestoreIOSPurchasesRequest request, System.Action<PlayFab.ClientModels.RestoreIOSPurchasesResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.RestoreIOSPurchasesResult>(apiEndpoint:  "/Client/RestoreIOSPurchases", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SendAccountRecoveryEmail(PlayFab.ClientModels.SendAccountRecoveryEmailRequest request, System.Action<PlayFab.ClientModels.SendAccountRecoveryEmailResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_1;
            var val_2;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_2 = null;
            val_2 = null;
            val_1 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.SendAccountRecoveryEmailResult>(apiEndpoint:  "/Client/SendAccountRecoveryEmail", request:  request, authType:  0, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_1, apiSettings:  0, instanceApi:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetFriendTags(PlayFab.ClientModels.SetFriendTagsRequest request, System.Action<PlayFab.ClientModels.SetFriendTagsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.SetFriendTagsResult>(apiEndpoint:  "/Client/SetFriendTags", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetPlayerSecret(PlayFab.ClientModels.SetPlayerSecretRequest request, System.Action<PlayFab.ClientModels.SetPlayerSecretResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.SetPlayerSecretResult>(apiEndpoint:  "/Client/SetPlayerSecret", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartGame(PlayFab.ClientModels.StartGameRequest request, System.Action<PlayFab.ClientModels.StartGameResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.StartGameResult>(apiEndpoint:  "/Client/StartGame", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartPurchase(PlayFab.ClientModels.StartPurchaseRequest request, System.Action<PlayFab.ClientModels.StartPurchaseResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.StartPurchaseResult>(apiEndpoint:  "/Client/StartPurchase", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SubtractUserVirtualCurrency(PlayFab.ClientModels.SubtractUserVirtualCurrencyRequest request, System.Action<PlayFab.ClientModels.ModifyUserVirtualCurrencyResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.ModifyUserVirtualCurrencyResult>(apiEndpoint:  "/Client/SubtractUserVirtualCurrency", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkAndroidDeviceID(PlayFab.ClientModels.UnlinkAndroidDeviceIDRequest request, System.Action<PlayFab.ClientModels.UnlinkAndroidDeviceIDResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlinkAndroidDeviceIDResult>(apiEndpoint:  "/Client/UnlinkAndroidDeviceID", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkCustomID(PlayFab.ClientModels.UnlinkCustomIDRequest request, System.Action<PlayFab.ClientModels.UnlinkCustomIDResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlinkCustomIDResult>(apiEndpoint:  "/Client/UnlinkCustomID", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkFacebookAccount(PlayFab.ClientModels.UnlinkFacebookAccountRequest request, System.Action<PlayFab.ClientModels.UnlinkFacebookAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlinkFacebookAccountResult>(apiEndpoint:  "/Client/UnlinkFacebookAccount", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkFacebookInstantGamesId(PlayFab.ClientModels.UnlinkFacebookInstantGamesIdRequest request, System.Action<PlayFab.ClientModels.UnlinkFacebookInstantGamesIdResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlinkFacebookInstantGamesIdResult>(apiEndpoint:  "/Client/UnlinkFacebookInstantGamesId", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkGameCenterAccount(PlayFab.ClientModels.UnlinkGameCenterAccountRequest request, System.Action<PlayFab.ClientModels.UnlinkGameCenterAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlinkGameCenterAccountResult>(apiEndpoint:  "/Client/UnlinkGameCenterAccount", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkGoogleAccount(PlayFab.ClientModels.UnlinkGoogleAccountRequest request, System.Action<PlayFab.ClientModels.UnlinkGoogleAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlinkGoogleAccountResult>(apiEndpoint:  "/Client/UnlinkGoogleAccount", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkIOSDeviceID(PlayFab.ClientModels.UnlinkIOSDeviceIDRequest request, System.Action<PlayFab.ClientModels.UnlinkIOSDeviceIDResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlinkIOSDeviceIDResult>(apiEndpoint:  "/Client/UnlinkIOSDeviceID", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkKongregate(PlayFab.ClientModels.UnlinkKongregateAccountRequest request, System.Action<PlayFab.ClientModels.UnlinkKongregateAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlinkKongregateAccountResult>(apiEndpoint:  "/Client/UnlinkKongregate", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkNintendoSwitchDeviceId(PlayFab.ClientModels.UnlinkNintendoSwitchDeviceIdRequest request, System.Action<PlayFab.ClientModels.UnlinkNintendoSwitchDeviceIdResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlinkNintendoSwitchDeviceIdResult>(apiEndpoint:  "/Client/UnlinkNintendoSwitchDeviceId", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkOpenIdConnect(PlayFab.ClientModels.UninkOpenIdConnectRequest request, System.Action<PlayFab.ClientModels.EmptyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.EmptyResponse>(apiEndpoint:  "/Client/UnlinkOpenIdConnect", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkPSNAccount(PlayFab.ClientModels.UnlinkPSNAccountRequest request, System.Action<PlayFab.ClientModels.UnlinkPSNAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlinkPSNAccountResult>(apiEndpoint:  "/Client/UnlinkPSNAccount", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkSteamAccount(PlayFab.ClientModels.UnlinkSteamAccountRequest request, System.Action<PlayFab.ClientModels.UnlinkSteamAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlinkSteamAccountResult>(apiEndpoint:  "/Client/UnlinkSteamAccount", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkTwitch(PlayFab.ClientModels.UnlinkTwitchAccountRequest request, System.Action<PlayFab.ClientModels.UnlinkTwitchAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlinkTwitchAccountResult>(apiEndpoint:  "/Client/UnlinkTwitch", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkWindowsHello(PlayFab.ClientModels.UnlinkWindowsHelloAccountRequest request, System.Action<PlayFab.ClientModels.UnlinkWindowsHelloAccountResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlinkWindowsHelloAccountResponse>(apiEndpoint:  "/Client/UnlinkWindowsHello", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlinkXboxAccount(PlayFab.ClientModels.UnlinkXboxAccountRequest request, System.Action<PlayFab.ClientModels.UnlinkXboxAccountResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlinkXboxAccountResult>(apiEndpoint:  "/Client/UnlinkXboxAccount", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlockContainerInstance(PlayFab.ClientModels.UnlockContainerInstanceRequest request, System.Action<PlayFab.ClientModels.UnlockContainerItemResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlockContainerItemResult>(apiEndpoint:  "/Client/UnlockContainerInstance", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UnlockContainerItem(PlayFab.ClientModels.UnlockContainerItemRequest request, System.Action<PlayFab.ClientModels.UnlockContainerItemResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UnlockContainerItemResult>(apiEndpoint:  "/Client/UnlockContainerItem", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UpdateAvatarUrl(PlayFab.ClientModels.UpdateAvatarUrlRequest request, System.Action<PlayFab.ClientModels.EmptyResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.EmptyResponse>(apiEndpoint:  "/Client/UpdateAvatarUrl", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UpdateCharacterData(PlayFab.ClientModels.UpdateCharacterDataRequest request, System.Action<PlayFab.ClientModels.UpdateCharacterDataResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UpdateCharacterDataResult>(apiEndpoint:  "/Client/UpdateCharacterData", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UpdateCharacterStatistics(PlayFab.ClientModels.UpdateCharacterStatisticsRequest request, System.Action<PlayFab.ClientModels.UpdateCharacterStatisticsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UpdateCharacterStatisticsResult>(apiEndpoint:  "/Client/UpdateCharacterStatistics", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UpdatePlayerStatistics(PlayFab.ClientModels.UpdatePlayerStatisticsRequest request, System.Action<PlayFab.ClientModels.UpdatePlayerStatisticsResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UpdatePlayerStatisticsResult>(apiEndpoint:  "/Client/UpdatePlayerStatistics", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UpdateSharedGroupData(PlayFab.ClientModels.UpdateSharedGroupDataRequest request, System.Action<PlayFab.ClientModels.UpdateSharedGroupDataResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UpdateSharedGroupDataResult>(apiEndpoint:  "/Client/UpdateSharedGroupData", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UpdateUserData(PlayFab.ClientModels.UpdateUserDataRequest request, System.Action<PlayFab.ClientModels.UpdateUserDataResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UpdateUserDataResult>(apiEndpoint:  "/Client/UpdateUserData", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UpdateUserPublisherData(PlayFab.ClientModels.UpdateUserDataRequest request, System.Action<PlayFab.ClientModels.UpdateUserDataResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UpdateUserDataResult>(apiEndpoint:  "/Client/UpdateUserPublisherData", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void UpdateUserTitleDisplayName(PlayFab.ClientModels.UpdateUserTitleDisplayNameRequest request, System.Action<PlayFab.ClientModels.UpdateUserTitleDisplayNameResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.UpdateUserTitleDisplayNameResult>(apiEndpoint:  "/Client/UpdateUserTitleDisplayName", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ValidateAmazonIAPReceipt(PlayFab.ClientModels.ValidateAmazonReceiptRequest request, System.Action<PlayFab.ClientModels.ValidateAmazonReceiptResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.ValidateAmazonReceiptResult>(apiEndpoint:  "/Client/ValidateAmazonIAPReceipt", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ValidateGooglePlayPurchase(PlayFab.ClientModels.ValidateGooglePlayPurchaseRequest request, System.Action<PlayFab.ClientModels.ValidateGooglePlayPurchaseResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.ValidateGooglePlayPurchaseResult>(apiEndpoint:  "/Client/ValidateGooglePlayPurchase", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ValidateIOSReceipt(PlayFab.ClientModels.ValidateIOSReceiptRequest request, System.Action<PlayFab.ClientModels.ValidateIOSReceiptResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.ValidateIOSReceiptResult>(apiEndpoint:  "/Client/ValidateIOSReceipt", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ValidateWindowsStoreReceipt(PlayFab.ClientModels.ValidateWindowsReceiptRequest request, System.Action<PlayFab.ClientModels.ValidateWindowsReceiptResult> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.ValidateWindowsReceiptResult>(apiEndpoint:  "/Client/ValidateWindowsStoreReceipt", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void WriteCharacterEvent(PlayFab.ClientModels.WriteClientCharacterEventRequest request, System.Action<PlayFab.ClientModels.WriteEventResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.WriteEventResponse>(apiEndpoint:  "/Client/WriteCharacterEvent", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void WritePlayerEvent(PlayFab.ClientModels.WriteClientPlayerEventRequest request, System.Action<PlayFab.ClientModels.WriteEventResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_3;
            var val_4;
            var val_5;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_4 = null;
            val_4 = null;
            val_3 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_5 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.WriteEventResponse>(apiEndpoint:  "/Client/WritePlayerEvent", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_3, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            PlayFab.PlayFabException val_2 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void WriteTitleEvent(PlayFab.ClientModels.WriteTitleEventRequest request, System.Action<PlayFab.ClientModels.WriteEventResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders)
        {
            PlayFab.PlayFabAuthenticationContext val_4;
            var val_5;
            var val_6;
            if(request != null)
            {
                    if(0 != 0)
            {
                goto label_2;
            }
            
            }
            
            val_5 = null;
            val_5 = null;
            val_4 = PlayFab.PlayFabSettings.staticPlayer;
            label_2:
            val_6 = null;
            if(PlayFab.PlayFabClientAPI.IsClientLoggedIn() != false)
            {
                    PlayFab.Internal.PlayFabHttp.MakeApiCall<PlayFab.ClientModels.WriteEventResponse>(apiEndpoint:  "/Client/WriteTitleEvent", request:  request, authType:  2, resultCallback:  resultCallback, errorCallback:  errorCallback, customData:  customData, extraHeaders:  extraHeaders, authenticationContext:  val_4, apiSettings:  0, instanceApi:  0);
                return;
            }
            
            string val_3 = new PlayFab.PlayFabException(code:  4, message:  "Must be logged in to call this method").nullableAsStr<System.Boolean>(val:  new System.Nullable<T>() {HasValue = false}, formatString:  public static System.Void PlayFab.PlayFabClientAPI::WriteTitleEvent(PlayFab.ClientModels.WriteTitleEventRequest request, System.Action<PlayFab.ClientModels.WriteEventResponse> resultCallback, System.Action<PlayFab.PlayFabError> errorCallback, object customData, System.Collections.Generic.Dictionary<string, string> extraHeaders));
        }
    
    }

}
