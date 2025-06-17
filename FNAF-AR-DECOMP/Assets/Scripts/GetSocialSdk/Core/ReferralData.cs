using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class ReferralData : IConvertableFromNative<GetSocialSdk.Core.ReferralData>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Token>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ReferrerUserId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ReferrerChannelId>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsFirstMatch>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsGuaranteedMatch>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsReinstall>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <IsFirstMatchLink>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.CustomReferralData <CustomReferralData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.LinkParams <LinkParams>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.CustomReferralData <OriginalCustomReferralData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.LinkParams <OriginalLinkParams>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, string> <ReferralLinkParams>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, string> <OriginalReferralLinkParams>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Token { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ReferrerUserId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ReferrerChannelId { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsFirstMatch { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsGuaranteedMatch { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsReinstall { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsFirstMatchLink { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.CustomReferralData CustomReferralData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.LinkParams LinkParams { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.CustomReferralData OriginalCustomReferralData { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.LinkParams OriginalLinkParams { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> ReferralLinkParams { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> OriginalReferralLinkParams { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Token()
        {
            return (string)this.<Token>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Token(string value)
        {
            this.<Token>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ReferrerUserId()
        {
            return (string)this.<ReferrerUserId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ReferrerUserId(string value)
        {
            this.<ReferrerUserId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ReferrerChannelId()
        {
            return (string)this.<ReferrerChannelId>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ReferrerChannelId(string value)
        {
            this.<ReferrerChannelId>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsFirstMatch()
        {
            return (bool)this.<IsFirstMatch>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsFirstMatch(bool value)
        {
            this.<IsFirstMatch>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsGuaranteedMatch()
        {
            return (bool)this.<IsGuaranteedMatch>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsGuaranteedMatch(bool value)
        {
            this.<IsGuaranteedMatch>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsReinstall()
        {
            return (bool)this.<IsReinstall>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsReinstall(bool value)
        {
            this.<IsReinstall>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsFirstMatchLink()
        {
            return (bool)this.<IsFirstMatchLink>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_IsFirstMatchLink(bool value)
        {
            this.<IsFirstMatchLink>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.CustomReferralData get_CustomReferralData()
        {
            return (GetSocialSdk.Core.CustomReferralData)this.<CustomReferralData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_CustomReferralData(GetSocialSdk.Core.CustomReferralData value)
        {
            this.<CustomReferralData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.LinkParams get_LinkParams()
        {
            return (GetSocialSdk.Core.LinkParams)this.<LinkParams>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_LinkParams(GetSocialSdk.Core.LinkParams value)
        {
            this.<LinkParams>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.CustomReferralData get_OriginalCustomReferralData()
        {
            return (GetSocialSdk.Core.CustomReferralData)this.<OriginalCustomReferralData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_OriginalCustomReferralData(GetSocialSdk.Core.CustomReferralData value)
        {
            this.<OriginalCustomReferralData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.LinkParams get_OriginalLinkParams()
        {
            return (GetSocialSdk.Core.LinkParams)this.<OriginalLinkParams>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_OriginalLinkParams(GetSocialSdk.Core.LinkParams value)
        {
            this.<OriginalLinkParams>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> get_ReferralLinkParams()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)this.<ReferralLinkParams>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ReferralLinkParams(System.Collections.Generic.Dictionary<string, string> value)
        {
            this.<ReferralLinkParams>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> get_OriginalReferralLinkParams()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)this.<OriginalReferralLinkParams>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_OriginalReferralLinkParams(System.Collections.Generic.Dictionary<string, string> value)
        {
            this.<OriginalReferralLinkParams>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ReferralData()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal ReferralData(string token, string referrerUserId, string referrerChannelId, bool isFirstMatch, bool isGuaranteedMatch, bool isReinstall, bool isFirstMatchLink, GetSocialSdk.Core.CustomReferralData customReferralData, System.Collections.Generic.Dictionary<string, string> referralLinkParams, GetSocialSdk.Core.CustomReferralData originalCustomReferralData, System.Collections.Generic.Dictionary<string, string> originalReferralLinkParams)
        {
            val_1 = new System.Object();
            this.<Token>k__BackingField = token;
            this.<ReferrerUserId>k__BackingField = val_1;
            this.<ReferrerChannelId>k__BackingField = referrerChannelId;
            this.<CustomReferralData>k__BackingField = customReferralData;
            this.<OriginalCustomReferralData>k__BackingField = originalCustomReferralData;
            this.<IsFirstMatch>k__BackingField = isFirstMatch;
            this.<IsGuaranteedMatch>k__BackingField = isGuaranteedMatch;
            this.<IsReinstall>k__BackingField = isReinstall;
            this.<IsFirstMatchLink>k__BackingField = isFirstMatchLink;
            this.<LinkParams>k__BackingField = new GetSocialSdk.Core.LinkParams(data:  referralLinkParams);
            this.<OriginalLinkParams>k__BackingField = new GetSocialSdk.Core.LinkParams(data:  originalReferralLinkParams);
            this.<ReferralLinkParams>k__BackingField = referralLinkParams;
            this.<OriginalReferralLinkParams>k__BackingField = originalReferralLinkParams;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool Equals(GetSocialSdk.Core.ReferralData other)
        {
            if((System.String.Equals(a:  this.<Token>k__BackingField, b:  other.<Token>k__BackingField)) == false)
            {
                    return false;
            }
            
            if((System.String.Equals(a:  this.<ReferrerUserId>k__BackingField, b:  other.<ReferrerUserId>k__BackingField)) == false)
            {
                    return false;
            }
            
            if((System.String.Equals(a:  this.<ReferrerChannelId>k__BackingField, b:  other.<ReferrerChannelId>k__BackingField)) == false)
            {
                    return false;
            }
            
            var val_4 = ((this.<IsFirstMatch>k__BackingField) == true) ? 1 : 0;
            val_4 = val_4 ^ (((other.<IsFirstMatch>k__BackingField) == true) ? 1 : 0);
            if((val_4 & 1) != 0)
            {
                    return false;
            }
            
            var val_6 = ((this.<IsGuaranteedMatch>k__BackingField) == true) ? 1 : 0;
            val_6 = val_6 ^ (((other.<IsGuaranteedMatch>k__BackingField) == true) ? 1 : 0);
            if((val_6 & 1) != 0)
            {
                    return false;
            }
            
            var val_8 = ((this.<IsReinstall>k__BackingField) == true) ? 1 : 0;
            val_8 = val_8 ^ (((other.<IsReinstall>k__BackingField) == true) ? 1 : 0);
            if((val_8 & 1) != 0)
            {
                    return false;
            }
            
            var val_10 = ((this.<IsFirstMatchLink>k__BackingField) == true) ? 1 : 0;
            val_10 = val_10 ^ (((other.<IsFirstMatchLink>k__BackingField) == true) ? 1 : 0);
            if((val_10 & 1) != 0)
            {
                    return false;
            }
            
            if((System.Object.Equals(objA:  this.<CustomReferralData>k__BackingField, objB:  other.<CustomReferralData>k__BackingField)) == false)
            {
                    return false;
            }
            
            if((System.Object.Equals(objA:  this.<LinkParams>k__BackingField, objB:  other.<LinkParams>k__BackingField)) == false)
            {
                    return false;
            }
            
            if((System.Object.Equals(objA:  this.<OriginalCustomReferralData>k__BackingField, objB:  other.<OriginalCustomReferralData>k__BackingField)) == false)
            {
                    return false;
            }
            
            return System.Object.Equals(objA:  this.<OriginalLinkParams>k__BackingField, objB:  other.<OriginalLinkParams>k__BackingField);
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
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            if((this.<Token>k__BackingField) != null)
            {
                    val_13 = (this.<Token>k__BackingField) * 397;
            }
            else
            {
                    val_13 = 0;
            }
            
            if((this.<ReferrerUserId>k__BackingField) != null)
            {
                    val_14 = this.<ReferrerUserId>k__BackingField;
            }
            else
            {
                    val_14 = 0;
            }
            
            val_14 = val_14 ^ val_13;
            if((this.<ReferrerChannelId>k__BackingField) != null)
            {
                    val_15 = this.<ReferrerChannelId>k__BackingField;
            }
            else
            {
                    val_15 = 0;
            }
            
            int val_13 = this.<IsFirstMatch>k__BackingField.GetHashCode();
            val_16 = 0;
            var val_6 = val_15 ^ (val_14 * 397);
            val_6 = val_6 * 397;
            val_6 = val_13 ^ val_6;
            val_6 = val_6 * 397;
            val_6 = (this.<IsGuaranteedMatch>k__BackingField.GetHashCode()) ^ val_6;
            val_6 = val_6 * 397;
            int val_12 = this.<IsFirstMatchLink>k__BackingField.GetHashCode();
            val_6 = (this.<IsReinstall>k__BackingField.GetHashCode()) ^ val_6;
            val_6 = val_6 * 397;
            val_12 = val_12 ^ val_6;
            val_15 = val_12 * 397;
            if((this.<CustomReferralData>k__BackingField) != null)
            {
                    val_17 = this.<CustomReferralData>k__BackingField;
            }
            else
            {
                    val_17 = 0;
            }
            
            val_17 = val_17 ^ val_15;
            val_13 = val_17 * 397;
            if((this.<OriginalCustomReferralData>k__BackingField) != null)
            {
                    val_18 = this.<OriginalCustomReferralData>k__BackingField;
            }
            else
            {
                    val_18 = 0;
            }
            
            val_18 = val_18 ^ val_13;
            if((this.<LinkParams>k__BackingField) != null)
            {
                    val_19 = this.<LinkParams>k__BackingField;
            }
            else
            {
                    val_19 = 0;
            }
            
            val_19 = val_19 ^ (val_18 * 397);
            val_13 = val_19 * 397;
            if((this.<OriginalLinkParams>k__BackingField) != null)
            {
                    val_20 = this.<OriginalLinkParams>k__BackingField;
            }
            else
            {
                    val_20 = 0;
            }
            
            val_20 = val_20 ^ val_13;
            if((this.<ReferralLinkParams>k__BackingField) != null)
            {
                    val_16 = public System.Int32 System.Object::GetHashCode();
                val_21 = this.<ReferralLinkParams>k__BackingField.GetHashCode();
            }
            else
            {
                    val_21 = 0;
            }
            
            val_21 = val_21 ^ (val_20 * 397);
            if((this.<OriginalReferralLinkParams>k__BackingField) != null)
            {
                    int val_11 = this.<OriginalReferralLinkParams>k__BackingField.GetHashCode();
            }
            
            val_11 = val_11 ^ (val_21 * 397);
            return (int)val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            object[] val_1 = new object[7];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if((this.<Token>k__BackingField) != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if((this.<Token>k__BackingField) == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = this.<Token>k__BackingField;
            val_1[1] = this.<ReferrerUserId>k__BackingField;
            val_1[2] = this.<ReferrerChannelId>k__BackingField;
            val_1[3] = this.<IsFirstMatch>k__BackingField;
            val_1[4] = this.<IsGuaranteedMatch>k__BackingField;
            val_1[5] = GetSocialSdk.Core.DebugUtils.ToDebugString<System.String, System.String>(dictionary:  this.<ReferralLinkParams>k__BackingField);
            val_1[6] = GetSocialSdk.Core.DebugUtils.ToDebugString<System.String, System.String>(dictionary:  this.<OriginalReferralLinkParams>k__BackingField);
            return (string)System.String.Format(format:  "[ReferralData: Token: {0}, ReferrerUserId={1}, ReferrerChannelId={2}, IsFirstMatch={3}, IsGuaranteedMatch={4}, ReferralLinkParams={5}, , OriginalReferralLinkParams={6}]", args:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.ReferralData ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            var val_31;
            var val_32 = this;
            if((GetSocialSdk.Core.JniUtils.IsJavaNull(ajo:  ajo)) != false)
            {
                    val_32 = 0;
                return (GetSocialSdk.Core.ReferralData)val_32;
            }
            
            this.<Token>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getToken", args:  System.Array.Empty<System.Object>());
            this.<ReferrerUserId>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getReferrerUserId", args:  System.Array.Empty<System.Object>());
            this.<ReferrerChannelId>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getReferrerChannelId", args:  System.Array.Empty<System.Object>());
            this.<IsFirstMatch>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  ajo, methodName:  "isFirstMatch", args:  System.Array.Empty<System.Object>());
            this.<IsGuaranteedMatch>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  ajo, methodName:  "isGuaranteedMatch", args:  System.Array.Empty<System.Object>());
            this.<IsReinstall>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  ajo, methodName:  "isReinstall", args:  System.Array.Empty<System.Object>());
            this.<IsFirstMatchLink>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  ajo, methodName:  "isFirstMatchLink", args:  System.Array.Empty<System.Object>());
            this.<ReferralLinkParams>k__BackingField = GetSocialSdk.Core.JniUtils.FromJavaHashMap(javaHashMap:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getReferralLinkParams", args:  System.Array.Empty<System.Object>()));
            this.<OriginalReferralLinkParams>k__BackingField = GetSocialSdk.Core.JniUtils.FromJavaHashMap(javaHashMap:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getOriginalReferralLinkParams", args:  System.Array.Empty<System.Object>()));
            new GetSocialSdk.Core.LinkParams() = new GetSocialSdk.Core.LinkParams(data:  this.<ReferralLinkParams>k__BackingField);
            this.<LinkParams>k__BackingField = new GetSocialSdk.Core.LinkParams();
            new GetSocialSdk.Core.LinkParams() = new GetSocialSdk.Core.LinkParams(data:  this.<OriginalReferralLinkParams>k__BackingField);
            this.<OriginalLinkParams>k__BackingField = new GetSocialSdk.Core.LinkParams();
            new GetSocialSdk.Core.CustomReferralData() = new GetSocialSdk.Core.CustomReferralData(data:  this.<ReferralLinkParams>k__BackingField);
            this.<CustomReferralData>k__BackingField = new GetSocialSdk.Core.CustomReferralData();
            new GetSocialSdk.Core.CustomReferralData() = new GetSocialSdk.Core.CustomReferralData(data:  this.<OriginalReferralLinkParams>k__BackingField);
            val_31 = 0;
            this.<OriginalCustomReferralData>k__BackingField = new GetSocialSdk.Core.CustomReferralData();
            if(ajo != null)
            {
                    var val_31 = 0;
                val_31 = val_31 + 1;
                ajo.Dispose();
            }
            
            if(300 == 300)
            {
                    return (GetSocialSdk.Core.ReferralData)val_32;
            }
            
            if(val_31 == 0)
            {
                    return (GetSocialSdk.Core.ReferralData)val_32;
            }
            
            return (GetSocialSdk.Core.ReferralData)val_32;
        }
    
    }

}
