using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class UserUpdate : IConvertableToNative
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string RemoveValue = "";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _displayName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _avatarUrl;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D _avatar;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, string> _publicProperties;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, string> _privateProperties;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, string> _publicInternalProperties;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, string> _privateInternalProperties;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.UserUpdate.Builder CreateBuilder()
        {
            return (Builder)new UserUpdate.Builder();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            var val_12;
            var val_41;
            GetSocialSdk.Core.UserUpdate val_42;
            var val_43;
            var val_44;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "im.getsocial.sdk.usermanagement.UserUpdate$Builder", args:  System.Array.Empty<System.Object>());
            object[] val_3 = new object[1];
            val_3[0] = this._displayName;
            UnityEngine.AndroidJavaObject val_4 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "updateDisplayName", args:  val_3);
            object[] val_5 = new object[1];
            val_5[0] = this._avatar;
            UnityEngine.AndroidJavaObject val_6 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "updateAvatar", args:  val_5);
            object[] val_7 = new object[1];
            val_7[0] = this._avatarUrl;
            UnityEngine.AndroidJavaObject val_8 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "updateAvatarUrl", args:  val_7);
            Dictionary.Enumerator<TKey, TValue> val_9 = this._publicProperties.GetEnumerator();
            label_22:
            if(((-35064416) & 1) == 0)
            {
                goto label_14;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_13 = val_12.trackableId;
            object[] val_14 = new object[2];
            val_14[0] = val_13.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key());
            val_14[1] = ;
            UnityEngine.AndroidJavaObject val_16 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setPublicProperty", args:  val_14);
            goto label_22;
            label_14:
            long val_17 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526046619040});
            Dictionary.Enumerator<TKey, TValue> val_19 = this._privateProperties.GetEnumerator();
            label_40:
            if(((-35064416) & 1) == 0)
            {
                goto label_32;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_20 = val_12.trackableId;
            object[] val_21 = new object[2];
            val_21[0] = val_20.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key());
            val_21[1] = ;
            UnityEngine.AndroidJavaObject val_23 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setPrivateProperty", args:  val_21);
            goto label_40;
            label_32:
            val_41 = 0;
            long val_24 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526046619040});
            if(((267 == 0) ? 267 : 267) == 267)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_41 = 0;
            }
            
            }
            
            Dictionary.Enumerator<TKey, TValue> val_26 = this._publicInternalProperties.GetEnumerator();
            label_60:
            if(((-35064416) & 1) == 0)
            {
                goto label_52;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_27 = val_12.trackableId;
            object[] val_28 = new object[2];
            val_28[0] = val_27.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key());
            val_28[1] = ;
            UnityEngine.AndroidJavaObject val_30 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setInternalPublicProperty", args:  val_28);
            goto label_60;
            label_52:
            val_42 = this;
            long val_31 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526046619040});
            if(((353 == 0) ? 353 : 353) == 353)
            {
                    val_43 = 1152921515881766512;
            }
            else
            {
                    val_43 = 1152921515881766512;
                if( != 0)
            {
                    val_41 = 0;
            }
            
            }
            
            Dictionary.Enumerator<TKey, TValue> val_33 = mem[1152921526046631248].GetEnumerator();
            label_80:
            if(((-35064416) & 1) == 0)
            {
                goto label_72;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_34 = val_12.trackableId;
            object[] val_35 = new object[2];
            val_35[0] = val_34.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key());
            val_35[1] = ;
            UnityEngine.AndroidJavaObject val_37 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "setInternalPrivateProperty", args:  val_35);
            goto label_80;
            label_72:
            val_44 = 1152921518828526064;
            long val_38 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921526046619040});
            if( == 0)
            {
                    return (UnityEngine.AndroidJavaObject)GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "build", args:  System.Array.Empty<System.Object>());
            }
            
            return (UnityEngine.AndroidJavaObject)GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "build", args:  System.Array.Empty<System.Object>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UserUpdate()
        {
            this._publicProperties = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, com.illumix.TSDF.VoxelBlock>();
            this._privateProperties = new System.Collections.Generic.Dictionary<System.String, System.String>();
            this._publicInternalProperties = new System.Collections.Generic.Dictionary<System.String, System.String>();
            this._privateInternalProperties = new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
    
    }

}
