using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class InviteChannel : IConvertableFromNative<GetSocialSdk.Core.InviteChannel>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Id>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Name>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <IconImageUrl>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int <DisplayOrder>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsEnabled>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string IconImageUrl { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int DisplayOrder { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsEnabled { get; set; }
        
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
        public string get_Name()
        {
            return (string)this.<Name>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Name(string value)
        {
            this.<Name>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_IconImageUrl()
        {
            return (string)this.<IconImageUrl>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IconImageUrl(string value)
        {
            this.<IconImageUrl>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_DisplayOrder()
        {
            return (int)this.<DisplayOrder>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_DisplayOrder(int value)
        {
            this.<DisplayOrder>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsEnabled()
        {
            return (bool)this.<IsEnabled>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsEnabled(bool value)
        {
            this.<IsEnabled>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal InviteChannel(string id, string name, string iconImageUrl, int displayOrder, bool isEnabled)
        {
            val_1 = new System.Object();
            this.<Id>k__BackingField = id;
            this.<Name>k__BackingField = val_1;
            this.<IconImageUrl>k__BackingField = iconImageUrl;
            this.<DisplayOrder>k__BackingField = displayOrder;
            this.<IsEnabled>k__BackingField = isEnabled;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InviteChannel()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[5];
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
            val_1[1] = this.<Name>k__BackingField;
            val_1[2] = this.<IconImageUrl>k__BackingField;
            val_1[3] = this.<DisplayOrder>k__BackingField;
            val_1[4] = this.<IsEnabled>k__BackingField;
            return (string)System.String.Format(format:  "[InviteChannel: Id={0}, Name={1}, IconImageUrl={2}, DisplayOrder={3}, IsEnabled={4}]", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool Equals(GetSocialSdk.Core.InviteChannel other)
        {
            var val_7;
            if(((System.String.Equals(a:  this.<Id>k__BackingField, b:  other.<Id>k__BackingField)) != false) && ((System.String.Equals(a:  this.<Name>k__BackingField, b:  other.<Name>k__BackingField)) != false))
            {
                    if(((System.String.Equals(a:  this.<IconImageUrl>k__BackingField, b:  other.<IconImageUrl>k__BackingField)) != false) && ((this.<DisplayOrder>k__BackingField) == (other.<DisplayOrder>k__BackingField)))
            {
                    var val_4 = ((this.<IsEnabled>k__BackingField) == true) ? 1 : 0;
                val_4 = val_4 ^ (((other.<IsEnabled>k__BackingField) == true) ? 1 : 0);
                val_7 = val_4 ^ 1;
                return (bool)val_7;
            }
            
            }
            
            val_7 = 0;
            return (bool)val_7;
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
            if((this.<Id>k__BackingField) != null)
            {
                    val_4 = (this.<Id>k__BackingField) * 397;
            }
            else
            {
                    val_4 = 0;
            }
            
            if((this.<Name>k__BackingField) != null)
            {
                    val_5 = this.<Name>k__BackingField;
            }
            else
            {
                    val_5 = 0;
            }
            
            val_5 = val_5 ^ val_4;
            if((this.<IconImageUrl>k__BackingField) != null)
            {
                    val_6 = this.<IconImageUrl>k__BackingField;
            }
            else
            {
                    val_6 = 0;
            }
            
            int val_2 = this.<IsEnabled>k__BackingField.GetHashCode();
            var val_3 = val_6 ^ (val_5 * 397);
            val_3 = val_3 * 397;
            val_3 = val_3 ^ (this.<DisplayOrder>k__BackingField);
            val_3 = val_3 * 397;
            val_2 = val_3 ^ val_2;
            return (int)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.InviteChannel ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            GetSocialSdk.Core.JniUtils.CheckIfClassIsCorrect(ajo:  ajo, expectedSimpleClassName:  "InviteChannel");
            this.<Id>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getChannelId", args:  System.Array.Empty<System.Object>());
            this.<Name>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getChannelName", args:  System.Array.Empty<System.Object>());
            this.<IconImageUrl>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getIconImageUrl", args:  System.Array.Empty<System.Object>());
            this.<DisplayOrder>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallInt(ajo:  ajo, methodName:  "getDisplayOrder", args:  System.Array.Empty<System.Object>());
            this.<IsEnabled>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  ajo, methodName:  "isEnabled", args:  System.Array.Empty<System.Object>());
            if(ajo != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                ajo.Dispose();
            }
            
            if(135 == 135)
            {
                    return (GetSocialSdk.Core.InviteChannel)this;
            }
            
            if(0 == 0)
            {
                    return (GetSocialSdk.Core.InviteChannel)this;
            }
            
            return (GetSocialSdk.Core.InviteChannel)this;
        }
    
    }

}
