using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class InvitePackage : IConvertableFromNative<GetSocialSdk.Core.InvitePackage>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Subject>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Text>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <UserName>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ReferralDataUrl>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D <Image>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ImageUrl>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Subject { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Text { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string UserName { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ReferralDataUrl { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D Image { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ImageUrl { get; set; }
        
        // Methods
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
        public string get_UserName()
        {
            return (string)this.<UserName>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_UserName(string value)
        {
            this.<UserName>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ReferralDataUrl()
        {
            return (string)this.<ReferralDataUrl>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ReferralDataUrl(string value)
        {
            this.<ReferralDataUrl>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Texture2D get_Image()
        {
            return (UnityEngine.Texture2D)this.<Image>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Image(UnityEngine.Texture2D value)
        {
            this.<Image>k__BackingField = value;
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
        public InvitePackage()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal InvitePackage(string subject, string text, string userName, string referralDataUrl, UnityEngine.Texture2D image, string imageUrl)
        {
            val_1 = new System.Object();
            this.<Subject>k__BackingField = subject;
            this.<Text>k__BackingField = val_1;
            this.<UserName>k__BackingField = userName;
            this.<ReferralDataUrl>k__BackingField = referralDataUrl;
            this.<Image>k__BackingField = image;
            this.<ImageUrl>k__BackingField = imageUrl;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[6];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if((this.<Subject>k__BackingField) != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if((this.<Subject>k__BackingField) == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.<Subject>k__BackingField;
            val_1[1] = this.<Text>k__BackingField;
            val_1[2] = this.<UserName>k__BackingField;
            val_1[3] = UnityEngine.Object.op_Inequality(x:  this.<Image>k__BackingField, y:  0);
            val_1[4] = this.<ImageUrl>k__BackingField;
            val_1[5] = this.<ReferralDataUrl>k__BackingField;
            return (string)System.String.Format(format:  "[InvitePackage: Subject={0}, Text={1}, UserName={2}, HasImage={3}, ImageUrl={4}, ReferralDataUrl={5}]", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool Equals(GetSocialSdk.Core.InvitePackage other)
        {
            if((System.String.Equals(a:  this.<Subject>k__BackingField, b:  other.<Subject>k__BackingField)) == false)
            {
                    return false;
            }
            
            if((System.String.Equals(a:  this.<Text>k__BackingField, b:  other.<Text>k__BackingField)) == false)
            {
                    return false;
            }
            
            if((System.String.Equals(a:  this.<UserName>k__BackingField, b:  other.<UserName>k__BackingField)) == false)
            {
                    return false;
            }
            
            if((System.String.Equals(a:  this.<ReferralDataUrl>k__BackingField, b:  other.<ReferralDataUrl>k__BackingField)) == false)
            {
                    return false;
            }
            
            if((GetSocialSdk.Core.Collections.Texture2DEquals(self:  this.<Image>k__BackingField, other:  other.<Image>k__BackingField)) == false)
            {
                    return false;
            }
            
            return System.String.Equals(a:  this.<ImageUrl>k__BackingField, b:  other.<ImageUrl>k__BackingField);
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
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            UnityEngine.Object val_8;
            var val_9;
            if((this.<Subject>k__BackingField) != null)
            {
                    val_4 = (this.<Subject>k__BackingField) * 397;
            }
            else
            {
                    val_4 = 0;
            }
            
            if((this.<Text>k__BackingField) != null)
            {
                    val_5 = this.<Text>k__BackingField;
            }
            else
            {
                    val_5 = 0;
            }
            
            val_5 = val_5 ^ val_4;
            val_4 = val_5 * 397;
            if((this.<UserName>k__BackingField) != null)
            {
                    val_6 = this.<UserName>k__BackingField;
            }
            else
            {
                    val_6 = 0;
            }
            
            if((this.<ReferralDataUrl>k__BackingField) != null)
            {
                    val_7 = this.<ReferralDataUrl>k__BackingField;
            }
            else
            {
                    val_7 = 0;
            }
            
            var val_2 = val_6 ^ val_4 * 397;
            val_8 = 0;
            val_2 = val_7 ^ val_2 * 397;
            if((this.<Image>k__BackingField) != val_8)
            {
                    val_9 = this.<Image>k__BackingField;
            }
            else
            {
                    val_9 = 0;
            }
            
            string val_6 = this.<ImageUrl>k__BackingField;
            val_9 = val_9 ^ val_2;
            val_6 = val_6 ^ (val_9 * 397);
            return (int)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.InvitePackage ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            GetSocialSdk.Core.JniUtils.CheckIfClassIsCorrect(ajo:  ajo, expectedSimpleClassName:  "InvitePackage");
            this.<Subject>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getSubject", args:  System.Array.Empty<System.Object>());
            this.<Text>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getText", args:  System.Array.Empty<System.Object>());
            this.<UserName>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getUserName", args:  System.Array.Empty<System.Object>());
            this.<ReferralDataUrl>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getReferralUrl", args:  System.Array.Empty<System.Object>());
            this.<Image>k__BackingField = GetSocialSdk.Core.JniUtils.FromAndroidBitmap(bitmapAJO:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getImage", args:  System.Array.Empty<System.Object>()));
            this.<ImageUrl>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getImageUrl", args:  System.Array.Empty<System.Object>());
            if(ajo != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                ajo.Dispose();
            }
            
            if(162 == 162)
            {
                    return (GetSocialSdk.Core.InvitePackage)this;
            }
            
            if(0 == 0)
            {
                    return (GetSocialSdk.Core.InvitePackage)this;
            }
            
            return (GetSocialSdk.Core.InvitePackage)this;
        }
    
    }

}
