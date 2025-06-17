using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class ActivityFeedViewBuilder : ViewBuilder<GetSocialSdk.Ui.ActivityFeedViewBuilder>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _feed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string, GetSocialSdk.Core.ActivityPost> _onButtonClickListener;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<GetSocialSdk.Core.PublicUser> _onAvatarClickListener;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _onMentionClickListener;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _tagClickListener;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.ActionListener _actionListener;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _filterUserId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _readOnly;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _friendsFeed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _tags;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal ActivityFeedViewBuilder()
        {
            this._tags = new string[0];
            this._feed = "g-global";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal ActivityFeedViewBuilder(string feed)
        {
            this._tags = new string[0];
            this._feed = feed;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityFeedViewBuilder SetButtonActionListener(System.Action<string, GetSocialSdk.Core.ActivityPost> onButtonClickListener)
        {
            this._onButtonClickListener = onButtonClickListener;
            return (GetSocialSdk.Ui.ActivityFeedViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityFeedViewBuilder SetActionListener(GetSocialSdk.Core.ActionListener listener)
        {
            this._actionListener = listener;
            return (GetSocialSdk.Ui.ActivityFeedViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityFeedViewBuilder SetAvatarClickListener(System.Action<GetSocialSdk.Core.PublicUser> onAvatarClickListener)
        {
            this._onAvatarClickListener = onAvatarClickListener;
            return (GetSocialSdk.Ui.ActivityFeedViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityFeedViewBuilder SetMentionClickListener(System.Action<string> mentionClickListener)
        {
            this._onMentionClickListener = mentionClickListener;
            return (GetSocialSdk.Ui.ActivityFeedViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityFeedViewBuilder SetTagClickListener(System.Action<string> tagClickListener)
        {
            this._tagClickListener = tagClickListener;
            return (GetSocialSdk.Ui.ActivityFeedViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityFeedViewBuilder SetFilterByUser(string userId)
        {
            this._filterUserId = userId;
            return (GetSocialSdk.Ui.ActivityFeedViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityFeedViewBuilder SetReadOnly(bool readOnly)
        {
            this._readOnly = readOnly;
            return (GetSocialSdk.Ui.ActivityFeedViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityFeedViewBuilder SetShowFriendsFeed(bool showFriendsFeed)
        {
            this._friendsFeed = showFriendsFeed;
            return (GetSocialSdk.Ui.ActivityFeedViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityFeedViewBuilder SetFilterByTags(string[] tags)
        {
            this._tags = tags;
            return (GetSocialSdk.Ui.ActivityFeedViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override bool ShowInternal()
        {
            return this.ShowBuilder(builder:  this.ToAJO());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AndroidJavaObject ToAJO()
        {
            object[] val_1 = new object[1];
            val_1[0] = this._feed;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "im.getsocial.sdk.ui.activities.ActivityFeedViewBuilder", args:  val_1);
            if(this._filterUserId != null)
            {
                    object[] val_3 = new object[1];
                val_3[0] = this._filterUserId;
                UnityEngine.AndroidJavaObject val_4 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setFilterByUser", args:  val_3);
            }
            
            if(this._onButtonClickListener != null)
            {
                    object[] val_5 = new object[1];
                val_5[0] = new GetSocialSdk.Ui.ActionButtonListenerProxy(onButtonClicked:  this._onButtonClickListener);
                UnityEngine.AndroidJavaObject val_7 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setButtonActionListener", args:  val_5);
            }
            
            if(this._actionListener != null)
            {
                    object[] val_8 = new object[1];
                val_8[0] = new GetSocialSdk.Core.ActionListenerProxy(actionListener:  this._actionListener);
                UnityEngine.AndroidJavaObject val_10 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setActionListener", args:  val_8);
            }
            
            if(this._onAvatarClickListener != null)
            {
                    object[] val_11 = new object[1];
                val_11[0] = new GetSocialSdk.Ui.AvatarClickListenerProxy(avatarClickListener:  this._onAvatarClickListener);
                UnityEngine.AndroidJavaObject val_13 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setAvatarClickListener", args:  val_11);
            }
            
            if(this._onMentionClickListener != null)
            {
                    object[] val_14 = new object[1];
                val_14[0] = new GetSocialSdk.Ui.MentionClickListenerProxy(onMentionClickListener:  this._onMentionClickListener);
                UnityEngine.AndroidJavaObject val_16 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setMentionClickListener", args:  val_14);
            }
            
            if(this._tagClickListener != null)
            {
                    object[] val_17 = new object[1];
                val_17[0] = new GetSocialSdk.Ui.TagClickListenerProxy(tagClickListener:  this._tagClickListener);
                UnityEngine.AndroidJavaObject val_19 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setTagClickListener", args:  val_17);
            }
            
            object[] val_20 = new object[1];
            val_20[0] = this._readOnly;
            UnityEngine.AndroidJavaObject val_21 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setReadOnly", args:  val_20);
            object[] val_22 = new object[1];
            val_22[0] = this._friendsFeed;
            UnityEngine.AndroidJavaObject val_23 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setShowFriendsFeed", args:  val_22);
            object[] val_24 = new object[1];
            val_24[0] = GetSocialSdk.Core.JniUtils.ToJavaStringArray(values:  this._tags);
            UnityEngine.AndroidJavaObject val_26 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setFilterByTags", args:  val_24);
            return val_2;
        }
    
    }

}
