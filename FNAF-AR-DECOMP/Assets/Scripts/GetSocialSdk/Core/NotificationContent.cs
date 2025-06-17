using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class NotificationContent : IConvertableToNative
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _text;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _title;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _templateName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.MediaAttachment _mediaAttachment;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, string> _templatePlaceholders;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.GetSocialAction _action;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<GetSocialSdk.Core.ActionButton> _actionButtons;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private NotificationContent()
        {
            this._templatePlaceholders = new System.Collections.Generic.Dictionary<System.String, System.String>();
            this._actionButtons = new System.Collections.Generic.List<GetSocialSdk.Core.ActionButton>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[5];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(this._title != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this._title == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this._title;
            val_1[1] = this._text;
            val_1[2] = this._action;
            val_1[3] = this._templateName;
            val_1[4] = GetSocialSdk.Core.DebugUtils.ToDebugString<System.String, System.String>(dictionary:  this._templatePlaceholders);
            return System.String.Format(format:  "Title: {0}, Text: {1}, Action: {2}, Template: {4}, TemplatePlaceholders: {5}", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.NotificationContent NotificationWithText(string text)
        {
            ._text = text;
            return (GetSocialSdk.Core.NotificationContent)new GetSocialSdk.Core.NotificationContent();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.NotificationContent NotificationFromTemplate(string templateName)
        {
            ._templateName = templateName;
            return (GetSocialSdk.Core.NotificationContent)new GetSocialSdk.Core.NotificationContent();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationContent WithTitle(string title)
        {
            this._title = title;
            return (GetSocialSdk.Core.NotificationContent)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationContent WithText(string text)
        {
            this._text = text;
            return (GetSocialSdk.Core.NotificationContent)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationContent WithTemplateName(string templateName)
        {
            this._templateName = templateName;
            return (GetSocialSdk.Core.NotificationContent)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationContent AddTemplatePlaceholder(string placeholder, string replacement)
        {
            this._templatePlaceholders.set_Item(key:  placeholder, value:  replacement);
            return (GetSocialSdk.Core.NotificationContent)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationContent AddTemplatePlaceholders(System.Collections.Generic.Dictionary<string, string> templateData)
        {
            GetSocialSdk.Core.Collections.AddAll<System.String, System.String>(container:  this._templatePlaceholders, items:  templateData);
            return (GetSocialSdk.Core.NotificationContent)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationContent WithMediaAttachment(GetSocialSdk.Core.MediaAttachment mediaAttachment)
        {
            this._mediaAttachment = mediaAttachment;
            return (GetSocialSdk.Core.NotificationContent)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationContent WithAction(GetSocialSdk.Core.GetSocialAction action)
        {
            this._action = action;
            return (GetSocialSdk.Core.NotificationContent)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationContent AddActionButton(GetSocialSdk.Core.ActionButton actionButton)
        {
            this._actionButtons.Add(item:  actionButton);
            return (GetSocialSdk.Core.NotificationContent)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.NotificationContent AddActionButtons(System.Collections.Generic.IEnumerable<GetSocialSdk.Core.ActionButton> actionButton)
        {
            GetSocialSdk.Core.Collections.AddAll<GetSocialSdk.Core.ActionButton>(container:  this._actionButtons, items:  actionButton);
            return (GetSocialSdk.Core.NotificationContent)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            System.Object[] val_22;
            System.Object[] val_23;
            var val_24;
            val_22 = this;
            object[] val_2 = new object[1];
            val_2[0] = this._text;
            object[] val_4 = new object[1];
            val_4[0] = this._title;
            object[] val_6 = new object[1];
            val_6[0] = this._templateName;
            object[] val_8 = new object[1];
            val_8[0] = GetSocialSdk.Core.JniUtils.ToJavaHashMap<System.String, System.String>(dictionary:  this._templatePlaceholders);
            object[] val_11 = new object[1];
            val_23 = val_11;
            val_24 = null;
            val_24 = null;
            if((NotificationContent.<>c.<>9__20_0) == null)
            {
                goto label_19;
            }
            
            label_40:
            val_23[0] = GetSocialSdk.Core.JniUtils.ToJavaList<UnityEngine.AndroidJavaObject>(list:  this._actionButtons.ConvertAll<UnityEngine.AndroidJavaObject>(converter:  NotificationContent.<>c.<>9__20_0));
            UnityEngine.AndroidJavaObject val_14 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.pushnotifications.NotificationContent"), methodName:  "notificationWithText", args:  val_2), methodName:  "withTitle", args:  val_4), methodName:  "withTemplateName", args:  val_6), methodName:  "addTemplatePlaceholders", args:  val_8), methodName:  "addActionButtons", args:  val_11);
            if(this._action != null)
            {
                    object[] val_15 = new object[1];
                val_23 = val_15;
                val_23[0] = this._action.ToAjo();
                UnityEngine.AndroidJavaObject val_17 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_14, methodName:  "withAction", args:  val_15);
            }
            
            if(this._mediaAttachment == null)
            {
                    return val_14;
            }
            
            object[] val_18 = new object[1];
            val_22 = val_18;
            val_23 = this._mediaAttachment.ToAjo();
            val_22[0] = val_23;
            UnityEngine.AndroidJavaObject val_20 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_14, methodName:  "withMediaAttachment", args:  val_18);
            return val_14;
            label_19:
            NotificationContent.<>c.<>9__20_0 = new System.Converter<GetSocialSdk.Core.ActionButton, UnityEngine.AndroidJavaObject>(object:  NotificationContent.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.AndroidJavaObject NotificationContent.<>c::<ToAjo>b__20_0(GetSocialSdk.Core.ActionButton item));
            if(this._actionButtons != null)
            {
                goto label_40;
            }
            
            goto label_40;
        }
    
    }

}
