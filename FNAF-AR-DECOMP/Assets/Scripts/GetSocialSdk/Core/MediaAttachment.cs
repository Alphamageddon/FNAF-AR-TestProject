using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class MediaAttachment : IConvertableToNative
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly string _method;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly object _object;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MediaAttachment(string method, object obj)
        {
            val_1 = new System.Object();
            this._method = method;
            this._object = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.MediaAttachment Image(UnityEngine.Texture2D texture)
        {
            UnityEngine.Object val_4;
            var val_5;
            val_4 = texture;
            val_5 = 0;
            if(val_4 == 0)
            {
                    return (GetSocialSdk.Core.MediaAttachment)val_5;
            }
            
            val_4 = GetSocialSdk.Core.JniUtils.ToAjoBitmap(texture2D:  val_4);
            GetSocialSdk.Core.MediaAttachment val_3 = null;
            val_5 = val_3;
            val_3 = new GetSocialSdk.Core.MediaAttachment();
            ._method = "image";
            ._object = val_4;
            return (GetSocialSdk.Core.MediaAttachment)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.MediaAttachment ImageUrl(string imageUrl)
        {
            var val_2;
            if(imageUrl != null)
            {
                    GetSocialSdk.Core.MediaAttachment val_1 = null;
                val_2 = val_1;
                val_1 = new GetSocialSdk.Core.MediaAttachment();
                ._method = "imageUrl";
                ._object = imageUrl;
                return (GetSocialSdk.Core.MediaAttachment)val_2;
            }
            
            val_2 = 0;
            return (GetSocialSdk.Core.MediaAttachment)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.MediaAttachment Video(byte[] video)
        {
            var val_2;
            if(video != null)
            {
                    GetSocialSdk.Core.MediaAttachment val_1 = null;
                val_2 = val_1;
                val_1 = new GetSocialSdk.Core.MediaAttachment();
                ._method = "video";
                ._object = video;
                return (GetSocialSdk.Core.MediaAttachment)val_2;
            }
            
            val_2 = 0;
            return (GetSocialSdk.Core.MediaAttachment)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.MediaAttachment VideoUrl(string videoUrl)
        {
            var val_2;
            if(videoUrl != null)
            {
                    GetSocialSdk.Core.MediaAttachment val_1 = null;
                val_2 = val_1;
                val_1 = new GetSocialSdk.Core.MediaAttachment();
                ._method = "videoUrl";
                ._object = videoUrl;
                return (GetSocialSdk.Core.MediaAttachment)val_2;
            }
            
            val_2 = 0;
            return (GetSocialSdk.Core.MediaAttachment)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if(this._object != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this._object == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = this._object;
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.media.MediaAttachment"), methodName:  this._method, args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static object Convert(UnityEngine.Texture2D texture)
        {
            return GetSocialSdk.Core.JniUtils.ToAjoBitmap(texture2D:  texture);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static object Convert(byte[] video)
        {
            return (object)video;
        }
    
    }

}
