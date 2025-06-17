using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class InviteContent : IConvertableToNative
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Subject>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Text>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.MediaAttachment _mediaAttachment;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Subject { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Text { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ImageUrl { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D Image { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] Video { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.InviteContent.Builder CreateBuilder()
        {
            return (Builder)new InviteContent.Builder();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Subject()
        {
            return (string)this.<Subject>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Subject(string value)
        {
            this.<Subject>k__BackingField = value;
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
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D get_Image()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public byte[] get_Video()
        {
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return (string)System.String.Format(format:  "[InviteContent: Subject={0}, Text={1}, HasAttachment={2}]", arg0:  this.<Subject>k__BackingField, arg1:  this.<Text>k__BackingField, arg2:  (this._mediaAttachment != 0) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            T[] val_11 = System.Array.Empty<System.Object>();
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "im.getsocial.sdk.invites.InviteContent$Builder", args:  val_11 = System.Array.Empty<System.Object>());
            if((this.<Subject>k__BackingField) != null)
            {
                    object[] val_3 = new object[1];
                val_11 = val_3;
                val_11[0] = this.<Subject>k__BackingField;
                UnityEngine.AndroidJavaObject val_4 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "withSubject", args:  val_3);
            }
            
            if((this.<Text>k__BackingField) != null)
            {
                    object[] val_5 = new object[1];
                val_11 = val_5;
                val_11[0] = this.<Text>k__BackingField;
                UnityEngine.AndroidJavaObject val_6 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "withText", args:  val_5);
            }
            
            if(this._mediaAttachment == null)
            {
                    return GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "build", args:  System.Array.Empty<System.Object>());
            }
            
            object[] val_7 = new object[1];
            val_11 = this._mediaAttachment.ToAjo();
            val_7[0] = val_11;
            UnityEngine.AndroidJavaObject val_9 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "withMediaAttachment", args:  val_7);
            return GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "build", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InviteContent()
        {
        
        }
    
    }

}
