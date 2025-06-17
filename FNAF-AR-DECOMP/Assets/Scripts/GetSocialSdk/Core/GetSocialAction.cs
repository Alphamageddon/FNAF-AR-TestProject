using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GetSocialAction : IConvertableToNative, IConvertableFromNative<GetSocialSdk.Core.GetSocialAction>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Type>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, string> <Data>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Type { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> Data { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Type()
        {
            return (string)this.<Type>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Type(string value)
        {
            this.<Type>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> get_Data()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)this.<Data>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Data(System.Collections.Generic.Dictionary<string, string> value)
        {
            this.<Data>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal GetSocialAction()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return System.String.Format(format:  "Type: {0}, Data: {1}", arg0:  this.<Type>k__BackingField, arg1:  GetSocialSdk.Core.DebugUtils.ToDebugString<System.String, System.String>(dictionary:  this.<Data>k__BackingField));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool Equals(GetSocialSdk.Core.GetSocialAction other)
        {
            if((System.String.Equals(a:  this.<Type>k__BackingField, b:  other.<Type>k__BackingField)) == false)
            {
                    return false;
            }
            
            return System.Object.Equals(objA:  this.<Data>k__BackingField, objB:  other.<Data>k__BackingField);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override bool Equals(object obj)
        {
            System.Type val_8;
            GetSocialSdk.Core.GetSocialAction val_9;
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
            var val_3;
            if((this.<Type>k__BackingField) != null)
            {
                    val_3 = (this.<Type>k__BackingField) * 397;
            }
            else
            {
                    val_3 = 0;
            }
            
            if((this.<Data>k__BackingField) != null)
            {
                    int val_1 = this.<Data>k__BackingField.GetHashCode();
            }
            
            val_1 = val_1 ^ val_3;
            return (int)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialAction(string type, System.Collections.Generic.Dictionary<string, string> data)
        {
            val_1 = new System.Object();
            this.<Type>k__BackingField = type;
            this.<Data>k__BackingField = new System.Collections.Generic.Dictionary<System.String, System.String>(dictionary:  System.Collections.Generic.Dictionary<System.String, System.String> val_1 = data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.GetSocialAction.Builder CreateBuilder(string type)
        {
            return (Builder)new GetSocialAction.Builder(type:  type);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            object[] val_2 = new object[1];
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if((this.<Type>k__BackingField) != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if((this.<Type>k__BackingField) == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = this.<Type>k__BackingField;
            object[] val_4 = new object[1];
            UnityEngine.AndroidJavaObject val_5 = GetSocialSdk.Core.JniUtils.ToJavaHashMap<System.String, System.String>(dictionary:  this.<Data>k__BackingField);
            if(val_4 == null)
            {
                goto label_7;
            }
            
            if(val_5 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(val_5 == null)
            {
                goto label_11;
            }
            
            label_8:
            label_11:
            val_4[0] = val_5;
            return GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.actions.Action"), methodName:  "builder", args:  val_2), methodName:  "addActionData", args:  val_4), methodName:  "build", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.GetSocialAction ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            this.<Type>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getType", args:  System.Array.Empty<System.Object>());
            this.<Data>k__BackingField = GetSocialSdk.Core.JniUtils.FromJavaHashMap(javaHashMap:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getData", args:  System.Array.Empty<System.Object>()));
            return (GetSocialSdk.Core.GetSocialAction)this;
        }
    
    }

}
