using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class GetSocialNativeBridgeMock : IGetSocialNativeBridge
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string Mock = "mock";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocialSdk.Core.IGetSocialNativeBridge _instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly System.Collections.Generic.Dictionary<string, string> EmptyIdentities;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly GetSocialSdk.Core.InviteChannel[] EmptyChannels;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Language>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.GetSocialFactory.AvailableRuntimes[] RuntimeImplementation { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.IGetSocialNativeBridge Instance { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsInitialized { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Language { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.InviteChannel[] InviteChannels { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UserId { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsUserAnonymous { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> UserAuthIdentities { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> AllPublicProperties { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> AllPrivateProperties { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DisplayName { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AvatarUrl { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.GetSocialFactory.AvailableRuntimes[] get_RuntimeImplementation()
        {
            AvailableRuntimes[] val_1 = new AvailableRuntimes[1];
            val_1[0] = 6;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.IGetSocialNativeBridge get_Instance()
        {
            var val_2;
            GetSocialSdk.Core.IGetSocialNativeBridge val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = GetSocialSdk.Core.GetSocialNativeBridgeMock._instance;
            if(val_3 != null)
            {
                    return (GetSocialSdk.Core.IGetSocialNativeBridge)val_3;
            }
            
            GetSocialSdk.Core.GetSocialNativeBridgeMock val_1 = null;
            val_3 = val_1;
            val_1 = new GetSocialSdk.Core.GetSocialNativeBridgeMock();
            val_4 = null;
            val_4 = null;
            GetSocialSdk.Core.GetSocialNativeBridgeMock._instance = val_3;
            return (GetSocialSdk.Core.IGetSocialNativeBridge)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Init(string appId)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(appId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(appId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = appId;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::Init(string appId), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WhenInitialized(System.Action action)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(action != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(action == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = action;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::WhenInitialized(System.Action action), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsInitialized()
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetNativeSdkVersion()
        {
            return "Not available in Editor";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetLanguage()
        {
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.String GetSocialSdk.Core.GetSocialNativeBridgeMock::GetLanguage(), values:  System.Array.Empty<System.Object>());
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SetLanguage(string languageCode)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(languageCode != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(languageCode == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = languageCode;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Core.GetSocialNativeBridgeMock::SetLanguage(string languageCode), values:  val_1);
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Language()
        {
            return (string)this.<Language>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Language(string value)
        {
            this.<Language>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsInviteChannelAvailable(string channelId)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(channelId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(channelId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = channelId;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Core.GetSocialNativeBridgeMock::IsInviteChannelAvailable(string channelId), values:  val_1);
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.InviteChannel[] get_InviteChannels()
        {
            null = null;
            return (GetSocialSdk.Core.InviteChannel[])GetSocialSdk.Core.GetSocialNativeBridgeMock.EmptyChannels;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendInvite(string channelId, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(channelId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(channelId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = channelId;
            val_1[1] = onComplete;
            val_1[2] = onCancel;
            val_1[3] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SendInvite(string channelId, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendInvite(string channelId, GetSocialSdk.Core.InviteContent customInviteContent, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[5];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(channelId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(channelId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = channelId;
            val_1[1] = customInviteContent;
            val_1[2] = onComplete;
            val_1[3] = onCancel;
            val_1[4] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SendInvite(string channelId, GetSocialSdk.Core.InviteContent customInviteContent, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendInvite(string channelId, GetSocialSdk.Core.InviteContent customInviteContent, GetSocialSdk.Core.LinkParams linkParams, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[6];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(channelId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(channelId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = channelId;
            val_1[1] = customInviteContent;
            val_1[2] = linkParams;
            val_1[3] = onComplete;
            val_1[4] = onCancel;
            val_1[5] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SendInvite(string channelId, GetSocialSdk.Core.InviteContent customInviteContent, GetSocialSdk.Core.LinkParams linkParams, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RegisterInviteChannelPlugin(string channelId, GetSocialSdk.Core.InviteChannelPlugin inviteChannelPlugin)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(channelId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(channelId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = channelId;
            val_1[1] = inviteChannelPlugin;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Core.GetSocialNativeBridgeMock::RegisterInviteChannelPlugin(string channelId, GetSocialSdk.Core.InviteChannelPlugin inviteChannelPlugin), values:  val_1);
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetReferralData(System.Action<GetSocialSdk.Core.ReferralData> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(onSuccess != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(onSuccess == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = onSuccess;
            val_1[1] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetReferralData(System.Action<GetSocialSdk.Core.ReferralData> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearReferralData()
        {
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::ClearReferralData(), values:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetReferredUsers(System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ReferredUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(onSuccess != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(onSuccess == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = onSuccess;
            val_1[1] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetReferredUsers(System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ReferredUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateInviteLink(GetSocialSdk.Core.LinkParams linkParams, System.Action<string> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(onSuccess != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(onSuccess == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = onSuccess;
            val_1[1] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::CreateInviteLink(GetSocialSdk.Core.LinkParams linkParams, System.Action<string> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterForPushNotifications()
        {
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::RegisterForPushNotifications(), values:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetNotificationListener(GetSocialSdk.Core.NotificationListener listener)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(listener != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(listener == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = listener;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SetNotificationListener(GetSocialSdk.Core.NotificationListener listener), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetNotifications(GetSocialSdk.Core.NotificationsQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.Notification>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(query != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(query == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = query;
            val_1[1] = onSuccess;
            val_1[2] = onError;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetNotifications(GetSocialSdk.Core.NotificationsQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.Notification>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetNotificationsCount(GetSocialSdk.Core.NotificationsCountQuery query, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(query != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(query == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = query;
            val_1[1] = onSuccess;
            val_1[2] = onError;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetNotificationsCount(GetSocialSdk.Core.NotificationsCountQuery query, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetNotificationsStatus(System.Collections.Generic.List<string> notificationsIds, string status, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(notificationsIds != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(notificationsIds == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = notificationsIds;
            val_1[1] = status;
            val_1[2] = onSuccess;
            val_1[3] = onError;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SetNotificationsStatus(System.Collections.Generic.List<string> notificationsIds, string status, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetPushNotificationsEnabled(bool isEnabled, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            bool val_1 = isEnabled;
            object[] val_2 = new object[3];
            if(val_2 == null)
            {
                goto label_2;
            }
            
            if(val_1 == true)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_1 == false)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_2[0] = val_1;
            val_2[1] = onSuccess;
            val_2[2] = onError;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SetPushNotificationsEnabled(bool isEnabled, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError), values:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void IsPushNotificationsEnabled(System.Action<bool> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(onSuccess != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(onSuccess == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = onSuccess;
            val_1[1] = onError;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::IsPushNotificationsEnabled(System.Action<bool> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendNotification(System.Collections.Generic.List<string> userIds, GetSocialSdk.Core.NotificationContent content, System.Action<GetSocialSdk.Core.NotificationsSummary> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(userIds != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(userIds == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = userIds;
            val_1[1] = content;
            val_1[2] = onSuccess;
            val_1[3] = onError;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SendNotification(System.Collections.Generic.List<string> userIds, GetSocialSdk.Core.NotificationContent content, System.Action<GetSocialSdk.Core.NotificationsSummary> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SetOnUserChangedListener(System.Action listener)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(listener != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(listener == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = listener;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Core.GetSocialNativeBridgeMock::SetOnUserChangedListener(System.Action listener), values:  val_1);
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RemoveOnUserChangedListener()
        {
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Core.GetSocialNativeBridgeMock::RemoveOnUserChangedListener(), values:  System.Array.Empty<System.Object>());
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SetGlobalErrorListener(System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(onError != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(onError == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = onError;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Core.GetSocialNativeBridgeMock::SetGlobalErrorListener(System.Action<GetSocialSdk.Core.GetSocialError> onError), values:  val_1);
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RemoveGlobalErrorListener()
        {
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Core.GetSocialNativeBridgeMock::RemoveGlobalErrorListener(), values:  System.Array.Empty<System.Object>());
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_UserId()
        {
            return (string)System.String.alignConst;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsUserAnonymous()
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetUser(System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(onSuccess != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(onSuccess == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = onSuccess;
            val_1[1] = onError;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::ResetUser(System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError), values:  val_1);
            onSuccess.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> get_UserAuthIdentities()
        {
            null = null;
            return (System.Collections.Generic.Dictionary<System.String, System.String>)GetSocialSdk.Core.GetSocialNativeBridgeMock.EmptyIdentities;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> get_AllPublicProperties()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> get_AllPrivateProperties()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_DisplayName()
        {
            return "";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetDisplayName(string displayName, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(displayName != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(displayName == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = displayName;
            val_1[1] = onComplete;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SetDisplayName(string displayName, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_AvatarUrl()
        {
            return "";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAvatarUrl(string avatarUrl, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(avatarUrl != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(avatarUrl == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = avatarUrl;
            val_1[1] = onComplete;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SetAvatarUrl(string avatarUrl, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAvatar(UnityEngine.Texture2D avatar, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(avatar != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(avatar == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = avatar;
            val_1[1] = onComplete;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SetAvatar(UnityEngine.Texture2D avatar, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetPublicProperty(string key, string value, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(key != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(key == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = key;
            val_1[1] = value;
            val_1[2] = onSuccess;
            val_1[3] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SetPublicProperty(string key, string value, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetPrivateProperty(string key, string value, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(key != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(key == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = key;
            val_1[1] = value;
            val_1[2] = onSuccess;
            val_1[3] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SetPrivateProperty(string key, string value, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetUserDetails(GetSocialSdk.Core.UserUpdate userUpdate, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(userUpdate != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(userUpdate == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = userUpdate;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SetUserDetails(GetSocialSdk.Core.UserUpdate userUpdate, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemovePublicProperty(string key, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(key != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(key == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = key;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::RemovePublicProperty(string key, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemovePrivateProperty(string key, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(key != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(key == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = key;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::RemovePrivateProperty(string key, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetPublicProperty(string key)
        {
            return "";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetPrivateProperty(string key)
        {
            return "";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasPublicProperty(string key)
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasPrivateProperty(string key)
        {
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddAuthIdentity(GetSocialSdk.Core.AuthIdentity authIdentity, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure, System.Action<GetSocialSdk.Core.ConflictUser> onConflict)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(authIdentity != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(authIdentity == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = authIdentity;
            val_1[1] = onComplete;
            val_1[2] = onFailure;
            val_1[3] = onConflict;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::AddAuthIdentity(GetSocialSdk.Core.AuthIdentity authIdentity, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure, System.Action<GetSocialSdk.Core.ConflictUser> onConflict), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetUserById(string userId, System.Action<GetSocialSdk.Core.PublicUser> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(userId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(userId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = userId;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetUserById(string userId, System.Action<GetSocialSdk.Core.PublicUser> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetUserByAuthIdentity(string providerId, string providerUserId, System.Action<GetSocialSdk.Core.PublicUser> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(providerId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(providerId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = providerId;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetUserByAuthIdentity(string providerId, string providerUserId, System.Action<GetSocialSdk.Core.PublicUser> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetUsersByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<System.Collections.Generic.Dictionary<string, GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(providerId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(providerId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = providerId;
            val_1[1] = providerUserIds;
            val_1[2] = onSuccess;
            val_1[3] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetUsersByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<System.Collections.Generic.Dictionary<string, GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FindUsers(GetSocialSdk.Core.UsersQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.UserReference>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(query != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(query == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = query;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::FindUsers(GetSocialSdk.Core.UsersQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.UserReference>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveAuthIdentity(string providerId, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(providerId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(providerId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = providerId;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::RemoveAuthIdentity(string providerId, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SwitchUser(GetSocialSdk.Core.AuthIdentity authIdentity, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(authIdentity != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(authIdentity == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = authIdentity;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SwitchUser(GetSocialSdk.Core.AuthIdentity authIdentity, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddFriend(string userId, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(userId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(userId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = userId;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::AddFriend(string userId, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(providerId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(providerId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = providerId;
            val_1[1] = providerUserIds;
            val_1[2] = onSuccess;
            val_1[3] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::AddFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveFriend(string userId, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(userId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(userId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = userId;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::RemoveFriend(string userId, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(providerId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(providerId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = providerId;
            val_1[1] = providerUserIds;
            val_1[2] = onSuccess;
            val_1[3] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::RemoveFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFriends(System.Collections.Generic.List<string> userIds, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(userIds != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(userIds == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = userIds;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SetFriends(System.Collections.Generic.List<string> userIds, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(providerId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(providerId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = providerId;
            val_1[1] = providerUserIds;
            val_1[2] = onSuccess;
            val_1[3] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::SetFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void IsFriend(string userId, System.Action<bool> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(userId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(userId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = userId;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::IsFriend(string userId, System.Action<bool> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetFriendsCount(System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(onSuccess != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(onSuccess == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = onSuccess;
            val_1[1] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetFriendsCount(System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetFriends(int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(offset != 0)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(offset == 0)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = offset;
            val_1[1] = limit;
            val_1[2] = onSuccess;
            val_1[3] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetFriends(int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetSuggestedFriends(int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.SuggestedFriend>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(offset != 0)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(offset == 0)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = offset;
            val_1[1] = limit;
            val_1[2] = onSuccess;
            val_1[3] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetSuggestedFriends(int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.SuggestedFriend>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetFriendsReferences(System.Action<System.Collections.Generic.List<GetSocialSdk.Core.UserReference>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(onSuccess != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(onSuccess == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = onSuccess;
            val_1[1] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetFriendsReferences(System.Action<System.Collections.Generic.List<GetSocialSdk.Core.UserReference>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetAnnouncements(string feed, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ActivityPost>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(feed != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(feed == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = feed;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetAnnouncements(string feed, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ActivityPost>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetActivities(GetSocialSdk.Core.ActivitiesQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ActivityPost>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(query != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(query == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = query;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetActivities(GetSocialSdk.Core.ActivitiesQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ActivityPost>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetActivity(string activityId, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(activityId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(activityId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = activityId;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetActivity(string activityId, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PostActivityToFeed(string feed, GetSocialSdk.Core.ActivityPostContent content, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(content != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(content == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = content;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::PostActivityToFeed(string feed, GetSocialSdk.Core.ActivityPostContent content, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PostCommentToActivity(string activityId, GetSocialSdk.Core.ActivityPostContent comment, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(activityId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(activityId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = activityId;
            val_1[1] = comment;
            val_1[2] = onSuccess;
            val_1[3] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::PostCommentToActivity(string activityId, GetSocialSdk.Core.ActivityPostContent comment, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LikeActivity(string activityId, bool isLiked, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[4];
            val_1[0] = activityId;
            val_1[1] = isLiked;
            val_1[2] = onSuccess;
            val_1[3] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::LikeActivity(string activityId, bool isLiked, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetActivityLikers(string activityId, int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(offset != 0)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(offset == 0)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = offset;
            val_1[1] = limit;
            val_1[2] = onSuccess;
            val_1[3] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetActivityLikers(string activityId, int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReportActivity(string activityId, GetSocialSdk.Core.ReportingReason reportingReason, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(activityId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(activityId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = activityId;
            val_1[1] = reportingReason;
            val_1[2] = onSuccess;
            val_1[3] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::ReportActivity(string activityId, GetSocialSdk.Core.ReportingReason reportingReason, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeleteActivity(string activityId, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(activityId != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(activityId == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = activityId;
            val_1[1] = onSuccess;
            val_1[2] = onFailure;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::DeleteActivity(string activityId, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::Reset(), values:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TrackPurchaseEvent(GetSocialSdk.Core.Analytics.PurchaseData purchaseData)
        {
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Core.GetSocialNativeBridgeMock::TrackPurchaseEvent(GetSocialSdk.Core.Analytics.PurchaseData purchaseData), values:  System.Array.Empty<System.Object>());
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TrackCustomEvent(string customEvent, System.Collections.Generic.Dictionary<string, string> eventProperties)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(customEvent != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(customEvent == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = customEvent;
            val_1[1] = eventProperties;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Boolean GetSocialSdk.Core.GetSocialNativeBridgeMock::TrackCustomEvent(string customEvent, System.Collections.Generic.Dictionary<string, string> eventProperties), values:  val_1);
            return false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ProcessAction(GetSocialSdk.Core.GetSocialAction notificationAction)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(notificationAction != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(notificationAction == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = notificationAction;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::ProcessAction(GetSocialSdk.Core.GetSocialAction notificationAction), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleOnStartUnityEvent()
        {
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::HandleOnStartUnityEvent(), values:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreatePromoCode(GetSocialSdk.Core.PromoCodeBuilder promoCodeBuilder, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(promoCodeBuilder != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(promoCodeBuilder == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = promoCodeBuilder;
            val_1[1] = onSuccess;
            val_1[2] = onError;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::CreatePromoCode(GetSocialSdk.Core.PromoCodeBuilder promoCodeBuilder, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetPromoCode(string code, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(code != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(code == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = code;
            val_1[1] = onSuccess;
            val_1[2] = onError;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::GetPromoCode(string code, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClaimPromoCode(string code, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(code != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(code == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = code;
            val_1[1] = onSuccess;
            val_1[2] = onError;
            GetSocialSdk.Core.DebugUtils.LogMethodCall(method:  public System.Void GetSocialSdk.Core.GetSocialNativeBridgeMock::ClaimPromoCode(string code, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError), values:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialNativeBridgeMock()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocialNativeBridgeMock()
        {
            GetSocialSdk.Core.GetSocialNativeBridgeMock.EmptyIdentities = new System.Collections.Generic.Dictionary<System.String, System.String>();
            GetSocialSdk.Core.GetSocialNativeBridgeMock.EmptyChannels = new GetSocialSdk.Core.InviteChannel[0];
        }
    
    }

}
