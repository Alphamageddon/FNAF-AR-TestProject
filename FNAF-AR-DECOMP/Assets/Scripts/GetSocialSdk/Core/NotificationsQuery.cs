using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class NotificationsQuery : IConvertableToNative
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string[] AllTypes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string[] _statuses;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _types;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.NotificationsQuery.Filter _filter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _notificationId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _limit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _actions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private NotificationsQuery(string[] statuses)
        {
            null = null;
            this._types = GetSocialSdk.Core.NotificationsQuery.AllTypes;
            this._actions = new string[0];
            this._statuses = statuses;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.NotificationsQuery ReadAndUnread()
        {
            string[] val_1 = new string[2];
            val_1[0] = "read";
            val_1[1] = "unread";
            return (GetSocialSdk.Core.NotificationsQuery)new GetSocialSdk.Core.NotificationsQuery(statuses:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.NotificationsQuery Read()
        {
            string[] val_1 = new string[1];
            val_1[0] = "read";
            return (GetSocialSdk.Core.NotificationsQuery)new GetSocialSdk.Core.NotificationsQuery(statuses:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.NotificationsQuery Unread()
        {
            string[] val_1 = new string[1];
            val_1[0] = "unread";
            return (GetSocialSdk.Core.NotificationsQuery)new GetSocialSdk.Core.NotificationsQuery(statuses:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.NotificationsQuery WithStatuses(string[] statuses)
        {
            return (GetSocialSdk.Core.NotificationsQuery)new GetSocialSdk.Core.NotificationsQuery(statuses:  statuses);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.NotificationsQuery WithAllStatuses()
        {
            return (GetSocialSdk.Core.NotificationsQuery)new GetSocialSdk.Core.NotificationsQuery(statuses:  System.Array.Empty<System.String>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationsQuery OfAllTypes()
        {
            null = null;
            this._types = GetSocialSdk.Core.NotificationsQuery.AllTypes;
            return (GetSocialSdk.Core.NotificationsQuery)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationsQuery OfTypes(string[] types)
        {
            this._types = types;
            return (GetSocialSdk.Core.NotificationsQuery)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationsQuery WithLimit(int limit)
        {
            this._limit = limit;
            return (GetSocialSdk.Core.NotificationsQuery)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationsQuery WithFilter(GetSocialSdk.Core.NotificationsQuery.Filter filter, string notificationId)
        {
            this._filter = filter;
            this._notificationId = notificationId;
            return (GetSocialSdk.Core.NotificationsQuery)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationsQuery WithActions(string[] actions)
        {
            this._actions = actions;
            return (GetSocialSdk.Core.NotificationsQuery)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            System.Object[] val_19;
            System.String[] val_20;
            val_19 = this;
            object[] val_2 = new object[1];
            val_2[0] = GetSocialSdk.Core.JniUtils.ToJavaStringArray(values:  System.Linq.Enumerable.ToList<System.String>(source:  this._statuses));
            UnityEngine.AndroidJavaObject val_5 = GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.pushnotifications.NotificationsQuery"), methodName:  "withStatuses", args:  val_2);
            object[] val_6 = new object[1];
            val_6[0] = this._limit;
            UnityEngine.AndroidJavaObject val_7 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_5, methodName:  "withLimit", args:  val_6);
            if(this._types.Length != 0)
            {
                    object[] val_8 = new object[1];
                val_8[0] = GetSocialSdk.Core.JniUtils.ToJavaStringArray(values:  System.Linq.Enumerable.ToList<System.String>(source:  this._types));
                UnityEngine.AndroidJavaObject val_11 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_5, methodName:  "ofTypes", args:  val_8);
            }
            
            if(this._filter != 0)
            {
                    object[] val_12 = new object[2];
                val_12[0] = GetSocialSdk.Core.EnumConversion.ToAndroidJavaObject(filter:  this._filter);
                val_12[1] = this._notificationId;
                UnityEngine.AndroidJavaObject val_14 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_5, methodName:  "withFilter", args:  val_12);
            }
            
            val_20 = this._actions;
            if(this._actions.Length == 0)
            {
                    return val_5;
            }
            
            object[] val_15 = new object[1];
            val_19 = val_15;
            val_20 = GetSocialSdk.Core.JniUtils.ToJavaStringArray(values:  System.Linq.Enumerable.ToList<System.String>(source:  this._actions));
            val_19[0] = val_20;
            UnityEngine.AndroidJavaObject val_18 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_5, methodName:  "withActions", args:  val_15);
            return val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static NotificationsQuery()
        {
            GetSocialSdk.Core.NotificationsQuery.AllTypes = new string[0];
        }
    
    }

}
