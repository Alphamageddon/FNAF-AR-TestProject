using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UserReference : IConvertableFromNative<GetSocialSdk.Core.UserReference>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Id>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <DisplayName>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <AvatarUrl>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DisplayName { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AvatarUrl { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Id()
        {
            return (string)this.<Id>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_Id(string value)
        {
            this.<Id>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_DisplayName()
        {
            return (string)this.<DisplayName>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_DisplayName(string value)
        {
            this.<DisplayName>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_AvatarUrl()
        {
            return (string)this.<AvatarUrl>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_AvatarUrl(string value)
        {
            this.<AvatarUrl>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.UserReference ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            if(ajo != null)
            {
                    this.<Id>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getId", args:  System.Array.Empty<System.Object>());
                this.<DisplayName>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getDisplayName", args:  System.Array.Empty<System.Object>());
                this.<AvatarUrl>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getAvatarUrl", args:  System.Array.Empty<System.Object>());
                return (GetSocialSdk.Core.UserReference)this;
            }
            
            this = 0;
            return (GetSocialSdk.Core.UserReference)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UserReference()
        {
        
        }
    
    }

}
