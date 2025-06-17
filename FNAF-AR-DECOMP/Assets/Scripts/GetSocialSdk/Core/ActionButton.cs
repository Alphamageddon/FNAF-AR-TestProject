using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class ActionButton : IConvertableToNative, IConvertableFromNative<GetSocialSdk.Core.ActionButton>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string ConsumeAction = "consume";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string IgnoreAction = "ignore";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Title>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Id>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Title { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Title()
        {
            return (string)this.<Title>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Title(string value)
        {
            this.<Title>k__BackingField = value;
        }
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
        public ActionButton()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.ActionButton Create(string title, string actionId)
        {
            GetSocialSdk.Core.ActionButton val_1 = new GetSocialSdk.Core.ActionButton();
            if(val_1 != null)
            {
                    .<Title>k__BackingField = title;
            }
            else
            {
                    mem[16] = title;
            }
            
            .<Id>k__BackingField = actionId;
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool Equals(GetSocialSdk.Core.ActionButton other)
        {
            if((System.String.Equals(a:  this.<Title>k__BackingField, b:  other.<Title>k__BackingField)) == false)
            {
                    return false;
            }
            
            return System.String.Equals(a:  this.<Id>k__BackingField, b:  other.<Id>k__BackingField);
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
            var val_2;
            if((this.<Title>k__BackingField) != null)
            {
                    val_2 = (this.<Title>k__BackingField) * 397;
            }
            else
            {
                    val_2 = 0;
            }
            
            string val_1 = this.<Id>k__BackingField;
            val_1 = val_1 ^ val_2;
            return (int)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return System.String.Format(format:  "Title: {0}, Id: {1}", arg0:  this.<Title>k__BackingField, arg1:  this.<Id>k__BackingField);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            object[] val_2 = new object[2];
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if((this.<Title>k__BackingField) != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if((this.<Title>k__BackingField) == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = this.<Title>k__BackingField;
            val_2[1] = this.<Id>k__BackingField;
            return GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.pushnotifications.ActionButton"), methodName:  "create", args:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.ActionButton ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            this.<Title>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getTitle", args:  System.Array.Empty<System.Object>());
            this.<Id>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getId", args:  System.Array.Empty<System.Object>());
            return (GetSocialSdk.Core.ActionButton)this;
        }
    
    }

}
