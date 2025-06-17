using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class ActivitiesQuery : IConvertableToNative
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string GlobalFeed = "g-global";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const int DefaultLimit = 10;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly GetSocialSdk.Core.ActivitiesQuery.Type _type;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _feed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _parentActivityId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _limit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.ActivitiesQuery.Filter _filter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _filteringActivityId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _filterUserId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _isFriendsFeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _tags;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ActivitiesQuery(GetSocialSdk.Core.ActivitiesQuery.Type type, string feed, string parentActivityId)
        {
            this._limit = 10;
            this._tags = new string[0];
            val_2 = new System.Object();
            this._type = type;
            this._feed = val_2;
            this._parentActivityId = parentActivityId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.ActivitiesQuery PostsForFeed(string feed)
        {
            return (GetSocialSdk.Core.ActivitiesQuery)new GetSocialSdk.Core.ActivitiesQuery(type:  1, feed:  feed, parentActivityId:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.ActivitiesQuery PostsForGlobalFeed()
        {
            return (GetSocialSdk.Core.ActivitiesQuery)new GetSocialSdk.Core.ActivitiesQuery(type:  1, feed:  "g-global", parentActivityId:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.ActivitiesQuery CommentsToPost(string activityId)
        {
            return (GetSocialSdk.Core.ActivitiesQuery)new GetSocialSdk.Core.ActivitiesQuery(type:  0, feed:  0, parentActivityId:  activityId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.ActivitiesQuery WithLimit(int limit)
        {
            this._limit = limit;
            return (GetSocialSdk.Core.ActivitiesQuery)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.ActivitiesQuery WithFilter(GetSocialSdk.Core.ActivitiesQuery.Filter filter, string activityId)
        {
            this._filter = filter;
            this._filteringActivityId = activityId;
            return (GetSocialSdk.Core.ActivitiesQuery)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.ActivitiesQuery FilterByUser(string userId)
        {
            this._filterUserId = userId;
            return (GetSocialSdk.Core.ActivitiesQuery)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.ActivitiesQuery FriendsFeed(bool isFriendsFeed)
        {
            this._isFriendsFeed = isFriendsFeed;
            return (GetSocialSdk.Core.ActivitiesQuery)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.ActivitiesQuery WithTags(string[] tags)
        {
            this._tags = tags;
            return (GetSocialSdk.Core.ActivitiesQuery)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            string val_16;
            string val_17;
            string val_18;
            System.Object[] val_19;
            val_16 = this;
            object[] val_2 = new object[1];
            if(this._type == 1)
            {
                    val_17 = this._feed;
                val_18 = "postsForFeed";
            }
            else
            {
                    val_17 = this._parentActivityId;
                val_18 = "commentsToPost";
            }
            
            val_2[0] = val_17;
            UnityEngine.AndroidJavaObject val_3 = GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.activities.ActivitiesQuery"), methodName:  val_18, args:  val_2);
            object[] val_4 = new object[1];
            val_4[0] = this._limit;
            UnityEngine.AndroidJavaObject val_5 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_3, methodName:  "withLimit", args:  val_4);
            object[] val_6 = new object[1];
            val_6[0] = this._filterUserId;
            UnityEngine.AndroidJavaObject val_7 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_3, methodName:  "filterByUser", args:  val_6);
            object[] val_8 = new object[1];
            val_8[0] = this._isFriendsFeed;
            UnityEngine.AndroidJavaObject val_9 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_3, methodName:  "friendsFeed", args:  val_8);
            object[] val_10 = new object[1];
            val_19 = val_10;
            val_19[0] = GetSocialSdk.Core.JniUtils.ToJavaStringArray(values:  this._tags);
            UnityEngine.AndroidJavaObject val_12 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_3, methodName:  "withTags", args:  val_10);
            if(this._filter == 0)
            {
                    return val_3;
            }
            
            object[] val_13 = new object[2];
            val_19 = val_13;
            val_19[0] = GetSocialSdk.Core.EnumConversion.ToAndroidJavaObject(filter:  this._filter);
            val_16 = this._filteringActivityId;
            val_19[1] = val_16;
            UnityEngine.AndroidJavaObject val_15 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_3, methodName:  "withFilter", args:  val_13);
            return val_3;
        }
    
    }

}
