using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class GetSocial
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Action<GetSocialSdk.Core.GetSocialError> _globalErrorListener;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Action<GetSocialSdk.Core.GetSocialError> _userGlobalErrorListener;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocialSdk.Core.IGetSocialNativeBridge _getSocialImpl;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocialSdk.Core.IGetSocialNativeBridge GetSocialImpl { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string UnitySdkVersion { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string NativeSdkVersion { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsInitialized { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.InviteChannel[] InviteChannels { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocialSdk.Core.IGetSocialNativeBridge get_GetSocialImpl()
        {
            System.Object[] val_4;
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if(GetSocialSdk.Core.GetSocial._getSocialImpl != null)
            {
                goto label_3;
            }
            
            val_6 = null;
            val_6 = null;
            GetSocialSdk.Core.GetSocial._getSocialImpl = GetSocialSdk.Core.GetSocialFactory.Instance;
            object[] val_2 = new object[2];
            val_4 = val_2;
            val_4[0] = "6.26.2";
            var val_7 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_15;
            }
            
            var val_4 = mem[val_1] + 176;
            var val_5 = 0;
            val_4 = val_4 + 8;
            label_14:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_5 = val_5 + 1;
            val_4 = val_4 + 16;
            if(val_5 < (mem[val_1] + 286))
            {
                goto label_14;
            }
            
            goto label_15;
            label_13:
            var val_6 = val_4;
            val_6 = val_6 + 4;
            val_7 = val_7 + val_6;
            val_7 = val_7 + 296;
            label_15:
            val_4[1] = GetSocialSdk.Core.GetSocial._getSocialImpl.GetNativeSdkVersion();
            UnityEngine.Debug.LogFormat(format:  "Using GetSocial Unity SDK v{0}, underlying native SDK v{1}", args:  val_2);
            val_5 = null;
            label_3:
            val_5 = null;
            return (GetSocialSdk.Core.IGetSocialNativeBridge)GetSocialSdk.Core.GetSocial._getSocialImpl;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void OnGlobalError(GetSocialSdk.Core.GetSocialError error)
        {
            var val_1;
            System.Action<GetSocialSdk.Core.GetSocialError> val_2;
            val_1 = null;
            val_1 = null;
            val_2 = GetSocialSdk.Core.GetSocial._userGlobalErrorListener;
            if(val_2 == null)
            {
                    return;
            }
            
            val_2 = GetSocialSdk.Core.GetSocial._userGlobalErrorListener;
            if(val_2 == null)
            {
                    val_2 = 0;
            }
            
            val_2.Invoke(obj:  error);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal static void InjectBridgeInternal(GetSocialSdk.Core.IGetSocialNativeBridge bridge)
        {
            null = null;
            GetSocialSdk.Core.GetSocial._getSocialImpl = bridge;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_UnitySdkVersion()
        {
            return "6.26.2";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string get_NativeSdkVersion()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return GetSocialSdk.Core.GetSocial.GetSocialImpl.GetNativeSdkVersion();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Init()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.Init(appId:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Init(string appId)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.Init(appId:  appId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void WhenInitialized(System.Action action)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.WhenInitialized(action:  action);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool get_IsInitialized()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return GetSocialSdk.Core.GetSocial.GetSocialImpl.IsInitialized;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool SetGlobalErrorListener(System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            string val_3 = 0;
            Check.Argument.IsNotNull(argument:  onError, argumentName:  "onError", message:  val_3 = 0);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_3 = 7;
            bool val_3 = GetSocialSdk.Core.GetSocial.GetSocialImpl.SetGlobalErrorListener(onError:  GetSocialSdk.Core.GetSocial._globalErrorListener);
            GetSocialSdk.Core.GetSocial._userGlobalErrorListener = onError;
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool RemoveGlobalErrorListener()
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            bool val_3 = GetSocialSdk.Core.GetSocial.GetSocialImpl.RemoveGlobalErrorListener();
            GetSocialSdk.Core.GetSocial._userGlobalErrorListener = 0;
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetLanguage()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return GetSocialSdk.Core.GetSocial.GetSocialImpl.GetLanguage();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool SetLanguage(string languageCode)
        {
            string val_3 = 0;
            Check.Argument.IsStrNotNullOrEmpty(argument:  languageCode, argumentName:  "languageCode", message:  val_3 = 0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 6;
            return GetSocialSdk.Core.GetSocial.GetSocialImpl.SetLanguage(languageCode:  languageCode);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool IsInviteChannelAvailable(string channelId)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return GetSocialSdk.Core.GetSocial.GetSocialImpl.IsInviteChannelAvailable(channelId:  channelId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.InviteChannel[] get_InviteChannels()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return GetSocialSdk.Core.GetSocial.GetSocialImpl.InviteChannels;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SendInvite(string channelId, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            var val_5 = null;
            GetSocialSdk.Core.Check.IfTrue(condition:  GetSocialSdk.Core.GetSocial.IsInitialized, message:  "GetSocial must be initialized before calling SendInvite()");
            Check.Argument.IsStrNotNullOrEmpty(argument:  channelId, argumentName:  "channelId", message:  0);
            Check.Argument.IsNotNull(argument:  onComplete, argumentName:  "onComplete", message:  0);
            Check.Argument.IsNotNull(argument:  onCancel, argumentName:  "onCancel", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_5 = 0;
            val_5 = val_5 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.SendInvite(channelId:  channelId, onComplete:  onComplete, onCancel:  onCancel, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SendInvite(string channelId, GetSocialSdk.Core.InviteContent customInviteContent, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsStrNotNullOrEmpty(argument:  channelId, argumentName:  "channelId", message:  0);
            Check.Argument.IsNotNull(argument:  onComplete, argumentName:  "onComplete", message:  0);
            Check.Argument.IsNotNull(argument:  onCancel, argumentName:  "onCancel", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.SendInvite(channelId:  channelId, customInviteContent:  customInviteContent, onComplete:  onComplete, onCancel:  onCancel, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SendInvite(string channelId, GetSocialSdk.Core.InviteContent customInviteContent, GetSocialSdk.Core.CustomReferralData customReferralData, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            GetSocialSdk.Core.GetSocial.SendInvite(channelId:  channelId, customInviteContent:  customInviteContent, linkParams:  new GetSocialSdk.Core.LinkParams(data:  customReferralData), onComplete:  onComplete, onCancel:  onCancel, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SendInvite(string channelId, GetSocialSdk.Core.InviteContent customInviteContent, GetSocialSdk.Core.LinkParams linkParams, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsStrNotNullOrEmpty(argument:  channelId, argumentName:  "channelId", message:  0);
            Check.Argument.IsNotNull(argument:  onComplete, argumentName:  "onComplete", message:  0);
            Check.Argument.IsNotNull(argument:  onCancel, argumentName:  "onCancel", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.SendInvite(channelId:  channelId, customInviteContent:  customInviteContent, linkParams:  linkParams, onComplete:  onComplete, onCancel:  onCancel, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool RegisterInviteChannelPlugin(string channelId, GetSocialSdk.Core.InviteChannelPlugin inviteChannelPlugin)
        {
            Check.Argument.IsStrNotNullOrEmpty(argument:  channelId, argumentName:  "channelId", message:  0);
            Check.Argument.IsNotNull(argument:  inviteChannelPlugin, argumentName:  "inviteChannelPlugin", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            return GetSocialSdk.Core.GetSocial.GetSocialImpl.RegisterInviteChannelPlugin(channelId:  channelId, inviteChannelPlugin:  inviteChannelPlugin);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetReferralData(System.Action<GetSocialSdk.Core.ReferralData> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.GetReferralData(onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ClearReferralData()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.ClearReferralData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetReferredUsers(System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ReferredUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.GetReferredUsers(onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CreateInviteLink(GetSocialSdk.Core.LinkParams linkParams, System.Action<string> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onComplete", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.CreateInviteLink(linkParams:  linkParams, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void RegisterForPushNotifications()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.RegisterForPushNotifications();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void SetNotificationListener(GetSocialSdk.Core.NotificationListener listener)
        {
            string val_3 = 0;
            Check.Argument.IsNotNull(argument:  listener, argumentName:  "Notification Action Listener", message:  val_3 = 0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 20;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.SetNotificationListener(listener:  listener);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetGlobalFeedAnnouncements(System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ActivityPost>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.GetAnnouncements(feed:  "g-global", onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetAnnouncements(string feed, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ActivityPost>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsStrNotNullOrEmpty(argument:  feed, argumentName:  "feed", message:  0);
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.GetAnnouncements(feed:  feed, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetActivities(GetSocialSdk.Core.ActivitiesQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ActivityPost>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  query, argumentName:  "query", message:  0);
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.GetActivities(query:  query, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetActivity(string activityId, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.GetActivity(activityId:  activityId, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void PostActivityToGlobalFeed(GetSocialSdk.Core.ActivityPostContent content, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.PostActivityToFeed(feed:  "g-global", content:  content, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void PostActivityToFeed(string feed, GetSocialSdk.Core.ActivityPostContent content, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  content, argumentName:  "content", message:  0);
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.PostActivityToFeed(feed:  feed, content:  content, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void PostCommentToActivity(string activityId, GetSocialSdk.Core.ActivityPostContent comment, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  comment, argumentName:  "comment", message:  0);
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.PostCommentToActivity(activityId:  activityId, comment:  comment, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void LikeActivity(string activityId, bool isLiked, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_4 = 0;
            val_4 = val_4 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.LikeActivity(activityId:  activityId, isLiked:  isLiked, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetActivityLikers(string activityId, int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.GetActivityLikers(activityId:  activityId, offset:  offset, limit:  limit, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ReportActivity(string activityId, GetSocialSdk.Core.ReportingReason reportingReason, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.ReportActivity(activityId:  activityId, reportingReason:  reportingReason, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void DeleteActivity(string activityId, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.DeleteActivity(activityId:  activityId, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetUserById(string userId, System.Action<GetSocialSdk.Core.PublicUser> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.GetUserById(userId:  userId, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetUserByAuthIdentity(string providerId, string providerUserId, System.Action<GetSocialSdk.Core.PublicUser> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  providerId, argumentName:  "providerId", message:  0);
            Check.Argument.IsNotNull(argument:  providerUserId, argumentName:  "providerUserId", message:  0);
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.GetUserByAuthIdentity(providerId:  providerId, providerUserId:  providerUserId, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetUsersByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<System.Collections.Generic.Dictionary<string, GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  providerId, argumentName:  "providerId", message:  0);
            Check.Argument.IsNotNull(argument:  providerUserIds, argumentName:  "providerUserIds", message:  0);
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.GetUsersByAuthIdentities(providerId:  providerId, providerUserIds:  providerUserIds, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void FindUsers(GetSocialSdk.Core.UsersQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.UserReference>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            Check.Argument.IsNotNull(argument:  query, argumentName:  "query", message:  0);
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.FindUsers(query:  query, onSuccess:  onSuccess, onFailure:  onFailure);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void CreatePromoCode(GetSocialSdk.Core.PromoCodeBuilder promoCodeBuilder, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onError, argumentName:  "onError", message:  0);
            Check.Argument.IsNotNull(argument:  promoCodeBuilder, argumentName:  "promoCodeBuilder", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.CreatePromoCode(promoCodeBuilder:  promoCodeBuilder, onSuccess:  onSuccess, onError:  onError);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void GetPromoCode(string code, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onError, argumentName:  "onError", message:  0);
            Check.Argument.IsNotNull(argument:  code, argumentName:  "promoCode", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.GetPromoCode(code:  code, onSuccess:  onSuccess, onError:  onError);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ClaimPromoCode(string code, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
            Check.Argument.IsNotNull(argument:  onError, argumentName:  "onError", message:  0);
            Check.Argument.IsNotNull(argument:  code, argumentName:  "promoCode", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.ClaimPromoCode(code:  code, onSuccess:  onSuccess, onError:  onError);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool TrackPurchaseEvent(GetSocialSdk.Core.Analytics.PurchaseData purchaseData)
        {
            string val_3 = 0;
            Check.Argument.IsNotNull(argument:  purchaseData, argumentName:  "purchaseData", message:  val_3 = 0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 81;
            return GetSocialSdk.Core.GetSocial.GetSocialImpl.TrackPurchaseEvent(purchaseData:  purchaseData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static bool TrackCustomEvent(string eventName, System.Collections.Generic.Dictionary<string, string> eventProperties)
        {
            Check.Argument.IsNotNull(argument:  eventName, argumentName:  "eventName", message:  0);
            var val_3 = 0;
            val_3 = val_3 + 1;
            return GetSocialSdk.Core.GetSocial.GetSocialImpl.TrackCustomEvent(customEvent:  eventName, eventProperties:  eventProperties);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ProcessAction(GetSocialSdk.Core.GetSocialAction notificationAction)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            GetSocialSdk.Core.GetSocial.GetSocialImpl.ProcessAction(notificationAction:  notificationAction);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocial()
        {
            GetSocialSdk.Core.GetSocial._globalErrorListener = new System.Action<GetSocialSdk.Core.GetSocialError>(object:  0, method:  static System.Void GetSocialSdk.Core.GetSocial::OnGlobalError(GetSocialSdk.Core.GetSocialError error));
        }
    
    }

}
