using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class GetSocialNativeBridgeAndroid : IGetSocialNativeBridge
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string GetSocialClassSignature = "im.getsocial.sdk.GetSocial";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string GetSocialUserClassSignature = "im.getsocial.sdk.GetSocial$User";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string AndroidAccessHelperClass = "im.getsocial.sdk.GetSocialAccessHelper";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static GetSocialSdk.Core.IGetSocialNativeBridge _instance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly UnityEngine.AndroidJavaClass _getSocial;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly UnityEngine.AndroidJavaClass _user;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.GetSocialFactory.AvailableRuntimes[] RuntimeImplementation { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsInitialized { get; }
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
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialNativeBridgeAndroid()
        {
            this._getSocial = new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.GetSocial");
            this._user = new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.GetSocial$User");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Init(string appId)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(appId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(appId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = appId;
            this._getSocial.CallStatic(methodName:  "init", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void WhenInitialized(System.Action action)
        {
            object[] val_1 = new object[1];
            GetSocialSdk.Core.RunnableProxy val_2 = new GetSocialSdk.Core.RunnableProxy(runnable:  action);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            this._getSocial.CallStatic(methodName:  "whenInitialized", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsInitialized()
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._getSocial, methodName:  "isInitialized", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetNativeSdkVersion()
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticStr(ajo:  this._getSocial, methodName:  "getSdkVersion", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetLanguage()
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticStr(ajo:  this._getSocial, methodName:  "getLanguage", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SetLanguage(string languageCode)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(languageCode != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(languageCode == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = languageCode;
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._getSocial, methodName:  "setLanguage", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsInviteChannelAvailable(string channelId)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(channelId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(channelId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = channelId;
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._getSocial, methodName:  "isInviteChannelAvailable", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.InviteChannel[] get_InviteChannels()
        {
            var val_6;
            System.Collections.Generic.List<UnityEngine.AndroidJavaObject> val_3 = GetSocialSdk.Core.JniUtils.FromJavaList(javaList:  GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  this._getSocial, methodName:  "getInviteChannels", args:  System.Array.Empty<System.Object>()));
            val_6 = null;
            val_6 = null;
            if((GetSocialNativeBridgeAndroid.<>c.<>9__18_0) == null)
            {
                goto label_3;
            }
            
            label_9:
            System.Collections.Generic.List<TOutput> val_4 = val_3.ConvertAll<GetSocialSdk.Core.InviteChannel>(converter:  GetSocialNativeBridgeAndroid.<>c.<>9__18_0);
            if(val_4 != null)
            {
                    return val_4.ToArray();
            }
            
            return val_4.ToArray();
            label_3:
            GetSocialNativeBridgeAndroid.<>c.<>9__18_0 = new System.Converter<UnityEngine.AndroidJavaObject, GetSocialSdk.Core.InviteChannel>(object:  GetSocialNativeBridgeAndroid.<>c.__il2cppRuntimeField_static_fields, method:  GetSocialSdk.Core.InviteChannel GetSocialNativeBridgeAndroid.<>c::<get_InviteChannels>b__18_0(UnityEngine.AndroidJavaObject ajo));
            if(val_3 != null)
            {
                goto label_9;
            }
            
            goto label_9;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendInvite(string channelId, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(channelId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(channelId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = channelId;
            val_1[1] = new GetSocialSdk.Core.InviteCallbackProxy(onComplete:  onComplete, onCancel:  onCancel, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "sendInvite", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendInvite(string channelId, GetSocialSdk.Core.InviteContent customInviteContent, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object val_4;
            if(customInviteContent != null)
            {
                    val_4 = customInviteContent.ToAjo();
            }
            else
            {
                    val_4 = 0;
            }
            
            object[] val_2 = new object[3];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(channelId != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(channelId == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = channelId;
            val_2[1] = val_4;
            val_2[2] = new GetSocialSdk.Core.InviteCallbackProxy(onComplete:  onComplete, onCancel:  onCancel, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "sendInvite", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendInvite(string channelId, GetSocialSdk.Core.InviteContent customInviteContent, GetSocialSdk.Core.LinkParams linkParams, System.Action onComplete, System.Action onCancel, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object val_5;
            object val_6;
            if(customInviteContent == null)
            {
                goto label_1;
            }
            
            val_5 = customInviteContent.ToAjo();
            if(linkParams == null)
            {
                goto label_2;
            }
            
            label_4:
            val_6 = linkParams.ToAjo();
            goto label_3;
            label_1:
            val_5 = 0;
            if(linkParams != null)
            {
                goto label_4;
            }
            
            label_2:
            val_6 = 0;
            label_3:
            object[] val_3 = new object[4];
            if(val_3 == null)
            {
                goto label_5;
            }
            
            if(channelId != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(channelId == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_3[0] = channelId;
            val_3[1] = val_5;
            val_3[2] = val_6;
            val_3[3] = new GetSocialSdk.Core.InviteCallbackProxy(onComplete:  onComplete, onCancel:  onCancel, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "sendInvite", args:  val_3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RegisterInviteChannelPlugin(string channelId, GetSocialSdk.Core.InviteChannelPlugin inviteChannelPlugin)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(channelId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(channelId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = channelId;
            val_1[1] = GetSocialSdk.Core.GetSocialNativeBridgeAndroid.CreateAdapter(plugin:  inviteChannelPlugin);
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._getSocial, methodName:  "registerInviteChannelPlugin", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetReferralData(System.Action<GetSocialSdk.Core.ReferralData> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[1];
            GetSocialSdk.Core.FetchReferralDataCallbackProxy val_2 = new GetSocialSdk.Core.FetchReferralDataCallbackProxy(onSuccess:  onSuccess, onFailure:  onFailure);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            this._getSocial.CallStatic(methodName:  "getReferralData", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClearReferralData()
        {
            this._getSocial.CallStatic(methodName:  "clearReferralData", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetReferredUsers(System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ReferredUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[1];
            GetSocialSdk.Core.ListCallbackProxy<GetSocialSdk.Core.ReferredUser> val_2 = new GetSocialSdk.Core.ListCallbackProxy<GetSocialSdk.Core.ReferredUser>(onSuccess:  onSuccess, onFailure:  onFailure);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            this._getSocial.CallStatic(methodName:  "getReferredUsers", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreateInviteLink(GetSocialSdk.Core.LinkParams linkParams, System.Action<string> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object val_4;
            if(linkParams != null)
            {
                    val_4 = linkParams.ToAjo();
            }
            else
            {
                    val_4 = 0;
            }
            
            object[] val_2 = new object[2];
            if(val_2 == null)
            {
                goto label_3;
            }
            
            if(val_4 != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_4 == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_2[0] = val_4;
            val_2[1] = new GetSocialSdk.Core.StringCallbackProxy(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "createInviteLink", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterForPushNotifications()
        {
            this._getSocial.CallStatic(methodName:  "registerForPushNotifications", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetNotificationListener(GetSocialSdk.Core.NotificationListener listener)
        {
            object[] val_1 = new object[1];
            GetSocialSdk.Core.NotificationListenerProxy val_2 = new GetSocialSdk.Core.NotificationListenerProxy(listener:  listener);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            this._getSocial.CallStatic(methodName:  "setNotificationListener", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetNotifications(GetSocialSdk.Core.NotificationsQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.Notification>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = query.ToAjo();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            val_1[1] = new GetSocialSdk.Core.ListCallbackProxy<GetSocialSdk.Core.Notification>(onSuccess:  onSuccess, onFailure:  onError);
            this._user.CallStatic(methodName:  "getNotifications", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetNotificationsCount(GetSocialSdk.Core.NotificationsCountQuery query, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = query.ToAjo();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            val_1[1] = new GetSocialSdk.Core.IntCallbackProxy(onSuccess:  onSuccess, onFailure:  onError);
            this._user.CallStatic(methodName:  "getNotificationsCount", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetNotificationsStatus(System.Collections.Generic.List<string> notificationsIds, string status, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[3];
            UnityEngine.AndroidJavaObject val_2 = GetSocialSdk.Core.JniUtils.ToJavaList<System.String>(list:  notificationsIds);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = status;
            val_1[2] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onSuccess, onFailure:  onError);
            this._user.CallStatic(methodName:  "setNotificationsStatus", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetPushNotificationsEnabled(bool isEnabled, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            bool val_1 = isEnabled;
            object[] val_2 = new object[2];
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if(val_1 == true)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_1 == false)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = val_1;
            val_2[1] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onSuccess, onFailure:  onError);
            this._user.CallStatic(methodName:  "setPushNotificationsEnabled", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void IsPushNotificationsEnabled(System.Action<bool> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[1];
            GetSocialSdk.Core.BoolCallbackProxy val_2 = new GetSocialSdk.Core.BoolCallbackProxy(onSuccess:  onSuccess, onFailure:  onError);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            this._user.CallStatic(methodName:  "isPushNotificationsEnabled", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SendNotification(System.Collections.Generic.List<string> userIds, GetSocialSdk.Core.NotificationContent content, System.Action<GetSocialSdk.Core.NotificationsSummary> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[3];
            UnityEngine.AndroidJavaObject val_2 = GetSocialSdk.Core.JniUtils.ToJavaList<System.String>(list:  userIds);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = content.ToAjo();
            val_1[2] = new GetSocialSdk.Core.CallbackProxy<GetSocialSdk.Core.NotificationsSummary>(onSuccess:  onSuccess, onFailure:  onError);
            this._user.CallStatic(methodName:  "sendNotification", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SetGlobalErrorListener(System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[1];
            GetSocialSdk.Core.GlobalErrorListenerProxy val_2 = new GetSocialSdk.Core.GlobalErrorListenerProxy(onError:  onError);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._getSocial, methodName:  "setGlobalErrorListener", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RemoveGlobalErrorListener()
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._getSocial, methodName:  "removeGlobalErrorListener", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_UserId()
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticStr(ajo:  this._user, methodName:  "getId", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsUserAnonymous()
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._user, methodName:  "isAnonymous", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetUser(System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[1];
            GetSocialSdk.Core.CompletionCallback val_2 = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onSuccess, onFailure:  onError);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            this._user.CallStatic(methodName:  "reset", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> get_UserAuthIdentities()
        {
            return GetSocialSdk.Core.JniUtils.FromJavaHashMap(javaHashMap:  GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  this._user, methodName:  "getAuthIdentities", args:  System.Array.Empty<System.Object>()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> get_AllPublicProperties()
        {
            return GetSocialSdk.Core.JniUtils.FromJavaHashMap(javaHashMap:  GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  this._user, methodName:  "getAllPublicProperties", args:  System.Array.Empty<System.Object>()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> get_AllPrivateProperties()
        {
            return GetSocialSdk.Core.JniUtils.FromJavaHashMap(javaHashMap:  GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  this._user, methodName:  "getAllPrivateProperties", args:  System.Array.Empty<System.Object>()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_DisplayName()
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticStr(ajo:  this._user, methodName:  "getDisplayName", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetDisplayName(string displayName, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(displayName != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(displayName == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = displayName;
            val_1[1] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onComplete, onFailure:  onFailure);
            this._user.CallStatic(methodName:  "setDisplayName", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_AvatarUrl()
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticStr(ajo:  this._user, methodName:  "getAvatarUrl", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAvatarUrl(string avatarUrl, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(avatarUrl != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(avatarUrl == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = avatarUrl;
            val_1[1] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onComplete, onFailure:  onFailure);
            GetSocialSdk.Core.JniExtensionMethods.CallStaticSafe(ajo:  this._user, methodName:  "setAvatarUrl", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetAvatar(UnityEngine.Texture2D avatar, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = GetSocialSdk.Core.JniUtils.ToAjoBitmap(texture2D:  avatar);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onComplete, onFailure:  onFailure);
            this._user.CallStatic(methodName:  "setAvatar", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetPublicProperty(string key, string value, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            val_1[1] = value;
            val_1[2] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onSuccess, onFailure:  onFailure);
            GetSocialSdk.Core.JniExtensionMethods.CallStaticSafe(ajo:  this._user, methodName:  "setPublicProperty", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetPrivateProperty(string key, string value, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            val_1[1] = value;
            val_1[2] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onSuccess, onFailure:  onFailure);
            GetSocialSdk.Core.JniExtensionMethods.CallStaticSafe(ajo:  this._user, methodName:  "setPrivateProperty", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetUserDetails(GetSocialSdk.Core.UserUpdate userUpdate, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = userUpdate.ToAjo();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            val_1[1] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onSuccess, onFailure:  onFailure);
            GetSocialSdk.Core.JniExtensionMethods.CallStaticSafe(ajo:  this._user, methodName:  "setUserDetails", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemovePublicProperty(string key, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            val_1[1] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onSuccess, onFailure:  onFailure);
            GetSocialSdk.Core.JniExtensionMethods.CallStaticSafe(ajo:  this._user, methodName:  "removePublicProperty", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemovePrivateProperty(string key, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            val_1[1] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onSuccess, onFailure:  onFailure);
            GetSocialSdk.Core.JniExtensionMethods.CallStaticSafe(ajo:  this._user, methodName:  "removePrivateProperty", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetPublicProperty(string key)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticStr(ajo:  this._user, methodName:  "getPublicProperty", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetPrivateProperty(string key)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticStr(ajo:  this._user, methodName:  "getPrivateProperty", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasPublicProperty(string key)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._user, methodName:  "hasPublicProperty", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasPrivateProperty(string key)
        {
            object[] val_1 = new object[1];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(key != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(key == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = key;
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._user, methodName:  "hasPrivateProperty", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddAuthIdentity(GetSocialSdk.Core.AuthIdentity identity, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure, System.Action<GetSocialSdk.Core.ConflictUser> onConflict)
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = identity.ToAjo();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            val_1[1] = new GetSocialSdk.Core.AddAuthIdentityCallbackProxy(onComplete:  onComplete, onFailure:  onFailure, onConflict:  onConflict);
            this._user.CallStatic(methodName:  "addAuthIdentity", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SwitchUser(GetSocialSdk.Core.AuthIdentity identity, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = identity.ToAjo();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            val_1[1] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onSuccess, onFailure:  onFailure);
            this._user.CallStatic(methodName:  "switchUser", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveAuthIdentity(string providerId, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(providerId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(providerId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = providerId;
            val_1[1] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onSuccess, onFailure:  onFailure);
            this._user.CallStatic(methodName:  "removeAuthIdentity", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool SetOnUserChangedListener(System.Action onUserChanged)
        {
            object[] val_1 = new object[1];
            GetSocialSdk.Core.OnUserChangedListenerProxy val_2 = new GetSocialSdk.Core.OnUserChangedListenerProxy(onUserChanged:  onUserChanged);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._user, methodName:  "setOnUserChangedListener", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool RemoveOnUserChangedListener()
        {
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._user, methodName:  "removeOnUserChangedListener", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetUserById(string userId, System.Action<GetSocialSdk.Core.PublicUser> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(userId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(userId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = userId;
            val_1[1] = new GetSocialSdk.Core.CallbackProxy<GetSocialSdk.Core.PublicUser>(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "getUserById", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetUserByAuthIdentity(string providerId, string providerUserId, System.Action<GetSocialSdk.Core.PublicUser> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(providerId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(providerId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = providerId;
            val_1[1] = providerUserId;
            val_1[2] = new GetSocialSdk.Core.CallbackProxy<GetSocialSdk.Core.PublicUser>(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "getUserByAuthIdentity", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetUsersByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<System.Collections.Generic.Dictionary<string, GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(providerId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(providerId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = providerId;
            val_1[1] = GetSocialSdk.Core.JniUtils.ToJavaList<System.String>(list:  providerUserIds);
            val_1[2] = new GetSocialSdk.Core.DictionaryCallbackProxy<GetSocialSdk.Core.PublicUser>(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "getUsersByAuthIdentities", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void FindUsers(GetSocialSdk.Core.UsersQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.UserReference>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = query.ToAjo();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            val_1[1] = new GetSocialSdk.Core.ListCallbackProxy<GetSocialSdk.Core.UserReference>(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "findUsers", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddFriend(string userId, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(userId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(userId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = userId;
            val_1[1] = new GetSocialSdk.Core.IntCallbackProxy(onSuccess:  onSuccess, onFailure:  onFailure);
            this._user.CallStatic(methodName:  "addFriend", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(providerId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(providerId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = providerId;
            val_1[1] = GetSocialSdk.Core.JniUtils.ToJavaList<System.String>(list:  providerUserIds);
            val_1[2] = new GetSocialSdk.Core.IntCallbackProxy(onSuccess:  onSuccess, onFailure:  onFailure);
            this._user.CallStatic(methodName:  "addFriendsByAuthIdentities", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveFriend(string userId, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(userId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(userId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = userId;
            val_1[1] = new GetSocialSdk.Core.IntCallbackProxy(onSuccess:  onSuccess, onFailure:  onFailure);
            this._user.CallStatic(methodName:  "removeFriend", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RemoveFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(providerId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(providerId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = providerId;
            val_1[1] = GetSocialSdk.Core.JniUtils.ToJavaList<System.String>(list:  providerUserIds);
            val_1[2] = new GetSocialSdk.Core.IntCallbackProxy(onSuccess:  onSuccess, onFailure:  onFailure);
            this._user.CallStatic(methodName:  "removeFriendsByAuthIdentities", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFriends(System.Collections.Generic.List<string> userIds, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(userIds != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(userIds == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = userIds;
            val_1[1] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "setFriends", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(providerId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(providerId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = providerId;
            val_1[1] = GetSocialSdk.Core.JniUtils.ToJavaList<System.String>(list:  providerUserIds);
            val_1[2] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "setFriendsByAuthIdentities", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void IsFriend(string userId, System.Action<bool> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(userId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(userId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = userId;
            val_1[1] = new GetSocialSdk.Core.BoolCallbackProxy(onSuccess:  onSuccess, onFailure:  onFailure);
            this._user.CallStatic(methodName:  "isFriend", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetFriendsCount(System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[1];
            GetSocialSdk.Core.IntCallbackProxy val_2 = new GetSocialSdk.Core.IntCallbackProxy(onSuccess:  onSuccess, onFailure:  onFailure);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            this._user.CallStatic(methodName:  "getFriendsCount", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetFriends(int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(offset != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(offset == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = offset;
            val_1[1] = limit;
            val_1[2] = new GetSocialSdk.Core.ListCallbackProxy<GetSocialSdk.Core.PublicUser>(onSuccess:  onSuccess, onFailure:  onFailure);
            this._user.CallStatic(methodName:  "getFriends", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetSuggestedFriends(int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.SuggestedFriend>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(offset != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(offset == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = offset;
            val_1[1] = limit;
            val_1[2] = new GetSocialSdk.Core.ListCallbackProxy<GetSocialSdk.Core.SuggestedFriend>(onSuccess:  onSuccess, onFailure:  onFailure);
            this._user.CallStatic(methodName:  "getSuggestedFriends", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetFriendsReferences(System.Action<System.Collections.Generic.List<GetSocialSdk.Core.UserReference>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[1];
            GetSocialSdk.Core.ListCallbackProxy<GetSocialSdk.Core.UserReference> val_2 = new GetSocialSdk.Core.ListCallbackProxy<GetSocialSdk.Core.UserReference>(onSuccess:  onSuccess, onFailure:  onFailure);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            this._user.CallStatic(methodName:  "getFriendsReferences", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetAnnouncements(string feed, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ActivityPost>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(feed != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(feed == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = feed;
            val_1[1] = new GetSocialSdk.Core.ListCallbackProxy<GetSocialSdk.Core.ActivityPost>(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "getAnnouncements", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetActivities(GetSocialSdk.Core.ActivitiesQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.ActivityPost>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = query.ToAjo();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            val_1[1] = new GetSocialSdk.Core.ListCallbackProxy<GetSocialSdk.Core.ActivityPost>(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "getActivities", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetActivity(string activityId, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(activityId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(activityId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = activityId;
            val_1[1] = new GetSocialSdk.Core.CallbackProxy<GetSocialSdk.Core.ActivityPost>(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "getActivity", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PostActivityToFeed(string feed, GetSocialSdk.Core.ActivityPostContent content, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(feed != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(feed == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = feed;
            val_1[1] = content.ToAjo();
            val_1[2] = new GetSocialSdk.Core.CallbackProxy<GetSocialSdk.Core.ActivityPost>(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "postActivityToFeed", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PostCommentToActivity(string activityId, GetSocialSdk.Core.ActivityPostContent comment, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(activityId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(activityId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = activityId;
            val_1[1] = comment.ToAjo();
            val_1[2] = new GetSocialSdk.Core.CallbackProxy<GetSocialSdk.Core.ActivityPost>(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "postCommentToActivity", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LikeActivity(string activityId, bool isLiked, System.Action<GetSocialSdk.Core.ActivityPost> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            val_1[0] = activityId;
            val_1[1] = isLiked;
            val_1[2] = new GetSocialSdk.Core.CallbackProxy<GetSocialSdk.Core.ActivityPost>(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "likeActivity", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetActivityLikers(string activityId, int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(activityId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(activityId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = activityId;
            val_1[1] = offset;
            val_1[2] = limit;
            val_1[3] = new GetSocialSdk.Core.ListCallbackProxy<GetSocialSdk.Core.PublicUser>(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "getActivityLikers", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReportActivity(string activityId, GetSocialSdk.Core.ReportingReason reportingReason, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[3];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(activityId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(activityId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = activityId;
            val_1[1] = GetSocialSdk.Core.EnumConversion.ToAndroidJavaObject(reportingReason:  reportingReason);
            val_1[2] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "reportActivity", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void DeleteActivity(string activityId, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(activityId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(activityId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = activityId;
            val_1[1] = new GetSocialSdk.Core.CompletionCallback(onSuccess:  onSuccess, onFailure:  onFailure);
            this._getSocial.CallStatic(methodName:  "deleteActivity", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CreatePromoCode(GetSocialSdk.Core.PromoCodeBuilder promoCodeBuilder, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[2];
            UnityEngine.AndroidJavaObject val_2 = promoCodeBuilder.ToAjo();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            val_1[1] = new GetSocialSdk.Core.CallbackProxy<GetSocialSdk.Core.PromoCode>(onSuccess:  onSuccess, onFailure:  onError);
            this._getSocial.CallStatic(methodName:  "createPromoCode", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetPromoCode(string code, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(code != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(code == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = code;
            val_1[1] = new GetSocialSdk.Core.CallbackProxy<GetSocialSdk.Core.PromoCode>(onSuccess:  onSuccess, onFailure:  onError);
            this._getSocial.CallStatic(methodName:  "getPromoCode", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ClaimPromoCode(string code, System.Action<GetSocialSdk.Core.PromoCode> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(code != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(code == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = code;
            val_1[1] = new GetSocialSdk.Core.CallbackProxy<GetSocialSdk.Core.PromoCode>(onSuccess:  onSuccess, onFailure:  onError);
            this._getSocial.CallStatic(methodName:  "claimPromoCode", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TrackPurchaseEvent(GetSocialSdk.Core.Analytics.PurchaseData purchaseData)
        {
            object[] val_1 = new object[1];
            UnityEngine.AndroidJavaObject val_2 = purchaseData.ToAjo();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._getSocial, methodName:  "trackPurchaseEvent", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool TrackCustomEvent(string customEvent, System.Collections.Generic.Dictionary<string, string> eventProperties)
        {
            object[] val_1 = new object[2];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(customEvent != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(customEvent == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = customEvent;
            val_1[1] = GetSocialSdk.Core.JniUtils.ToJavaHashMap<System.String, System.String>(dictionary:  eventProperties);
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticBool(ajo:  this._getSocial, methodName:  "trackCustomEvent", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleOnStartUnityEvent()
        {
            this._getSocial.CallStatic(methodName:  "handleOnStartUnityEvent", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UnityEngine.AndroidJavaObject CreateAdapter(GetSocialSdk.Core.InviteChannelPlugin plugin)
        {
            System.Object[] val_4;
            var val_5;
            if(plugin != null)
            {
                    object[] val_1 = new object[1];
                val_4 = val_1;
                val_4[0] = new GetSocialSdk.Core.InviteChannelPluginProxy(invitePlugin:  plugin);
                UnityEngine.AndroidJavaObject val_3 = null;
                val_5 = val_3;
                val_3 = new UnityEngine.AndroidJavaObject(className:  "im.getsocial.sdk.internal.unity.InviteChannelPluginAdapter", args:  val_1);
                return (UnityEngine.AndroidJavaObject)val_5;
            }
            
            val_5 = 0;
            return (UnityEngine.AndroidJavaObject)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            new UnityEngine.AndroidJavaClass() = new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.GetSocialAccessHelper");
            object[] val_3 = new object[1];
            val_3[0] = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  GetSocialSdk.Core.JniUtils.Activity, methodName:  "getApplication", args:  System.Array.Empty<System.Object>());
            new UnityEngine.AndroidJavaClass().CallStatic(methodName:  "reset", args:  val_3);
            if(new UnityEngine.AndroidJavaClass() != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                new UnityEngine.AndroidJavaClass().Dispose();
            }
            
            if(65 == 65)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ProcessAction(GetSocialSdk.Core.GetSocialAction notificationAction)
        {
            object[] val_1 = new object[1];
            UnityEngine.AndroidJavaObject val_2 = notificationAction.ToAjo();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            if(val_2 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_2 == null)
            {
                goto label_6;
            }
            
            label_3:
            label_6:
            val_1[0] = val_2;
            this._getSocial.CallStatic(methodName:  "processAction", args:  val_1);
        }
    
    }

}
