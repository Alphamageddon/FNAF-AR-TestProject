using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class LinkParams : Dictionary<string, object>, IConvertableFromNative<GetSocialSdk.Core.LinkParams>, IConvertableToNative
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string KeyCustomTitle = "$title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string KeyCustomDescription = "$description";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string KeyCustomImage = "$image";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string KeyCustomYouTubeVideo = "$youtube_video";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string KeyPromoCode = "$promo_code";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkParams()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkParams(System.Collections.Generic.Dictionary<string, string> data)
        {
            var val_6;
            var val_7 = this;
            if(data == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = data.GetEnumerator();
            val_6 = 1152921515881767536;
            label_3:
            if(((-69876520) & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_2 = 0.trackableId;
            this.set_Item(key:  val_2.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key()), value:  val_2.m_SubId1);
            goto label_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkParams(System.Collections.Generic.Dictionary<string, object> data)
        {
            var val_6;
            var val_7 = this;
            if(data == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = data.GetEnumerator();
            val_6 = 1152921517613415616;
            label_3:
            if(((-69748136) & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_2 = 0.trackableId;
            this.set_Item(key:  val_2.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Object>::get_Key()), value:  val_2.m_SubId1);
            goto label_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return System.String.Format(format:  "[LinkParams: {0}]", arg0:  GetSocialSdk.Core.DebugUtils.ToDebugString<System.String, System.Object>(dictionary:  this));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool Equals(GetSocialSdk.Core.LinkParams other)
        {
            return GetSocialSdk.Core.Collections.DictionaryEquals<System.String, System.Object>(self:  this, other:  other);
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
            UnityEngine.Object val_10;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>(dictionary:  this);
            if((val_1.ContainsKey(key:  "$image")) != false)
            {
                    object val_3 = val_1.Item["$image"];
                if(val_3 != null)
            {
                    var val_4 = (null == null) ? (val_3) : 0;
            }
            else
            {
                    val_10 = 0;
            }
            
                if(val_10 != 0)
            {
                    val_1.set_Item(key:  "$image", value:  GetSocialSdk.Core.JniUtils.ToAjoBitmap(texture2D:  val_10));
            }
            
            }
            
            object[] val_7 = new object[1];
            UnityEngine.AndroidJavaObject val_8 = GetSocialSdk.Core.JniUtils.ToJavaHashMap<System.String, System.Object>(dictionary:  val_1);
            if(val_7 == null)
            {
                goto label_10;
            }
            
            if(val_8 != null)
            {
                goto label_11;
            }
            
            goto label_14;
            label_10:
            if(val_8 == null)
            {
                goto label_14;
            }
            
            label_11:
            label_14:
            val_7[0] = val_8;
            return (UnityEngine.AndroidJavaObject)new UnityEngine.AndroidJavaObject(className:  "im.getsocial.sdk.invites.LinkParams", args:  val_7);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.LinkParams ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            return (GetSocialSdk.Core.LinkParams)new GetSocialSdk.Core.LinkParams(data:  GetSocialSdk.Core.JniUtils.FromJavaHashMap(javaHashMap:  ajo));
        }
    
    }

}
