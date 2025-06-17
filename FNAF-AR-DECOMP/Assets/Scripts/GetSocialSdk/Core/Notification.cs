using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Notification : IConvertableFromNative<GetSocialSdk.Core.Notification>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Id>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.GetSocialAction <NotificationAction>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GetSocialSdk.Core.ActionButton> <ActionButtons>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.Notification.Type <Action>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Status>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <NotificationType>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private long <CreatedAt>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Title>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Text>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ImageUrl>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <VideoUrl>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.UserReference <Sender>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.GetSocialAction NotificationAction { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GetSocialSdk.Core.ActionButton> ActionButtons { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.Notification.Type Action { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> ActionData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool WasRead { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Status { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string NotificationType { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long CreatedAt { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Title { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Text { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ImageUrl { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string VideoUrl { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.UserReference Sender { get; set; }
        
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
        public GetSocialSdk.Core.GetSocialAction get_NotificationAction()
        {
            return (GetSocialSdk.Core.GetSocialAction)this.<NotificationAction>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_NotificationAction(GetSocialSdk.Core.GetSocialAction value)
        {
            this.<NotificationAction>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GetSocialSdk.Core.ActionButton> get_ActionButtons()
        {
            return (System.Collections.Generic.List<GetSocialSdk.Core.ActionButton>)this.<ActionButtons>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ActionButtons(System.Collections.Generic.List<GetSocialSdk.Core.ActionButton> value)
        {
            this.<ActionButtons>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.Notification.Type get_Action()
        {
            return (Type)this.<Action>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Action(GetSocialSdk.Core.Notification.Type value)
        {
            this.<Action>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> get_ActionData()
        {
            if((this.<NotificationAction>k__BackingField) != null)
            {
                    return this.<NotificationAction>k__BackingField.Data;
            }
            
            return this.<NotificationAction>k__BackingField.Data;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_WasRead()
        {
            bool val_1 = this.<Status>k__BackingField.Equals(value:  "unread");
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Status()
        {
            return (string)this.<Status>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Status(string value)
        {
            this.<Status>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_NotificationType()
        {
            return (string)this.<NotificationType>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_NotificationType(string value)
        {
            this.<NotificationType>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public long get_CreatedAt()
        {
            return (long)this.<CreatedAt>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_CreatedAt(long value)
        {
            this.<CreatedAt>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Title()
        {
            return (string)this.<Title>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Title(string value)
        {
            this.<Title>k__BackingField = value;
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
        public string get_VideoUrl()
        {
            return (string)this.<VideoUrl>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_VideoUrl(string value)
        {
            this.<VideoUrl>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.UserReference get_Sender()
        {
            return (GetSocialSdk.Core.UserReference)this.<Sender>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Sender(GetSocialSdk.Core.UserReference value)
        {
            this.<Sender>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[11];
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
            val_1[1] = this.<NotificationAction>k__BackingField;
            val_1[2] = GetSocialSdk.Core.DebugUtils.ToDebugString<GetSocialSdk.Core.ActionButton>(list:  this.<ActionButtons>k__BackingField);
            val_1[3] = this.<Status>k__BackingField;
            val_1[4] = this.<NotificationType>k__BackingField;
            val_1[5] = this.<CreatedAt>k__BackingField;
            val_1[6] = this.<Title>k__BackingField;
            val_1[7] = this.<Text>k__BackingField;
            val_1[8] = this.<ImageUrl>k__BackingField;
            val_1[9] = this.<VideoUrl>k__BackingField;
            val_1[10] = this.<Sender>k__BackingField;
            return (string)System.String.Format(format:  "Id: {0}, Action: {1}, ActionButtons: {2}, Status: {3}, NotificationType: {4}, CreatedAt: {5}, Title: {6}, Text: {7}, ImageUrl: {8}, VideoUrl: {9}, Sender: {10}", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.Notification ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            var val_32;
            this.<Id>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getId", args:  System.Array.Empty<System.Object>());
            this.<Status>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getStatus", args:  System.Array.Empty<System.Object>());
            this.<NotificationType>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getType", args:  System.Array.Empty<System.Object>());
            this.<Action>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallInt(ajo:  ajo, methodName:  "getActionType", args:  System.Array.Empty<System.Object>());
            this.<CreatedAt>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallLong(ajo:  ajo, methodName:  "getCreatedAt", args:  System.Array.Empty<System.Object>());
            this.<Title>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getTitle", args:  System.Array.Empty<System.Object>());
            this.<Text>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getText", args:  System.Array.Empty<System.Object>());
            this.<NotificationAction>k__BackingField = new GetSocialSdk.Core.GetSocialAction().ParseFromAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getAction", args:  System.Array.Empty<System.Object>()));
            System.Collections.Generic.List<UnityEngine.AndroidJavaObject> val_21 = GetSocialSdk.Core.JniUtils.FromJavaList(javaList:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getActionButtons", args:  System.Array.Empty<System.Object>()));
            val_32 = null;
            val_32 = null;
            if((Notification.<>c.<>9__56_0) == null)
            {
                goto label_4;
            }
            
            label_10:
            this.<ActionButtons>k__BackingField = val_21.ConvertAll<GetSocialSdk.Core.ActionButton>(converter:  Notification.<>c.<>9__56_0);
            this.<ImageUrl>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getImageUrl", args:  System.Array.Empty<System.Object>());
            this.<VideoUrl>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getVideoUrl", args:  System.Array.Empty<System.Object>());
            this.<Sender>k__BackingField = new GetSocialSdk.Core.UserReference().ParseFromAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getSender", args:  System.Array.Empty<System.Object>()));
            return (GetSocialSdk.Core.Notification)this;
            label_4:
            Notification.<>c.<>9__56_0 = new System.Converter<UnityEngine.AndroidJavaObject, GetSocialSdk.Core.ActionButton>(object:  Notification.<>c.__il2cppRuntimeField_static_fields, method:  GetSocialSdk.Core.ActionButton Notification.<>c::<ParseFromAJO>b__56_0(UnityEngine.AndroidJavaObject item));
            if(val_21 != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Notification()
        {
        
        }
    
    }

}
