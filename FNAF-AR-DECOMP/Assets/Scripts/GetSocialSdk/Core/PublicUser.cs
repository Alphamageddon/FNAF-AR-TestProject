using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PublicUser : IConvertableFromNative<GetSocialSdk.Core.PublicUser>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Id>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <DisplayName>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <AvatarUrl>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, string> <Identities>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, string> _publicProperties;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DisplayName { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string AvatarUrl { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> Identities { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> AllPublicProperties { get; }
        
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
        public System.Collections.Generic.Dictionary<string, string> get_Identities()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)this.<Identities>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_Identities(System.Collections.Generic.Dictionary<string, string> value)
        {
            this.<Identities>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> get_AllPublicProperties()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)new System.Collections.Generic.Dictionary<System.String, System.String>(dictionary:  this._publicProperties);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[4];
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
            val_1[1] = this.<DisplayName>k__BackingField;
            val_1[2] = GetSocialSdk.Core.DebugUtils.ToDebugString<System.String, System.String>(dictionary:  this.<Identities>k__BackingField);
            val_1[3] = GetSocialSdk.Core.DebugUtils.ToDebugString<System.String, System.String>(dictionary:  this._publicProperties);
            return System.String.Format(format:  "[PublicUser: Id={0}, DisplayName={1}, Identities={2}, PublicProperties={3}]", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PublicUser()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal PublicUser(System.Collections.Generic.Dictionary<string, string> publicProperties, string id, string displayName, string avatarUrl, System.Collections.Generic.Dictionary<string, string> identities)
        {
            val_1 = new System.Object();
            this.<Identities>k__BackingField = identities;
            this._publicProperties = publicProperties;
            this.<Id>k__BackingField = val_1;
            this.<DisplayName>k__BackingField = displayName;
            this.<AvatarUrl>k__BackingField = avatarUrl;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool Equals(GetSocialSdk.Core.PublicUser other)
        {
            if((GetSocialSdk.Core.Collections.DictionaryEquals<System.String, System.String>(self:  this._publicProperties, other:  other._publicProperties)) == false)
            {
                    return false;
            }
            
            if((System.String.Equals(a:  this.<Id>k__BackingField, b:  other.<Id>k__BackingField)) == false)
            {
                    return false;
            }
            
            if((System.String.Equals(a:  this.<DisplayName>k__BackingField, b:  other.<DisplayName>k__BackingField)) == false)
            {
                    return false;
            }
            
            if((System.String.Equals(a:  this.<AvatarUrl>k__BackingField, b:  other.<AvatarUrl>k__BackingField)) == false)
            {
                    return false;
            }
            
            return GetSocialSdk.Core.Collections.DictionaryEquals<System.String, System.String>(self:  this.<Identities>k__BackingField, other:  other.<Identities>k__BackingField);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Equals(object obj)
        {
            System.Type val_8;
            GetSocialSdk.Core.PublicUser val_9;
            var val_10;
            val_9 = obj;
            if(val_9 == null)
            {
                goto label_1;
            }
            
            if(this == val_9)
            {
                goto label_2;
            }
            
            val_8 = val_9.GetType();
            if((System.Type.op_Inequality(left:  val_8, right:  this.GetType())) == false)
            {
                goto label_5;
            }
            
            label_1:
            val_10 = 0;
            return (bool)this.Equals(other:  val_9 = 0);
            label_2:
            val_10 = 1;
            return (bool)this.Equals(other:  val_9);
            label_5:
            val_10 = this;
            return (bool)this.Equals(other:  val_9);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override int GetHashCode()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            if(this._publicProperties != null)
            {
                    val_4 = public System.Int32 System.Object::GetHashCode();
                val_5 = this._publicProperties.GetHashCode() * 397;
            }
            else
            {
                    val_5 = 0;
            }
            
            if((this.<Id>k__BackingField) != null)
            {
                    val_6 = this.<Id>k__BackingField;
            }
            else
            {
                    val_6 = 0;
            }
            
            val_6 = val_6 ^ val_5;
            if((this.<DisplayName>k__BackingField) != null)
            {
                    val_7 = this.<DisplayName>k__BackingField;
            }
            else
            {
                    val_7 = 0;
            }
            
            val_7 = val_7 ^ (val_6 * 397);
            if((this.<AvatarUrl>k__BackingField) != null)
            {
                    val_8 = this.<AvatarUrl>k__BackingField;
            }
            else
            {
                    val_8 = 0;
            }
            
            val_8 = val_8 ^ (val_7 * 397);
            if((this.<Identities>k__BackingField) != null)
            {
                    int val_5 = this.<Identities>k__BackingField.GetHashCode();
            }
            
            val_5 = val_5 ^ (val_8 * 397);
            return (int)val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.PublicUser ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            this.<Id>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getId", args:  System.Array.Empty<System.Object>());
            this.<DisplayName>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getDisplayName", args:  System.Array.Empty<System.Object>());
            this.<AvatarUrl>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getAvatarUrl", args:  System.Array.Empty<System.Object>());
            this.<Identities>k__BackingField = GetSocialSdk.Core.JniUtils.FromJavaHashMap(javaHashMap:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getIdentities", args:  System.Array.Empty<System.Object>()));
            this._publicProperties = GetSocialSdk.Core.JniUtils.FromJavaHashMap(javaHashMap:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getAllPublicProperties", args:  System.Array.Empty<System.Object>()));
            return (GetSocialSdk.Core.PublicUser)this;
        }
    
    }

}
