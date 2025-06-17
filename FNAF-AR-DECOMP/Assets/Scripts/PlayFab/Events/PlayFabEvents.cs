using UnityEngine;

namespace PlayFab.Events
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabEvents
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.AuthenticationModels.GetEntityTokenRequest> OnAuthenticationGetEntityTokenRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.AuthenticationModels.GetEntityTokenResponse> OnAuthenticationGetEntityTokenResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.AuthenticationModels.ValidateEntityTokenRequest> OnAuthenticationValidateEntityTokenRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.AuthenticationModels.ValidateEntityTokenResponse> OnAuthenticationValidateEntityTokenResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LoginResult> OnLoginResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AcceptTradeRequest> OnAcceptTradeRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AcceptTradeResponse> OnAcceptTradeResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddFriendRequest> OnAddFriendRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddFriendResult> OnAddFriendResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddGenericIDRequest> OnAddGenericIDRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddGenericIDResult> OnAddGenericIDResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddOrUpdateContactEmailRequest> OnAddOrUpdateContactEmailRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddOrUpdateContactEmailResult> OnAddOrUpdateContactEmailResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddSharedGroupMembersRequest> OnAddSharedGroupMembersRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddSharedGroupMembersResult> OnAddSharedGroupMembersResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddUsernamePasswordRequest> OnAddUsernamePasswordRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddUsernamePasswordResult> OnAddUsernamePasswordResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddUserVirtualCurrencyRequest> OnAddUserVirtualCurrencyRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ModifyUserVirtualCurrencyResult> OnAddUserVirtualCurrencyResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationRequest> OnAndroidDevicePushNotificationRegistrationRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationResult> OnAndroidDevicePushNotificationRegistrationResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AttributeInstallRequest> OnAttributeInstallRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AttributeInstallResult> OnAttributeInstallResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.CancelTradeRequest> OnCancelTradeRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.CancelTradeResponse> OnCancelTradeResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ConfirmPurchaseRequest> OnConfirmPurchaseRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ConfirmPurchaseResult> OnConfirmPurchaseResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ConsumeItemRequest> OnConsumeItemRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ConsumeItemResult> OnConsumeItemResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ConsumePSNEntitlementsRequest> OnConsumePSNEntitlementsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ConsumePSNEntitlementsResult> OnConsumePSNEntitlementsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ConsumeXboxEntitlementsRequest> OnConsumeXboxEntitlementsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ConsumeXboxEntitlementsResult> OnConsumeXboxEntitlementsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.CreateSharedGroupRequest> OnCreateSharedGroupRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.CreateSharedGroupResult> OnCreateSharedGroupResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ExecuteCloudScriptRequest> OnExecuteCloudScriptRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ExecuteCloudScriptResult> OnExecuteCloudScriptResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetAccountInfoRequest> OnGetAccountInfoRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetAccountInfoResult> OnGetAccountInfoResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ListUsersCharactersRequest> OnGetAllUsersCharactersRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ListUsersCharactersResult> OnGetAllUsersCharactersResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCatalogItemsRequest> OnGetCatalogItemsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCatalogItemsResult> OnGetCatalogItemsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterDataRequest> OnGetCharacterDataRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterDataResult> OnGetCharacterDataResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterInventoryRequest> OnGetCharacterInventoryRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterInventoryResult> OnGetCharacterInventoryResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterLeaderboardRequest> OnGetCharacterLeaderboardRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterLeaderboardResult> OnGetCharacterLeaderboardResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterDataRequest> OnGetCharacterReadOnlyDataRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterDataResult> OnGetCharacterReadOnlyDataResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterStatisticsRequest> OnGetCharacterStatisticsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterStatisticsResult> OnGetCharacterStatisticsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetContentDownloadUrlRequest> OnGetContentDownloadUrlRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetContentDownloadUrlResult> OnGetContentDownloadUrlResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.CurrentGamesRequest> OnGetCurrentGamesRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.CurrentGamesResult> OnGetCurrentGamesResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetFriendLeaderboardRequest> OnGetFriendLeaderboardRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardResult> OnGetFriendLeaderboardResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetFriendLeaderboardAroundPlayerRequest> OnGetFriendLeaderboardAroundPlayerRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetFriendLeaderboardAroundPlayerResult> OnGetFriendLeaderboardAroundPlayerResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetFriendsListRequest> OnGetFriendsListRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetFriendsListResult> OnGetFriendsListResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GameServerRegionsRequest> OnGetGameServerRegionsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GameServerRegionsResult> OnGetGameServerRegionsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetLeaderboardRequest> OnGetLeaderboardRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardResult> OnGetLeaderboardResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetLeaderboardAroundCharacterRequest> OnGetLeaderboardAroundCharacterRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardAroundCharacterResult> OnGetLeaderboardAroundCharacterResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetLeaderboardAroundPlayerRequest> OnGetLeaderboardAroundPlayerRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardAroundPlayerResult> OnGetLeaderboardAroundPlayerResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetLeaderboardForUsersCharactersRequest> OnGetLeaderboardForUserCharactersRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardForUsersCharactersResult> OnGetLeaderboardForUserCharactersResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPaymentTokenRequest> OnGetPaymentTokenRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPaymentTokenResult> OnGetPaymentTokenResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPhotonAuthenticationTokenRequest> OnGetPhotonAuthenticationTokenRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPhotonAuthenticationTokenResult> OnGetPhotonAuthenticationTokenResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerCombinedInfoRequest> OnGetPlayerCombinedInfoRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerCombinedInfoResult> OnGetPlayerCombinedInfoResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerProfileRequest> OnGetPlayerProfileRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerProfileResult> OnGetPlayerProfileResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerSegmentsRequest> OnGetPlayerSegmentsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerSegmentsResult> OnGetPlayerSegmentsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerStatisticsRequest> OnGetPlayerStatisticsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerStatisticsResult> OnGetPlayerStatisticsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerStatisticVersionsRequest> OnGetPlayerStatisticVersionsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerStatisticVersionsResult> OnGetPlayerStatisticVersionsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerTagsRequest> OnGetPlayerTagsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerTagsResult> OnGetPlayerTagsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerTradesRequest> OnGetPlayerTradesRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerTradesResponse> OnGetPlayerTradesResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromFacebookIDsRequest> OnGetPlayFabIDsFromFacebookIDsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromFacebookIDsResult> OnGetPlayFabIDsFromFacebookIDsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromFacebookInstantGamesIdsRequest> OnGetPlayFabIDsFromFacebookInstantGamesIdsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromFacebookInstantGamesIdsResult> OnGetPlayFabIDsFromFacebookInstantGamesIdsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromGameCenterIDsRequest> OnGetPlayFabIDsFromGameCenterIDsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromGameCenterIDsResult> OnGetPlayFabIDsFromGameCenterIDsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromGenericIDsRequest> OnGetPlayFabIDsFromGenericIDsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromGenericIDsResult> OnGetPlayFabIDsFromGenericIDsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromGoogleIDsRequest> OnGetPlayFabIDsFromGoogleIDsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromGoogleIDsResult> OnGetPlayFabIDsFromGoogleIDsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromKongregateIDsRequest> OnGetPlayFabIDsFromKongregateIDsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromKongregateIDsResult> OnGetPlayFabIDsFromKongregateIDsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest> OnGetPlayFabIDsFromNintendoSwitchDeviceIdsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> OnGetPlayFabIDsFromNintendoSwitchDeviceIdsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromPSNAccountIDsRequest> OnGetPlayFabIDsFromPSNAccountIDsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromPSNAccountIDsResult> OnGetPlayFabIDsFromPSNAccountIDsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromSteamIDsRequest> OnGetPlayFabIDsFromSteamIDsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromSteamIDsResult> OnGetPlayFabIDsFromSteamIDsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromTwitchIDsRequest> OnGetPlayFabIDsFromTwitchIDsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromTwitchIDsResult> OnGetPlayFabIDsFromTwitchIDsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromXboxLiveIDsRequest> OnGetPlayFabIDsFromXboxLiveIDsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromXboxLiveIDsResult> OnGetPlayFabIDsFromXboxLiveIDsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPublisherDataRequest> OnGetPublisherDataRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPublisherDataResult> OnGetPublisherDataResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPurchaseRequest> OnGetPurchaseRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPurchaseResult> OnGetPurchaseResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetSharedGroupDataRequest> OnGetSharedGroupDataRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetSharedGroupDataResult> OnGetSharedGroupDataResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetStoreItemsRequest> OnGetStoreItemsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetStoreItemsResult> OnGetStoreItemsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTimeRequest> OnGetTimeRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTimeResult> OnGetTimeResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTitleDataRequest> OnGetTitleDataRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTitleDataResult> OnGetTitleDataResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTitleNewsRequest> OnGetTitleNewsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTitleNewsResult> OnGetTitleNewsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTitlePublicKeyRequest> OnGetTitlePublicKeyRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTitlePublicKeyResult> OnGetTitlePublicKeyResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTradeStatusRequest> OnGetTradeStatusRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTradeStatusResponse> OnGetTradeStatusResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserDataRequest> OnGetUserDataRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserDataResult> OnGetUserDataResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserInventoryRequest> OnGetUserInventoryRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserInventoryResult> OnGetUserInventoryResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserDataRequest> OnGetUserPublisherDataRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserDataResult> OnGetUserPublisherDataResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserDataRequest> OnGetUserPublisherReadOnlyDataRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserDataResult> OnGetUserPublisherReadOnlyDataResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserDataRequest> OnGetUserReadOnlyDataRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserDataResult> OnGetUserReadOnlyDataResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetWindowsHelloChallengeRequest> OnGetWindowsHelloChallengeRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetWindowsHelloChallengeResponse> OnGetWindowsHelloChallengeResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GrantCharacterToUserRequest> OnGrantCharacterToUserRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GrantCharacterToUserResult> OnGrantCharacterToUserResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkAndroidDeviceIDRequest> OnLinkAndroidDeviceIDRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkAndroidDeviceIDResult> OnLinkAndroidDeviceIDResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkCustomIDRequest> OnLinkCustomIDRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkCustomIDResult> OnLinkCustomIDResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkFacebookAccountRequest> OnLinkFacebookAccountRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkFacebookAccountResult> OnLinkFacebookAccountResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkFacebookInstantGamesIdRequest> OnLinkFacebookInstantGamesIdRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkFacebookInstantGamesIdResult> OnLinkFacebookInstantGamesIdResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkGameCenterAccountRequest> OnLinkGameCenterAccountRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkGameCenterAccountResult> OnLinkGameCenterAccountResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkGoogleAccountRequest> OnLinkGoogleAccountRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkGoogleAccountResult> OnLinkGoogleAccountResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkIOSDeviceIDRequest> OnLinkIOSDeviceIDRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkIOSDeviceIDResult> OnLinkIOSDeviceIDResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkKongregateAccountRequest> OnLinkKongregateRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkKongregateAccountResult> OnLinkKongregateResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkNintendoSwitchDeviceIdRequest> OnLinkNintendoSwitchDeviceIdRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkNintendoSwitchDeviceIdResult> OnLinkNintendoSwitchDeviceIdResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkOpenIdConnectRequest> OnLinkOpenIdConnectRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResult> OnLinkOpenIdConnectResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkPSNAccountRequest> OnLinkPSNAccountRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkPSNAccountResult> OnLinkPSNAccountResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkSteamAccountRequest> OnLinkSteamAccountRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkSteamAccountResult> OnLinkSteamAccountResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkTwitchAccountRequest> OnLinkTwitchRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkTwitchAccountResult> OnLinkTwitchResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkWindowsHelloAccountRequest> OnLinkWindowsHelloRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkWindowsHelloAccountResponse> OnLinkWindowsHelloResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkXboxAccountRequest> OnLinkXboxAccountRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkXboxAccountResult> OnLinkXboxAccountResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithAndroidDeviceIDRequest> OnLoginWithAndroidDeviceIDRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithCustomIDRequest> OnLoginWithCustomIDRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithEmailAddressRequest> OnLoginWithEmailAddressRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithFacebookRequest> OnLoginWithFacebookRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithFacebookInstantGamesIdRequest> OnLoginWithFacebookInstantGamesIdRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithGameCenterRequest> OnLoginWithGameCenterRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithGoogleAccountRequest> OnLoginWithGoogleAccountRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithIOSDeviceIDRequest> OnLoginWithIOSDeviceIDRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithKongregateRequest> OnLoginWithKongregateRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithNintendoSwitchDeviceIdRequest> OnLoginWithNintendoSwitchDeviceIdRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithOpenIdConnectRequest> OnLoginWithOpenIdConnectRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithPlayFabRequest> OnLoginWithPlayFabRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithPSNRequest> OnLoginWithPSNRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithSteamRequest> OnLoginWithSteamRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithTwitchRequest> OnLoginWithTwitchRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithWindowsHelloRequest> OnLoginWithWindowsHelloRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithXboxRequest> OnLoginWithXboxRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.MatchmakeRequest> OnMatchmakeRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.MatchmakeResult> OnMatchmakeResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.OpenTradeRequest> OnOpenTradeRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.OpenTradeResponse> OnOpenTradeResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.PayForPurchaseRequest> OnPayForPurchaseRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.PayForPurchaseResult> OnPayForPurchaseResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.PurchaseItemRequest> OnPurchaseItemRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.PurchaseItemResult> OnPurchaseItemResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RedeemCouponRequest> OnRedeemCouponRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RedeemCouponResult> OnRedeemCouponResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RefreshPSNAuthTokenRequest> OnRefreshPSNAuthTokenRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResponse> OnRefreshPSNAuthTokenResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RegisterForIOSPushNotificationRequest> OnRegisterForIOSPushNotificationRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RegisterForIOSPushNotificationResult> OnRegisterForIOSPushNotificationResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RegisterPlayFabUserRequest> OnRegisterPlayFabUserRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RegisterPlayFabUserResult> OnRegisterPlayFabUserResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RegisterWithWindowsHelloRequest> OnRegisterWithWindowsHelloRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RemoveContactEmailRequest> OnRemoveContactEmailRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RemoveContactEmailResult> OnRemoveContactEmailResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RemoveFriendRequest> OnRemoveFriendRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RemoveFriendResult> OnRemoveFriendResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RemoveGenericIDRequest> OnRemoveGenericIDRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RemoveGenericIDResult> OnRemoveGenericIDResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RemoveSharedGroupMembersRequest> OnRemoveSharedGroupMembersRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RemoveSharedGroupMembersResult> OnRemoveSharedGroupMembersResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.DeviceInfoRequest> OnReportDeviceInfoRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResponse> OnReportDeviceInfoResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ReportPlayerClientRequest> OnReportPlayerRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ReportPlayerClientResult> OnReportPlayerResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RestoreIOSPurchasesRequest> OnRestoreIOSPurchasesRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RestoreIOSPurchasesResult> OnRestoreIOSPurchasesResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.SendAccountRecoveryEmailRequest> OnSendAccountRecoveryEmailRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.SendAccountRecoveryEmailResult> OnSendAccountRecoveryEmailResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.SetFriendTagsRequest> OnSetFriendTagsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.SetFriendTagsResult> OnSetFriendTagsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.SetPlayerSecretRequest> OnSetPlayerSecretRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.SetPlayerSecretResult> OnSetPlayerSecretResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.StartGameRequest> OnStartGameRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.StartGameResult> OnStartGameResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.StartPurchaseRequest> OnStartPurchaseRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.StartPurchaseResult> OnStartPurchaseResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.SubtractUserVirtualCurrencyRequest> OnSubtractUserVirtualCurrencyRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ModifyUserVirtualCurrencyResult> OnSubtractUserVirtualCurrencyResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkAndroidDeviceIDRequest> OnUnlinkAndroidDeviceIDRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkAndroidDeviceIDResult> OnUnlinkAndroidDeviceIDResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkCustomIDRequest> OnUnlinkCustomIDRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkCustomIDResult> OnUnlinkCustomIDResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkFacebookAccountRequest> OnUnlinkFacebookAccountRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkFacebookAccountResult> OnUnlinkFacebookAccountResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkFacebookInstantGamesIdRequest> OnUnlinkFacebookInstantGamesIdRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkFacebookInstantGamesIdResult> OnUnlinkFacebookInstantGamesIdResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkGameCenterAccountRequest> OnUnlinkGameCenterAccountRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkGameCenterAccountResult> OnUnlinkGameCenterAccountResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkGoogleAccountRequest> OnUnlinkGoogleAccountRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkGoogleAccountResult> OnUnlinkGoogleAccountResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkIOSDeviceIDRequest> OnUnlinkIOSDeviceIDRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkIOSDeviceIDResult> OnUnlinkIOSDeviceIDResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkKongregateAccountRequest> OnUnlinkKongregateRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkKongregateAccountResult> OnUnlinkKongregateResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkNintendoSwitchDeviceIdRequest> OnUnlinkNintendoSwitchDeviceIdRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkNintendoSwitchDeviceIdResult> OnUnlinkNintendoSwitchDeviceIdResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UninkOpenIdConnectRequest> OnUnlinkOpenIdConnectRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResponse> OnUnlinkOpenIdConnectResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkPSNAccountRequest> OnUnlinkPSNAccountRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkPSNAccountResult> OnUnlinkPSNAccountResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkSteamAccountRequest> OnUnlinkSteamAccountRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkSteamAccountResult> OnUnlinkSteamAccountResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkTwitchAccountRequest> OnUnlinkTwitchRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkTwitchAccountResult> OnUnlinkTwitchResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkWindowsHelloAccountRequest> OnUnlinkWindowsHelloRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkWindowsHelloAccountResponse> OnUnlinkWindowsHelloResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkXboxAccountRequest> OnUnlinkXboxAccountRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkXboxAccountResult> OnUnlinkXboxAccountResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlockContainerInstanceRequest> OnUnlockContainerInstanceRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlockContainerItemResult> OnUnlockContainerInstanceResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlockContainerItemRequest> OnUnlockContainerItemRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlockContainerItemResult> OnUnlockContainerItemResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateAvatarUrlRequest> OnUpdateAvatarUrlRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResponse> OnUpdateAvatarUrlResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateCharacterDataRequest> OnUpdateCharacterDataRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateCharacterDataResult> OnUpdateCharacterDataResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateCharacterStatisticsRequest> OnUpdateCharacterStatisticsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateCharacterStatisticsResult> OnUpdateCharacterStatisticsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdatePlayerStatisticsRequest> OnUpdatePlayerStatisticsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdatePlayerStatisticsResult> OnUpdatePlayerStatisticsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateSharedGroupDataRequest> OnUpdateSharedGroupDataRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateSharedGroupDataResult> OnUpdateSharedGroupDataResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateUserDataRequest> OnUpdateUserDataRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateUserDataResult> OnUpdateUserDataResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateUserDataRequest> OnUpdateUserPublisherDataRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateUserDataResult> OnUpdateUserPublisherDataResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateUserTitleDisplayNameRequest> OnUpdateUserTitleDisplayNameRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateUserTitleDisplayNameResult> OnUpdateUserTitleDisplayNameResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ValidateAmazonReceiptRequest> OnValidateAmazonIAPReceiptRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ValidateAmazonReceiptResult> OnValidateAmazonIAPReceiptResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ValidateGooglePlayPurchaseRequest> OnValidateGooglePlayPurchaseRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ValidateGooglePlayPurchaseResult> OnValidateGooglePlayPurchaseResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ValidateIOSReceiptRequest> OnValidateIOSReceiptRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ValidateIOSReceiptResult> OnValidateIOSReceiptResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ValidateWindowsReceiptRequest> OnValidateWindowsStoreReceiptRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ValidateWindowsReceiptResult> OnValidateWindowsStoreReceiptResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.WriteClientCharacterEventRequest> OnWriteCharacterEventRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.WriteEventResponse> OnWriteCharacterEventResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.WriteClientPlayerEventRequest> OnWritePlayerEventRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.WriteEventResponse> OnWritePlayerEventResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.WriteTitleEventRequest> OnWriteTitleEventRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.WriteEventResponse> OnWriteTitleEventResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.CloudScriptModels.ExecuteEntityCloudScriptRequest> OnCloudScriptExecuteEntityCloudScriptRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.CloudScriptModels.ExecuteCloudScriptResult> OnCloudScriptExecuteEntityCloudScriptResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.AbortFileUploadsRequest> OnDataAbortFileUploadsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.AbortFileUploadsResponse> OnDataAbortFileUploadsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.DeleteFilesRequest> OnDataDeleteFilesRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.DeleteFilesResponse> OnDataDeleteFilesResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.FinalizeFileUploadsRequest> OnDataFinalizeFileUploadsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.FinalizeFileUploadsResponse> OnDataFinalizeFileUploadsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.GetFilesRequest> OnDataGetFilesRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.GetFilesResponse> OnDataGetFilesResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.GetObjectsRequest> OnDataGetObjectsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.GetObjectsResponse> OnDataGetObjectsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.InitiateFileUploadsRequest> OnDataInitiateFileUploadsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.InitiateFileUploadsResponse> OnDataInitiateFileUploadsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.SetObjectsRequest> OnDataSetObjectsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.SetObjectsResponse> OnDataSetObjectsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.EventsModels.WriteEventsRequest> OnEventsWriteEventsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.EventsModels.WriteEventsResponse> OnEventsWriteEventsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.EventsModels.WriteEventsRequest> OnEventsWriteTelemetryEventsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.EventsModels.WriteEventsResponse> OnEventsWriteTelemetryEventsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.AcceptGroupApplicationRequest> OnGroupsAcceptGroupApplicationRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> OnGroupsAcceptGroupApplicationResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.AcceptGroupInvitationRequest> OnGroupsAcceptGroupInvitationRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> OnGroupsAcceptGroupInvitationResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.AddMembersRequest> OnGroupsAddMembersRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> OnGroupsAddMembersResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ApplyToGroupRequest> OnGroupsApplyToGroupRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ApplyToGroupResponse> OnGroupsApplyToGroupResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.BlockEntityRequest> OnGroupsBlockEntityRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> OnGroupsBlockEntityResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ChangeMemberRoleRequest> OnGroupsChangeMemberRoleRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> OnGroupsChangeMemberRoleResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.CreateGroupRequest> OnGroupsCreateGroupRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.CreateGroupResponse> OnGroupsCreateGroupResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.CreateGroupRoleRequest> OnGroupsCreateRoleRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.CreateGroupRoleResponse> OnGroupsCreateRoleResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.DeleteGroupRequest> OnGroupsDeleteGroupRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> OnGroupsDeleteGroupResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.DeleteRoleRequest> OnGroupsDeleteRoleRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> OnGroupsDeleteRoleResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.GetGroupRequest> OnGroupsGetGroupRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.GetGroupResponse> OnGroupsGetGroupResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.InviteToGroupRequest> OnGroupsInviteToGroupRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.InviteToGroupResponse> OnGroupsInviteToGroupResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.IsMemberRequest> OnGroupsIsMemberRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.IsMemberResponse> OnGroupsIsMemberResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListGroupApplicationsRequest> OnGroupsListGroupApplicationsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListGroupApplicationsResponse> OnGroupsListGroupApplicationsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListGroupBlocksRequest> OnGroupsListGroupBlocksRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListGroupBlocksResponse> OnGroupsListGroupBlocksResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListGroupInvitationsRequest> OnGroupsListGroupInvitationsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListGroupInvitationsResponse> OnGroupsListGroupInvitationsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListGroupMembersRequest> OnGroupsListGroupMembersRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListGroupMembersResponse> OnGroupsListGroupMembersResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListMembershipRequest> OnGroupsListMembershipRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListMembershipResponse> OnGroupsListMembershipResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListMembershipOpportunitiesRequest> OnGroupsListMembershipOpportunitiesRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListMembershipOpportunitiesResponse> OnGroupsListMembershipOpportunitiesResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.RemoveGroupApplicationRequest> OnGroupsRemoveGroupApplicationRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> OnGroupsRemoveGroupApplicationResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.RemoveGroupInvitationRequest> OnGroupsRemoveGroupInvitationRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> OnGroupsRemoveGroupInvitationResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.RemoveMembersRequest> OnGroupsRemoveMembersRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> OnGroupsRemoveMembersResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.UnblockEntityRequest> OnGroupsUnblockEntityRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> OnGroupsUnblockEntityResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.UpdateGroupRequest> OnGroupsUpdateGroupRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.UpdateGroupResponse> OnGroupsUpdateGroupResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.UpdateGroupRoleRequest> OnGroupsUpdateRoleRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.UpdateGroupRoleResponse> OnGroupsUpdateRoleResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.LocalizationModels.GetLanguageListRequest> OnLocalizationGetLanguageListRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.LocalizationModels.GetLanguageListResponse> OnLocalizationGetLanguageListResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CancelAllMatchmakingTicketsForPlayerRequest> OnMultiplayerCancelAllMatchmakingTicketsForPlayerRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CancelAllMatchmakingTicketsForPlayerResult> OnMultiplayerCancelAllMatchmakingTicketsForPlayerResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CancelMatchmakingTicketRequest> OnMultiplayerCancelMatchmakingTicketRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CancelMatchmakingTicketResult> OnMultiplayerCancelMatchmakingTicketResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateBuildWithCustomContainerRequest> OnMultiplayerCreateBuildWithCustomContainerRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateBuildWithCustomContainerResponse> OnMultiplayerCreateBuildWithCustomContainerResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateBuildWithManagedContainerRequest> OnMultiplayerCreateBuildWithManagedContainerRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateBuildWithManagedContainerResponse> OnMultiplayerCreateBuildWithManagedContainerResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateMatchmakingTicketRequest> OnMultiplayerCreateMatchmakingTicketRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateMatchmakingTicketResult> OnMultiplayerCreateMatchmakingTicketResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateRemoteUserRequest> OnMultiplayerCreateRemoteUserRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateRemoteUserResponse> OnMultiplayerCreateRemoteUserResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateServerMatchmakingTicketRequest> OnMultiplayerCreateServerMatchmakingTicketRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateMatchmakingTicketResult> OnMultiplayerCreateServerMatchmakingTicketResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.DeleteAssetRequest> OnMultiplayerDeleteAssetRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> OnMultiplayerDeleteAssetResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.DeleteBuildRequest> OnMultiplayerDeleteBuildRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> OnMultiplayerDeleteBuildResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.DeleteCertificateRequest> OnMultiplayerDeleteCertificateRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> OnMultiplayerDeleteCertificateResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.DeleteRemoteUserRequest> OnMultiplayerDeleteRemoteUserRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> OnMultiplayerDeleteRemoteUserResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.EnableMultiplayerServersForTitleRequest> OnMultiplayerEnableMultiplayerServersForTitleRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EnableMultiplayerServersForTitleResponse> OnMultiplayerEnableMultiplayerServersForTitleResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetAssetUploadUrlRequest> OnMultiplayerGetAssetUploadUrlRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetAssetUploadUrlResponse> OnMultiplayerGetAssetUploadUrlResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetBuildRequest> OnMultiplayerGetBuildRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetBuildResponse> OnMultiplayerGetBuildResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetContainerRegistryCredentialsRequest> OnMultiplayerGetContainerRegistryCredentialsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetContainerRegistryCredentialsResponse> OnMultiplayerGetContainerRegistryCredentialsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetMatchRequest> OnMultiplayerGetMatchRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetMatchResult> OnMultiplayerGetMatchResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetMatchmakingTicketRequest> OnMultiplayerGetMatchmakingTicketRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetMatchmakingTicketResult> OnMultiplayerGetMatchmakingTicketResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetMultiplayerServerDetailsRequest> OnMultiplayerGetMultiplayerServerDetailsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetMultiplayerServerDetailsResponse> OnMultiplayerGetMultiplayerServerDetailsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetQueueStatisticsRequest> OnMultiplayerGetQueueStatisticsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetQueueStatisticsResult> OnMultiplayerGetQueueStatisticsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetRemoteLoginEndpointRequest> OnMultiplayerGetRemoteLoginEndpointRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetRemoteLoginEndpointResponse> OnMultiplayerGetRemoteLoginEndpointResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetTitleEnabledForMultiplayerServersStatusRequest> OnMultiplayerGetTitleEnabledForMultiplayerServersStatusRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetTitleEnabledForMultiplayerServersStatusResponse> OnMultiplayerGetTitleEnabledForMultiplayerServersStatusResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetTitleMultiplayerServersQuotasRequest> OnMultiplayerGetTitleMultiplayerServersQuotasRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetTitleMultiplayerServersQuotasResponse> OnMultiplayerGetTitleMultiplayerServersQuotasResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.JoinMatchmakingTicketRequest> OnMultiplayerJoinMatchmakingTicketRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.JoinMatchmakingTicketResult> OnMultiplayerJoinMatchmakingTicketResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListMultiplayerServersRequest> OnMultiplayerListArchivedMultiplayerServersRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListMultiplayerServersResponse> OnMultiplayerListArchivedMultiplayerServersResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListAssetSummariesRequest> OnMultiplayerListAssetSummariesRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListAssetSummariesResponse> OnMultiplayerListAssetSummariesResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListBuildSummariesRequest> OnMultiplayerListBuildSummariesRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListBuildSummariesResponse> OnMultiplayerListBuildSummariesResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListCertificateSummariesRequest> OnMultiplayerListCertificateSummariesRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListCertificateSummariesResponse> OnMultiplayerListCertificateSummariesResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListContainerImagesRequest> OnMultiplayerListContainerImagesRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListContainerImagesResponse> OnMultiplayerListContainerImagesResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListContainerImageTagsRequest> OnMultiplayerListContainerImageTagsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListContainerImageTagsResponse> OnMultiplayerListContainerImageTagsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListMatchmakingTicketsForPlayerRequest> OnMultiplayerListMatchmakingTicketsForPlayerRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListMatchmakingTicketsForPlayerResult> OnMultiplayerListMatchmakingTicketsForPlayerResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListMultiplayerServersRequest> OnMultiplayerListMultiplayerServersRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListMultiplayerServersResponse> OnMultiplayerListMultiplayerServersResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListPartyQosServersRequest> OnMultiplayerListPartyQosServersRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListPartyQosServersResponse> OnMultiplayerListPartyQosServersResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListQosServersRequest> OnMultiplayerListQosServersRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListQosServersResponse> OnMultiplayerListQosServersResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListQosServersForTitleRequest> OnMultiplayerListQosServersForTitleRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListQosServersForTitleResponse> OnMultiplayerListQosServersForTitleResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListVirtualMachineSummariesRequest> OnMultiplayerListVirtualMachineSummariesRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListVirtualMachineSummariesResponse> OnMultiplayerListVirtualMachineSummariesResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.RequestMultiplayerServerRequest> OnMultiplayerRequestMultiplayerServerRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.RequestMultiplayerServerResponse> OnMultiplayerRequestMultiplayerServerResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.RolloverContainerRegistryCredentialsRequest> OnMultiplayerRolloverContainerRegistryCredentialsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.RolloverContainerRegistryCredentialsResponse> OnMultiplayerRolloverContainerRegistryCredentialsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ShutdownMultiplayerServerRequest> OnMultiplayerShutdownMultiplayerServerRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> OnMultiplayerShutdownMultiplayerServerResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.UpdateBuildRegionsRequest> OnMultiplayerUpdateBuildRegionsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> OnMultiplayerUpdateBuildRegionsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.UploadCertificateRequest> OnMultiplayerUploadCertificateRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> OnMultiplayerUploadCertificateResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.GetGlobalPolicyRequest> OnProfilesGetGlobalPolicyRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.GetGlobalPolicyResponse> OnProfilesGetGlobalPolicyResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.GetEntityProfileRequest> OnProfilesGetProfileRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.GetEntityProfileResponse> OnProfilesGetProfileResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.GetEntityProfilesRequest> OnProfilesGetProfilesRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.GetEntityProfilesResponse> OnProfilesGetProfilesResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.GetTitlePlayersFromMasterPlayerAccountIdsRequest> OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.GetTitlePlayersFromMasterPlayerAccountIdsResponse> OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.SetGlobalPolicyRequest> OnProfilesSetGlobalPolicyRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.SetGlobalPolicyResponse> OnProfilesSetGlobalPolicyResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.SetProfileLanguageRequest> OnProfilesSetProfileLanguageRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.SetProfileLanguageResponse> OnProfilesSetProfileLanguageResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.SetEntityProfilePolicyRequest> OnProfilesSetProfilePolicyRequestEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.SetEntityProfilePolicyResponse> OnProfilesSetProfilePolicyResultEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFab.Events.PlayFabEvents.PlayFabErrorEvent OnGlobalErrorEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static PlayFab.Events.PlayFabEvents _instance;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAuthenticationGetEntityTokenRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.AuthenticationModels.GetEntityTokenRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAuthenticationGetEntityTokenRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAuthenticationGetEntityTokenRequestEvent != 1152921525815972240);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAuthenticationGetEntityTokenRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.AuthenticationModels.GetEntityTokenRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAuthenticationGetEntityTokenRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAuthenticationGetEntityTokenRequestEvent != 1152921525816108816);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAuthenticationGetEntityTokenResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.AuthenticationModels.GetEntityTokenResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAuthenticationGetEntityTokenResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAuthenticationGetEntityTokenResultEvent != 1152921525816245400);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAuthenticationGetEntityTokenResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.AuthenticationModels.GetEntityTokenResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAuthenticationGetEntityTokenResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAuthenticationGetEntityTokenResultEvent != 1152921525816381976);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAuthenticationValidateEntityTokenRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.AuthenticationModels.ValidateEntityTokenRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAuthenticationValidateEntityTokenRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAuthenticationValidateEntityTokenRequestEvent != 1152921525816518560);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAuthenticationValidateEntityTokenRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.AuthenticationModels.ValidateEntityTokenRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAuthenticationValidateEntityTokenRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAuthenticationValidateEntityTokenRequestEvent != 1152921525816655136);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAuthenticationValidateEntityTokenResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.AuthenticationModels.ValidateEntityTokenResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAuthenticationValidateEntityTokenResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAuthenticationValidateEntityTokenResultEvent != 1152921525816791720);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAuthenticationValidateEntityTokenResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.AuthenticationModels.ValidateEntityTokenResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAuthenticationValidateEntityTokenResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAuthenticationValidateEntityTokenResultEvent != 1152921525816928296);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LoginResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginResultEvent != 1152921525817064880);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LoginResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginResultEvent != 1152921525817201456);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAcceptTradeRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AcceptTradeRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAcceptTradeRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAcceptTradeRequestEvent != 1152921525817338040);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAcceptTradeRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AcceptTradeRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAcceptTradeRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAcceptTradeRequestEvent != 1152921525817474616);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAcceptTradeResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AcceptTradeResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAcceptTradeResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAcceptTradeResultEvent != 1152921525817611200);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAcceptTradeResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AcceptTradeResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAcceptTradeResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAcceptTradeResultEvent != 1152921525817747776);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAddFriendRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddFriendRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAddFriendRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddFriendRequestEvent != 1152921525817884360);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAddFriendRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddFriendRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAddFriendRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddFriendRequestEvent != 1152921525818020936);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAddFriendResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddFriendResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAddFriendResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddFriendResultEvent != 1152921525818157520);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAddFriendResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddFriendResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAddFriendResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddFriendResultEvent != 1152921525818294096);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAddGenericIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddGenericIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAddGenericIDRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddGenericIDRequestEvent != 1152921525818430680);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAddGenericIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddGenericIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAddGenericIDRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddGenericIDRequestEvent != 1152921525818567256);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAddGenericIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddGenericIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAddGenericIDResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddGenericIDResultEvent != 1152921525818703840);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAddGenericIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddGenericIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAddGenericIDResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddGenericIDResultEvent != 1152921525818840416);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAddOrUpdateContactEmailRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddOrUpdateContactEmailRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAddOrUpdateContactEmailRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddOrUpdateContactEmailRequestEvent != 1152921525818977000);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAddOrUpdateContactEmailRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddOrUpdateContactEmailRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAddOrUpdateContactEmailRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddOrUpdateContactEmailRequestEvent != 1152921525819113576);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAddOrUpdateContactEmailResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddOrUpdateContactEmailResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAddOrUpdateContactEmailResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddOrUpdateContactEmailResultEvent != 1152921525819250160);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAddOrUpdateContactEmailResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddOrUpdateContactEmailResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAddOrUpdateContactEmailResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddOrUpdateContactEmailResultEvent != 1152921525819386736);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAddSharedGroupMembersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddSharedGroupMembersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAddSharedGroupMembersRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddSharedGroupMembersRequestEvent != 1152921525819523320);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAddSharedGroupMembersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddSharedGroupMembersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAddSharedGroupMembersRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddSharedGroupMembersRequestEvent != 1152921525819659896);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAddSharedGroupMembersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddSharedGroupMembersResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAddSharedGroupMembersResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddSharedGroupMembersResultEvent != 1152921525819796480);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAddSharedGroupMembersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddSharedGroupMembersResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAddSharedGroupMembersResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddSharedGroupMembersResultEvent != 1152921525819933056);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAddUsernamePasswordRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddUsernamePasswordRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAddUsernamePasswordRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddUsernamePasswordRequestEvent != 1152921525820069640);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAddUsernamePasswordRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddUsernamePasswordRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAddUsernamePasswordRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddUsernamePasswordRequestEvent != 1152921525820206216);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAddUsernamePasswordResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddUsernamePasswordResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAddUsernamePasswordResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddUsernamePasswordResultEvent != 1152921525820342800);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAddUsernamePasswordResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AddUsernamePasswordResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAddUsernamePasswordResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddUsernamePasswordResultEvent != 1152921525820479376);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAddUserVirtualCurrencyRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddUserVirtualCurrencyRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAddUserVirtualCurrencyRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddUserVirtualCurrencyRequestEvent != 1152921525820615960);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAddUserVirtualCurrencyRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AddUserVirtualCurrencyRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAddUserVirtualCurrencyRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddUserVirtualCurrencyRequestEvent != 1152921525820752536);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAddUserVirtualCurrencyResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ModifyUserVirtualCurrencyResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAddUserVirtualCurrencyResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddUserVirtualCurrencyResultEvent != 1152921525820889120);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAddUserVirtualCurrencyResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ModifyUserVirtualCurrencyResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAddUserVirtualCurrencyResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAddUserVirtualCurrencyResultEvent != 1152921525821025696);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAndroidDevicePushNotificationRegistrationRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAndroidDevicePushNotificationRegistrationRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAndroidDevicePushNotificationRegistrationRequestEvent != 1152921525821162280);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAndroidDevicePushNotificationRegistrationRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAndroidDevicePushNotificationRegistrationRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAndroidDevicePushNotificationRegistrationRequestEvent != 1152921525821298856);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAndroidDevicePushNotificationRegistrationResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAndroidDevicePushNotificationRegistrationResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAndroidDevicePushNotificationRegistrationResultEvent != 1152921525821435440);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAndroidDevicePushNotificationRegistrationResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AndroidDevicePushNotificationRegistrationResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAndroidDevicePushNotificationRegistrationResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAndroidDevicePushNotificationRegistrationResultEvent != 1152921525821572016);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAttributeInstallRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AttributeInstallRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAttributeInstallRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAttributeInstallRequestEvent != 1152921525821708600);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAttributeInstallRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.AttributeInstallRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAttributeInstallRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAttributeInstallRequestEvent != 1152921525821845176);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAttributeInstallResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AttributeInstallResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAttributeInstallResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAttributeInstallResultEvent != 1152921525821981760);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAttributeInstallResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.AttributeInstallResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAttributeInstallResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAttributeInstallResultEvent != 1152921525822118336);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnCancelTradeRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.CancelTradeRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnCancelTradeRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnCancelTradeRequestEvent != 1152921525822254920);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnCancelTradeRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.CancelTradeRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnCancelTradeRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnCancelTradeRequestEvent != 1152921525822391496);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnCancelTradeResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.CancelTradeResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnCancelTradeResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnCancelTradeResultEvent != 1152921525822528080);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnCancelTradeResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.CancelTradeResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnCancelTradeResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnCancelTradeResultEvent != 1152921525822664656);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnConfirmPurchaseRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ConfirmPurchaseRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnConfirmPurchaseRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConfirmPurchaseRequestEvent != 1152921525822801240);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnConfirmPurchaseRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ConfirmPurchaseRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnConfirmPurchaseRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConfirmPurchaseRequestEvent != 1152921525822937816);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnConfirmPurchaseResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ConfirmPurchaseResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnConfirmPurchaseResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConfirmPurchaseResultEvent != 1152921525823074400);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnConfirmPurchaseResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ConfirmPurchaseResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnConfirmPurchaseResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConfirmPurchaseResultEvent != 1152921525823210976);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnConsumeItemRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ConsumeItemRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnConsumeItemRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConsumeItemRequestEvent != 1152921525823347560);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnConsumeItemRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ConsumeItemRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnConsumeItemRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConsumeItemRequestEvent != 1152921525823484136);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnConsumeItemResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ConsumeItemResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnConsumeItemResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConsumeItemResultEvent != 1152921525823620720);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnConsumeItemResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ConsumeItemResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnConsumeItemResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConsumeItemResultEvent != 1152921525823757296);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnConsumePSNEntitlementsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ConsumePSNEntitlementsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnConsumePSNEntitlementsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConsumePSNEntitlementsRequestEvent != 1152921525823893880);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnConsumePSNEntitlementsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ConsumePSNEntitlementsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnConsumePSNEntitlementsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConsumePSNEntitlementsRequestEvent != 1152921525824030456);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnConsumePSNEntitlementsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ConsumePSNEntitlementsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnConsumePSNEntitlementsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConsumePSNEntitlementsResultEvent != this.OnConsumePSNEntitlementsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnConsumePSNEntitlementsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ConsumePSNEntitlementsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnConsumePSNEntitlementsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConsumePSNEntitlementsResultEvent != this.OnConsumePSNEntitlementsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnConsumeXboxEntitlementsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ConsumeXboxEntitlementsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnConsumeXboxEntitlementsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConsumeXboxEntitlementsRequestEvent != this.OnConsumeXboxEntitlementsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnConsumeXboxEntitlementsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ConsumeXboxEntitlementsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnConsumeXboxEntitlementsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConsumeXboxEntitlementsRequestEvent != this.OnConsumeXboxEntitlementsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnConsumeXboxEntitlementsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ConsumeXboxEntitlementsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnConsumeXboxEntitlementsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConsumeXboxEntitlementsResultEvent != this.OnConsumeXboxEntitlementsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnConsumeXboxEntitlementsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ConsumeXboxEntitlementsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnConsumeXboxEntitlementsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnConsumeXboxEntitlementsResultEvent != this.OnConsumeXboxEntitlementsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnCreateSharedGroupRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.CreateSharedGroupRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnCreateSharedGroupRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnCreateSharedGroupRequestEvent != this.OnCreateSharedGroupRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnCreateSharedGroupRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.CreateSharedGroupRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnCreateSharedGroupRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnCreateSharedGroupRequestEvent != this.OnCreateSharedGroupRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnCreateSharedGroupResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.CreateSharedGroupResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnCreateSharedGroupResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnCreateSharedGroupResultEvent != this.OnCreateSharedGroupResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnCreateSharedGroupResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.CreateSharedGroupResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnCreateSharedGroupResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnCreateSharedGroupResultEvent != this.OnCreateSharedGroupResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnExecuteCloudScriptRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ExecuteCloudScriptRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnExecuteCloudScriptRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnExecuteCloudScriptRequestEvent != this.OnExecuteCloudScriptRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnExecuteCloudScriptRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ExecuteCloudScriptRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnExecuteCloudScriptRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnExecuteCloudScriptRequestEvent != this.OnExecuteCloudScriptRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnExecuteCloudScriptResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ExecuteCloudScriptResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnExecuteCloudScriptResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnExecuteCloudScriptResultEvent != this.OnExecuteCloudScriptResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnExecuteCloudScriptResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ExecuteCloudScriptResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnExecuteCloudScriptResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnExecuteCloudScriptResultEvent != this.OnExecuteCloudScriptResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetAccountInfoRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetAccountInfoRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetAccountInfoRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetAccountInfoRequestEvent != this.OnGetAccountInfoRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetAccountInfoRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetAccountInfoRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetAccountInfoRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetAccountInfoRequestEvent != this.OnGetAccountInfoRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetAccountInfoResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetAccountInfoResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetAccountInfoResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetAccountInfoResultEvent != this.OnGetAccountInfoResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetAccountInfoResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetAccountInfoResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetAccountInfoResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetAccountInfoResultEvent != this.OnGetAccountInfoResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetAllUsersCharactersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ListUsersCharactersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetAllUsersCharactersRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetAllUsersCharactersRequestEvent != this.OnGetAllUsersCharactersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetAllUsersCharactersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ListUsersCharactersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetAllUsersCharactersRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetAllUsersCharactersRequestEvent != this.OnGetAllUsersCharactersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetAllUsersCharactersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ListUsersCharactersResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetAllUsersCharactersResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetAllUsersCharactersResultEvent != this.OnGetAllUsersCharactersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetAllUsersCharactersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ListUsersCharactersResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetAllUsersCharactersResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetAllUsersCharactersResultEvent != this.OnGetAllUsersCharactersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetCatalogItemsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCatalogItemsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetCatalogItemsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCatalogItemsRequestEvent != this.OnGetCatalogItemsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetCatalogItemsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCatalogItemsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetCatalogItemsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCatalogItemsRequestEvent != this.OnGetCatalogItemsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetCatalogItemsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCatalogItemsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetCatalogItemsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCatalogItemsResultEvent != this.OnGetCatalogItemsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetCatalogItemsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCatalogItemsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetCatalogItemsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCatalogItemsResultEvent != this.OnGetCatalogItemsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetCharacterDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetCharacterDataRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterDataRequestEvent != this.OnGetCharacterDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetCharacterDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetCharacterDataRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterDataRequestEvent != this.OnGetCharacterDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetCharacterDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetCharacterDataResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterDataResultEvent != this.OnGetCharacterDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetCharacterDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetCharacterDataResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterDataResultEvent != this.OnGetCharacterDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetCharacterInventoryRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterInventoryRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetCharacterInventoryRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterInventoryRequestEvent != this.OnGetCharacterInventoryRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetCharacterInventoryRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterInventoryRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetCharacterInventoryRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterInventoryRequestEvent != this.OnGetCharacterInventoryRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetCharacterInventoryResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterInventoryResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetCharacterInventoryResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterInventoryResultEvent != this.OnGetCharacterInventoryResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetCharacterInventoryResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterInventoryResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetCharacterInventoryResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterInventoryResultEvent != this.OnGetCharacterInventoryResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetCharacterLeaderboardRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterLeaderboardRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetCharacterLeaderboardRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterLeaderboardRequestEvent != this.OnGetCharacterLeaderboardRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetCharacterLeaderboardRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterLeaderboardRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetCharacterLeaderboardRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterLeaderboardRequestEvent != this.OnGetCharacterLeaderboardRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetCharacterLeaderboardResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterLeaderboardResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetCharacterLeaderboardResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterLeaderboardResultEvent != this.OnGetCharacterLeaderboardResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetCharacterLeaderboardResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterLeaderboardResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetCharacterLeaderboardResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterLeaderboardResultEvent != this.OnGetCharacterLeaderboardResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetCharacterReadOnlyDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetCharacterReadOnlyDataRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterReadOnlyDataRequestEvent != this.OnGetCharacterReadOnlyDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetCharacterReadOnlyDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetCharacterReadOnlyDataRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterReadOnlyDataRequestEvent != this.OnGetCharacterReadOnlyDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetCharacterReadOnlyDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetCharacterReadOnlyDataResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterReadOnlyDataResultEvent != this.OnGetCharacterReadOnlyDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetCharacterReadOnlyDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetCharacterReadOnlyDataResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterReadOnlyDataResultEvent != this.OnGetCharacterReadOnlyDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetCharacterStatisticsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterStatisticsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetCharacterStatisticsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterStatisticsRequestEvent != this.OnGetCharacterStatisticsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetCharacterStatisticsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetCharacterStatisticsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetCharacterStatisticsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterStatisticsRequestEvent != this.OnGetCharacterStatisticsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetCharacterStatisticsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterStatisticsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetCharacterStatisticsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterStatisticsResultEvent != this.OnGetCharacterStatisticsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetCharacterStatisticsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetCharacterStatisticsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetCharacterStatisticsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCharacterStatisticsResultEvent != this.OnGetCharacterStatisticsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetContentDownloadUrlRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetContentDownloadUrlRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetContentDownloadUrlRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetContentDownloadUrlRequestEvent != this.OnGetContentDownloadUrlRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetContentDownloadUrlRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetContentDownloadUrlRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetContentDownloadUrlRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetContentDownloadUrlRequestEvent != this.OnGetContentDownloadUrlRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetContentDownloadUrlResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetContentDownloadUrlResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetContentDownloadUrlResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetContentDownloadUrlResultEvent != this.OnGetContentDownloadUrlResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetContentDownloadUrlResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetContentDownloadUrlResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetContentDownloadUrlResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetContentDownloadUrlResultEvent != this.OnGetContentDownloadUrlResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetCurrentGamesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.CurrentGamesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetCurrentGamesRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCurrentGamesRequestEvent != this.OnGetCurrentGamesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetCurrentGamesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.CurrentGamesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetCurrentGamesRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCurrentGamesRequestEvent != this.OnGetCurrentGamesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetCurrentGamesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.CurrentGamesResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetCurrentGamesResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCurrentGamesResultEvent != this.OnGetCurrentGamesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetCurrentGamesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.CurrentGamesResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetCurrentGamesResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetCurrentGamesResultEvent != this.OnGetCurrentGamesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetFriendLeaderboardRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetFriendLeaderboardRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetFriendLeaderboardRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetFriendLeaderboardRequestEvent != this.OnGetFriendLeaderboardRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetFriendLeaderboardRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetFriendLeaderboardRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetFriendLeaderboardRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetFriendLeaderboardRequestEvent != this.OnGetFriendLeaderboardRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetFriendLeaderboardResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetFriendLeaderboardResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetFriendLeaderboardResultEvent != this.OnGetFriendLeaderboardResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetFriendLeaderboardResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetFriendLeaderboardResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetFriendLeaderboardResultEvent != this.OnGetFriendLeaderboardResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetFriendLeaderboardAroundPlayerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetFriendLeaderboardAroundPlayerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetFriendLeaderboardAroundPlayerRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetFriendLeaderboardAroundPlayerRequestEvent != this.OnGetFriendLeaderboardAroundPlayerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetFriendLeaderboardAroundPlayerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetFriendLeaderboardAroundPlayerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetFriendLeaderboardAroundPlayerRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetFriendLeaderboardAroundPlayerRequestEvent != this.OnGetFriendLeaderboardAroundPlayerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetFriendLeaderboardAroundPlayerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetFriendLeaderboardAroundPlayerResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetFriendLeaderboardAroundPlayerResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetFriendLeaderboardAroundPlayerResultEvent != this.OnGetFriendLeaderboardAroundPlayerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetFriendLeaderboardAroundPlayerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetFriendLeaderboardAroundPlayerResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetFriendLeaderboardAroundPlayerResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetFriendLeaderboardAroundPlayerResultEvent != this.OnGetFriendLeaderboardAroundPlayerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetFriendsListRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetFriendsListRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetFriendsListRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetFriendsListRequestEvent != this.OnGetFriendsListRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetFriendsListRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetFriendsListRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetFriendsListRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetFriendsListRequestEvent != this.OnGetFriendsListRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetFriendsListResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetFriendsListResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetFriendsListResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetFriendsListResultEvent != this.OnGetFriendsListResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetFriendsListResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetFriendsListResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetFriendsListResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetFriendsListResultEvent != this.OnGetFriendsListResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetGameServerRegionsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GameServerRegionsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetGameServerRegionsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetGameServerRegionsRequestEvent != this.OnGetGameServerRegionsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetGameServerRegionsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GameServerRegionsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetGameServerRegionsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetGameServerRegionsRequestEvent != this.OnGetGameServerRegionsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetGameServerRegionsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GameServerRegionsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetGameServerRegionsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetGameServerRegionsResultEvent != this.OnGetGameServerRegionsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetGameServerRegionsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GameServerRegionsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetGameServerRegionsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetGameServerRegionsResultEvent != this.OnGetGameServerRegionsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetLeaderboardRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetLeaderboardRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetLeaderboardRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardRequestEvent != this.OnGetLeaderboardRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetLeaderboardRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetLeaderboardRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetLeaderboardRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardRequestEvent != this.OnGetLeaderboardRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetLeaderboardResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetLeaderboardResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardResultEvent != this.OnGetLeaderboardResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetLeaderboardResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetLeaderboardResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardResultEvent != this.OnGetLeaderboardResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetLeaderboardAroundCharacterRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetLeaderboardAroundCharacterRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetLeaderboardAroundCharacterRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardAroundCharacterRequestEvent != this.OnGetLeaderboardAroundCharacterRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetLeaderboardAroundCharacterRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetLeaderboardAroundCharacterRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetLeaderboardAroundCharacterRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardAroundCharacterRequestEvent != this.OnGetLeaderboardAroundCharacterRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetLeaderboardAroundCharacterResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardAroundCharacterResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetLeaderboardAroundCharacterResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardAroundCharacterResultEvent != this.OnGetLeaderboardAroundCharacterResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetLeaderboardAroundCharacterResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardAroundCharacterResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetLeaderboardAroundCharacterResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardAroundCharacterResultEvent != this.OnGetLeaderboardAroundCharacterResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetLeaderboardAroundPlayerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetLeaderboardAroundPlayerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetLeaderboardAroundPlayerRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardAroundPlayerRequestEvent != this.OnGetLeaderboardAroundPlayerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetLeaderboardAroundPlayerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetLeaderboardAroundPlayerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetLeaderboardAroundPlayerRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardAroundPlayerRequestEvent != this.OnGetLeaderboardAroundPlayerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetLeaderboardAroundPlayerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardAroundPlayerResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetLeaderboardAroundPlayerResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardAroundPlayerResultEvent != this.OnGetLeaderboardAroundPlayerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetLeaderboardAroundPlayerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardAroundPlayerResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetLeaderboardAroundPlayerResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardAroundPlayerResultEvent != this.OnGetLeaderboardAroundPlayerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetLeaderboardForUserCharactersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetLeaderboardForUsersCharactersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetLeaderboardForUserCharactersRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardForUserCharactersRequestEvent != this.OnGetLeaderboardForUserCharactersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetLeaderboardForUserCharactersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetLeaderboardForUsersCharactersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetLeaderboardForUserCharactersRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardForUserCharactersRequestEvent != this.OnGetLeaderboardForUserCharactersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetLeaderboardForUserCharactersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardForUsersCharactersResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetLeaderboardForUserCharactersResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardForUserCharactersResultEvent != this.OnGetLeaderboardForUserCharactersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetLeaderboardForUserCharactersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetLeaderboardForUsersCharactersResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetLeaderboardForUserCharactersResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetLeaderboardForUserCharactersResultEvent != this.OnGetLeaderboardForUserCharactersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPaymentTokenRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPaymentTokenRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPaymentTokenRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPaymentTokenRequestEvent != this.OnGetPaymentTokenRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPaymentTokenRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPaymentTokenRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPaymentTokenRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPaymentTokenRequestEvent != this.OnGetPaymentTokenRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPaymentTokenResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPaymentTokenResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPaymentTokenResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPaymentTokenResultEvent != this.OnGetPaymentTokenResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPaymentTokenResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPaymentTokenResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPaymentTokenResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPaymentTokenResultEvent != this.OnGetPaymentTokenResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPhotonAuthenticationTokenRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPhotonAuthenticationTokenRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPhotonAuthenticationTokenRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPhotonAuthenticationTokenRequestEvent != this.OnGetPhotonAuthenticationTokenRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPhotonAuthenticationTokenRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPhotonAuthenticationTokenRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPhotonAuthenticationTokenRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPhotonAuthenticationTokenRequestEvent != this.OnGetPhotonAuthenticationTokenRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPhotonAuthenticationTokenResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPhotonAuthenticationTokenResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPhotonAuthenticationTokenResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPhotonAuthenticationTokenResultEvent != this.OnGetPhotonAuthenticationTokenResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPhotonAuthenticationTokenResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPhotonAuthenticationTokenResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPhotonAuthenticationTokenResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPhotonAuthenticationTokenResultEvent != this.OnGetPhotonAuthenticationTokenResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayerCombinedInfoRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerCombinedInfoRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayerCombinedInfoRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerCombinedInfoRequestEvent != this.OnGetPlayerCombinedInfoRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayerCombinedInfoRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerCombinedInfoRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayerCombinedInfoRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerCombinedInfoRequestEvent != this.OnGetPlayerCombinedInfoRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayerCombinedInfoResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerCombinedInfoResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayerCombinedInfoResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerCombinedInfoResultEvent != this.OnGetPlayerCombinedInfoResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayerCombinedInfoResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerCombinedInfoResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayerCombinedInfoResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerCombinedInfoResultEvent != this.OnGetPlayerCombinedInfoResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayerProfileRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerProfileRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayerProfileRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerProfileRequestEvent != this.OnGetPlayerProfileRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayerProfileRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerProfileRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayerProfileRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerProfileRequestEvent != this.OnGetPlayerProfileRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayerProfileResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerProfileResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayerProfileResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerProfileResultEvent != this.OnGetPlayerProfileResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayerProfileResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerProfileResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayerProfileResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerProfileResultEvent != this.OnGetPlayerProfileResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayerSegmentsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerSegmentsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayerSegmentsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerSegmentsRequestEvent != this.OnGetPlayerSegmentsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayerSegmentsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerSegmentsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayerSegmentsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerSegmentsRequestEvent != this.OnGetPlayerSegmentsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayerSegmentsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerSegmentsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayerSegmentsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerSegmentsResultEvent != this.OnGetPlayerSegmentsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayerSegmentsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerSegmentsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayerSegmentsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerSegmentsResultEvent != this.OnGetPlayerSegmentsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayerStatisticsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerStatisticsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayerStatisticsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerStatisticsRequestEvent != this.OnGetPlayerStatisticsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayerStatisticsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerStatisticsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayerStatisticsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerStatisticsRequestEvent != this.OnGetPlayerStatisticsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayerStatisticsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerStatisticsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayerStatisticsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerStatisticsResultEvent != this.OnGetPlayerStatisticsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayerStatisticsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerStatisticsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayerStatisticsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerStatisticsResultEvent != this.OnGetPlayerStatisticsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayerStatisticVersionsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerStatisticVersionsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayerStatisticVersionsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerStatisticVersionsRequestEvent != this.OnGetPlayerStatisticVersionsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayerStatisticVersionsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerStatisticVersionsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayerStatisticVersionsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerStatisticVersionsRequestEvent != this.OnGetPlayerStatisticVersionsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayerStatisticVersionsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerStatisticVersionsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayerStatisticVersionsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerStatisticVersionsResultEvent != this.OnGetPlayerStatisticVersionsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayerStatisticVersionsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerStatisticVersionsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayerStatisticVersionsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerStatisticVersionsResultEvent != this.OnGetPlayerStatisticVersionsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayerTagsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerTagsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayerTagsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerTagsRequestEvent != this.OnGetPlayerTagsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayerTagsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerTagsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayerTagsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerTagsRequestEvent != this.OnGetPlayerTagsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayerTagsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerTagsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayerTagsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerTagsResultEvent != this.OnGetPlayerTagsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayerTagsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerTagsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayerTagsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerTagsResultEvent != this.OnGetPlayerTagsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayerTradesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerTradesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayerTradesRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerTradesRequestEvent != this.OnGetPlayerTradesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayerTradesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayerTradesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayerTradesRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerTradesRequestEvent != this.OnGetPlayerTradesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayerTradesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerTradesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayerTradesResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerTradesResultEvent != this.OnGetPlayerTradesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayerTradesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayerTradesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayerTradesResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayerTradesResultEvent != this.OnGetPlayerTradesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromFacebookIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromFacebookIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromFacebookIDsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromFacebookIDsRequestEvent != this.OnGetPlayFabIDsFromFacebookIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromFacebookIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromFacebookIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromFacebookIDsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromFacebookIDsRequestEvent != this.OnGetPlayFabIDsFromFacebookIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromFacebookIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromFacebookIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromFacebookIDsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromFacebookIDsResultEvent != this.OnGetPlayFabIDsFromFacebookIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromFacebookIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromFacebookIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromFacebookIDsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromFacebookIDsResultEvent != this.OnGetPlayFabIDsFromFacebookIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromFacebookInstantGamesIdsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromFacebookInstantGamesIdsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromFacebookInstantGamesIdsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromFacebookInstantGamesIdsRequestEvent != this.OnGetPlayFabIDsFromFacebookInstantGamesIdsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromFacebookInstantGamesIdsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromFacebookInstantGamesIdsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromFacebookInstantGamesIdsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromFacebookInstantGamesIdsRequestEvent != this.OnGetPlayFabIDsFromFacebookInstantGamesIdsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromFacebookInstantGamesIdsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromFacebookInstantGamesIdsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromFacebookInstantGamesIdsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromFacebookInstantGamesIdsResultEvent != this.OnGetPlayFabIDsFromFacebookInstantGamesIdsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromFacebookInstantGamesIdsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromFacebookInstantGamesIdsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromFacebookInstantGamesIdsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromFacebookInstantGamesIdsResultEvent != this.OnGetPlayFabIDsFromFacebookInstantGamesIdsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromGameCenterIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromGameCenterIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromGameCenterIDsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromGameCenterIDsRequestEvent != this.OnGetPlayFabIDsFromGameCenterIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromGameCenterIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromGameCenterIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromGameCenterIDsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromGameCenterIDsRequestEvent != this.OnGetPlayFabIDsFromGameCenterIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromGameCenterIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromGameCenterIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromGameCenterIDsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromGameCenterIDsResultEvent != this.OnGetPlayFabIDsFromGameCenterIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromGameCenterIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromGameCenterIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromGameCenterIDsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromGameCenterIDsResultEvent != this.OnGetPlayFabIDsFromGameCenterIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromGenericIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromGenericIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromGenericIDsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromGenericIDsRequestEvent != this.OnGetPlayFabIDsFromGenericIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromGenericIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromGenericIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromGenericIDsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromGenericIDsRequestEvent != this.OnGetPlayFabIDsFromGenericIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromGenericIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromGenericIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromGenericIDsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromGenericIDsResultEvent != this.OnGetPlayFabIDsFromGenericIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromGenericIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromGenericIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromGenericIDsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromGenericIDsResultEvent != this.OnGetPlayFabIDsFromGenericIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromGoogleIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromGoogleIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromGoogleIDsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromGoogleIDsRequestEvent != this.OnGetPlayFabIDsFromGoogleIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromGoogleIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromGoogleIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromGoogleIDsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromGoogleIDsRequestEvent != this.OnGetPlayFabIDsFromGoogleIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromGoogleIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromGoogleIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromGoogleIDsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromGoogleIDsResultEvent != this.OnGetPlayFabIDsFromGoogleIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromGoogleIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromGoogleIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromGoogleIDsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromGoogleIDsResultEvent != this.OnGetPlayFabIDsFromGoogleIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromKongregateIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromKongregateIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromKongregateIDsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromKongregateIDsRequestEvent != this.OnGetPlayFabIDsFromKongregateIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromKongregateIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromKongregateIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromKongregateIDsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromKongregateIDsRequestEvent != this.OnGetPlayFabIDsFromKongregateIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromKongregateIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromKongregateIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromKongregateIDsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromKongregateIDsResultEvent != this.OnGetPlayFabIDsFromKongregateIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromKongregateIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromKongregateIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromKongregateIDsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromKongregateIDsResultEvent != this.OnGetPlayFabIDsFromKongregateIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromNintendoSwitchDeviceIdsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromNintendoSwitchDeviceIdsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromNintendoSwitchDeviceIdsRequestEvent != this.OnGetPlayFabIDsFromNintendoSwitchDeviceIdsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromNintendoSwitchDeviceIdsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromNintendoSwitchDeviceIdsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromNintendoSwitchDeviceIdsRequestEvent != this.OnGetPlayFabIDsFromNintendoSwitchDeviceIdsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromNintendoSwitchDeviceIdsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromNintendoSwitchDeviceIdsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromNintendoSwitchDeviceIdsResultEvent != this.OnGetPlayFabIDsFromNintendoSwitchDeviceIdsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromNintendoSwitchDeviceIdsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromNintendoSwitchDeviceIdsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromNintendoSwitchDeviceIdsResultEvent != this.OnGetPlayFabIDsFromNintendoSwitchDeviceIdsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromPSNAccountIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromPSNAccountIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromPSNAccountIDsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromPSNAccountIDsRequestEvent != this.OnGetPlayFabIDsFromPSNAccountIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromPSNAccountIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromPSNAccountIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromPSNAccountIDsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromPSNAccountIDsRequestEvent != this.OnGetPlayFabIDsFromPSNAccountIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromPSNAccountIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromPSNAccountIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromPSNAccountIDsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromPSNAccountIDsResultEvent != this.OnGetPlayFabIDsFromPSNAccountIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromPSNAccountIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromPSNAccountIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromPSNAccountIDsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromPSNAccountIDsResultEvent != this.OnGetPlayFabIDsFromPSNAccountIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromSteamIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromSteamIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromSteamIDsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromSteamIDsRequestEvent != this.OnGetPlayFabIDsFromSteamIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromSteamIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromSteamIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromSteamIDsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromSteamIDsRequestEvent != this.OnGetPlayFabIDsFromSteamIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromSteamIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromSteamIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromSteamIDsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromSteamIDsResultEvent != this.OnGetPlayFabIDsFromSteamIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromSteamIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromSteamIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromSteamIDsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromSteamIDsResultEvent != this.OnGetPlayFabIDsFromSteamIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromTwitchIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromTwitchIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromTwitchIDsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromTwitchIDsRequestEvent != this.OnGetPlayFabIDsFromTwitchIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromTwitchIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromTwitchIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromTwitchIDsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromTwitchIDsRequestEvent != this.OnGetPlayFabIDsFromTwitchIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromTwitchIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromTwitchIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromTwitchIDsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromTwitchIDsResultEvent != this.OnGetPlayFabIDsFromTwitchIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromTwitchIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromTwitchIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromTwitchIDsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromTwitchIDsResultEvent != this.OnGetPlayFabIDsFromTwitchIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromXboxLiveIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromXboxLiveIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromXboxLiveIDsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromXboxLiveIDsRequestEvent != this.OnGetPlayFabIDsFromXboxLiveIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromXboxLiveIDsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPlayFabIDsFromXboxLiveIDsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromXboxLiveIDsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromXboxLiveIDsRequestEvent != this.OnGetPlayFabIDsFromXboxLiveIDsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPlayFabIDsFromXboxLiveIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromXboxLiveIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPlayFabIDsFromXboxLiveIDsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromXboxLiveIDsResultEvent != this.OnGetPlayFabIDsFromXboxLiveIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPlayFabIDsFromXboxLiveIDsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPlayFabIDsFromXboxLiveIDsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPlayFabIDsFromXboxLiveIDsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPlayFabIDsFromXboxLiveIDsResultEvent != this.OnGetPlayFabIDsFromXboxLiveIDsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPublisherDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPublisherDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPublisherDataRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPublisherDataRequestEvent != this.OnGetPublisherDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPublisherDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPublisherDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPublisherDataRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPublisherDataRequestEvent != this.OnGetPublisherDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPublisherDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPublisherDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPublisherDataResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPublisherDataResultEvent != this.OnGetPublisherDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPublisherDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPublisherDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPublisherDataResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPublisherDataResultEvent != this.OnGetPublisherDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPurchaseRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPurchaseRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPurchaseRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPurchaseRequestEvent != this.OnGetPurchaseRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPurchaseRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetPurchaseRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPurchaseRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPurchaseRequestEvent != this.OnGetPurchaseRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetPurchaseResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPurchaseResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetPurchaseResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPurchaseResultEvent != this.OnGetPurchaseResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetPurchaseResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetPurchaseResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetPurchaseResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetPurchaseResultEvent != this.OnGetPurchaseResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetSharedGroupDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetSharedGroupDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetSharedGroupDataRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetSharedGroupDataRequestEvent != this.OnGetSharedGroupDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetSharedGroupDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetSharedGroupDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetSharedGroupDataRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetSharedGroupDataRequestEvent != this.OnGetSharedGroupDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetSharedGroupDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetSharedGroupDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetSharedGroupDataResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetSharedGroupDataResultEvent != this.OnGetSharedGroupDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetSharedGroupDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetSharedGroupDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetSharedGroupDataResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetSharedGroupDataResultEvent != this.OnGetSharedGroupDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetStoreItemsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetStoreItemsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetStoreItemsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetStoreItemsRequestEvent != this.OnGetStoreItemsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetStoreItemsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetStoreItemsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetStoreItemsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetStoreItemsRequestEvent != this.OnGetStoreItemsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetStoreItemsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetStoreItemsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetStoreItemsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetStoreItemsResultEvent != this.OnGetStoreItemsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetStoreItemsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetStoreItemsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetStoreItemsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetStoreItemsResultEvent != this.OnGetStoreItemsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetTimeRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTimeRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetTimeRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTimeRequestEvent != this.OnGetTimeRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetTimeRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTimeRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetTimeRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTimeRequestEvent != this.OnGetTimeRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetTimeResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTimeResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetTimeResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTimeResultEvent != this.OnGetTimeResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetTimeResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTimeResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetTimeResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTimeResultEvent != this.OnGetTimeResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetTitleDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTitleDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetTitleDataRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTitleDataRequestEvent != this.OnGetTitleDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetTitleDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTitleDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetTitleDataRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTitleDataRequestEvent != this.OnGetTitleDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetTitleDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTitleDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetTitleDataResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTitleDataResultEvent != this.OnGetTitleDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetTitleDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTitleDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetTitleDataResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTitleDataResultEvent != this.OnGetTitleDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetTitleNewsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTitleNewsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetTitleNewsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTitleNewsRequestEvent != this.OnGetTitleNewsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetTitleNewsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTitleNewsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetTitleNewsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTitleNewsRequestEvent != this.OnGetTitleNewsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetTitleNewsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTitleNewsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetTitleNewsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTitleNewsResultEvent != this.OnGetTitleNewsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetTitleNewsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTitleNewsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetTitleNewsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTitleNewsResultEvent != this.OnGetTitleNewsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetTitlePublicKeyRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTitlePublicKeyRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetTitlePublicKeyRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTitlePublicKeyRequestEvent != this.OnGetTitlePublicKeyRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetTitlePublicKeyRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTitlePublicKeyRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetTitlePublicKeyRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTitlePublicKeyRequestEvent != this.OnGetTitlePublicKeyRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetTitlePublicKeyResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTitlePublicKeyResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetTitlePublicKeyResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTitlePublicKeyResultEvent != this.OnGetTitlePublicKeyResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetTitlePublicKeyResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTitlePublicKeyResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetTitlePublicKeyResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTitlePublicKeyResultEvent != this.OnGetTitlePublicKeyResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetTradeStatusRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTradeStatusRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetTradeStatusRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTradeStatusRequestEvent != this.OnGetTradeStatusRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetTradeStatusRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetTradeStatusRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetTradeStatusRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTradeStatusRequestEvent != this.OnGetTradeStatusRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetTradeStatusResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTradeStatusResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetTradeStatusResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTradeStatusResultEvent != this.OnGetTradeStatusResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetTradeStatusResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetTradeStatusResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetTradeStatusResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetTradeStatusResultEvent != this.OnGetTradeStatusResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetUserDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetUserDataRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserDataRequestEvent != this.OnGetUserDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetUserDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetUserDataRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserDataRequestEvent != this.OnGetUserDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetUserDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetUserDataResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserDataResultEvent != this.OnGetUserDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetUserDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetUserDataResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserDataResultEvent != this.OnGetUserDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetUserInventoryRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserInventoryRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetUserInventoryRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserInventoryRequestEvent != this.OnGetUserInventoryRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetUserInventoryRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserInventoryRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetUserInventoryRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserInventoryRequestEvent != this.OnGetUserInventoryRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetUserInventoryResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserInventoryResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetUserInventoryResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserInventoryResultEvent != this.OnGetUserInventoryResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetUserInventoryResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserInventoryResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetUserInventoryResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserInventoryResultEvent != this.OnGetUserInventoryResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetUserPublisherDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetUserPublisherDataRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserPublisherDataRequestEvent != this.OnGetUserPublisherDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetUserPublisherDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetUserPublisherDataRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserPublisherDataRequestEvent != this.OnGetUserPublisherDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetUserPublisherDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetUserPublisherDataResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserPublisherDataResultEvent != this.OnGetUserPublisherDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetUserPublisherDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetUserPublisherDataResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserPublisherDataResultEvent != this.OnGetUserPublisherDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetUserPublisherReadOnlyDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetUserPublisherReadOnlyDataRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserPublisherReadOnlyDataRequestEvent != this.OnGetUserPublisherReadOnlyDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetUserPublisherReadOnlyDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetUserPublisherReadOnlyDataRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserPublisherReadOnlyDataRequestEvent != this.OnGetUserPublisherReadOnlyDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetUserPublisherReadOnlyDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetUserPublisherReadOnlyDataResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserPublisherReadOnlyDataResultEvent != this.OnGetUserPublisherReadOnlyDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetUserPublisherReadOnlyDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetUserPublisherReadOnlyDataResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserPublisherReadOnlyDataResultEvent != this.OnGetUserPublisherReadOnlyDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetUserReadOnlyDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetUserReadOnlyDataRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserReadOnlyDataRequestEvent != this.OnGetUserReadOnlyDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetUserReadOnlyDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetUserDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetUserReadOnlyDataRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserReadOnlyDataRequestEvent != this.OnGetUserReadOnlyDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetUserReadOnlyDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetUserReadOnlyDataResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserReadOnlyDataResultEvent != this.OnGetUserReadOnlyDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetUserReadOnlyDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetUserDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetUserReadOnlyDataResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetUserReadOnlyDataResultEvent != this.OnGetUserReadOnlyDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetWindowsHelloChallengeRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetWindowsHelloChallengeRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetWindowsHelloChallengeRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetWindowsHelloChallengeRequestEvent != this.OnGetWindowsHelloChallengeRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetWindowsHelloChallengeRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GetWindowsHelloChallengeRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetWindowsHelloChallengeRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetWindowsHelloChallengeRequestEvent != this.OnGetWindowsHelloChallengeRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGetWindowsHelloChallengeResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetWindowsHelloChallengeResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGetWindowsHelloChallengeResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetWindowsHelloChallengeResultEvent != this.OnGetWindowsHelloChallengeResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGetWindowsHelloChallengeResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GetWindowsHelloChallengeResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGetWindowsHelloChallengeResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGetWindowsHelloChallengeResultEvent != this.OnGetWindowsHelloChallengeResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGrantCharacterToUserRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GrantCharacterToUserRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGrantCharacterToUserRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGrantCharacterToUserRequestEvent != this.OnGrantCharacterToUserRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGrantCharacterToUserRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.GrantCharacterToUserRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGrantCharacterToUserRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGrantCharacterToUserRequestEvent != this.OnGrantCharacterToUserRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGrantCharacterToUserResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GrantCharacterToUserResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGrantCharacterToUserResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGrantCharacterToUserResultEvent != this.OnGrantCharacterToUserResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGrantCharacterToUserResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.GrantCharacterToUserResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGrantCharacterToUserResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGrantCharacterToUserResultEvent != this.OnGrantCharacterToUserResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkAndroidDeviceIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkAndroidDeviceIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkAndroidDeviceIDRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkAndroidDeviceIDRequestEvent != this.OnLinkAndroidDeviceIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkAndroidDeviceIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkAndroidDeviceIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkAndroidDeviceIDRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkAndroidDeviceIDRequestEvent != this.OnLinkAndroidDeviceIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkAndroidDeviceIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkAndroidDeviceIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkAndroidDeviceIDResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkAndroidDeviceIDResultEvent != this.OnLinkAndroidDeviceIDResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkAndroidDeviceIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkAndroidDeviceIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkAndroidDeviceIDResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkAndroidDeviceIDResultEvent != this.OnLinkAndroidDeviceIDResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkCustomIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkCustomIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkCustomIDRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkCustomIDRequestEvent != this.OnLinkCustomIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkCustomIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkCustomIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkCustomIDRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkCustomIDRequestEvent != this.OnLinkCustomIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkCustomIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkCustomIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkCustomIDResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkCustomIDResultEvent != this.OnLinkCustomIDResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkCustomIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkCustomIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkCustomIDResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkCustomIDResultEvent != this.OnLinkCustomIDResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkFacebookAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkFacebookAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkFacebookAccountRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkFacebookAccountRequestEvent != this.OnLinkFacebookAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkFacebookAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkFacebookAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkFacebookAccountRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkFacebookAccountRequestEvent != this.OnLinkFacebookAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkFacebookAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkFacebookAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkFacebookAccountResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkFacebookAccountResultEvent != this.OnLinkFacebookAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkFacebookAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkFacebookAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkFacebookAccountResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkFacebookAccountResultEvent != this.OnLinkFacebookAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkFacebookInstantGamesIdRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkFacebookInstantGamesIdRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkFacebookInstantGamesIdRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkFacebookInstantGamesIdRequestEvent != this.OnLinkFacebookInstantGamesIdRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkFacebookInstantGamesIdRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkFacebookInstantGamesIdRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkFacebookInstantGamesIdRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkFacebookInstantGamesIdRequestEvent != this.OnLinkFacebookInstantGamesIdRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkFacebookInstantGamesIdResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkFacebookInstantGamesIdResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkFacebookInstantGamesIdResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkFacebookInstantGamesIdResultEvent != this.OnLinkFacebookInstantGamesIdResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkFacebookInstantGamesIdResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkFacebookInstantGamesIdResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkFacebookInstantGamesIdResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkFacebookInstantGamesIdResultEvent != this.OnLinkFacebookInstantGamesIdResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkGameCenterAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkGameCenterAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkGameCenterAccountRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkGameCenterAccountRequestEvent != this.OnLinkGameCenterAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkGameCenterAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkGameCenterAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkGameCenterAccountRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkGameCenterAccountRequestEvent != this.OnLinkGameCenterAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkGameCenterAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkGameCenterAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkGameCenterAccountResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkGameCenterAccountResultEvent != this.OnLinkGameCenterAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkGameCenterAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkGameCenterAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkGameCenterAccountResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkGameCenterAccountResultEvent != this.OnLinkGameCenterAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkGoogleAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkGoogleAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkGoogleAccountRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkGoogleAccountRequestEvent != this.OnLinkGoogleAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkGoogleAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkGoogleAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkGoogleAccountRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkGoogleAccountRequestEvent != this.OnLinkGoogleAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkGoogleAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkGoogleAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkGoogleAccountResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkGoogleAccountResultEvent != this.OnLinkGoogleAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkGoogleAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkGoogleAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkGoogleAccountResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkGoogleAccountResultEvent != this.OnLinkGoogleAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkIOSDeviceIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkIOSDeviceIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkIOSDeviceIDRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkIOSDeviceIDRequestEvent != this.OnLinkIOSDeviceIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkIOSDeviceIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkIOSDeviceIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkIOSDeviceIDRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkIOSDeviceIDRequestEvent != this.OnLinkIOSDeviceIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkIOSDeviceIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkIOSDeviceIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkIOSDeviceIDResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkIOSDeviceIDResultEvent != this.OnLinkIOSDeviceIDResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkIOSDeviceIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkIOSDeviceIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkIOSDeviceIDResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkIOSDeviceIDResultEvent != this.OnLinkIOSDeviceIDResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkKongregateRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkKongregateAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkKongregateRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkKongregateRequestEvent != this.OnLinkKongregateRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkKongregateRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkKongregateAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkKongregateRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkKongregateRequestEvent != this.OnLinkKongregateRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkKongregateResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkKongregateAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkKongregateResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkKongregateResultEvent != this.OnLinkKongregateResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkKongregateResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkKongregateAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkKongregateResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkKongregateResultEvent != this.OnLinkKongregateResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkNintendoSwitchDeviceIdRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkNintendoSwitchDeviceIdRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkNintendoSwitchDeviceIdRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkNintendoSwitchDeviceIdRequestEvent != this.OnLinkNintendoSwitchDeviceIdRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkNintendoSwitchDeviceIdRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkNintendoSwitchDeviceIdRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkNintendoSwitchDeviceIdRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkNintendoSwitchDeviceIdRequestEvent != this.OnLinkNintendoSwitchDeviceIdRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkNintendoSwitchDeviceIdResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkNintendoSwitchDeviceIdResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkNintendoSwitchDeviceIdResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkNintendoSwitchDeviceIdResultEvent != this.OnLinkNintendoSwitchDeviceIdResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkNintendoSwitchDeviceIdResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkNintendoSwitchDeviceIdResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkNintendoSwitchDeviceIdResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkNintendoSwitchDeviceIdResultEvent != this.OnLinkNintendoSwitchDeviceIdResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkOpenIdConnectRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkOpenIdConnectRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkOpenIdConnectRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkOpenIdConnectRequestEvent != this.OnLinkOpenIdConnectRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkOpenIdConnectRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkOpenIdConnectRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkOpenIdConnectRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkOpenIdConnectRequestEvent != this.OnLinkOpenIdConnectRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkOpenIdConnectResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkOpenIdConnectResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkOpenIdConnectResultEvent != this.OnLinkOpenIdConnectResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkOpenIdConnectResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkOpenIdConnectResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkOpenIdConnectResultEvent != this.OnLinkOpenIdConnectResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkPSNAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkPSNAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkPSNAccountRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkPSNAccountRequestEvent != this.OnLinkPSNAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkPSNAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkPSNAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkPSNAccountRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkPSNAccountRequestEvent != this.OnLinkPSNAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkPSNAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkPSNAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkPSNAccountResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkPSNAccountResultEvent != this.OnLinkPSNAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkPSNAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkPSNAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkPSNAccountResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkPSNAccountResultEvent != this.OnLinkPSNAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkSteamAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkSteamAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkSteamAccountRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkSteamAccountRequestEvent != this.OnLinkSteamAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkSteamAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkSteamAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkSteamAccountRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkSteamAccountRequestEvent != this.OnLinkSteamAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkSteamAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkSteamAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkSteamAccountResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkSteamAccountResultEvent != this.OnLinkSteamAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkSteamAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkSteamAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkSteamAccountResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkSteamAccountResultEvent != this.OnLinkSteamAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkTwitchRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkTwitchAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkTwitchRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkTwitchRequestEvent != this.OnLinkTwitchRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkTwitchRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkTwitchAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkTwitchRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkTwitchRequestEvent != this.OnLinkTwitchRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkTwitchResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkTwitchAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkTwitchResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkTwitchResultEvent != this.OnLinkTwitchResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkTwitchResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkTwitchAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkTwitchResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkTwitchResultEvent != this.OnLinkTwitchResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkWindowsHelloRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkWindowsHelloAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkWindowsHelloRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkWindowsHelloRequestEvent != this.OnLinkWindowsHelloRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkWindowsHelloRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkWindowsHelloAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkWindowsHelloRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkWindowsHelloRequestEvent != this.OnLinkWindowsHelloRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkWindowsHelloResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkWindowsHelloAccountResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkWindowsHelloResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkWindowsHelloResultEvent != this.OnLinkWindowsHelloResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkWindowsHelloResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkWindowsHelloAccountResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkWindowsHelloResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkWindowsHelloResultEvent != this.OnLinkWindowsHelloResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkXboxAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkXboxAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkXboxAccountRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkXboxAccountRequestEvent != this.OnLinkXboxAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkXboxAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LinkXboxAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkXboxAccountRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkXboxAccountRequestEvent != this.OnLinkXboxAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLinkXboxAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkXboxAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLinkXboxAccountResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkXboxAccountResultEvent != this.OnLinkXboxAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLinkXboxAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.LinkXboxAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLinkXboxAccountResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLinkXboxAccountResultEvent != this.OnLinkXboxAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithAndroidDeviceIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithAndroidDeviceIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithAndroidDeviceIDRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithAndroidDeviceIDRequestEvent != this.OnLoginWithAndroidDeviceIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithAndroidDeviceIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithAndroidDeviceIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithAndroidDeviceIDRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithAndroidDeviceIDRequestEvent != this.OnLoginWithAndroidDeviceIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithCustomIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithCustomIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithCustomIDRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithCustomIDRequestEvent != this.OnLoginWithCustomIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithCustomIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithCustomIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithCustomIDRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithCustomIDRequestEvent != this.OnLoginWithCustomIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithEmailAddressRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithEmailAddressRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithEmailAddressRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithEmailAddressRequestEvent != this.OnLoginWithEmailAddressRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithEmailAddressRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithEmailAddressRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithEmailAddressRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithEmailAddressRequestEvent != this.OnLoginWithEmailAddressRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithFacebookRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithFacebookRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithFacebookRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithFacebookRequestEvent != this.OnLoginWithFacebookRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithFacebookRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithFacebookRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithFacebookRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithFacebookRequestEvent != this.OnLoginWithFacebookRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithFacebookInstantGamesIdRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithFacebookInstantGamesIdRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithFacebookInstantGamesIdRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithFacebookInstantGamesIdRequestEvent != this.OnLoginWithFacebookInstantGamesIdRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithFacebookInstantGamesIdRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithFacebookInstantGamesIdRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithFacebookInstantGamesIdRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithFacebookInstantGamesIdRequestEvent != this.OnLoginWithFacebookInstantGamesIdRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithGameCenterRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithGameCenterRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithGameCenterRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithGameCenterRequestEvent != this.OnLoginWithGameCenterRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithGameCenterRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithGameCenterRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithGameCenterRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithGameCenterRequestEvent != this.OnLoginWithGameCenterRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithGoogleAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithGoogleAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithGoogleAccountRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithGoogleAccountRequestEvent != this.OnLoginWithGoogleAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithGoogleAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithGoogleAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithGoogleAccountRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithGoogleAccountRequestEvent != this.OnLoginWithGoogleAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithIOSDeviceIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithIOSDeviceIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithIOSDeviceIDRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithIOSDeviceIDRequestEvent != this.OnLoginWithIOSDeviceIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithIOSDeviceIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithIOSDeviceIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithIOSDeviceIDRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithIOSDeviceIDRequestEvent != this.OnLoginWithIOSDeviceIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithKongregateRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithKongregateRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithKongregateRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithKongregateRequestEvent != this.OnLoginWithKongregateRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithKongregateRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithKongregateRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithKongregateRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithKongregateRequestEvent != this.OnLoginWithKongregateRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithNintendoSwitchDeviceIdRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithNintendoSwitchDeviceIdRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithNintendoSwitchDeviceIdRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithNintendoSwitchDeviceIdRequestEvent != this.OnLoginWithNintendoSwitchDeviceIdRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithNintendoSwitchDeviceIdRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithNintendoSwitchDeviceIdRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithNintendoSwitchDeviceIdRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithNintendoSwitchDeviceIdRequestEvent != this.OnLoginWithNintendoSwitchDeviceIdRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithOpenIdConnectRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithOpenIdConnectRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithOpenIdConnectRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithOpenIdConnectRequestEvent != this.OnLoginWithOpenIdConnectRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithOpenIdConnectRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithOpenIdConnectRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithOpenIdConnectRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithOpenIdConnectRequestEvent != this.OnLoginWithOpenIdConnectRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithPlayFabRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithPlayFabRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithPlayFabRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithPlayFabRequestEvent != this.OnLoginWithPlayFabRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithPlayFabRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithPlayFabRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithPlayFabRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithPlayFabRequestEvent != this.OnLoginWithPlayFabRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithPSNRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithPSNRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithPSNRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithPSNRequestEvent != this.OnLoginWithPSNRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithPSNRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithPSNRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithPSNRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithPSNRequestEvent != this.OnLoginWithPSNRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithSteamRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithSteamRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithSteamRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithSteamRequestEvent != this.OnLoginWithSteamRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithSteamRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithSteamRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithSteamRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithSteamRequestEvent != this.OnLoginWithSteamRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithTwitchRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithTwitchRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithTwitchRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithTwitchRequestEvent != this.OnLoginWithTwitchRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithTwitchRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithTwitchRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithTwitchRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithTwitchRequestEvent != this.OnLoginWithTwitchRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithWindowsHelloRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithWindowsHelloRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithWindowsHelloRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithWindowsHelloRequestEvent != this.OnLoginWithWindowsHelloRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithWindowsHelloRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithWindowsHelloRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithWindowsHelloRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithWindowsHelloRequestEvent != this.OnLoginWithWindowsHelloRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLoginWithXboxRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithXboxRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLoginWithXboxRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithXboxRequestEvent != this.OnLoginWithXboxRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLoginWithXboxRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.LoginWithXboxRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLoginWithXboxRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLoginWithXboxRequestEvent != this.OnLoginWithXboxRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMatchmakeRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.MatchmakeRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMatchmakeRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMatchmakeRequestEvent != this.OnMatchmakeRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMatchmakeRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.MatchmakeRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMatchmakeRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMatchmakeRequestEvent != this.OnMatchmakeRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMatchmakeResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.MatchmakeResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMatchmakeResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMatchmakeResultEvent != this.OnMatchmakeResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMatchmakeResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.MatchmakeResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMatchmakeResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMatchmakeResultEvent != this.OnMatchmakeResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnOpenTradeRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.OpenTradeRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnOpenTradeRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnOpenTradeRequestEvent != this.OnOpenTradeRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnOpenTradeRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.OpenTradeRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnOpenTradeRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnOpenTradeRequestEvent != this.OnOpenTradeRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnOpenTradeResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.OpenTradeResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnOpenTradeResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnOpenTradeResultEvent != this.OnOpenTradeResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnOpenTradeResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.OpenTradeResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnOpenTradeResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnOpenTradeResultEvent != this.OnOpenTradeResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnPayForPurchaseRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.PayForPurchaseRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnPayForPurchaseRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPayForPurchaseRequestEvent != this.OnPayForPurchaseRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnPayForPurchaseRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.PayForPurchaseRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnPayForPurchaseRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPayForPurchaseRequestEvent != this.OnPayForPurchaseRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnPayForPurchaseResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.PayForPurchaseResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnPayForPurchaseResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPayForPurchaseResultEvent != this.OnPayForPurchaseResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnPayForPurchaseResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.PayForPurchaseResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnPayForPurchaseResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPayForPurchaseResultEvent != this.OnPayForPurchaseResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnPurchaseItemRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.PurchaseItemRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnPurchaseItemRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPurchaseItemRequestEvent != this.OnPurchaseItemRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnPurchaseItemRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.PurchaseItemRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnPurchaseItemRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPurchaseItemRequestEvent != this.OnPurchaseItemRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnPurchaseItemResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.PurchaseItemResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnPurchaseItemResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPurchaseItemResultEvent != this.OnPurchaseItemResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnPurchaseItemResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.PurchaseItemResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnPurchaseItemResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPurchaseItemResultEvent != this.OnPurchaseItemResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRedeemCouponRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RedeemCouponRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRedeemCouponRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRedeemCouponRequestEvent != this.OnRedeemCouponRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRedeemCouponRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RedeemCouponRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRedeemCouponRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRedeemCouponRequestEvent != this.OnRedeemCouponRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRedeemCouponResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RedeemCouponResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRedeemCouponResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRedeemCouponResultEvent != this.OnRedeemCouponResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRedeemCouponResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RedeemCouponResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRedeemCouponResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRedeemCouponResultEvent != this.OnRedeemCouponResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRefreshPSNAuthTokenRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RefreshPSNAuthTokenRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRefreshPSNAuthTokenRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRefreshPSNAuthTokenRequestEvent != this.OnRefreshPSNAuthTokenRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRefreshPSNAuthTokenRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RefreshPSNAuthTokenRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRefreshPSNAuthTokenRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRefreshPSNAuthTokenRequestEvent != this.OnRefreshPSNAuthTokenRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRefreshPSNAuthTokenResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRefreshPSNAuthTokenResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRefreshPSNAuthTokenResultEvent != this.OnRefreshPSNAuthTokenResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRefreshPSNAuthTokenResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRefreshPSNAuthTokenResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRefreshPSNAuthTokenResultEvent != this.OnRefreshPSNAuthTokenResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRegisterForIOSPushNotificationRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RegisterForIOSPushNotificationRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRegisterForIOSPushNotificationRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRegisterForIOSPushNotificationRequestEvent != this.OnRegisterForIOSPushNotificationRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRegisterForIOSPushNotificationRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RegisterForIOSPushNotificationRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRegisterForIOSPushNotificationRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRegisterForIOSPushNotificationRequestEvent != this.OnRegisterForIOSPushNotificationRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRegisterForIOSPushNotificationResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RegisterForIOSPushNotificationResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRegisterForIOSPushNotificationResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRegisterForIOSPushNotificationResultEvent != this.OnRegisterForIOSPushNotificationResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRegisterForIOSPushNotificationResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RegisterForIOSPushNotificationResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRegisterForIOSPushNotificationResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRegisterForIOSPushNotificationResultEvent != this.OnRegisterForIOSPushNotificationResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRegisterPlayFabUserRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RegisterPlayFabUserRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRegisterPlayFabUserRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRegisterPlayFabUserRequestEvent != this.OnRegisterPlayFabUserRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRegisterPlayFabUserRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RegisterPlayFabUserRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRegisterPlayFabUserRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRegisterPlayFabUserRequestEvent != this.OnRegisterPlayFabUserRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRegisterPlayFabUserResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RegisterPlayFabUserResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRegisterPlayFabUserResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRegisterPlayFabUserResultEvent != this.OnRegisterPlayFabUserResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRegisterPlayFabUserResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RegisterPlayFabUserResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRegisterPlayFabUserResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRegisterPlayFabUserResultEvent != this.OnRegisterPlayFabUserResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRegisterWithWindowsHelloRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RegisterWithWindowsHelloRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRegisterWithWindowsHelloRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRegisterWithWindowsHelloRequestEvent != this.OnRegisterWithWindowsHelloRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRegisterWithWindowsHelloRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RegisterWithWindowsHelloRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRegisterWithWindowsHelloRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRegisterWithWindowsHelloRequestEvent != this.OnRegisterWithWindowsHelloRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRemoveContactEmailRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RemoveContactEmailRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRemoveContactEmailRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveContactEmailRequestEvent != this.OnRemoveContactEmailRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRemoveContactEmailRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RemoveContactEmailRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRemoveContactEmailRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveContactEmailRequestEvent != this.OnRemoveContactEmailRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRemoveContactEmailResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RemoveContactEmailResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRemoveContactEmailResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveContactEmailResultEvent != this.OnRemoveContactEmailResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRemoveContactEmailResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RemoveContactEmailResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRemoveContactEmailResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveContactEmailResultEvent != this.OnRemoveContactEmailResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRemoveFriendRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RemoveFriendRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRemoveFriendRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveFriendRequestEvent != this.OnRemoveFriendRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRemoveFriendRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RemoveFriendRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRemoveFriendRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveFriendRequestEvent != this.OnRemoveFriendRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRemoveFriendResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RemoveFriendResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRemoveFriendResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveFriendResultEvent != this.OnRemoveFriendResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRemoveFriendResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RemoveFriendResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRemoveFriendResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveFriendResultEvent != this.OnRemoveFriendResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRemoveGenericIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RemoveGenericIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRemoveGenericIDRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveGenericIDRequestEvent != this.OnRemoveGenericIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRemoveGenericIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RemoveGenericIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRemoveGenericIDRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveGenericIDRequestEvent != this.OnRemoveGenericIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRemoveGenericIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RemoveGenericIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRemoveGenericIDResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveGenericIDResultEvent != this.OnRemoveGenericIDResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRemoveGenericIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RemoveGenericIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRemoveGenericIDResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveGenericIDResultEvent != this.OnRemoveGenericIDResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRemoveSharedGroupMembersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RemoveSharedGroupMembersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRemoveSharedGroupMembersRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveSharedGroupMembersRequestEvent != this.OnRemoveSharedGroupMembersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRemoveSharedGroupMembersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RemoveSharedGroupMembersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRemoveSharedGroupMembersRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveSharedGroupMembersRequestEvent != this.OnRemoveSharedGroupMembersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRemoveSharedGroupMembersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RemoveSharedGroupMembersResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRemoveSharedGroupMembersResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveSharedGroupMembersResultEvent != this.OnRemoveSharedGroupMembersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRemoveSharedGroupMembersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RemoveSharedGroupMembersResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRemoveSharedGroupMembersResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRemoveSharedGroupMembersResultEvent != this.OnRemoveSharedGroupMembersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnReportDeviceInfoRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.DeviceInfoRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnReportDeviceInfoRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnReportDeviceInfoRequestEvent != this.OnReportDeviceInfoRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnReportDeviceInfoRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.DeviceInfoRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnReportDeviceInfoRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnReportDeviceInfoRequestEvent != this.OnReportDeviceInfoRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnReportDeviceInfoResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnReportDeviceInfoResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnReportDeviceInfoResultEvent != this.OnReportDeviceInfoResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnReportDeviceInfoResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnReportDeviceInfoResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnReportDeviceInfoResultEvent != this.OnReportDeviceInfoResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnReportPlayerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ReportPlayerClientRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnReportPlayerRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnReportPlayerRequestEvent != this.OnReportPlayerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnReportPlayerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ReportPlayerClientRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnReportPlayerRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnReportPlayerRequestEvent != this.OnReportPlayerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnReportPlayerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ReportPlayerClientResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnReportPlayerResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnReportPlayerResultEvent != this.OnReportPlayerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnReportPlayerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ReportPlayerClientResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnReportPlayerResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnReportPlayerResultEvent != this.OnReportPlayerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRestoreIOSPurchasesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RestoreIOSPurchasesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRestoreIOSPurchasesRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRestoreIOSPurchasesRequestEvent != this.OnRestoreIOSPurchasesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRestoreIOSPurchasesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.RestoreIOSPurchasesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRestoreIOSPurchasesRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRestoreIOSPurchasesRequestEvent != this.OnRestoreIOSPurchasesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnRestoreIOSPurchasesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RestoreIOSPurchasesResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnRestoreIOSPurchasesResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRestoreIOSPurchasesResultEvent != this.OnRestoreIOSPurchasesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnRestoreIOSPurchasesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.RestoreIOSPurchasesResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnRestoreIOSPurchasesResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnRestoreIOSPurchasesResultEvent != this.OnRestoreIOSPurchasesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnSendAccountRecoveryEmailRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.SendAccountRecoveryEmailRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnSendAccountRecoveryEmailRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSendAccountRecoveryEmailRequestEvent != this.OnSendAccountRecoveryEmailRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnSendAccountRecoveryEmailRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.SendAccountRecoveryEmailRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnSendAccountRecoveryEmailRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSendAccountRecoveryEmailRequestEvent != this.OnSendAccountRecoveryEmailRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnSendAccountRecoveryEmailResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.SendAccountRecoveryEmailResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnSendAccountRecoveryEmailResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSendAccountRecoveryEmailResultEvent != this.OnSendAccountRecoveryEmailResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnSendAccountRecoveryEmailResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.SendAccountRecoveryEmailResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnSendAccountRecoveryEmailResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSendAccountRecoveryEmailResultEvent != this.OnSendAccountRecoveryEmailResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnSetFriendTagsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.SetFriendTagsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnSetFriendTagsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSetFriendTagsRequestEvent != this.OnSetFriendTagsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnSetFriendTagsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.SetFriendTagsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnSetFriendTagsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSetFriendTagsRequestEvent != this.OnSetFriendTagsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnSetFriendTagsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.SetFriendTagsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnSetFriendTagsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSetFriendTagsResultEvent != this.OnSetFriendTagsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnSetFriendTagsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.SetFriendTagsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnSetFriendTagsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSetFriendTagsResultEvent != this.OnSetFriendTagsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnSetPlayerSecretRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.SetPlayerSecretRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnSetPlayerSecretRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSetPlayerSecretRequestEvent != this.OnSetPlayerSecretRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnSetPlayerSecretRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.SetPlayerSecretRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnSetPlayerSecretRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSetPlayerSecretRequestEvent != this.OnSetPlayerSecretRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnSetPlayerSecretResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.SetPlayerSecretResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnSetPlayerSecretResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSetPlayerSecretResultEvent != this.OnSetPlayerSecretResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnSetPlayerSecretResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.SetPlayerSecretResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnSetPlayerSecretResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSetPlayerSecretResultEvent != this.OnSetPlayerSecretResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnStartGameRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.StartGameRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnStartGameRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStartGameRequestEvent != this.OnStartGameRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnStartGameRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.StartGameRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnStartGameRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStartGameRequestEvent != this.OnStartGameRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnStartGameResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.StartGameResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnStartGameResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStartGameResultEvent != this.OnStartGameResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnStartGameResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.StartGameResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnStartGameResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStartGameResultEvent != this.OnStartGameResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnStartPurchaseRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.StartPurchaseRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnStartPurchaseRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStartPurchaseRequestEvent != this.OnStartPurchaseRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnStartPurchaseRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.StartPurchaseRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnStartPurchaseRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStartPurchaseRequestEvent != this.OnStartPurchaseRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnStartPurchaseResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.StartPurchaseResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnStartPurchaseResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStartPurchaseResultEvent != this.OnStartPurchaseResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnStartPurchaseResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.StartPurchaseResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnStartPurchaseResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnStartPurchaseResultEvent != this.OnStartPurchaseResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnSubtractUserVirtualCurrencyRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.SubtractUserVirtualCurrencyRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnSubtractUserVirtualCurrencyRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSubtractUserVirtualCurrencyRequestEvent != this.OnSubtractUserVirtualCurrencyRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnSubtractUserVirtualCurrencyRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.SubtractUserVirtualCurrencyRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnSubtractUserVirtualCurrencyRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSubtractUserVirtualCurrencyRequestEvent != this.OnSubtractUserVirtualCurrencyRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnSubtractUserVirtualCurrencyResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ModifyUserVirtualCurrencyResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnSubtractUserVirtualCurrencyResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSubtractUserVirtualCurrencyResultEvent != this.OnSubtractUserVirtualCurrencyResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnSubtractUserVirtualCurrencyResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ModifyUserVirtualCurrencyResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnSubtractUserVirtualCurrencyResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSubtractUserVirtualCurrencyResultEvent != this.OnSubtractUserVirtualCurrencyResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkAndroidDeviceIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkAndroidDeviceIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkAndroidDeviceIDRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkAndroidDeviceIDRequestEvent != this.OnUnlinkAndroidDeviceIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkAndroidDeviceIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkAndroidDeviceIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkAndroidDeviceIDRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkAndroidDeviceIDRequestEvent != this.OnUnlinkAndroidDeviceIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkAndroidDeviceIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkAndroidDeviceIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkAndroidDeviceIDResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkAndroidDeviceIDResultEvent != this.OnUnlinkAndroidDeviceIDResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkAndroidDeviceIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkAndroidDeviceIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkAndroidDeviceIDResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkAndroidDeviceIDResultEvent != this.OnUnlinkAndroidDeviceIDResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkCustomIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkCustomIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkCustomIDRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkCustomIDRequestEvent != this.OnUnlinkCustomIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkCustomIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkCustomIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkCustomIDRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkCustomIDRequestEvent != this.OnUnlinkCustomIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkCustomIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkCustomIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkCustomIDResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkCustomIDResultEvent != this.OnUnlinkCustomIDResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkCustomIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkCustomIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkCustomIDResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkCustomIDResultEvent != this.OnUnlinkCustomIDResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkFacebookAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkFacebookAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkFacebookAccountRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkFacebookAccountRequestEvent != this.OnUnlinkFacebookAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkFacebookAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkFacebookAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkFacebookAccountRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkFacebookAccountRequestEvent != this.OnUnlinkFacebookAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkFacebookAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkFacebookAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkFacebookAccountResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkFacebookAccountResultEvent != this.OnUnlinkFacebookAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkFacebookAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkFacebookAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkFacebookAccountResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkFacebookAccountResultEvent != this.OnUnlinkFacebookAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkFacebookInstantGamesIdRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkFacebookInstantGamesIdRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkFacebookInstantGamesIdRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkFacebookInstantGamesIdRequestEvent != this.OnUnlinkFacebookInstantGamesIdRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkFacebookInstantGamesIdRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkFacebookInstantGamesIdRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkFacebookInstantGamesIdRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkFacebookInstantGamesIdRequestEvent != this.OnUnlinkFacebookInstantGamesIdRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkFacebookInstantGamesIdResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkFacebookInstantGamesIdResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkFacebookInstantGamesIdResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkFacebookInstantGamesIdResultEvent != this.OnUnlinkFacebookInstantGamesIdResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkFacebookInstantGamesIdResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkFacebookInstantGamesIdResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkFacebookInstantGamesIdResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkFacebookInstantGamesIdResultEvent != this.OnUnlinkFacebookInstantGamesIdResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkGameCenterAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkGameCenterAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkGameCenterAccountRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkGameCenterAccountRequestEvent != this.OnUnlinkGameCenterAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkGameCenterAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkGameCenterAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkGameCenterAccountRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkGameCenterAccountRequestEvent != this.OnUnlinkGameCenterAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkGameCenterAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkGameCenterAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkGameCenterAccountResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkGameCenterAccountResultEvent != this.OnUnlinkGameCenterAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkGameCenterAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkGameCenterAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkGameCenterAccountResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkGameCenterAccountResultEvent != this.OnUnlinkGameCenterAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkGoogleAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkGoogleAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkGoogleAccountRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkGoogleAccountRequestEvent != this.OnUnlinkGoogleAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkGoogleAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkGoogleAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkGoogleAccountRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkGoogleAccountRequestEvent != this.OnUnlinkGoogleAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkGoogleAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkGoogleAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkGoogleAccountResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkGoogleAccountResultEvent != this.OnUnlinkGoogleAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkGoogleAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkGoogleAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkGoogleAccountResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkGoogleAccountResultEvent != this.OnUnlinkGoogleAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkIOSDeviceIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkIOSDeviceIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkIOSDeviceIDRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkIOSDeviceIDRequestEvent != this.OnUnlinkIOSDeviceIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkIOSDeviceIDRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkIOSDeviceIDRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkIOSDeviceIDRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkIOSDeviceIDRequestEvent != this.OnUnlinkIOSDeviceIDRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkIOSDeviceIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkIOSDeviceIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkIOSDeviceIDResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkIOSDeviceIDResultEvent != this.OnUnlinkIOSDeviceIDResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkIOSDeviceIDResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkIOSDeviceIDResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkIOSDeviceIDResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkIOSDeviceIDResultEvent != this.OnUnlinkIOSDeviceIDResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkKongregateRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkKongregateAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkKongregateRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkKongregateRequestEvent != this.OnUnlinkKongregateRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkKongregateRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkKongregateAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkKongregateRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkKongregateRequestEvent != this.OnUnlinkKongregateRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkKongregateResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkKongregateAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkKongregateResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkKongregateResultEvent != this.OnUnlinkKongregateResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkKongregateResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkKongregateAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkKongregateResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkKongregateResultEvent != this.OnUnlinkKongregateResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkNintendoSwitchDeviceIdRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkNintendoSwitchDeviceIdRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkNintendoSwitchDeviceIdRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkNintendoSwitchDeviceIdRequestEvent != this.OnUnlinkNintendoSwitchDeviceIdRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkNintendoSwitchDeviceIdRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkNintendoSwitchDeviceIdRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkNintendoSwitchDeviceIdRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkNintendoSwitchDeviceIdRequestEvent != this.OnUnlinkNintendoSwitchDeviceIdRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkNintendoSwitchDeviceIdResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkNintendoSwitchDeviceIdResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkNintendoSwitchDeviceIdResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkNintendoSwitchDeviceIdResultEvent != this.OnUnlinkNintendoSwitchDeviceIdResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkNintendoSwitchDeviceIdResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkNintendoSwitchDeviceIdResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkNintendoSwitchDeviceIdResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkNintendoSwitchDeviceIdResultEvent != this.OnUnlinkNintendoSwitchDeviceIdResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkOpenIdConnectRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UninkOpenIdConnectRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkOpenIdConnectRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkOpenIdConnectRequestEvent != this.OnUnlinkOpenIdConnectRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkOpenIdConnectRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UninkOpenIdConnectRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkOpenIdConnectRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkOpenIdConnectRequestEvent != this.OnUnlinkOpenIdConnectRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkOpenIdConnectResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkOpenIdConnectResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkOpenIdConnectResultEvent != this.OnUnlinkOpenIdConnectResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkOpenIdConnectResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkOpenIdConnectResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkOpenIdConnectResultEvent != this.OnUnlinkOpenIdConnectResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkPSNAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkPSNAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkPSNAccountRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkPSNAccountRequestEvent != this.OnUnlinkPSNAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkPSNAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkPSNAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkPSNAccountRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkPSNAccountRequestEvent != this.OnUnlinkPSNAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkPSNAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkPSNAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkPSNAccountResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkPSNAccountResultEvent != this.OnUnlinkPSNAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkPSNAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkPSNAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkPSNAccountResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkPSNAccountResultEvent != this.OnUnlinkPSNAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkSteamAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkSteamAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkSteamAccountRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkSteamAccountRequestEvent != this.OnUnlinkSteamAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkSteamAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkSteamAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkSteamAccountRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkSteamAccountRequestEvent != this.OnUnlinkSteamAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkSteamAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkSteamAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkSteamAccountResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkSteamAccountResultEvent != this.OnUnlinkSteamAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkSteamAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkSteamAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkSteamAccountResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkSteamAccountResultEvent != this.OnUnlinkSteamAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkTwitchRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkTwitchAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkTwitchRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkTwitchRequestEvent != this.OnUnlinkTwitchRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkTwitchRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkTwitchAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkTwitchRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkTwitchRequestEvent != this.OnUnlinkTwitchRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkTwitchResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkTwitchAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkTwitchResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkTwitchResultEvent != this.OnUnlinkTwitchResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkTwitchResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkTwitchAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkTwitchResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkTwitchResultEvent != this.OnUnlinkTwitchResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkWindowsHelloRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkWindowsHelloAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkWindowsHelloRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkWindowsHelloRequestEvent != this.OnUnlinkWindowsHelloRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkWindowsHelloRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkWindowsHelloAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkWindowsHelloRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkWindowsHelloRequestEvent != this.OnUnlinkWindowsHelloRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkWindowsHelloResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkWindowsHelloAccountResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkWindowsHelloResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkWindowsHelloResultEvent != this.OnUnlinkWindowsHelloResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkWindowsHelloResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkWindowsHelloAccountResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkWindowsHelloResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkWindowsHelloResultEvent != this.OnUnlinkWindowsHelloResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkXboxAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkXboxAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkXboxAccountRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkXboxAccountRequestEvent != this.OnUnlinkXboxAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkXboxAccountRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlinkXboxAccountRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkXboxAccountRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkXboxAccountRequestEvent != this.OnUnlinkXboxAccountRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlinkXboxAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkXboxAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlinkXboxAccountResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkXboxAccountResultEvent != this.OnUnlinkXboxAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlinkXboxAccountResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlinkXboxAccountResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlinkXboxAccountResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlinkXboxAccountResultEvent != this.OnUnlinkXboxAccountResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlockContainerInstanceRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlockContainerInstanceRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlockContainerInstanceRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlockContainerInstanceRequestEvent != this.OnUnlockContainerInstanceRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlockContainerInstanceRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlockContainerInstanceRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlockContainerInstanceRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlockContainerInstanceRequestEvent != this.OnUnlockContainerInstanceRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlockContainerInstanceResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlockContainerItemResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlockContainerInstanceResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlockContainerInstanceResultEvent != this.OnUnlockContainerInstanceResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlockContainerInstanceResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlockContainerItemResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlockContainerInstanceResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlockContainerInstanceResultEvent != this.OnUnlockContainerInstanceResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlockContainerItemRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlockContainerItemRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlockContainerItemRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlockContainerItemRequestEvent != this.OnUnlockContainerItemRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlockContainerItemRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UnlockContainerItemRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlockContainerItemRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlockContainerItemRequestEvent != this.OnUnlockContainerItemRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUnlockContainerItemResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlockContainerItemResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUnlockContainerItemResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlockContainerItemResultEvent != this.OnUnlockContainerItemResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUnlockContainerItemResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UnlockContainerItemResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUnlockContainerItemResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUnlockContainerItemResultEvent != this.OnUnlockContainerItemResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdateAvatarUrlRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateAvatarUrlRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdateAvatarUrlRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateAvatarUrlRequestEvent != this.OnUpdateAvatarUrlRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdateAvatarUrlRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateAvatarUrlRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdateAvatarUrlRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateAvatarUrlRequestEvent != this.OnUpdateAvatarUrlRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdateAvatarUrlResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdateAvatarUrlResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateAvatarUrlResultEvent != this.OnUpdateAvatarUrlResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdateAvatarUrlResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdateAvatarUrlResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateAvatarUrlResultEvent != this.OnUpdateAvatarUrlResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdateCharacterDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateCharacterDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdateCharacterDataRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateCharacterDataRequestEvent != this.OnUpdateCharacterDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdateCharacterDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateCharacterDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdateCharacterDataRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateCharacterDataRequestEvent != this.OnUpdateCharacterDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdateCharacterDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateCharacterDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdateCharacterDataResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateCharacterDataResultEvent != this.OnUpdateCharacterDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdateCharacterDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateCharacterDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdateCharacterDataResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateCharacterDataResultEvent != this.OnUpdateCharacterDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdateCharacterStatisticsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateCharacterStatisticsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdateCharacterStatisticsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateCharacterStatisticsRequestEvent != this.OnUpdateCharacterStatisticsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdateCharacterStatisticsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateCharacterStatisticsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdateCharacterStatisticsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateCharacterStatisticsRequestEvent != this.OnUpdateCharacterStatisticsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdateCharacterStatisticsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateCharacterStatisticsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdateCharacterStatisticsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateCharacterStatisticsResultEvent != this.OnUpdateCharacterStatisticsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdateCharacterStatisticsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateCharacterStatisticsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdateCharacterStatisticsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateCharacterStatisticsResultEvent != this.OnUpdateCharacterStatisticsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdatePlayerStatisticsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdatePlayerStatisticsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdatePlayerStatisticsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdatePlayerStatisticsRequestEvent != this.OnUpdatePlayerStatisticsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdatePlayerStatisticsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdatePlayerStatisticsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdatePlayerStatisticsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdatePlayerStatisticsRequestEvent != this.OnUpdatePlayerStatisticsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdatePlayerStatisticsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdatePlayerStatisticsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdatePlayerStatisticsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdatePlayerStatisticsResultEvent != this.OnUpdatePlayerStatisticsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdatePlayerStatisticsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdatePlayerStatisticsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdatePlayerStatisticsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdatePlayerStatisticsResultEvent != this.OnUpdatePlayerStatisticsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdateSharedGroupDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateSharedGroupDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdateSharedGroupDataRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateSharedGroupDataRequestEvent != this.OnUpdateSharedGroupDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdateSharedGroupDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateSharedGroupDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdateSharedGroupDataRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateSharedGroupDataRequestEvent != this.OnUpdateSharedGroupDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdateSharedGroupDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateSharedGroupDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdateSharedGroupDataResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateSharedGroupDataResultEvent != this.OnUpdateSharedGroupDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdateSharedGroupDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateSharedGroupDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdateSharedGroupDataResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateSharedGroupDataResultEvent != this.OnUpdateSharedGroupDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdateUserDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateUserDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdateUserDataRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateUserDataRequestEvent != this.OnUpdateUserDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdateUserDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateUserDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdateUserDataRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateUserDataRequestEvent != this.OnUpdateUserDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdateUserDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateUserDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdateUserDataResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateUserDataResultEvent != this.OnUpdateUserDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdateUserDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateUserDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdateUserDataResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateUserDataResultEvent != this.OnUpdateUserDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdateUserPublisherDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateUserDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdateUserPublisherDataRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateUserPublisherDataRequestEvent != this.OnUpdateUserPublisherDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdateUserPublisherDataRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateUserDataRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdateUserPublisherDataRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateUserPublisherDataRequestEvent != this.OnUpdateUserPublisherDataRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdateUserPublisherDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateUserDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdateUserPublisherDataResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateUserPublisherDataResultEvent != this.OnUpdateUserPublisherDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdateUserPublisherDataResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateUserDataResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdateUserPublisherDataResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateUserPublisherDataResultEvent != this.OnUpdateUserPublisherDataResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdateUserTitleDisplayNameRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateUserTitleDisplayNameRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdateUserTitleDisplayNameRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateUserTitleDisplayNameRequestEvent != this.OnUpdateUserTitleDisplayNameRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdateUserTitleDisplayNameRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.UpdateUserTitleDisplayNameRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdateUserTitleDisplayNameRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateUserTitleDisplayNameRequestEvent != this.OnUpdateUserTitleDisplayNameRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnUpdateUserTitleDisplayNameResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateUserTitleDisplayNameResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnUpdateUserTitleDisplayNameResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateUserTitleDisplayNameResultEvent != this.OnUpdateUserTitleDisplayNameResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnUpdateUserTitleDisplayNameResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.UpdateUserTitleDisplayNameResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnUpdateUserTitleDisplayNameResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnUpdateUserTitleDisplayNameResultEvent != this.OnUpdateUserTitleDisplayNameResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnValidateAmazonIAPReceiptRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ValidateAmazonReceiptRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnValidateAmazonIAPReceiptRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateAmazonIAPReceiptRequestEvent != this.OnValidateAmazonIAPReceiptRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnValidateAmazonIAPReceiptRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ValidateAmazonReceiptRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnValidateAmazonIAPReceiptRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateAmazonIAPReceiptRequestEvent != this.OnValidateAmazonIAPReceiptRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnValidateAmazonIAPReceiptResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ValidateAmazonReceiptResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnValidateAmazonIAPReceiptResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateAmazonIAPReceiptResultEvent != this.OnValidateAmazonIAPReceiptResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnValidateAmazonIAPReceiptResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ValidateAmazonReceiptResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnValidateAmazonIAPReceiptResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateAmazonIAPReceiptResultEvent != this.OnValidateAmazonIAPReceiptResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnValidateGooglePlayPurchaseRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ValidateGooglePlayPurchaseRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnValidateGooglePlayPurchaseRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateGooglePlayPurchaseRequestEvent != this.OnValidateGooglePlayPurchaseRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnValidateGooglePlayPurchaseRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ValidateGooglePlayPurchaseRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnValidateGooglePlayPurchaseRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateGooglePlayPurchaseRequestEvent != this.OnValidateGooglePlayPurchaseRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnValidateGooglePlayPurchaseResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ValidateGooglePlayPurchaseResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnValidateGooglePlayPurchaseResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateGooglePlayPurchaseResultEvent != this.OnValidateGooglePlayPurchaseResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnValidateGooglePlayPurchaseResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ValidateGooglePlayPurchaseResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnValidateGooglePlayPurchaseResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateGooglePlayPurchaseResultEvent != this.OnValidateGooglePlayPurchaseResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnValidateIOSReceiptRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ValidateIOSReceiptRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnValidateIOSReceiptRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateIOSReceiptRequestEvent != this.OnValidateIOSReceiptRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnValidateIOSReceiptRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ValidateIOSReceiptRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnValidateIOSReceiptRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateIOSReceiptRequestEvent != this.OnValidateIOSReceiptRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnValidateIOSReceiptResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ValidateIOSReceiptResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnValidateIOSReceiptResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateIOSReceiptResultEvent != this.OnValidateIOSReceiptResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnValidateIOSReceiptResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ValidateIOSReceiptResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnValidateIOSReceiptResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateIOSReceiptResultEvent != this.OnValidateIOSReceiptResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnValidateWindowsStoreReceiptRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ValidateWindowsReceiptRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnValidateWindowsStoreReceiptRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateWindowsStoreReceiptRequestEvent != this.OnValidateWindowsStoreReceiptRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnValidateWindowsStoreReceiptRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.ValidateWindowsReceiptRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnValidateWindowsStoreReceiptRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateWindowsStoreReceiptRequestEvent != this.OnValidateWindowsStoreReceiptRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnValidateWindowsStoreReceiptResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ValidateWindowsReceiptResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnValidateWindowsStoreReceiptResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateWindowsStoreReceiptResultEvent != this.OnValidateWindowsStoreReceiptResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnValidateWindowsStoreReceiptResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.ValidateWindowsReceiptResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnValidateWindowsStoreReceiptResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnValidateWindowsStoreReceiptResultEvent != this.OnValidateWindowsStoreReceiptResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnWriteCharacterEventRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.WriteClientCharacterEventRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnWriteCharacterEventRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnWriteCharacterEventRequestEvent != this.OnWriteCharacterEventRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnWriteCharacterEventRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.WriteClientCharacterEventRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnWriteCharacterEventRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnWriteCharacterEventRequestEvent != this.OnWriteCharacterEventRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnWriteCharacterEventResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.WriteEventResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnWriteCharacterEventResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnWriteCharacterEventResultEvent != this.OnWriteCharacterEventResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnWriteCharacterEventResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.WriteEventResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnWriteCharacterEventResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnWriteCharacterEventResultEvent != this.OnWriteCharacterEventResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnWritePlayerEventRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.WriteClientPlayerEventRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnWritePlayerEventRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnWritePlayerEventRequestEvent != this.OnWritePlayerEventRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnWritePlayerEventRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.WriteClientPlayerEventRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnWritePlayerEventRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnWritePlayerEventRequestEvent != this.OnWritePlayerEventRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnWritePlayerEventResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.WriteEventResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnWritePlayerEventResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnWritePlayerEventResultEvent != this.OnWritePlayerEventResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnWritePlayerEventResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.WriteEventResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnWritePlayerEventResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnWritePlayerEventResultEvent != this.OnWritePlayerEventResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnWriteTitleEventRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.WriteTitleEventRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnWriteTitleEventRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnWriteTitleEventRequestEvent != this.OnWriteTitleEventRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnWriteTitleEventRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ClientModels.WriteTitleEventRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnWriteTitleEventRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnWriteTitleEventRequestEvent != this.OnWriteTitleEventRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnWriteTitleEventResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.WriteEventResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnWriteTitleEventResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnWriteTitleEventResultEvent != this.OnWriteTitleEventResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnWriteTitleEventResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ClientModels.WriteEventResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnWriteTitleEventResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnWriteTitleEventResultEvent != this.OnWriteTitleEventResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnCloudScriptExecuteEntityCloudScriptRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.CloudScriptModels.ExecuteEntityCloudScriptRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnCloudScriptExecuteEntityCloudScriptRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnCloudScriptExecuteEntityCloudScriptRequestEvent != this.OnCloudScriptExecuteEntityCloudScriptRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnCloudScriptExecuteEntityCloudScriptRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.CloudScriptModels.ExecuteEntityCloudScriptRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnCloudScriptExecuteEntityCloudScriptRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnCloudScriptExecuteEntityCloudScriptRequestEvent != this.OnCloudScriptExecuteEntityCloudScriptRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnCloudScriptExecuteEntityCloudScriptResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.CloudScriptModels.ExecuteCloudScriptResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnCloudScriptExecuteEntityCloudScriptResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnCloudScriptExecuteEntityCloudScriptResultEvent != this.OnCloudScriptExecuteEntityCloudScriptResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnCloudScriptExecuteEntityCloudScriptResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.CloudScriptModels.ExecuteCloudScriptResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnCloudScriptExecuteEntityCloudScriptResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnCloudScriptExecuteEntityCloudScriptResultEvent != this.OnCloudScriptExecuteEntityCloudScriptResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnDataAbortFileUploadsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.AbortFileUploadsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataAbortFileUploadsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataAbortFileUploadsRequestEvent != this.OnDataAbortFileUploadsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnDataAbortFileUploadsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.AbortFileUploadsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataAbortFileUploadsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataAbortFileUploadsRequestEvent != this.OnDataAbortFileUploadsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnDataAbortFileUploadsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.AbortFileUploadsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataAbortFileUploadsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataAbortFileUploadsResultEvent != this.OnDataAbortFileUploadsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnDataAbortFileUploadsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.AbortFileUploadsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataAbortFileUploadsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataAbortFileUploadsResultEvent != this.OnDataAbortFileUploadsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnDataDeleteFilesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.DeleteFilesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataDeleteFilesRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataDeleteFilesRequestEvent != this.OnDataDeleteFilesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnDataDeleteFilesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.DeleteFilesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataDeleteFilesRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataDeleteFilesRequestEvent != this.OnDataDeleteFilesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnDataDeleteFilesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.DeleteFilesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataDeleteFilesResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataDeleteFilesResultEvent != this.OnDataDeleteFilesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnDataDeleteFilesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.DeleteFilesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataDeleteFilesResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataDeleteFilesResultEvent != this.OnDataDeleteFilesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnDataFinalizeFileUploadsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.FinalizeFileUploadsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataFinalizeFileUploadsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataFinalizeFileUploadsRequestEvent != this.OnDataFinalizeFileUploadsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnDataFinalizeFileUploadsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.FinalizeFileUploadsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataFinalizeFileUploadsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataFinalizeFileUploadsRequestEvent != this.OnDataFinalizeFileUploadsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnDataFinalizeFileUploadsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.FinalizeFileUploadsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataFinalizeFileUploadsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataFinalizeFileUploadsResultEvent != this.OnDataFinalizeFileUploadsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnDataFinalizeFileUploadsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.FinalizeFileUploadsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataFinalizeFileUploadsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataFinalizeFileUploadsResultEvent != this.OnDataFinalizeFileUploadsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnDataGetFilesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.GetFilesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataGetFilesRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataGetFilesRequestEvent != this.OnDataGetFilesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnDataGetFilesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.GetFilesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataGetFilesRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataGetFilesRequestEvent != this.OnDataGetFilesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnDataGetFilesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.GetFilesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataGetFilesResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataGetFilesResultEvent != this.OnDataGetFilesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnDataGetFilesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.GetFilesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataGetFilesResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataGetFilesResultEvent != this.OnDataGetFilesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnDataGetObjectsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.GetObjectsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataGetObjectsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataGetObjectsRequestEvent != this.OnDataGetObjectsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnDataGetObjectsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.GetObjectsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataGetObjectsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataGetObjectsRequestEvent != this.OnDataGetObjectsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnDataGetObjectsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.GetObjectsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataGetObjectsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataGetObjectsResultEvent != this.OnDataGetObjectsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnDataGetObjectsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.GetObjectsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataGetObjectsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataGetObjectsResultEvent != this.OnDataGetObjectsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnDataInitiateFileUploadsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.InitiateFileUploadsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataInitiateFileUploadsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataInitiateFileUploadsRequestEvent != this.OnDataInitiateFileUploadsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnDataInitiateFileUploadsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.InitiateFileUploadsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataInitiateFileUploadsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataInitiateFileUploadsRequestEvent != this.OnDataInitiateFileUploadsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnDataInitiateFileUploadsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.InitiateFileUploadsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataInitiateFileUploadsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataInitiateFileUploadsResultEvent != this.OnDataInitiateFileUploadsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnDataInitiateFileUploadsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.InitiateFileUploadsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataInitiateFileUploadsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataInitiateFileUploadsResultEvent != this.OnDataInitiateFileUploadsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnDataSetObjectsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.SetObjectsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataSetObjectsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataSetObjectsRequestEvent != this.OnDataSetObjectsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnDataSetObjectsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.DataModels.SetObjectsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataSetObjectsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataSetObjectsRequestEvent != this.OnDataSetObjectsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnDataSetObjectsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.SetObjectsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnDataSetObjectsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataSetObjectsResultEvent != this.OnDataSetObjectsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnDataSetObjectsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.DataModels.SetObjectsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnDataSetObjectsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnDataSetObjectsResultEvent != this.OnDataSetObjectsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnEventsWriteEventsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.EventsModels.WriteEventsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnEventsWriteEventsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEventsWriteEventsRequestEvent != this.OnEventsWriteEventsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnEventsWriteEventsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.EventsModels.WriteEventsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnEventsWriteEventsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEventsWriteEventsRequestEvent != this.OnEventsWriteEventsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnEventsWriteEventsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.EventsModels.WriteEventsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnEventsWriteEventsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEventsWriteEventsResultEvent != this.OnEventsWriteEventsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnEventsWriteEventsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.EventsModels.WriteEventsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnEventsWriteEventsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEventsWriteEventsResultEvent != this.OnEventsWriteEventsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnEventsWriteTelemetryEventsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.EventsModels.WriteEventsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnEventsWriteTelemetryEventsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEventsWriteTelemetryEventsRequestEvent != this.OnEventsWriteTelemetryEventsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnEventsWriteTelemetryEventsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.EventsModels.WriteEventsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnEventsWriteTelemetryEventsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEventsWriteTelemetryEventsRequestEvent != this.OnEventsWriteTelemetryEventsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnEventsWriteTelemetryEventsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.EventsModels.WriteEventsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnEventsWriteTelemetryEventsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEventsWriteTelemetryEventsResultEvent != this.OnEventsWriteTelemetryEventsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnEventsWriteTelemetryEventsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.EventsModels.WriteEventsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnEventsWriteTelemetryEventsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnEventsWriteTelemetryEventsResultEvent != this.OnEventsWriteTelemetryEventsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsAcceptGroupApplicationRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.AcceptGroupApplicationRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsAcceptGroupApplicationRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsAcceptGroupApplicationRequestEvent != this.OnGroupsAcceptGroupApplicationRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsAcceptGroupApplicationRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.AcceptGroupApplicationRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsAcceptGroupApplicationRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsAcceptGroupApplicationRequestEvent != this.OnGroupsAcceptGroupApplicationRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsAcceptGroupApplicationResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsAcceptGroupApplicationResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsAcceptGroupApplicationResultEvent != this.OnGroupsAcceptGroupApplicationResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsAcceptGroupApplicationResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsAcceptGroupApplicationResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsAcceptGroupApplicationResultEvent != this.OnGroupsAcceptGroupApplicationResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsAcceptGroupInvitationRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.AcceptGroupInvitationRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsAcceptGroupInvitationRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsAcceptGroupInvitationRequestEvent != this.OnGroupsAcceptGroupInvitationRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsAcceptGroupInvitationRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.AcceptGroupInvitationRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsAcceptGroupInvitationRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsAcceptGroupInvitationRequestEvent != this.OnGroupsAcceptGroupInvitationRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsAcceptGroupInvitationResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsAcceptGroupInvitationResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsAcceptGroupInvitationResultEvent != this.OnGroupsAcceptGroupInvitationResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsAcceptGroupInvitationResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsAcceptGroupInvitationResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsAcceptGroupInvitationResultEvent != this.OnGroupsAcceptGroupInvitationResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsAddMembersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.AddMembersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsAddMembersRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsAddMembersRequestEvent != this.OnGroupsAddMembersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsAddMembersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.AddMembersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsAddMembersRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsAddMembersRequestEvent != this.OnGroupsAddMembersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsAddMembersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsAddMembersResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsAddMembersResultEvent != this.OnGroupsAddMembersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsAddMembersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsAddMembersResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsAddMembersResultEvent != this.OnGroupsAddMembersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsApplyToGroupRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ApplyToGroupRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsApplyToGroupRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsApplyToGroupRequestEvent != this.OnGroupsApplyToGroupRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsApplyToGroupRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ApplyToGroupRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsApplyToGroupRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsApplyToGroupRequestEvent != this.OnGroupsApplyToGroupRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsApplyToGroupResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ApplyToGroupResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsApplyToGroupResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsApplyToGroupResultEvent != this.OnGroupsApplyToGroupResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsApplyToGroupResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ApplyToGroupResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsApplyToGroupResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsApplyToGroupResultEvent != this.OnGroupsApplyToGroupResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsBlockEntityRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.BlockEntityRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsBlockEntityRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsBlockEntityRequestEvent != this.OnGroupsBlockEntityRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsBlockEntityRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.BlockEntityRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsBlockEntityRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsBlockEntityRequestEvent != this.OnGroupsBlockEntityRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsBlockEntityResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsBlockEntityResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsBlockEntityResultEvent != this.OnGroupsBlockEntityResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsBlockEntityResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsBlockEntityResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsBlockEntityResultEvent != this.OnGroupsBlockEntityResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsChangeMemberRoleRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ChangeMemberRoleRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsChangeMemberRoleRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsChangeMemberRoleRequestEvent != this.OnGroupsChangeMemberRoleRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsChangeMemberRoleRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ChangeMemberRoleRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsChangeMemberRoleRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsChangeMemberRoleRequestEvent != this.OnGroupsChangeMemberRoleRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsChangeMemberRoleResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsChangeMemberRoleResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsChangeMemberRoleResultEvent != this.OnGroupsChangeMemberRoleResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsChangeMemberRoleResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsChangeMemberRoleResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsChangeMemberRoleResultEvent != this.OnGroupsChangeMemberRoleResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsCreateGroupRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.CreateGroupRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsCreateGroupRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsCreateGroupRequestEvent != this.OnGroupsCreateGroupRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsCreateGroupRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.CreateGroupRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsCreateGroupRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsCreateGroupRequestEvent != this.OnGroupsCreateGroupRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsCreateGroupResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.CreateGroupResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsCreateGroupResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsCreateGroupResultEvent != this.OnGroupsCreateGroupResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsCreateGroupResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.CreateGroupResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsCreateGroupResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsCreateGroupResultEvent != this.OnGroupsCreateGroupResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsCreateRoleRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.CreateGroupRoleRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsCreateRoleRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsCreateRoleRequestEvent != this.OnGroupsCreateRoleRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsCreateRoleRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.CreateGroupRoleRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsCreateRoleRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsCreateRoleRequestEvent != this.OnGroupsCreateRoleRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsCreateRoleResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.CreateGroupRoleResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsCreateRoleResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsCreateRoleResultEvent != this.OnGroupsCreateRoleResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsCreateRoleResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.CreateGroupRoleResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsCreateRoleResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsCreateRoleResultEvent != this.OnGroupsCreateRoleResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsDeleteGroupRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.DeleteGroupRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsDeleteGroupRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsDeleteGroupRequestEvent != this.OnGroupsDeleteGroupRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsDeleteGroupRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.DeleteGroupRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsDeleteGroupRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsDeleteGroupRequestEvent != this.OnGroupsDeleteGroupRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsDeleteGroupResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsDeleteGroupResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsDeleteGroupResultEvent != this.OnGroupsDeleteGroupResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsDeleteGroupResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsDeleteGroupResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsDeleteGroupResultEvent != this.OnGroupsDeleteGroupResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsDeleteRoleRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.DeleteRoleRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsDeleteRoleRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsDeleteRoleRequestEvent != this.OnGroupsDeleteRoleRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsDeleteRoleRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.DeleteRoleRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsDeleteRoleRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsDeleteRoleRequestEvent != this.OnGroupsDeleteRoleRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsDeleteRoleResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsDeleteRoleResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsDeleteRoleResultEvent != this.OnGroupsDeleteRoleResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsDeleteRoleResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsDeleteRoleResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsDeleteRoleResultEvent != this.OnGroupsDeleteRoleResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsGetGroupRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.GetGroupRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsGetGroupRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsGetGroupRequestEvent != this.OnGroupsGetGroupRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsGetGroupRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.GetGroupRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsGetGroupRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsGetGroupRequestEvent != this.OnGroupsGetGroupRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsGetGroupResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.GetGroupResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsGetGroupResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsGetGroupResultEvent != this.OnGroupsGetGroupResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsGetGroupResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.GetGroupResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsGetGroupResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsGetGroupResultEvent != this.OnGroupsGetGroupResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsInviteToGroupRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.InviteToGroupRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsInviteToGroupRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsInviteToGroupRequestEvent != this.OnGroupsInviteToGroupRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsInviteToGroupRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.InviteToGroupRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsInviteToGroupRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsInviteToGroupRequestEvent != this.OnGroupsInviteToGroupRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsInviteToGroupResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.InviteToGroupResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsInviteToGroupResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsInviteToGroupResultEvent != this.OnGroupsInviteToGroupResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsInviteToGroupResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.InviteToGroupResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsInviteToGroupResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsInviteToGroupResultEvent != this.OnGroupsInviteToGroupResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsIsMemberRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.IsMemberRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsIsMemberRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsIsMemberRequestEvent != this.OnGroupsIsMemberRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsIsMemberRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.IsMemberRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsIsMemberRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsIsMemberRequestEvent != this.OnGroupsIsMemberRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsIsMemberResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.IsMemberResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsIsMemberResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsIsMemberResultEvent != this.OnGroupsIsMemberResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsIsMemberResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.IsMemberResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsIsMemberResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsIsMemberResultEvent != this.OnGroupsIsMemberResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsListGroupApplicationsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListGroupApplicationsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsListGroupApplicationsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupApplicationsRequestEvent != this.OnGroupsListGroupApplicationsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsListGroupApplicationsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListGroupApplicationsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsListGroupApplicationsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupApplicationsRequestEvent != this.OnGroupsListGroupApplicationsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsListGroupApplicationsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListGroupApplicationsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsListGroupApplicationsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupApplicationsResultEvent != this.OnGroupsListGroupApplicationsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsListGroupApplicationsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListGroupApplicationsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsListGroupApplicationsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupApplicationsResultEvent != this.OnGroupsListGroupApplicationsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsListGroupBlocksRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListGroupBlocksRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsListGroupBlocksRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupBlocksRequestEvent != this.OnGroupsListGroupBlocksRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsListGroupBlocksRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListGroupBlocksRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsListGroupBlocksRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupBlocksRequestEvent != this.OnGroupsListGroupBlocksRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsListGroupBlocksResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListGroupBlocksResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsListGroupBlocksResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupBlocksResultEvent != this.OnGroupsListGroupBlocksResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsListGroupBlocksResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListGroupBlocksResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsListGroupBlocksResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupBlocksResultEvent != this.OnGroupsListGroupBlocksResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsListGroupInvitationsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListGroupInvitationsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsListGroupInvitationsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupInvitationsRequestEvent != this.OnGroupsListGroupInvitationsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsListGroupInvitationsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListGroupInvitationsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsListGroupInvitationsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupInvitationsRequestEvent != this.OnGroupsListGroupInvitationsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsListGroupInvitationsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListGroupInvitationsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsListGroupInvitationsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupInvitationsResultEvent != this.OnGroupsListGroupInvitationsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsListGroupInvitationsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListGroupInvitationsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsListGroupInvitationsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupInvitationsResultEvent != this.OnGroupsListGroupInvitationsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsListGroupMembersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListGroupMembersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsListGroupMembersRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupMembersRequestEvent != this.OnGroupsListGroupMembersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsListGroupMembersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListGroupMembersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsListGroupMembersRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupMembersRequestEvent != this.OnGroupsListGroupMembersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsListGroupMembersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListGroupMembersResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsListGroupMembersResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupMembersResultEvent != this.OnGroupsListGroupMembersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsListGroupMembersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListGroupMembersResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsListGroupMembersResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListGroupMembersResultEvent != this.OnGroupsListGroupMembersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsListMembershipRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListMembershipRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsListMembershipRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListMembershipRequestEvent != this.OnGroupsListMembershipRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsListMembershipRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListMembershipRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsListMembershipRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListMembershipRequestEvent != this.OnGroupsListMembershipRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsListMembershipResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListMembershipResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsListMembershipResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListMembershipResultEvent != this.OnGroupsListMembershipResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsListMembershipResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListMembershipResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsListMembershipResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListMembershipResultEvent != this.OnGroupsListMembershipResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsListMembershipOpportunitiesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListMembershipOpportunitiesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsListMembershipOpportunitiesRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListMembershipOpportunitiesRequestEvent != this.OnGroupsListMembershipOpportunitiesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsListMembershipOpportunitiesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.ListMembershipOpportunitiesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsListMembershipOpportunitiesRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListMembershipOpportunitiesRequestEvent != this.OnGroupsListMembershipOpportunitiesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsListMembershipOpportunitiesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListMembershipOpportunitiesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsListMembershipOpportunitiesResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListMembershipOpportunitiesResultEvent != this.OnGroupsListMembershipOpportunitiesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsListMembershipOpportunitiesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.ListMembershipOpportunitiesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsListMembershipOpportunitiesResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsListMembershipOpportunitiesResultEvent != this.OnGroupsListMembershipOpportunitiesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsRemoveGroupApplicationRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.RemoveGroupApplicationRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsRemoveGroupApplicationRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsRemoveGroupApplicationRequestEvent != this.OnGroupsRemoveGroupApplicationRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsRemoveGroupApplicationRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.RemoveGroupApplicationRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsRemoveGroupApplicationRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsRemoveGroupApplicationRequestEvent != this.OnGroupsRemoveGroupApplicationRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsRemoveGroupApplicationResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsRemoveGroupApplicationResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsRemoveGroupApplicationResultEvent != this.OnGroupsRemoveGroupApplicationResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsRemoveGroupApplicationResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsRemoveGroupApplicationResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsRemoveGroupApplicationResultEvent != this.OnGroupsRemoveGroupApplicationResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsRemoveGroupInvitationRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.RemoveGroupInvitationRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsRemoveGroupInvitationRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsRemoveGroupInvitationRequestEvent != this.OnGroupsRemoveGroupInvitationRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsRemoveGroupInvitationRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.RemoveGroupInvitationRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsRemoveGroupInvitationRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsRemoveGroupInvitationRequestEvent != this.OnGroupsRemoveGroupInvitationRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsRemoveGroupInvitationResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsRemoveGroupInvitationResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsRemoveGroupInvitationResultEvent != this.OnGroupsRemoveGroupInvitationResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsRemoveGroupInvitationResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsRemoveGroupInvitationResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsRemoveGroupInvitationResultEvent != this.OnGroupsRemoveGroupInvitationResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsRemoveMembersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.RemoveMembersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsRemoveMembersRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsRemoveMembersRequestEvent != this.OnGroupsRemoveMembersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsRemoveMembersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.RemoveMembersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsRemoveMembersRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsRemoveMembersRequestEvent != this.OnGroupsRemoveMembersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsRemoveMembersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsRemoveMembersResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsRemoveMembersResultEvent != this.OnGroupsRemoveMembersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsRemoveMembersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsRemoveMembersResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsRemoveMembersResultEvent != this.OnGroupsRemoveMembersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsUnblockEntityRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.UnblockEntityRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsUnblockEntityRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsUnblockEntityRequestEvent != this.OnGroupsUnblockEntityRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsUnblockEntityRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.UnblockEntityRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsUnblockEntityRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsUnblockEntityRequestEvent != this.OnGroupsUnblockEntityRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsUnblockEntityResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsUnblockEntityResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsUnblockEntityResultEvent != this.OnGroupsUnblockEntityResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsUnblockEntityResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsUnblockEntityResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsUnblockEntityResultEvent != this.OnGroupsUnblockEntityResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsUpdateGroupRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.UpdateGroupRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsUpdateGroupRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsUpdateGroupRequestEvent != this.OnGroupsUpdateGroupRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsUpdateGroupRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.UpdateGroupRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsUpdateGroupRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsUpdateGroupRequestEvent != this.OnGroupsUpdateGroupRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsUpdateGroupResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.UpdateGroupResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsUpdateGroupResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsUpdateGroupResultEvent != this.OnGroupsUpdateGroupResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsUpdateGroupResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.UpdateGroupResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsUpdateGroupResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsUpdateGroupResultEvent != this.OnGroupsUpdateGroupResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsUpdateRoleRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.UpdateGroupRoleRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsUpdateRoleRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsUpdateRoleRequestEvent != this.OnGroupsUpdateRoleRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsUpdateRoleRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.GroupsModels.UpdateGroupRoleRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsUpdateRoleRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsUpdateRoleRequestEvent != this.OnGroupsUpdateRoleRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGroupsUpdateRoleResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.UpdateGroupRoleResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGroupsUpdateRoleResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsUpdateRoleResultEvent != this.OnGroupsUpdateRoleResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGroupsUpdateRoleResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.GroupsModels.UpdateGroupRoleResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGroupsUpdateRoleResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGroupsUpdateRoleResultEvent != this.OnGroupsUpdateRoleResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLocalizationGetLanguageListRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.LocalizationModels.GetLanguageListRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLocalizationGetLanguageListRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLocalizationGetLanguageListRequestEvent != this.OnLocalizationGetLanguageListRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLocalizationGetLanguageListRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.LocalizationModels.GetLanguageListRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLocalizationGetLanguageListRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLocalizationGetLanguageListRequestEvent != this.OnLocalizationGetLanguageListRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnLocalizationGetLanguageListResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.LocalizationModels.GetLanguageListResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnLocalizationGetLanguageListResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLocalizationGetLanguageListResultEvent != this.OnLocalizationGetLanguageListResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnLocalizationGetLanguageListResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.LocalizationModels.GetLanguageListResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnLocalizationGetLanguageListResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnLocalizationGetLanguageListResultEvent != this.OnLocalizationGetLanguageListResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerCancelAllMatchmakingTicketsForPlayerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CancelAllMatchmakingTicketsForPlayerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerCancelAllMatchmakingTicketsForPlayerRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCancelAllMatchmakingTicketsForPlayerRequestEvent != this.OnMultiplayerCancelAllMatchmakingTicketsForPlayerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerCancelAllMatchmakingTicketsForPlayerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CancelAllMatchmakingTicketsForPlayerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerCancelAllMatchmakingTicketsForPlayerRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCancelAllMatchmakingTicketsForPlayerRequestEvent != this.OnMultiplayerCancelAllMatchmakingTicketsForPlayerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerCancelAllMatchmakingTicketsForPlayerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CancelAllMatchmakingTicketsForPlayerResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerCancelAllMatchmakingTicketsForPlayerResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCancelAllMatchmakingTicketsForPlayerResultEvent != this.OnMultiplayerCancelAllMatchmakingTicketsForPlayerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerCancelAllMatchmakingTicketsForPlayerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CancelAllMatchmakingTicketsForPlayerResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerCancelAllMatchmakingTicketsForPlayerResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCancelAllMatchmakingTicketsForPlayerResultEvent != this.OnMultiplayerCancelAllMatchmakingTicketsForPlayerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerCancelMatchmakingTicketRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CancelMatchmakingTicketRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerCancelMatchmakingTicketRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCancelMatchmakingTicketRequestEvent != this.OnMultiplayerCancelMatchmakingTicketRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerCancelMatchmakingTicketRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CancelMatchmakingTicketRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerCancelMatchmakingTicketRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCancelMatchmakingTicketRequestEvent != this.OnMultiplayerCancelMatchmakingTicketRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerCancelMatchmakingTicketResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CancelMatchmakingTicketResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerCancelMatchmakingTicketResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCancelMatchmakingTicketResultEvent != this.OnMultiplayerCancelMatchmakingTicketResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerCancelMatchmakingTicketResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CancelMatchmakingTicketResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerCancelMatchmakingTicketResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCancelMatchmakingTicketResultEvent != this.OnMultiplayerCancelMatchmakingTicketResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerCreateBuildWithCustomContainerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateBuildWithCustomContainerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerCreateBuildWithCustomContainerRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateBuildWithCustomContainerRequestEvent != this.OnMultiplayerCreateBuildWithCustomContainerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerCreateBuildWithCustomContainerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateBuildWithCustomContainerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerCreateBuildWithCustomContainerRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateBuildWithCustomContainerRequestEvent != this.OnMultiplayerCreateBuildWithCustomContainerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerCreateBuildWithCustomContainerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateBuildWithCustomContainerResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerCreateBuildWithCustomContainerResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateBuildWithCustomContainerResultEvent != this.OnMultiplayerCreateBuildWithCustomContainerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerCreateBuildWithCustomContainerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateBuildWithCustomContainerResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerCreateBuildWithCustomContainerResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateBuildWithCustomContainerResultEvent != this.OnMultiplayerCreateBuildWithCustomContainerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerCreateBuildWithManagedContainerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateBuildWithManagedContainerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerCreateBuildWithManagedContainerRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateBuildWithManagedContainerRequestEvent != this.OnMultiplayerCreateBuildWithManagedContainerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerCreateBuildWithManagedContainerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateBuildWithManagedContainerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerCreateBuildWithManagedContainerRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateBuildWithManagedContainerRequestEvent != this.OnMultiplayerCreateBuildWithManagedContainerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerCreateBuildWithManagedContainerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateBuildWithManagedContainerResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerCreateBuildWithManagedContainerResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateBuildWithManagedContainerResultEvent != this.OnMultiplayerCreateBuildWithManagedContainerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerCreateBuildWithManagedContainerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateBuildWithManagedContainerResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerCreateBuildWithManagedContainerResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateBuildWithManagedContainerResultEvent != this.OnMultiplayerCreateBuildWithManagedContainerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerCreateMatchmakingTicketRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateMatchmakingTicketRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerCreateMatchmakingTicketRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateMatchmakingTicketRequestEvent != this.OnMultiplayerCreateMatchmakingTicketRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerCreateMatchmakingTicketRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateMatchmakingTicketRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerCreateMatchmakingTicketRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateMatchmakingTicketRequestEvent != this.OnMultiplayerCreateMatchmakingTicketRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerCreateMatchmakingTicketResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateMatchmakingTicketResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerCreateMatchmakingTicketResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateMatchmakingTicketResultEvent != this.OnMultiplayerCreateMatchmakingTicketResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerCreateMatchmakingTicketResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateMatchmakingTicketResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerCreateMatchmakingTicketResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateMatchmakingTicketResultEvent != this.OnMultiplayerCreateMatchmakingTicketResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerCreateRemoteUserRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateRemoteUserRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerCreateRemoteUserRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateRemoteUserRequestEvent != this.OnMultiplayerCreateRemoteUserRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerCreateRemoteUserRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateRemoteUserRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerCreateRemoteUserRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateRemoteUserRequestEvent != this.OnMultiplayerCreateRemoteUserRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerCreateRemoteUserResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateRemoteUserResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerCreateRemoteUserResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateRemoteUserResultEvent != this.OnMultiplayerCreateRemoteUserResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerCreateRemoteUserResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateRemoteUserResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerCreateRemoteUserResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateRemoteUserResultEvent != this.OnMultiplayerCreateRemoteUserResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerCreateServerMatchmakingTicketRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateServerMatchmakingTicketRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerCreateServerMatchmakingTicketRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateServerMatchmakingTicketRequestEvent != this.OnMultiplayerCreateServerMatchmakingTicketRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerCreateServerMatchmakingTicketRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.CreateServerMatchmakingTicketRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerCreateServerMatchmakingTicketRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateServerMatchmakingTicketRequestEvent != this.OnMultiplayerCreateServerMatchmakingTicketRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerCreateServerMatchmakingTicketResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateMatchmakingTicketResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerCreateServerMatchmakingTicketResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateServerMatchmakingTicketResultEvent != this.OnMultiplayerCreateServerMatchmakingTicketResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerCreateServerMatchmakingTicketResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.CreateMatchmakingTicketResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerCreateServerMatchmakingTicketResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerCreateServerMatchmakingTicketResultEvent != this.OnMultiplayerCreateServerMatchmakingTicketResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerDeleteAssetRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.DeleteAssetRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerDeleteAssetRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteAssetRequestEvent != this.OnMultiplayerDeleteAssetRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerDeleteAssetRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.DeleteAssetRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerDeleteAssetRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteAssetRequestEvent != this.OnMultiplayerDeleteAssetRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerDeleteAssetResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerDeleteAssetResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteAssetResultEvent != this.OnMultiplayerDeleteAssetResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerDeleteAssetResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerDeleteAssetResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteAssetResultEvent != this.OnMultiplayerDeleteAssetResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerDeleteBuildRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.DeleteBuildRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerDeleteBuildRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteBuildRequestEvent != this.OnMultiplayerDeleteBuildRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerDeleteBuildRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.DeleteBuildRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerDeleteBuildRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteBuildRequestEvent != this.OnMultiplayerDeleteBuildRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerDeleteBuildResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerDeleteBuildResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteBuildResultEvent != this.OnMultiplayerDeleteBuildResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerDeleteBuildResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerDeleteBuildResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteBuildResultEvent != this.OnMultiplayerDeleteBuildResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerDeleteCertificateRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.DeleteCertificateRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerDeleteCertificateRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteCertificateRequestEvent != this.OnMultiplayerDeleteCertificateRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerDeleteCertificateRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.DeleteCertificateRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerDeleteCertificateRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteCertificateRequestEvent != this.OnMultiplayerDeleteCertificateRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerDeleteCertificateResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerDeleteCertificateResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteCertificateResultEvent != this.OnMultiplayerDeleteCertificateResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerDeleteCertificateResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerDeleteCertificateResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteCertificateResultEvent != this.OnMultiplayerDeleteCertificateResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerDeleteRemoteUserRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.DeleteRemoteUserRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerDeleteRemoteUserRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteRemoteUserRequestEvent != this.OnMultiplayerDeleteRemoteUserRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerDeleteRemoteUserRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.DeleteRemoteUserRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerDeleteRemoteUserRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteRemoteUserRequestEvent != this.OnMultiplayerDeleteRemoteUserRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerDeleteRemoteUserResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerDeleteRemoteUserResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteRemoteUserResultEvent != this.OnMultiplayerDeleteRemoteUserResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerDeleteRemoteUserResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerDeleteRemoteUserResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerDeleteRemoteUserResultEvent != this.OnMultiplayerDeleteRemoteUserResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerEnableMultiplayerServersForTitleRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.EnableMultiplayerServersForTitleRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerEnableMultiplayerServersForTitleRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerEnableMultiplayerServersForTitleRequestEvent != this.OnMultiplayerEnableMultiplayerServersForTitleRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerEnableMultiplayerServersForTitleRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.EnableMultiplayerServersForTitleRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerEnableMultiplayerServersForTitleRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerEnableMultiplayerServersForTitleRequestEvent != this.OnMultiplayerEnableMultiplayerServersForTitleRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerEnableMultiplayerServersForTitleResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EnableMultiplayerServersForTitleResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerEnableMultiplayerServersForTitleResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerEnableMultiplayerServersForTitleResultEvent != this.OnMultiplayerEnableMultiplayerServersForTitleResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerEnableMultiplayerServersForTitleResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EnableMultiplayerServersForTitleResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerEnableMultiplayerServersForTitleResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerEnableMultiplayerServersForTitleResultEvent != this.OnMultiplayerEnableMultiplayerServersForTitleResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetAssetUploadUrlRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetAssetUploadUrlRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetAssetUploadUrlRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetAssetUploadUrlRequestEvent != this.OnMultiplayerGetAssetUploadUrlRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetAssetUploadUrlRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetAssetUploadUrlRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetAssetUploadUrlRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetAssetUploadUrlRequestEvent != this.OnMultiplayerGetAssetUploadUrlRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetAssetUploadUrlResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetAssetUploadUrlResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetAssetUploadUrlResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetAssetUploadUrlResultEvent != this.OnMultiplayerGetAssetUploadUrlResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetAssetUploadUrlResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetAssetUploadUrlResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetAssetUploadUrlResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetAssetUploadUrlResultEvent != this.OnMultiplayerGetAssetUploadUrlResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetBuildRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetBuildRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetBuildRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetBuildRequestEvent != this.OnMultiplayerGetBuildRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetBuildRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetBuildRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetBuildRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetBuildRequestEvent != this.OnMultiplayerGetBuildRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetBuildResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetBuildResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetBuildResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetBuildResultEvent != this.OnMultiplayerGetBuildResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetBuildResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetBuildResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetBuildResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetBuildResultEvent != this.OnMultiplayerGetBuildResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetContainerRegistryCredentialsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetContainerRegistryCredentialsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetContainerRegistryCredentialsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetContainerRegistryCredentialsRequestEvent != this.OnMultiplayerGetContainerRegistryCredentialsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetContainerRegistryCredentialsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetContainerRegistryCredentialsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetContainerRegistryCredentialsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetContainerRegistryCredentialsRequestEvent != this.OnMultiplayerGetContainerRegistryCredentialsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetContainerRegistryCredentialsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetContainerRegistryCredentialsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetContainerRegistryCredentialsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetContainerRegistryCredentialsResultEvent != this.OnMultiplayerGetContainerRegistryCredentialsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetContainerRegistryCredentialsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetContainerRegistryCredentialsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetContainerRegistryCredentialsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetContainerRegistryCredentialsResultEvent != this.OnMultiplayerGetContainerRegistryCredentialsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetMatchRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetMatchRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetMatchRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetMatchRequestEvent != this.OnMultiplayerGetMatchRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetMatchRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetMatchRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetMatchRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetMatchRequestEvent != this.OnMultiplayerGetMatchRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetMatchResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetMatchResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetMatchResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetMatchResultEvent != this.OnMultiplayerGetMatchResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetMatchResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetMatchResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetMatchResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetMatchResultEvent != this.OnMultiplayerGetMatchResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetMatchmakingTicketRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetMatchmakingTicketRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetMatchmakingTicketRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetMatchmakingTicketRequestEvent != this.OnMultiplayerGetMatchmakingTicketRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetMatchmakingTicketRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetMatchmakingTicketRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetMatchmakingTicketRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetMatchmakingTicketRequestEvent != this.OnMultiplayerGetMatchmakingTicketRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetMatchmakingTicketResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetMatchmakingTicketResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetMatchmakingTicketResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetMatchmakingTicketResultEvent != this.OnMultiplayerGetMatchmakingTicketResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetMatchmakingTicketResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetMatchmakingTicketResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetMatchmakingTicketResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetMatchmakingTicketResultEvent != this.OnMultiplayerGetMatchmakingTicketResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetMultiplayerServerDetailsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetMultiplayerServerDetailsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetMultiplayerServerDetailsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetMultiplayerServerDetailsRequestEvent != this.OnMultiplayerGetMultiplayerServerDetailsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetMultiplayerServerDetailsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetMultiplayerServerDetailsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetMultiplayerServerDetailsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetMultiplayerServerDetailsRequestEvent != this.OnMultiplayerGetMultiplayerServerDetailsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetMultiplayerServerDetailsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetMultiplayerServerDetailsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetMultiplayerServerDetailsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetMultiplayerServerDetailsResultEvent != this.OnMultiplayerGetMultiplayerServerDetailsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetMultiplayerServerDetailsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetMultiplayerServerDetailsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetMultiplayerServerDetailsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetMultiplayerServerDetailsResultEvent != this.OnMultiplayerGetMultiplayerServerDetailsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetQueueStatisticsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetQueueStatisticsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetQueueStatisticsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetQueueStatisticsRequestEvent != this.OnMultiplayerGetQueueStatisticsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetQueueStatisticsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetQueueStatisticsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetQueueStatisticsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetQueueStatisticsRequestEvent != this.OnMultiplayerGetQueueStatisticsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetQueueStatisticsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetQueueStatisticsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetQueueStatisticsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetQueueStatisticsResultEvent != this.OnMultiplayerGetQueueStatisticsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetQueueStatisticsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetQueueStatisticsResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetQueueStatisticsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetQueueStatisticsResultEvent != this.OnMultiplayerGetQueueStatisticsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetRemoteLoginEndpointRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetRemoteLoginEndpointRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetRemoteLoginEndpointRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetRemoteLoginEndpointRequestEvent != this.OnMultiplayerGetRemoteLoginEndpointRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetRemoteLoginEndpointRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetRemoteLoginEndpointRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetRemoteLoginEndpointRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetRemoteLoginEndpointRequestEvent != this.OnMultiplayerGetRemoteLoginEndpointRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetRemoteLoginEndpointResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetRemoteLoginEndpointResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetRemoteLoginEndpointResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetRemoteLoginEndpointResultEvent != this.OnMultiplayerGetRemoteLoginEndpointResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetRemoteLoginEndpointResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetRemoteLoginEndpointResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetRemoteLoginEndpointResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetRemoteLoginEndpointResultEvent != this.OnMultiplayerGetRemoteLoginEndpointResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetTitleEnabledForMultiplayerServersStatusRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetTitleEnabledForMultiplayerServersStatusRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetTitleEnabledForMultiplayerServersStatusRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetTitleEnabledForMultiplayerServersStatusRequestEvent != this.OnMultiplayerGetTitleEnabledForMultiplayerServersStatusRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetTitleEnabledForMultiplayerServersStatusRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetTitleEnabledForMultiplayerServersStatusRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetTitleEnabledForMultiplayerServersStatusRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetTitleEnabledForMultiplayerServersStatusRequestEvent != this.OnMultiplayerGetTitleEnabledForMultiplayerServersStatusRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetTitleEnabledForMultiplayerServersStatusResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetTitleEnabledForMultiplayerServersStatusResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetTitleEnabledForMultiplayerServersStatusResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetTitleEnabledForMultiplayerServersStatusResultEvent != this.OnMultiplayerGetTitleEnabledForMultiplayerServersStatusResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetTitleEnabledForMultiplayerServersStatusResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetTitleEnabledForMultiplayerServersStatusResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetTitleEnabledForMultiplayerServersStatusResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetTitleEnabledForMultiplayerServersStatusResultEvent != this.OnMultiplayerGetTitleEnabledForMultiplayerServersStatusResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetTitleMultiplayerServersQuotasRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetTitleMultiplayerServersQuotasRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetTitleMultiplayerServersQuotasRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetTitleMultiplayerServersQuotasRequestEvent != this.OnMultiplayerGetTitleMultiplayerServersQuotasRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetTitleMultiplayerServersQuotasRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.GetTitleMultiplayerServersQuotasRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetTitleMultiplayerServersQuotasRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetTitleMultiplayerServersQuotasRequestEvent != this.OnMultiplayerGetTitleMultiplayerServersQuotasRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerGetTitleMultiplayerServersQuotasResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetTitleMultiplayerServersQuotasResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerGetTitleMultiplayerServersQuotasResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetTitleMultiplayerServersQuotasResultEvent != this.OnMultiplayerGetTitleMultiplayerServersQuotasResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerGetTitleMultiplayerServersQuotasResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.GetTitleMultiplayerServersQuotasResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerGetTitleMultiplayerServersQuotasResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerGetTitleMultiplayerServersQuotasResultEvent != this.OnMultiplayerGetTitleMultiplayerServersQuotasResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerJoinMatchmakingTicketRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.JoinMatchmakingTicketRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerJoinMatchmakingTicketRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerJoinMatchmakingTicketRequestEvent != this.OnMultiplayerJoinMatchmakingTicketRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerJoinMatchmakingTicketRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.JoinMatchmakingTicketRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerJoinMatchmakingTicketRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerJoinMatchmakingTicketRequestEvent != this.OnMultiplayerJoinMatchmakingTicketRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerJoinMatchmakingTicketResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.JoinMatchmakingTicketResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerJoinMatchmakingTicketResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerJoinMatchmakingTicketResultEvent != this.OnMultiplayerJoinMatchmakingTicketResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerJoinMatchmakingTicketResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.JoinMatchmakingTicketResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerJoinMatchmakingTicketResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerJoinMatchmakingTicketResultEvent != this.OnMultiplayerJoinMatchmakingTicketResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListArchivedMultiplayerServersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListMultiplayerServersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListArchivedMultiplayerServersRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListArchivedMultiplayerServersRequestEvent != this.OnMultiplayerListArchivedMultiplayerServersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListArchivedMultiplayerServersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListMultiplayerServersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListArchivedMultiplayerServersRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListArchivedMultiplayerServersRequestEvent != this.OnMultiplayerListArchivedMultiplayerServersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListArchivedMultiplayerServersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListMultiplayerServersResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListArchivedMultiplayerServersResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListArchivedMultiplayerServersResultEvent != this.OnMultiplayerListArchivedMultiplayerServersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListArchivedMultiplayerServersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListMultiplayerServersResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListArchivedMultiplayerServersResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListArchivedMultiplayerServersResultEvent != this.OnMultiplayerListArchivedMultiplayerServersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListAssetSummariesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListAssetSummariesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListAssetSummariesRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListAssetSummariesRequestEvent != this.OnMultiplayerListAssetSummariesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListAssetSummariesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListAssetSummariesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListAssetSummariesRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListAssetSummariesRequestEvent != this.OnMultiplayerListAssetSummariesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListAssetSummariesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListAssetSummariesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListAssetSummariesResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListAssetSummariesResultEvent != this.OnMultiplayerListAssetSummariesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListAssetSummariesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListAssetSummariesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListAssetSummariesResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListAssetSummariesResultEvent != this.OnMultiplayerListAssetSummariesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListBuildSummariesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListBuildSummariesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListBuildSummariesRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListBuildSummariesRequestEvent != this.OnMultiplayerListBuildSummariesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListBuildSummariesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListBuildSummariesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListBuildSummariesRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListBuildSummariesRequestEvent != this.OnMultiplayerListBuildSummariesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListBuildSummariesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListBuildSummariesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListBuildSummariesResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListBuildSummariesResultEvent != this.OnMultiplayerListBuildSummariesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListBuildSummariesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListBuildSummariesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListBuildSummariesResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListBuildSummariesResultEvent != this.OnMultiplayerListBuildSummariesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListCertificateSummariesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListCertificateSummariesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListCertificateSummariesRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListCertificateSummariesRequestEvent != this.OnMultiplayerListCertificateSummariesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListCertificateSummariesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListCertificateSummariesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListCertificateSummariesRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListCertificateSummariesRequestEvent != this.OnMultiplayerListCertificateSummariesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListCertificateSummariesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListCertificateSummariesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListCertificateSummariesResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListCertificateSummariesResultEvent != this.OnMultiplayerListCertificateSummariesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListCertificateSummariesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListCertificateSummariesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListCertificateSummariesResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListCertificateSummariesResultEvent != this.OnMultiplayerListCertificateSummariesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListContainerImagesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListContainerImagesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListContainerImagesRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListContainerImagesRequestEvent != this.OnMultiplayerListContainerImagesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListContainerImagesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListContainerImagesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListContainerImagesRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListContainerImagesRequestEvent != this.OnMultiplayerListContainerImagesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListContainerImagesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListContainerImagesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListContainerImagesResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListContainerImagesResultEvent != this.OnMultiplayerListContainerImagesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListContainerImagesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListContainerImagesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListContainerImagesResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListContainerImagesResultEvent != this.OnMultiplayerListContainerImagesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListContainerImageTagsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListContainerImageTagsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListContainerImageTagsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListContainerImageTagsRequestEvent != this.OnMultiplayerListContainerImageTagsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListContainerImageTagsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListContainerImageTagsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListContainerImageTagsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListContainerImageTagsRequestEvent != this.OnMultiplayerListContainerImageTagsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListContainerImageTagsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListContainerImageTagsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListContainerImageTagsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListContainerImageTagsResultEvent != this.OnMultiplayerListContainerImageTagsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListContainerImageTagsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListContainerImageTagsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListContainerImageTagsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListContainerImageTagsResultEvent != this.OnMultiplayerListContainerImageTagsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListMatchmakingTicketsForPlayerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListMatchmakingTicketsForPlayerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListMatchmakingTicketsForPlayerRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListMatchmakingTicketsForPlayerRequestEvent != this.OnMultiplayerListMatchmakingTicketsForPlayerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListMatchmakingTicketsForPlayerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListMatchmakingTicketsForPlayerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListMatchmakingTicketsForPlayerRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListMatchmakingTicketsForPlayerRequestEvent != this.OnMultiplayerListMatchmakingTicketsForPlayerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListMatchmakingTicketsForPlayerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListMatchmakingTicketsForPlayerResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListMatchmakingTicketsForPlayerResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListMatchmakingTicketsForPlayerResultEvent != this.OnMultiplayerListMatchmakingTicketsForPlayerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListMatchmakingTicketsForPlayerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListMatchmakingTicketsForPlayerResult> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListMatchmakingTicketsForPlayerResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListMatchmakingTicketsForPlayerResultEvent != this.OnMultiplayerListMatchmakingTicketsForPlayerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListMultiplayerServersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListMultiplayerServersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListMultiplayerServersRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListMultiplayerServersRequestEvent != this.OnMultiplayerListMultiplayerServersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListMultiplayerServersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListMultiplayerServersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListMultiplayerServersRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListMultiplayerServersRequestEvent != this.OnMultiplayerListMultiplayerServersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListMultiplayerServersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListMultiplayerServersResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListMultiplayerServersResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListMultiplayerServersResultEvent != this.OnMultiplayerListMultiplayerServersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListMultiplayerServersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListMultiplayerServersResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListMultiplayerServersResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListMultiplayerServersResultEvent != this.OnMultiplayerListMultiplayerServersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListPartyQosServersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListPartyQosServersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListPartyQosServersRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListPartyQosServersRequestEvent != this.OnMultiplayerListPartyQosServersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListPartyQosServersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListPartyQosServersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListPartyQosServersRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListPartyQosServersRequestEvent != this.OnMultiplayerListPartyQosServersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListPartyQosServersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListPartyQosServersResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListPartyQosServersResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListPartyQosServersResultEvent != this.OnMultiplayerListPartyQosServersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListPartyQosServersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListPartyQosServersResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListPartyQosServersResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListPartyQosServersResultEvent != this.OnMultiplayerListPartyQosServersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListQosServersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListQosServersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListQosServersRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListQosServersRequestEvent != this.OnMultiplayerListQosServersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListQosServersRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListQosServersRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListQosServersRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListQosServersRequestEvent != this.OnMultiplayerListQosServersRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListQosServersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListQosServersResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListQosServersResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListQosServersResultEvent != this.OnMultiplayerListQosServersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListQosServersResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListQosServersResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListQosServersResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListQosServersResultEvent != this.OnMultiplayerListQosServersResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListQosServersForTitleRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListQosServersForTitleRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListQosServersForTitleRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListQosServersForTitleRequestEvent != this.OnMultiplayerListQosServersForTitleRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListQosServersForTitleRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListQosServersForTitleRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListQosServersForTitleRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListQosServersForTitleRequestEvent != this.OnMultiplayerListQosServersForTitleRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListQosServersForTitleResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListQosServersForTitleResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListQosServersForTitleResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListQosServersForTitleResultEvent != this.OnMultiplayerListQosServersForTitleResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListQosServersForTitleResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListQosServersForTitleResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListQosServersForTitleResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListQosServersForTitleResultEvent != this.OnMultiplayerListQosServersForTitleResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListVirtualMachineSummariesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListVirtualMachineSummariesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListVirtualMachineSummariesRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListVirtualMachineSummariesRequestEvent != this.OnMultiplayerListVirtualMachineSummariesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListVirtualMachineSummariesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ListVirtualMachineSummariesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListVirtualMachineSummariesRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListVirtualMachineSummariesRequestEvent != this.OnMultiplayerListVirtualMachineSummariesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerListVirtualMachineSummariesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListVirtualMachineSummariesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerListVirtualMachineSummariesResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListVirtualMachineSummariesResultEvent != this.OnMultiplayerListVirtualMachineSummariesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerListVirtualMachineSummariesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.ListVirtualMachineSummariesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerListVirtualMachineSummariesResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerListVirtualMachineSummariesResultEvent != this.OnMultiplayerListVirtualMachineSummariesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerRequestMultiplayerServerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.RequestMultiplayerServerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerRequestMultiplayerServerRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerRequestMultiplayerServerRequestEvent != this.OnMultiplayerRequestMultiplayerServerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerRequestMultiplayerServerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.RequestMultiplayerServerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerRequestMultiplayerServerRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerRequestMultiplayerServerRequestEvent != this.OnMultiplayerRequestMultiplayerServerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerRequestMultiplayerServerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.RequestMultiplayerServerResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerRequestMultiplayerServerResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerRequestMultiplayerServerResultEvent != this.OnMultiplayerRequestMultiplayerServerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerRequestMultiplayerServerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.RequestMultiplayerServerResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerRequestMultiplayerServerResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerRequestMultiplayerServerResultEvent != this.OnMultiplayerRequestMultiplayerServerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerRolloverContainerRegistryCredentialsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.RolloverContainerRegistryCredentialsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerRolloverContainerRegistryCredentialsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerRolloverContainerRegistryCredentialsRequestEvent != this.OnMultiplayerRolloverContainerRegistryCredentialsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerRolloverContainerRegistryCredentialsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.RolloverContainerRegistryCredentialsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerRolloverContainerRegistryCredentialsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerRolloverContainerRegistryCredentialsRequestEvent != this.OnMultiplayerRolloverContainerRegistryCredentialsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerRolloverContainerRegistryCredentialsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.RolloverContainerRegistryCredentialsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerRolloverContainerRegistryCredentialsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerRolloverContainerRegistryCredentialsResultEvent != this.OnMultiplayerRolloverContainerRegistryCredentialsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerRolloverContainerRegistryCredentialsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.RolloverContainerRegistryCredentialsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerRolloverContainerRegistryCredentialsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerRolloverContainerRegistryCredentialsResultEvent != this.OnMultiplayerRolloverContainerRegistryCredentialsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerShutdownMultiplayerServerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ShutdownMultiplayerServerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerShutdownMultiplayerServerRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerShutdownMultiplayerServerRequestEvent != this.OnMultiplayerShutdownMultiplayerServerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerShutdownMultiplayerServerRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.ShutdownMultiplayerServerRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerShutdownMultiplayerServerRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerShutdownMultiplayerServerRequestEvent != this.OnMultiplayerShutdownMultiplayerServerRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerShutdownMultiplayerServerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerShutdownMultiplayerServerResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerShutdownMultiplayerServerResultEvent != this.OnMultiplayerShutdownMultiplayerServerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerShutdownMultiplayerServerResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerShutdownMultiplayerServerResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerShutdownMultiplayerServerResultEvent != this.OnMultiplayerShutdownMultiplayerServerResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerUpdateBuildRegionsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.UpdateBuildRegionsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerUpdateBuildRegionsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerUpdateBuildRegionsRequestEvent != this.OnMultiplayerUpdateBuildRegionsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerUpdateBuildRegionsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.UpdateBuildRegionsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerUpdateBuildRegionsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerUpdateBuildRegionsRequestEvent != this.OnMultiplayerUpdateBuildRegionsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerUpdateBuildRegionsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerUpdateBuildRegionsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerUpdateBuildRegionsResultEvent != this.OnMultiplayerUpdateBuildRegionsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerUpdateBuildRegionsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerUpdateBuildRegionsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerUpdateBuildRegionsResultEvent != this.OnMultiplayerUpdateBuildRegionsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerUploadCertificateRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.UploadCertificateRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerUploadCertificateRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerUploadCertificateRequestEvent != this.OnMultiplayerUploadCertificateRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerUploadCertificateRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.MultiplayerModels.UploadCertificateRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerUploadCertificateRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerUploadCertificateRequestEvent != this.OnMultiplayerUploadCertificateRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnMultiplayerUploadCertificateResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnMultiplayerUploadCertificateResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerUploadCertificateResultEvent != this.OnMultiplayerUploadCertificateResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnMultiplayerUploadCertificateResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.MultiplayerModels.EmptyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnMultiplayerUploadCertificateResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnMultiplayerUploadCertificateResultEvent != this.OnMultiplayerUploadCertificateResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnProfilesGetGlobalPolicyRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.GetGlobalPolicyRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnProfilesGetGlobalPolicyRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetGlobalPolicyRequestEvent != this.OnProfilesGetGlobalPolicyRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnProfilesGetGlobalPolicyRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.GetGlobalPolicyRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnProfilesGetGlobalPolicyRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetGlobalPolicyRequestEvent != this.OnProfilesGetGlobalPolicyRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnProfilesGetGlobalPolicyResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.GetGlobalPolicyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnProfilesGetGlobalPolicyResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetGlobalPolicyResultEvent != this.OnProfilesGetGlobalPolicyResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnProfilesGetGlobalPolicyResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.GetGlobalPolicyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnProfilesGetGlobalPolicyResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetGlobalPolicyResultEvent != this.OnProfilesGetGlobalPolicyResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnProfilesGetProfileRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.GetEntityProfileRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnProfilesGetProfileRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetProfileRequestEvent != this.OnProfilesGetProfileRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnProfilesGetProfileRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.GetEntityProfileRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnProfilesGetProfileRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetProfileRequestEvent != this.OnProfilesGetProfileRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnProfilesGetProfileResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.GetEntityProfileResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnProfilesGetProfileResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetProfileResultEvent != this.OnProfilesGetProfileResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnProfilesGetProfileResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.GetEntityProfileResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnProfilesGetProfileResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetProfileResultEvent != this.OnProfilesGetProfileResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnProfilesGetProfilesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.GetEntityProfilesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnProfilesGetProfilesRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetProfilesRequestEvent != this.OnProfilesGetProfilesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnProfilesGetProfilesRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.GetEntityProfilesRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnProfilesGetProfilesRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetProfilesRequestEvent != this.OnProfilesGetProfilesRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnProfilesGetProfilesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.GetEntityProfilesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnProfilesGetProfilesResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetProfilesResultEvent != this.OnProfilesGetProfilesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnProfilesGetProfilesResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.GetEntityProfilesResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnProfilesGetProfilesResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetProfilesResultEvent != this.OnProfilesGetProfilesResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.GetTitlePlayersFromMasterPlayerAccountIdsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsRequestEvent != this.OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.GetTitlePlayersFromMasterPlayerAccountIdsRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsRequestEvent != this.OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.GetTitlePlayersFromMasterPlayerAccountIdsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsResultEvent != this.OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.GetTitlePlayersFromMasterPlayerAccountIdsResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsResultEvent != this.OnProfilesGetTitlePlayersFromMasterPlayerAccountIdsResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnProfilesSetGlobalPolicyRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.SetGlobalPolicyRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnProfilesSetGlobalPolicyRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesSetGlobalPolicyRequestEvent != this.OnProfilesSetGlobalPolicyRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnProfilesSetGlobalPolicyRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.SetGlobalPolicyRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnProfilesSetGlobalPolicyRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesSetGlobalPolicyRequestEvent != this.OnProfilesSetGlobalPolicyRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnProfilesSetGlobalPolicyResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.SetGlobalPolicyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnProfilesSetGlobalPolicyResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesSetGlobalPolicyResultEvent != this.OnProfilesSetGlobalPolicyResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnProfilesSetGlobalPolicyResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.SetGlobalPolicyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnProfilesSetGlobalPolicyResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesSetGlobalPolicyResultEvent != this.OnProfilesSetGlobalPolicyResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnProfilesSetProfileLanguageRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.SetProfileLanguageRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnProfilesSetProfileLanguageRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesSetProfileLanguageRequestEvent != this.OnProfilesSetProfileLanguageRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnProfilesSetProfileLanguageRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.SetProfileLanguageRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnProfilesSetProfileLanguageRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesSetProfileLanguageRequestEvent != this.OnProfilesSetProfileLanguageRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnProfilesSetProfileLanguageResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.SetProfileLanguageResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnProfilesSetProfileLanguageResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesSetProfileLanguageResultEvent != this.OnProfilesSetProfileLanguageResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnProfilesSetProfileLanguageResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.SetProfileLanguageResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnProfilesSetProfileLanguageResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesSetProfileLanguageResultEvent != this.OnProfilesSetProfileLanguageResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnProfilesSetProfilePolicyRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.SetEntityProfilePolicyRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnProfilesSetProfilePolicyRequestEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesSetProfilePolicyRequestEvent != this.OnProfilesSetProfilePolicyRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnProfilesSetProfilePolicyRequestEvent(PlayFab.Events.PlayFabEvents.PlayFabRequestEvent<PlayFab.ProfilesModels.SetEntityProfilePolicyRequest> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnProfilesSetProfilePolicyRequestEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesSetProfilePolicyRequestEvent != this.OnProfilesSetProfilePolicyRequestEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnProfilesSetProfilePolicyResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.SetEntityProfilePolicyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnProfilesSetProfilePolicyResultEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesSetProfilePolicyResultEvent != this.OnProfilesSetProfilePolicyResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnProfilesSetProfilePolicyResultEvent(PlayFab.Events.PlayFabEvents.PlayFabResultEvent<PlayFab.ProfilesModels.SetEntityProfilePolicyResponse> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnProfilesSetProfilePolicyResultEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnProfilesSetProfilePolicyResultEvent != this.OnProfilesSetProfilePolicyResultEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnGlobalErrorEvent(PlayFab.Events.PlayFabEvents.PlayFabErrorEvent value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnGlobalErrorEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGlobalErrorEvent != this.OnGlobalErrorEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnGlobalErrorEvent(PlayFab.Events.PlayFabEvents.PlayFabErrorEvent value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnGlobalErrorEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnGlobalErrorEvent != this.OnGlobalErrorEvent);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PlayFabEvents()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static PlayFab.Events.PlayFabEvents Init()
        {
            PlayFab.Events.PlayFabEvents val_4 = PlayFab.Events.PlayFabEvents._instance;
            if(val_4 == null)
            {
                    PlayFab.Events.PlayFabEvents val_1 = new PlayFab.Events.PlayFabEvents();
                PlayFab.Events.PlayFabEvents._instance = val_1;
                val_4 = PlayFab.Events.PlayFabEvents._instance;
            }
            
            PlayFab.Internal.PlayFabHttp.add_ApiProcessingEventHandler(value:  new PlayFabHttp.ApiProcessingEvent<PlayFab.Internal.ApiProcessingEventArgs>(object:  val_1, method:  System.Void PlayFab.Events.PlayFabEvents::OnProcessingEvent(PlayFab.Internal.ApiProcessingEventArgs e)));
            PlayFab.Internal.PlayFabHttp.add_ApiProcessingErrorEventHandler(value:  new PlayFabHttp.ApiProcessErrorEvent(object:  val_1, method:  System.Void PlayFab.Events.PlayFabEvents::OnProcessingErrorEvent(PlayFab.SharedModels.PlayFabRequestCommon request, PlayFab.PlayFabError error)));
            return (PlayFab.Events.PlayFabEvents)PlayFab.Events.PlayFabEvents._instance;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UnregisterInstance(object instance)
        {
            System.Delegate val_4;
            var val_4 = 0;
            val_4 = this.OnLoginResultEvent.GetInvocationList()[0];
            if(val_4.Target == instance)
            {
                    if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                this.remove_OnLoginResultEvent(value:  val_4);
            }
            
            val_4 = val_4 + 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnProcessingErrorEvent(PlayFab.SharedModels.PlayFabRequestCommon request, PlayFab.PlayFabError error)
        {
            if(null == 0)
            {
                    return;
            }
            
            Invoke(request:  request, error:  error);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnProcessingEvent(PlayFab.Internal.ApiProcessingEventArgs e)
        {
            if(e == null)
            {
                
            }
            
            bool val_3 = System.Type.op_Equality(left:  e.Result.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
    
    }

}
