using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class NotificationsCountQuery : IConvertableToNative
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string[] AllTypes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string[] _statuses;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _types;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _actions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private NotificationsCountQuery(string[] statuses)
        {
            null = null;
            this._types = GetSocialSdk.Core.NotificationsCountQuery.AllTypes;
            this._actions = new string[0];
            this._statuses = statuses;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.NotificationsCountQuery ReadAndUnread()
        {
            string[] val_1 = new string[2];
            val_1[0] = "read";
            val_1[1] = "unread";
            return (GetSocialSdk.Core.NotificationsCountQuery)new GetSocialSdk.Core.NotificationsCountQuery(statuses:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.NotificationsCountQuery Read()
        {
            string[] val_1 = new string[1];
            val_1[0] = "read";
            return (GetSocialSdk.Core.NotificationsCountQuery)new GetSocialSdk.Core.NotificationsCountQuery(statuses:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.NotificationsCountQuery Unread()
        {
            string[] val_1 = new string[1];
            val_1[0] = "unread";
            return (GetSocialSdk.Core.NotificationsCountQuery)new GetSocialSdk.Core.NotificationsCountQuery(statuses:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.NotificationsCountQuery WithStatuses(string[] statuses)
        {
            return (GetSocialSdk.Core.NotificationsCountQuery)new GetSocialSdk.Core.NotificationsCountQuery(statuses:  statuses);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.NotificationsCountQuery WithAllStatuses()
        {
            return (GetSocialSdk.Core.NotificationsCountQuery)new GetSocialSdk.Core.NotificationsCountQuery(statuses:  System.Array.Empty<System.String>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationsCountQuery OfAllTypes()
        {
            null = null;
            this._types = GetSocialSdk.Core.NotificationsCountQuery.AllTypes;
            return (GetSocialSdk.Core.NotificationsCountQuery)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationsCountQuery OfTypes(string[] types)
        {
            this._types = types;
            return (GetSocialSdk.Core.NotificationsCountQuery)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationsCountQuery WithActions(string[] actions)
        {
            this._actions = actions;
            return (GetSocialSdk.Core.NotificationsCountQuery)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            System.Object[] val_14;
            System.String[] val_15;
            val_14 = this;
            object[] val_2 = new object[1];
            val_2[0] = GetSocialSdk.Core.JniUtils.ToJavaStringArray(values:  System.Linq.Enumerable.ToList<System.String>(source:  this._statuses));
            UnityEngine.AndroidJavaObject val_5 = GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.pushnotifications.NotificationsCountQuery"), methodName:  "withStatuses", args:  val_2);
            if(this._types.Length != 0)
            {
                    object[] val_6 = new object[1];
                val_6[0] = GetSocialSdk.Core.JniUtils.ToJavaStringArray(values:  System.Linq.Enumerable.ToList<System.String>(source:  this._types));
                UnityEngine.AndroidJavaObject val_9 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_5, methodName:  "ofTypes", args:  val_6);
            }
            
            val_15 = this._actions;
            if(this._actions.Length == 0)
            {
                    return val_5;
            }
            
            object[] val_10 = new object[1];
            val_14 = val_10;
            val_15 = GetSocialSdk.Core.JniUtils.ToJavaStringArray(values:  System.Linq.Enumerable.ToList<System.String>(source:  this._actions));
            val_14[0] = val_15;
            UnityEngine.AndroidJavaObject val_13 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_5, methodName:  "withActions", args:  val_10);
            return val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static NotificationsCountQuery()
        {
            GetSocialSdk.Core.NotificationsCountQuery.AllTypes = new string[0];
        }
    
    }

}
