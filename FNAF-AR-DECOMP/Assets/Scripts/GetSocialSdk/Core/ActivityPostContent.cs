using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class ActivityPostContent : IConvertableToNative
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _text;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _buttonTitle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _buttonAction;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.MediaAttachment _mediaAttachment;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.GetSocialAction _action;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ActivityPostContent()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.ActivityPostContent.Builder CreateBuilder()
        {
            return (Builder)new ActivityPostContent.Builder();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            T[] val_14 = System.Array.Empty<System.Object>();
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "im.getsocial.sdk.activities.ActivityPostContent$Builder", args:  val_14 = System.Array.Empty<System.Object>());
            if(this._text != null)
            {
                    object[] val_3 = new object[1];
                val_14 = val_3;
                val_14[0] = this._text;
                UnityEngine.AndroidJavaObject val_4 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "withText", args:  val_3);
            }
            
            if(this._buttonTitle != null)
            {
                    if(this._buttonAction != null)
            {
                    object[] val_5 = new object[2];
                val_14 = val_5;
                val_14[0] = this._buttonTitle;
                val_14[1] = this._buttonAction;
                UnityEngine.AndroidJavaObject val_6 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "withButton", args:  val_5);
            }
            
                if(this._action != null)
            {
                    object[] val_7 = new object[2];
                val_14 = val_7;
                val_14[0] = this._buttonTitle;
                val_14[1] = this._action.ToAjo();
                UnityEngine.AndroidJavaObject val_9 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "withButton", args:  val_7);
            }
            
            }
            
            if(this._mediaAttachment == null)
            {
                    return GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "build", args:  System.Array.Empty<System.Object>());
            }
            
            object[] val_10 = new object[1];
            val_14 = this._mediaAttachment.ToAjo();
            val_10[0] = val_14;
            UnityEngine.AndroidJavaObject val_12 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "withMediaAttachment", args:  val_10);
            return GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "build", args:  System.Array.Empty<System.Object>());
        }
    
    }

}
