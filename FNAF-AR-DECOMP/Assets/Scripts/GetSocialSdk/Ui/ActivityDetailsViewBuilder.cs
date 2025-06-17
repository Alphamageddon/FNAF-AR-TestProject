using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class ActivityDetailsViewBuilder : ViewBuilder<GetSocialSdk.Ui.ActivityDetailsViewBuilder>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _activityId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _commentId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _showActivityFeedView;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _readOnly;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string, GetSocialSdk.Core.ActivityPost> _onButtonClicked;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.ActionListener _actionListener;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<GetSocialSdk.Core.PublicUser> _onAvatarClickListener;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _onMentionClickListener;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> _tagClickListener;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal ActivityDetailsViewBuilder(string activityId)
        {
            this._activityId = activityId;
            this._showActivityFeedView = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityDetailsViewBuilder SetShowActivityFeedView(bool showFeedView)
        {
            this._showActivityFeedView = showFeedView;
            return (GetSocialSdk.Ui.ActivityDetailsViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityDetailsViewBuilder SetButtonActionListener(System.Action<string, GetSocialSdk.Core.ActivityPost> onButtonClicked)
        {
            this._onButtonClicked = onButtonClicked;
            return (GetSocialSdk.Ui.ActivityDetailsViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityDetailsViewBuilder SetActionListener(GetSocialSdk.Core.ActionListener listener)
        {
            this._actionListener = listener;
            return (GetSocialSdk.Ui.ActivityDetailsViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityDetailsViewBuilder SetAvatarClickListener(System.Action<GetSocialSdk.Core.PublicUser> onAvatarClickListener)
        {
            this._onAvatarClickListener = onAvatarClickListener;
            return (GetSocialSdk.Ui.ActivityDetailsViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityDetailsViewBuilder SetMentionClickListener(System.Action<string> mentionClickListener)
        {
            this._onMentionClickListener = mentionClickListener;
            return (GetSocialSdk.Ui.ActivityDetailsViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityDetailsViewBuilder SetTagClickListener(System.Action<string> tagClickListener)
        {
            this._tagClickListener = tagClickListener;
            return (GetSocialSdk.Ui.ActivityDetailsViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityDetailsViewBuilder SetReadOnly(bool readOnly)
        {
            this._readOnly = readOnly;
            return (GetSocialSdk.Ui.ActivityDetailsViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Ui.ActivityDetailsViewBuilder SetCommentId(string commentId)
        {
            this._commentId = commentId;
            return (GetSocialSdk.Ui.ActivityDetailsViewBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal override bool ShowInternal()
        {
            return this.ShowBuilder(builder:  this.ToAJO());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AndroidJavaObject ToAJO()
        {
            System.Action<System.String, GetSocialSdk.Core.ActivityPost> val_24;
            object[] val_1 = new object[1];
            val_1[0] = this._activityId;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "im.getsocial.sdk.ui.activities.ActivityDetailsViewBuilder", args:  val_1);
            object[] val_3 = new object[1];
            val_3[0] = this._showActivityFeedView;
            UnityEngine.AndroidJavaObject val_4 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setShowActivityFeedView", args:  val_3);
            if(this._onButtonClicked != null)
            {
                    object[] val_5 = new object[1];
                val_24 = this._onButtonClicked;
                val_5[0] = new GetSocialSdk.Ui.ActionButtonListenerProxy(onButtonClicked:  val_24);
                UnityEngine.AndroidJavaObject val_7 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setButtonActionListener", args:  val_5);
            }
            
            if(this._actionListener != null)
            {
                    object[] val_8 = new object[1];
                val_24 = this._actionListener;
                val_8[0] = new GetSocialSdk.Core.ActionListenerProxy(actionListener:  val_24);
                UnityEngine.AndroidJavaObject val_10 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setActionListener", args:  val_8);
            }
            
            if(this._onAvatarClickListener != null)
            {
                    object[] val_11 = new object[1];
                val_24 = this._onAvatarClickListener;
                val_11[0] = new GetSocialSdk.Ui.AvatarClickListenerProxy(avatarClickListener:  val_24);
                UnityEngine.AndroidJavaObject val_13 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setAvatarClickListener", args:  val_11);
            }
            
            if(this._onMentionClickListener != null)
            {
                    object[] val_14 = new object[1];
                val_24 = this._onMentionClickListener;
                val_14[0] = new GetSocialSdk.Ui.MentionClickListenerProxy(onMentionClickListener:  val_24);
                UnityEngine.AndroidJavaObject val_16 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setMentionClickListener", args:  val_14);
            }
            
            if(this._tagClickListener != null)
            {
                    object[] val_17 = new object[1];
                val_24 = this._tagClickListener;
                val_17[0] = new GetSocialSdk.Ui.TagClickListenerProxy(tagClickListener:  val_24);
                UnityEngine.AndroidJavaObject val_19 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setTagClickListener", args:  val_17);
            }
            
            if(this._commentId != null)
            {
                    object[] val_20 = new object[1];
                val_20[0] = this._commentId;
                UnityEngine.AndroidJavaObject val_21 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setCommentId", args:  val_20);
            }
            
            object[] val_22 = new object[1];
            val_22[0] = this._readOnly;
            UnityEngine.AndroidJavaObject val_23 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setReadOnly", args:  val_22);
            return val_2;
        }
    
    }

}
