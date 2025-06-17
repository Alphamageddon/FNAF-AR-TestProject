using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class PostAuthor : PublicUser, IConvertableFromNative<GetSocialSdk.Core.PostAuthor>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsVerified>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsVerified { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsVerified()
        {
            return (bool)this.<IsVerified>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsVerified(bool value)
        {
            this.<IsVerified>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[4];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(X21 != 0)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(X21 == 0)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = null;
            val_1[1] = null;
            val_1[2] = GetSocialSdk.Core.DebugUtils.ToDebugString<System.String, System.String>(dictionary:  X21);
            val_1[3] = this.<IsVerified>k__BackingField;
            return (string)System.String.Format(format:  "[PostAuthor: Id={0}, DisplayName={1}, Identities={2}, IsVerified={3}]", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PostAuthor()
        {
            val_1 = new System.Object();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal PostAuthor(System.Collections.Generic.Dictionary<string, string> publicProperties, string id, string displayName, string avatarUrl, System.Collections.Generic.Dictionary<string, string> identities, bool isVerified)
        {
            val_1 = new System.Object();
            mem[1152921525987273352] = identities;
            mem[1152921525987273360] = publicProperties;
            mem[1152921525987273328] = val_1;
            mem[1152921525987273336] = displayName;
            mem[1152921525987273344] = avatarUrl;
            this.<IsVerified>k__BackingField = isVerified;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool Equals(GetSocialSdk.Core.PostAuthor other)
        {
            var val_5;
            if((other.Equals(other:  other)) != false)
            {
                    var val_3 = ((other.<IsVerified>k__BackingField) == true) ? 1 : 0;
                val_3 = (((this.<IsVerified>k__BackingField) == true) ? 1 : 0) ^ val_3;
                val_5 = val_3 ^ 1;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
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
            int val_2 = this.<IsVerified>k__BackingField.GetHashCode();
            val_2 = val_2 ^ (this.GetHashCode() * 397);
            return (int)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.PostAuthor ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            GetSocialSdk.Core.PublicUser val_1 = this.ParseFromAJO(ajo:  ajo);
            this.<IsVerified>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  ajo, methodName:  "isVerified", args:  System.Array.Empty<System.Object>());
            if(ajo != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                ajo.Dispose();
            }
            
            if(44 == 44)
            {
                    return (GetSocialSdk.Core.PostAuthor)this;
            }
            
            if(0 == 0)
            {
                    return (GetSocialSdk.Core.PostAuthor)this;
            }
            
            return (GetSocialSdk.Core.PostAuthor)this;
        }
    
    }

}
