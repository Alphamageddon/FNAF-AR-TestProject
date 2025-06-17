using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class ActivityPost : IConvertableFromNative<GetSocialSdk.Core.ActivityPost>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Id>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Text>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ImageUrl>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTime <CreatedAt>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ButtonTitle>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ButtonAction>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.GetSocialAction <Action>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.PostAuthor <Author>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <CommentsCount>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <LikesCount>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsLikedByMe>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTime <StickyStart>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTime <StickyEnd>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GetSocialSdk.Core.Mention> <Mentions>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <FeedId>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Text { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasText { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ImageUrl { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasImage { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime CreatedAt { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ButtonTitle { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ButtonAction { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.GetSocialAction Action { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasButton { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.PostAuthor Author { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CommentsCount { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int LikesCount { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsLikedByMe { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime StickyStart { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime StickyEnd { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GetSocialSdk.Core.Mention> Mentions { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string FeedId { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Id()
        {
            return (string)this.<Id>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Id(string value)
        {
            this.<Id>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Text()
        {
            return (string)this.<Text>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Text(string value)
        {
            this.<Text>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasText()
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  this.<Text>k__BackingField);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ImageUrl()
        {
            return (string)this.<ImageUrl>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ImageUrl(string value)
        {
            this.<ImageUrl>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasImage()
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  this.<ImageUrl>k__BackingField);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime get_CreatedAt()
        {
            return (System.DateTime)this.<CreatedAt>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_CreatedAt(System.DateTime value)
        {
            this.<CreatedAt>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ButtonTitle()
        {
            return (string)this.<ButtonTitle>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ButtonTitle(string value)
        {
            this.<ButtonTitle>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ButtonAction()
        {
            return (string)this.<ButtonAction>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ButtonAction(string value)
        {
            this.<ButtonAction>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.GetSocialAction get_Action()
        {
            return (GetSocialSdk.Core.GetSocialAction)this.<Action>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Action(GetSocialSdk.Core.GetSocialAction value)
        {
            this.<Action>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_HasButton()
        {
            return (bool)((this.<ButtonTitle>k__BackingField) != null) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.PostAuthor get_Author()
        {
            return (GetSocialSdk.Core.PostAuthor)this.<Author>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Author(GetSocialSdk.Core.PostAuthor value)
        {
            this.<Author>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_CommentsCount()
        {
            return (int)this.<CommentsCount>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_CommentsCount(int value)
        {
            this.<CommentsCount>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_LikesCount()
        {
            return (int)this.<LikesCount>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_LikesCount(int value)
        {
            this.<LikesCount>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsLikedByMe()
        {
            return (bool)this.<IsLikedByMe>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsLikedByMe(bool value)
        {
            this.<IsLikedByMe>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime get_StickyStart()
        {
            return (System.DateTime)this.<StickyStart>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_StickyStart(System.DateTime value)
        {
            this.<StickyStart>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime get_StickyEnd()
        {
            return (System.DateTime)this.<StickyEnd>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_StickyEnd(System.DateTime value)
        {
            this.<StickyEnd>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsStickyAt(System.DateTime dateTime)
        {
            var val_6;
            if(dateTime.dateData.Ticks > (this.<StickyStart>k__BackingField.Ticks))
            {
                    var val_5 = (dateTime.dateData.Ticks < (this.<StickyEnd>k__BackingField.Ticks)) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GetSocialSdk.Core.Mention> get_Mentions()
        {
            return (System.Collections.Generic.List<GetSocialSdk.Core.Mention>)this.<Mentions>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Mentions(System.Collections.Generic.List<GetSocialSdk.Core.Mention> value)
        {
            this.<Mentions>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_FeedId()
        {
            return (string)this.<FeedId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_FeedId(string value)
        {
            this.<FeedId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[18];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if((this.<Id>k__BackingField) != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if((this.<Id>k__BackingField) == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.<Id>k__BackingField;
            val_1[1] = this.<Text>k__BackingField;
            object val_7 = ~(System.String.IsNullOrEmpty(value:  this.<Text>k__BackingField));
            val_7 = val_7 & 1;
            val_1[2] = val_7;
            val_1[3] = this.<ImageUrl>k__BackingField;
            object val_8 = ~(System.String.IsNullOrEmpty(value:  this.<ImageUrl>k__BackingField));
            val_8 = val_8 & 1;
            val_1[4] = val_8;
            val_1[5] = this.<CreatedAt>k__BackingField;
            val_1[6] = this.<ButtonTitle>k__BackingField;
            val_1[7] = this.<ButtonAction>k__BackingField;
            val_1[8] = this.<Action>k__BackingField;
            val_1[9] = ((this.<ButtonTitle>k__BackingField) != null) ? 1 : 0;
            val_1[10] = this.<Author>k__BackingField;
            val_1[11] = this.<CommentsCount>k__BackingField;
            val_1[12] = this.<LikesCount>k__BackingField;
            val_1[13] = this.<IsLikedByMe>k__BackingField;
            val_1[14] = this.<StickyStart>k__BackingField;
            val_1[15] = this.<StickyEnd>k__BackingField;
            val_1[16] = this.<FeedId>k__BackingField;
            val_1[17] = GetSocialSdk.Core.DebugUtils.ToDebugString<GetSocialSdk.Core.Mention>(list:  this.<Mentions>k__BackingField);
            return (string)System.String.Format(format:  "Id: {0}, Text: {1}, HasText: {2}, ImageUrl: {3}, HasImage: {4}, CreatedAt: {5}, ButtonTitle: {6}, ButtonAction: {7}, Action: {8}, HasButton: {9}, Author: {10}, CommentsCount: {11}, LikesCount: {12}, IsLikedByMe: {13}, StickyStart: {14}, StickyEnd: {15}, FeedId: {16}, Mentions: {17}", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ActivityPost()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal ActivityPost(string id, string text, string imageUrl, System.DateTime createdAt, string buttonTitle, string buttonAction, GetSocialSdk.Core.PostAuthor author, int commentsCount, int likesCount, bool isLikedByMe, System.DateTime stickyStart, System.DateTime stickyEnd, System.Collections.Generic.List<GetSocialSdk.Core.Mention> mentions, string feedId)
        {
            val_1 = new System.Object();
            this.<Id>k__BackingField = id;
            this.<Text>k__BackingField = val_1;
            this.<ImageUrl>k__BackingField = imageUrl;
            this.<CreatedAt>k__BackingField = createdAt;
            this.<ButtonTitle>k__BackingField = buttonTitle;
            this.<ButtonAction>k__BackingField = buttonAction;
            this.<CommentsCount>k__BackingField = commentsCount;
            this.<LikesCount>k__BackingField = likesCount;
            this.<StickyStart>k__BackingField = stickyStart;
            this.<Author>k__BackingField = author;
            this.<IsLikedByMe>k__BackingField = isLikedByMe;
            this.<StickyEnd>k__BackingField = stickyEnd;
            this.<Mentions>k__BackingField = mentions;
            this.<FeedId>k__BackingField = feedId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool Equals(GetSocialSdk.Core.ActivityPost other)
        {
            string val_15;
            if(((((((((System.String.Equals(a:  this.<Id>k__BackingField, b:  other.<Id>k__BackingField)) == false) || ((System.String.Equals(a:  this.<Text>k__BackingField, b:  other.<Text>k__BackingField)) == false)) || ((System.String.Equals(a:  this.<ImageUrl>k__BackingField, b:  other.<ImageUrl>k__BackingField)) == false)) || ((this.<CreatedAt>k__BackingField.Equals(value:  new System.DateTime() {dateData = other.<CreatedAt>k__BackingField})) == false)) || ((System.String.Equals(a:  this.<ButtonTitle>k__BackingField, b:  other.<ButtonTitle>k__BackingField)) == false)) || ((System.String.Equals(a:  this.<ButtonAction>k__BackingField, b:  other.<ButtonAction>k__BackingField)) == false)) || ((System.Object.Equals(objA:  this.<Action>k__BackingField, objB:  other.<Action>k__BackingField)) == false)) || ((((System.Object.Equals(objA:  this.<Author>k__BackingField, objB:  other.<Author>k__BackingField)) == false) || ((this.<CommentsCount>k__BackingField) != (other.<CommentsCount>k__BackingField))) || ((this.<LikesCount>k__BackingField) != (other.<LikesCount>k__BackingField))))
            {
                goto label_15;
            }
            
            var val_9 = ((this.<IsLikedByMe>k__BackingField) == true) ? 1 : 0;
            val_9 = val_9 ^ (((other.<IsLikedByMe>k__BackingField) == true) ? 1 : 0);
            if(((((val_9 & 1) != 0) || ((this.<StickyStart>k__BackingField.Equals(value:  new System.DateTime() {dateData = other.<StickyStart>k__BackingField})) == false)) || ((this.<StickyEnd>k__BackingField.Equals(value:  new System.DateTime() {dateData = other.<StickyEnd>k__BackingField})) == false)) || ((GetSocialSdk.Core.Collections.ListEquals<GetSocialSdk.Core.Mention>(self:  this.<Mentions>k__BackingField, other:  other.<Mentions>k__BackingField)) == false))
            {
                goto label_15;
            }
            
            val_15 = this.<FeedId>k__BackingField;
            bool val_14 = System.String.Equals(a:  val_15, b:  other.<FeedId>k__BackingField);
            goto label_16;
            label_15:
            val_15 = 0;
            label_16:
            val_15 = val_15 & 1;
            return (bool)val_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Equals(object obj)
        {
            var val_3;
            if(obj == null)
            {
                goto label_1;
            }
            
            if(this == obj)
            {
                goto label_2;
            }
            
            if(null == null)
            {
                goto label_3;
            }
            
            label_1:
            val_3 = 0;
            return (bool)this.Equals(other:  obj);
            label_2:
            val_3 = 1;
            return (bool)this.Equals(other:  obj);
            label_3:
            val_3 = this;
            return (bool)this.Equals(other:  obj);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int GetHashCode()
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            if((this.<Id>k__BackingField) != null)
            {
                    val_13 = (this.<Id>k__BackingField) * 397;
            }
            else
            {
                    val_13 = 0;
            }
            
            if((this.<Text>k__BackingField) != null)
            {
                    val_14 = this.<Text>k__BackingField;
            }
            else
            {
                    val_14 = 0;
            }
            
            val_14 = val_14 ^ val_13;
            if((this.<ImageUrl>k__BackingField) != null)
            {
                    val_15 = this.<ImageUrl>k__BackingField;
            }
            else
            {
                    val_15 = 0;
            }
            
            val_16 = 0;
            int val_12 = this.<CreatedAt>k__BackingField.GetHashCode();
            var val_3 = val_15 ^ (val_14 * 397);
            val_3 = val_3 * 397;
            val_12 = val_12 ^ val_3;
            val_15 = val_12 * 397;
            if((this.<ButtonTitle>k__BackingField) != null)
            {
                    val_17 = this.<ButtonTitle>k__BackingField;
            }
            else
            {
                    val_17 = 0;
            }
            
            val_17 = val_17 ^ val_15;
            if((this.<ButtonAction>k__BackingField) != null)
            {
                    val_18 = this.<ButtonAction>k__BackingField;
            }
            else
            {
                    val_18 = 0;
            }
            
            val_18 = val_18 ^ (val_17 * 397);
            if((this.<Action>k__BackingField) != null)
            {
                    val_19 = this.<Action>k__BackingField;
            }
            else
            {
                    val_19 = 0;
            }
            
            val_19 = val_19 ^ (val_18 * 397);
            if((this.<Author>k__BackingField) != null)
            {
                    val_20 = this.<Author>k__BackingField;
            }
            else
            {
                    val_20 = 0;
            }
            
            val_21 = 0;
            val_3 = val_20 ^ (val_19 * 397);
            val_3 = val_3 * 397;
            val_3 = val_3 ^ (this.<CommentsCount>k__BackingField);
            val_3 = val_3 * 397;
            val_3 = val_3 ^ (this.<LikesCount>k__BackingField);
            val_3 = val_3 * 397;
            val_3 = val_3 ^ (this.<IsLikedByMe>k__BackingField.GetHashCode());
            val_3 = val_3 * 397;
            int val_13 = this.<StickyEnd>k__BackingField.GetHashCode();
            val_3 = val_3 ^ (this.<StickyStart>k__BackingField.GetHashCode());
            val_3 = val_3 * 397;
            val_13 = val_13 ^ val_3;
            val_20 = val_13 * 397;
            if((this.<Mentions>k__BackingField) != null)
            {
                    val_21 = public System.Int32 System.Object::GetHashCode();
                val_22 = this.<Mentions>k__BackingField.GetHashCode();
            }
            else
            {
                    val_22 = 0;
            }
            
            string val_14 = this.<FeedId>k__BackingField;
            val_22 = val_22 ^ val_20;
            val_14 = val_14 ^ (val_22 * 397);
            return (int)val_14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.ActivityPost ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            var val_44;
            var val_45;
            System.Converter<UnityEngine.AndroidJavaObject, GetSocialSdk.Core.Mention> val_47;
            val_44 = 1152921518828526064;
            this.<Id>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getId", args:  System.Array.Empty<System.Object>());
            this.<Text>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getText", args:  System.Array.Empty<System.Object>());
            this.<ImageUrl>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getImageUrl", args:  System.Array.Empty<System.Object>());
            this.<ButtonTitle>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getButtonTitle", args:  System.Array.Empty<System.Object>());
            this.<ButtonAction>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getButtonAction", args:  System.Array.Empty<System.Object>());
            UnityEngine.AndroidJavaObject val_12 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getAction", args:  System.Array.Empty<System.Object>());
            if(val_12 != null)
            {
                    new GetSocialSdk.Core.GetSocialAction() = new System.Object();
                GetSocialSdk.Core.GetSocialAction val_14 = new GetSocialSdk.Core.GetSocialAction().ParseFromAJO(ajo:  val_12);
                this.<Action>k__BackingField = new GetSocialSdk.Core.GetSocialAction();
            }
            
            System.DateTime val_17 = GetSocialSdk.Core.DateUtils.FromUnixTime(unixTime:  GetSocialSdk.Core.JniExtensionMethods.CallLong(ajo:  ajo, methodName:  "getCreatedAt", args:  System.Array.Empty<System.Object>()));
            this.<CreatedAt>k__BackingField = val_17;
            new GetSocialSdk.Core.PostAuthor() = new GetSocialSdk.Core.PostAuthor();
            this.<Author>k__BackingField = new GetSocialSdk.Core.PostAuthor().ParseFromAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getAuthor", args:  System.Array.Empty<System.Object>()));
            this.<CommentsCount>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallInt(ajo:  ajo, methodName:  "getCommentsCount", args:  System.Array.Empty<System.Object>());
            this.<LikesCount>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallInt(ajo:  ajo, methodName:  "getLikesCount", args:  System.Array.Empty<System.Object>());
            this.<IsLikedByMe>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  ajo, methodName:  "isLikedByMe", args:  System.Array.Empty<System.Object>());
            System.DateTime val_31 = GetSocialSdk.Core.DateUtils.FromUnixTime(unixTime:  GetSocialSdk.Core.JniExtensionMethods.CallLong(ajo:  ajo, methodName:  "getStickyStart", args:  System.Array.Empty<System.Object>()));
            this.<StickyStart>k__BackingField = val_31;
            System.DateTime val_34 = GetSocialSdk.Core.DateUtils.FromUnixTime(unixTime:  GetSocialSdk.Core.JniExtensionMethods.CallLong(ajo:  ajo, methodName:  "getStickyEnd", args:  System.Array.Empty<System.Object>()));
            this.<StickyEnd>k__BackingField = val_34;
            this.<FeedId>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getFeedId", args:  System.Array.Empty<System.Object>());
            System.Collections.Generic.List<UnityEngine.AndroidJavaObject> val_39 = GetSocialSdk.Core.JniUtils.FromJavaList(javaList:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getMentions", args:  System.Array.Empty<System.Object>()));
            val_45 = null;
            val_45 = null;
            val_47 = ActivityPost.<>c.<>9__73_0;
            if(val_47 == null)
            {
                goto label_6;
            }
            
            if(val_39 != null)
            {
                goto label_11;
            }
            
            goto label_8;
            label_6:
            val_47 = null;
            val_47 = new System.Converter<UnityEngine.AndroidJavaObject, GetSocialSdk.Core.Mention>(object:  ActivityPost.<>c.__il2cppRuntimeField_static_fields, method:  GetSocialSdk.Core.Mention ActivityPost.<>c::<ParseFromAJO>b__73_0(UnityEngine.AndroidJavaObject mentionAjo));
            ActivityPost.<>c.<>9__73_0 = val_47;
            if(val_39 != null)
            {
                goto label_11;
            }
            
            label_8:
            label_11:
            this.<Mentions>k__BackingField = System.Linq.Enumerable.ToList<GetSocialSdk.Core.Mention>(source:  val_39.ConvertAll<GetSocialSdk.Core.Mention>(converter:  null));
            if(ajo != null)
            {
                    var val_44 = 0;
                val_44 = val_44 + 1;
                ajo.Dispose();
            }
            
            if(430 == 430)
            {
                    return (GetSocialSdk.Core.ActivityPost)this;
            }
            
            if(0 == 0)
            {
                    return (GetSocialSdk.Core.ActivityPost)this;
            }
            
            return (GetSocialSdk.Core.ActivityPost)this;
        }
    
    }

}
