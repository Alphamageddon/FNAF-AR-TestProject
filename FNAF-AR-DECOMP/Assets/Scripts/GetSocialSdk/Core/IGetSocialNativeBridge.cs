using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal interface IGetSocialNativeBridge
    {
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract GetSocialSdk.Core.GetSocialFactory.AvailableRuntimes[] RuntimeImplementation { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsInitialized { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract GetSocialSdk.Core.InviteChannel[] InviteChannels { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string UserId { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsUserAnonymous { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.Dictionary<string, string> UserAuthIdentities { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.Dictionary<string, string> AllPublicProperties { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.Dictionary<string, string> AllPrivateProperties { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string DisplayName { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string AvatarUrl { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract GetSocialSdk.Core.GetSocialFactory.AvailableRuntimes[] get_RuntimeImplementation(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Init(string appId); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void WhenInitialized(System.Action action); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsInitialized(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetNativeSdkVersion(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetLanguage(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool SetLanguage(string languageCode); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool SetGlobalErrorListener(System.Action<GetSocialSdk.Core.GetSocialError> onError); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool RemoveGlobalErrorListener(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool IsInviteChannelAvailable(string channelId); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract GetSocialSdk.Core.InviteChannel[] get_InviteChannels(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SendInvite(string channelId, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SendInvite(string channelId, GetSocialSdk.Core.InviteContent customInviteContent, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SendInvite(string channelId, GetSocialSdk.Core.InviteContent customInviteContent, GetSocialSdk.Core.LinkParams linkParams, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool RegisterInviteChannelPlugin(string channelId, GetSocialSdk.Core.InviteChannelPlugin inviteChannelPlugin); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetReferralData(System.Action<GetSocialSdk.Core.ReferralData> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ClearReferralData(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetReferredUsers(System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ReferredUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void CreateInviteLink(GetSocialSdk.Core.LinkParams linkParams, System.Action<string> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RegisterForPushNotifications(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetNotificationListener(GetSocialSdk.Core.NotificationListener listener); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetNotifications(GetSocialSdk.Core.NotificationsQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.Notification>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetNotificationsCount(GetSocialSdk.Core.NotificationsCountQuery query, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetNotificationsStatus(System.Collections.Generic.List<string> notificationsIds, string status, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetPushNotificationsEnabled(bool isEnabled, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void IsPushNotificationsEnabled(System.Action<bool> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SendNotification(System.Collections.Generic.List<string> userIds, GetSocialSdk.Core.NotificationContent content, System.Action<GetSocialSdk.Core.NotificationsSummary> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool SetOnUserChangedListener(System.Action listener); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool RemoveOnUserChangedListener(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string get_UserId(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool get_IsUserAnonymous(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ResetUser(System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.Dictionary<string, string> get_UserAuthIdentities(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.Dictionary<string, string> get_AllPublicProperties(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract System.Collections.Generic.Dictionary<string, string> get_AllPrivateProperties(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string get_DisplayName(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetDisplayName(string displayName, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string get_AvatarUrl(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetAvatarUrl(string avatarUrl, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetAvatar(UnityEngine.Texture2D avatar, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetPublicProperty(string key, string value, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetPrivateProperty(string key, string value, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetUserDetails(GetSocialSdk.Core.UserUpdate userUpdate, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RemovePublicProperty(string key, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RemovePrivateProperty(string key, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetPublicProperty(string key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract string GetPrivateProperty(string key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool HasPublicProperty(string key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool HasPrivateProperty(string key); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddAuthIdentity(GetSocialSdk.Core.AuthIdentity authIdentity, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure, System.Action<GetSocialSdk.Core.ConflictUser> onConflict); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RemoveAuthIdentity(string providerId, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SwitchUser(GetSocialSdk.Core.AuthIdentity authIdentity, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetUserById(string userId, System.Action<GetSocialSdk.Core.PublicUser> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetUserByAuthIdentity(string providerId, string providerUserId, System.Action<GetSocialSdk.Core.PublicUser> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetUsersByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<System.Collections.Generic.Dictionary<string, GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void FindUsers(GetSocialSdk.Core.UsersQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.UserReference>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddFriend(string userId, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void AddFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RemoveFriend(string userId, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void RemoveFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetFriends(System.Collections.Generic.List<string> userIds, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void SetFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void IsFriend(string userId, System.Action<bool> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetFriendsCount(System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetFriends(int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetSuggestedFriends(int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.SuggestedFriend>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetFriendsReferences(System.Action<System.Collections.Generic.List<GetSocialSdk.Core.UserReference>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetAnnouncements(string feed, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ActivityPost>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetActivities(GetSocialSdk.Core.ActivitiesQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ActivityPost>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetActivity(string activityId, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void PostActivityToFeed(string feed, GetSocialSdk.Core.ActivityPostContent content, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void PostCommentToActivity(string activityId, GetSocialSdk.Core.ActivityPostContent comment, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void LikeActivity(string activityId, bool isLiked, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetActivityLikers(string activityId, int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ReportActivity(string activityId, GetSocialSdk.Core.ReportingReason reportingReason, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void DeleteActivity(string activityId, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void CreatePromoCode(GetSocialSdk.Core.PromoCodeBuilder promoCodeBuilder, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void GetPromoCode(string code, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ClaimPromoCode(string code, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void HandleOnStartUnityEvent(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void Reset(); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool TrackPurchaseEvent(GetSocialSdk.Core.Analytics.PurchaseData purchaseData); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract bool TrackCustomEvent(string customEvent, System.Collections.Generic.Dictionary<string, string> eventProperties); // 0
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public abstract void ProcessAction(GetSocialSdk.Core.GetSocialAction notificationAction); // 0
    
    }

}
