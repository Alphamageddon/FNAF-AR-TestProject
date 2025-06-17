using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PromoCode : IConvertableFromNative<GetSocialSdk.Core.PromoCode>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Code>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, string> <Data>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private uint <MaxClaimCount>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTime <StartDate>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<System.DateTime> <EndDate>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.UserReference <Creator>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private uint <ClaimCount>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <Enabled>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <Claimable>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Code { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, string> Data { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint MaxClaimCount { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime StartDate { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> EndDate { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.UserReference Creator { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint ClaimCount { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Enabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Claimable { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Code()
        {
            return (string)this.<Code>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Code(string value)
        {
            this.<Code>k__BackingField = value;
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
        public uint get_MaxClaimCount()
        {
            return (uint)this.<MaxClaimCount>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_MaxClaimCount(uint value)
        {
            this.<MaxClaimCount>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.DateTime get_StartDate()
        {
            return (System.DateTime)this.<StartDate>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_StartDate(System.DateTime value)
        {
            this.<StartDate>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Nullable<System.DateTime> get_EndDate()
        {
            return (System.Nullable<System.DateTime>)this.<EndDate>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_EndDate(System.Nullable<System.DateTime> value)
        {
            this.<EndDate>k__BackingField = value;
            mem[1152921526022577464] = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.UserReference get_Creator()
        {
            return (GetSocialSdk.Core.UserReference)this.<Creator>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Creator(GetSocialSdk.Core.UserReference value)
        {
            this.<Creator>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public uint get_ClaimCount()
        {
            return (uint)this.<ClaimCount>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ClaimCount(uint value)
        {
            this.<ClaimCount>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_Enabled()
        {
            return (bool)this.<Enabled>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Enabled(bool value)
        {
            this.<Enabled>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_Claimable()
        {
            return (bool)this.<Claimable>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Claimable(bool value)
        {
            this.<Claimable>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PromoCode()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.PromoCode ParseFromAJO(UnityEngine.AndroidJavaObject ajo)
        {
            this.<Code>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallStr(ajo:  ajo, methodName:  "getCode", args:  System.Array.Empty<System.Object>());
            this.<Data>k__BackingField = GetSocialSdk.Core.JniUtils.FromJavaHashMap(javaHashMap:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getData", args:  System.Array.Empty<System.Object>()));
            this.<MaxClaimCount>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallInt(ajo:  ajo, methodName:  "getMaxClaimCount", args:  System.Array.Empty<System.Object>());
            System.Nullable<System.DateTime> val_10 = GetSocialSdk.Core.PromoCode.DateFromAjo(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getStartDate", args:  System.Array.Empty<System.Object>()));
            this.<StartDate>k__BackingField = ;
            System.Nullable<System.DateTime> val_13 = GetSocialSdk.Core.PromoCode.DateFromAjo(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getEndDate", args:  System.Array.Empty<System.Object>()));
            this.<EndDate>k__BackingField = val_13;
            mem[1152921526024083192] = "getEndDate";
            new GetSocialSdk.Core.UserReference() = new System.Object();
            this.<Creator>k__BackingField = new GetSocialSdk.Core.UserReference().ParseFromAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  ajo, methodName:  "getCreator", args:  System.Array.Empty<System.Object>()));
            this.<ClaimCount>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallInt(ajo:  ajo, methodName:  "getClaimCount", args:  System.Array.Empty<System.Object>());
            this.<Enabled>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  ajo, methodName:  "isEnabled", args:  System.Array.Empty<System.Object>());
            this.<Claimable>k__BackingField = GetSocialSdk.Core.JniExtensionMethods.CallBool(ajo:  ajo, methodName:  "isClaimable", args:  System.Array.Empty<System.Object>());
            if(ajo != null)
            {
                    var val_27 = 0;
                val_27 = val_27 + 1;
                ajo.Dispose();
            }
            
            if(245 == 245)
            {
                    return (GetSocialSdk.Core.PromoCode)this;
            }
            
            if(0 == 0)
            {
                    return (GetSocialSdk.Core.PromoCode)this;
            }
            
            return (GetSocialSdk.Core.PromoCode)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Nullable<System.DateTime> DateFromAjo(UnityEngine.AndroidJavaObject ajo)
        {
            if((GetSocialSdk.Core.JniUtils.IsJavaNull(ajo:  ajo)) != false)
            {
                    return 0;
            }
            
            long val_3 = GetSocialSdk.Core.JniExtensionMethods.CallLong(ajo:  ajo, methodName:  "getTime", args:  System.Array.Empty<System.Object>());
            System.DateTime val_4 = 0.AddSeconds(value:  1.84467449498829E+16);
            System.DateTime val_5 = val_4.dateData.ToLocalTime();
            return 0;
        }
    
    }

}
