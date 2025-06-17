using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AuthIdentity : IConvertableToNative
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal readonly string ProviderId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal readonly string ProviderUserId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal readonly string AccessToken;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AuthIdentity(string providerName, string userId, string accessToken)
        {
            val_1 = new System.Object();
            this.ProviderId = providerName;
            this.ProviderUserId = val_1;
            this.AccessToken = accessToken;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.AuthIdentity CreateFacebookIdentity(string accessToken)
        {
            return GetSocialSdk.Core.AuthIdentity.CreateCustomIdentity(providerName:  "facebook", userId:  0, accessToken:  accessToken);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.AuthIdentity CreateCustomIdentity(string providerName, string userId, string accessToken)
        {
            .ProviderId = providerName;
            .ProviderUserId = userId;
            .AccessToken = accessToken;
            return (GetSocialSdk.Core.AuthIdentity)new GetSocialSdk.Core.AuthIdentity();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            object[] val_2 = new object[3];
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if(this.ProviderId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this.ProviderId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = this.ProviderId;
            val_2[1] = this.ProviderUserId;
            val_2[2] = this.AccessToken;
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.usermanagement.AuthIdentity"), methodName:  "createCustomIdentity", args:  val_2);
        }
    
    }

}
