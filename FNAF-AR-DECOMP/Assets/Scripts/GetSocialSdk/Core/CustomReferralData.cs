using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class CustomReferralData : Dictionary<string, string>, IConvertableFromNative<GetSocialSdk.Core.CustomReferralData>, IConvertableToNative
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CustomReferralData()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CustomReferralData(System.Collections.Generic.Dictionary<string, string> data)
        {
            System.Collections.Generic.Dictionary<System.String, System.String> val_1 = data;
            val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>(dictionary:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public CustomReferralData(System.Collections.Generic.IDictionary<string, object> data)
        {
            var val_7;
            var val_8;
            string val_12;
            var val_13;
            val_8 = data;
            if(val_8 == null)
            {
                    return;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_8 = val_8.GetEnumerator();
            label_19:
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(val_8.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            T val_6 = val_8.Current;
            if(val_6 != 0)
            {
                    var val_8 = (val_6 == null) ? () : 0;
            }
            else
            {
                    val_12 = 0;
            }
            
            this.set_Item(key:  val_6.emailUIDataHandler, value:  val_12);
            goto label_19;
            label_11:
            val_13 = 0;
            val_7 = 71;
            if(val_8 == null)
            {
                
            }
            else
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_8.Dispose();
            }
            
            if( == 71)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return System.String.Format(format:  "[CustomReferralData: {0}]", arg0:  GetSocialSdk.Core.DebugUtils.ToDebugString<System.String, System.String>(dictionary:  this));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool Equals(GetSocialSdk.Core.CustomReferralData other)
        {
            return GetSocialSdk.Core.Collections.DictionaryEquals<System.String, System.String>(self:  this, other:  other);
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
            return this.GetHashCode();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            object[] val_1 = new object[1];
            UnityEngine.AndroidJavaObject val_2 = GetSocialSdk.Core.JniUtils.ToJavaHashMap<System.String, System.String>(dictionary:  this);
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject(className:  "im.getsocial.sdk.invites.CustomReferralData", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.CustomReferralData ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            new GetSocialSdk.Core.CustomReferralData() = new GetSocialSdk.Core.CustomReferralData(data:  GetSocialSdk.Core.JniUtils.FromJavaHashMap(javaHashMap:  ajo));
            if(ajo != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                ajo.Dispose();
            }
            
            if(26 == 26)
            {
                    return (GetSocialSdk.Core.CustomReferralData)new GetSocialSdk.Core.CustomReferralData();
            }
            
            if(0 == 0)
            {
                    return (GetSocialSdk.Core.CustomReferralData)new GetSocialSdk.Core.CustomReferralData();
            }
            
            return (GetSocialSdk.Core.CustomReferralData)new GetSocialSdk.Core.CustomReferralData();
        }
    
    }

}
