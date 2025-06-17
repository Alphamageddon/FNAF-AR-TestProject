using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class GetSocial.User
{
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string Id { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool IsAnonymous { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.Dictionary<string, string> AuthIdentities { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string DisplayName { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string AvatarUrl { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.Dictionary<string, string> AllPublicProperties { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.Dictionary<string, string> AllPrivateProperties { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string get_Id()
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        return GetSocialSdk.Core.GetSocial.GetSocialImpl.UserId;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool get_IsAnonymous()
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        return GetSocialSdk.Core.GetSocial.GetSocialImpl.IsUserAnonymous;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.Dictionary<string, string> get_AuthIdentities()
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        return GetSocialSdk.Core.GetSocial.GetSocialImpl.UserAuthIdentities;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string get_DisplayName()
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        return GetSocialSdk.Core.GetSocial.GetSocialImpl.DisplayName;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string get_AvatarUrl()
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        return GetSocialSdk.Core.GetSocial.GetSocialImpl.AvatarUrl;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void Reset(System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.ResetUser(onSuccess:  onSuccess, onError:  onError);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetDisplayName(string displayName, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.SetDisplayName(displayName:  displayName, onComplete:  onComplete, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetAvatarUrl(string avatarUrl, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.SetAvatarUrl(avatarUrl:  avatarUrl, onComplete:  onComplete, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetAvatar(UnityEngine.Texture2D avatar, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.SetAvatar(avatar:  avatar, onComplete:  onComplete, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetPublicProperty(string key, string value, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.SetPublicProperty(key:  key, value:  value, onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetPrivateProperty(string key, string value, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        GetSocialSdk.Core.IGetSocialNativeBridge val_1 = GetSocialSdk.Core.GetSocial.GetSocialImpl;
        var val_3 = 0;
        val_3 = val_3 + 1;
        goto (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(val_1, typeof("shortCode"), slot: 41);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void RemovePublicProperty(string key, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.RemovePublicProperty(key:  key, onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void RemovePrivateProperty(string key, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.RemovePrivateProperty(key:  key, onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string GetPublicProperty(string key)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        return GetSocialSdk.Core.GetSocial.GetSocialImpl.GetPublicProperty(key:  key);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static string GetPrivateProperty(string key)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        return GetSocialSdk.Core.GetSocial.GetSocialImpl.GetPrivateProperty(key:  key);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool HasPublicProperty(string key)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        return GetSocialSdk.Core.GetSocial.GetSocialImpl.HasPublicProperty(key:  key);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool HasPrivateProperty(string key)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        return GetSocialSdk.Core.GetSocial.GetSocialImpl.HasPrivateProperty(key:  key);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.Dictionary<string, string> get_AllPublicProperties()
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        return GetSocialSdk.Core.GetSocial.GetSocialImpl.AllPublicProperties;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.Dictionary<string, string> get_AllPrivateProperties()
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        return GetSocialSdk.Core.GetSocial.GetSocialImpl.AllPrivateProperties;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetUserDetails(GetSocialSdk.Core.UserUpdate userUpdate, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.SetUserDetails(userUpdate:  userUpdate, onSuccess:  onComplete, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void AddAuthIdentity(GetSocialSdk.Core.AuthIdentity authIdentity, System.Action onComplete, System.Action<GetSocialSdk.Core.GetSocialError> onFailure, System.Action<GetSocialSdk.Core.ConflictUser> onConflict)
    {
        Check.Argument.IsNotNull(argument:  authIdentity, argumentName:  "identity", message:  0);
        Check.Argument.IsNotNull(argument:  onComplete, argumentName:  "onComplete", message:  0);
        Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
        Check.Argument.IsNotNull(argument:  onConflict, argumentName:  "onConflict", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.AddAuthIdentity(authIdentity:  authIdentity, onComplete:  onComplete, onFailure:  onFailure, onConflict:  onConflict);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void RemoveAuthIdentity(string providerId, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        Check.Argument.IsStrNotNullOrEmpty(argument:  providerId, argumentName:  "providerId", message:  0);
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.RemoveAuthIdentity(providerId:  providerId, onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SwitchUser(GetSocialSdk.Core.AuthIdentity authIdentity, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        Check.Argument.IsNotNull(argument:  authIdentity, argumentName:  "identity", message:  0);
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.SwitchUser(authIdentity:  authIdentity, onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void AddFriend(string userId, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        Check.Argument.IsStrNotNullOrEmpty(argument:  userId, argumentName:  "userId", message:  0);
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.AddFriend(userId:  userId, onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void AddFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        Check.Argument.IsNotNull(argument:  providerId, argumentName:  "providerId", message:  0);
        Check.Argument.IsNotNull(argument:  providerUserIds, argumentName:  "providerUserIds", message:  0);
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.AddFriendsByAuthIdentities(providerId:  providerId, providerUserIds:  providerUserIds, onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetFriends(System.Collections.Generic.List<string> userIds, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        Check.Argument.IsNotNull(argument:  userIds, argumentName:  "providerId", message:  0);
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.SetFriends(userIds:  userIds, onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        Check.Argument.IsNotNull(argument:  providerId, argumentName:  "providerId", message:  0);
        Check.Argument.IsNotNull(argument:  providerUserIds, argumentName:  "providerUserIds", message:  0);
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.SetFriendsByAuthIdentities(providerId:  providerId, providerUserIds:  providerUserIds, onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void RemoveFriend(string userId, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        Check.Argument.IsStrNotNullOrEmpty(argument:  userId, argumentName:  "userId", message:  0);
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.RemoveFriend(userId:  userId, onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void RemoveFriendsByAuthIdentities(string providerId, System.Collections.Generic.List<string> providerUserIds, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        Check.Argument.IsNotNull(argument:  providerId, argumentName:  "providerId", message:  0);
        Check.Argument.IsNotNull(argument:  providerUserIds, argumentName:  "providerUserIds", message:  0);
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.RemoveFriendsByAuthIdentities(providerId:  providerId, providerUserIds:  providerUserIds, onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void IsFriend(string userId, System.Action<bool> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        Check.Argument.IsStrNotNullOrEmpty(argument:  userId, argumentName:  "userId", message:  0);
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.IsFriend(userId:  userId, onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void GetFriendsCount(System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.GetFriendsCount(onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void GetFriends(int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.PublicUser>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.GetFriends(offset:  offset, limit:  limit, onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void GetFriendsReferences(System.Action<System.Collections.Generic.List<GetSocialSdk.Core.UserReference>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.GetFriendsReferences(onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void GetSuggestedFriends(int offset, int limit, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.SuggestedFriend>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onFailure)
    {
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onFailure, argumentName:  "onFailure", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.GetSuggestedFriends(offset:  offset, limit:  limit, onSuccess:  onSuccess, onFailure:  onFailure);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool SetOnUserChangedListener(System.Action onUserChanged)
    {
        string val_3 = 0;
        Check.Argument.IsNotNull(argument:  onUserChanged, argumentName:  "onUserChanged", message:  val_3 = 0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        val_3 = 27;
        return GetSocialSdk.Core.GetSocial.GetSocialImpl.SetOnUserChangedListener(listener:  onUserChanged);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool RemoveOnUserChangedListener()
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        return GetSocialSdk.Core.GetSocial.GetSocialImpl.RemoveOnUserChangedListener();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void GetNotifications(GetSocialSdk.Core.NotificationsQuery query, System.Action<System.Collections.Generic.List<GetSocialSdk.Core.Notification>> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
    {
        Check.Argument.IsNotNull(argument:  query, argumentName:  "query", message:  0);
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onError, argumentName:  "onError", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.GetNotifications(query:  query, onSuccess:  onSuccess, onError:  onError);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void GetNotificationsCount(GetSocialSdk.Core.NotificationsCountQuery query, System.Action<int> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
    {
        Check.Argument.IsNotNull(argument:  query, argumentName:  "query", message:  0);
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onError, argumentName:  "onError", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.GetNotificationsCount(query:  query, onSuccess:  onSuccess, onError:  onError);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetNotificationsRead(System.Collections.Generic.List<string> notificationsIds, bool isRead, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
    {
        Check.Argument.IsNotNull(argument:  notificationsIds, argumentName:  "notificationsIds", message:  0);
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onError, argumentName:  "onError", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.SetNotificationsStatus(notificationsIds:  notificationsIds, status:  "read", onSuccess:  onSuccess, onError:  onError);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetNotificationsStatus(System.Collections.Generic.List<string> notificationsIds, string status, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
    {
        Check.Argument.IsNotNull(argument:  notificationsIds, argumentName:  "notificationsIds", message:  0);
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onError, argumentName:  "onError", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.SetNotificationsStatus(notificationsIds:  notificationsIds, status:  status, onSuccess:  onSuccess, onError:  onError);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SetPushNotificationsEnabled(bool isEnabled, System.Action onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
    {
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onError, argumentName:  "onError", message:  0);
        var val_4 = 0;
        val_4 = val_4 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.SetPushNotificationsEnabled(isEnabled:  isEnabled, onSuccess:  onSuccess, onError:  onError);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void IsPushNotificationsEnabled(System.Action<bool> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
    {
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onError, argumentName:  "onError", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.IsPushNotificationsEnabled(onSuccess:  onSuccess, onError:  onError);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void SendNotification(System.Collections.Generic.List<string> userIds, GetSocialSdk.Core.NotificationContent content, System.Action<GetSocialSdk.Core.NotificationsSummary> onSuccess, System.Action<GetSocialSdk.Core.GetSocialError> onError)
    {
        Check.Argument.IsNotNull(argument:  onSuccess, argumentName:  "onSuccess", message:  0);
        Check.Argument.IsNotNull(argument:  onError, argumentName:  "onError", message:  0);
        Check.Argument.IsNotNull(argument:  userIds, argumentName:  "userIds", message:  0);
        Check.Argument.IsNotNull(argument:  content, argumentName:  "content", message:  0);
        var val_3 = 0;
        val_3 = val_3 + 1;
        GetSocialSdk.Core.GetSocial.GetSocialImpl.SendNotification(userIds:  userIds, content:  content, onSuccess:  onSuccess, onError:  onError);
    }

}
