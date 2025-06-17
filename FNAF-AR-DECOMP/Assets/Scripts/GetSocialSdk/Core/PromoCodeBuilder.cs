using UnityEngine;

namespace GetSocialSdk.Core
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PromoCodeBuilder : IConvertableToNative
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _code;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, string> _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private uint _maxClaimCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<System.DateTime> _startDate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<System.DateTime> _endDate;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PromoCodeBuilder(string code)
        {
            this._code = code;
            this._data = new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.PromoCodeBuilder CreateRandomCode()
        {
            return (GetSocialSdk.Core.PromoCodeBuilder)new GetSocialSdk.Core.PromoCodeBuilder(code:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.PromoCodeBuilder CreateWithCode(string code)
        {
            return (GetSocialSdk.Core.PromoCodeBuilder)new GetSocialSdk.Core.PromoCodeBuilder(code:  code);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.PromoCodeBuilder WithMaxClaimCount(uint maxClaimCount)
        {
            this._maxClaimCount = maxClaimCount;
            return (GetSocialSdk.Core.PromoCodeBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.PromoCodeBuilder WithTimeLimit(System.DateTime startDate, System.DateTime endDate)
        {
            this._startDate = 0;
            mem[1152921526025246720] = 0;
            this._endDate = 0;
            mem[1152921526025246736] = 0;
            return (GetSocialSdk.Core.PromoCodeBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.PromoCodeBuilder AddData(string key, string value)
        {
            this._data.Add(key:  key, value:  value);
            return (GetSocialSdk.Core.PromoCodeBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GetSocialSdk.Core.PromoCodeBuilder AddData(System.Collections.Generic.Dictionary<string, string> data)
        {
            GetSocialSdk.Core.Collections.AddAll<System.String, System.String>(container:  this._data, items:  data);
            return (GetSocialSdk.Core.PromoCodeBuilder)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            System.Object[] val_14;
            string val_15;
            var val_16;
            if(this._code != null)
            {
                    val_14 = new object[1];
                val_14[0] = this._code;
                val_15 = "createWithCode";
            }
            else
            {
                    val_15 = "createRandomCode";
                val_14 = System.Array.Empty<System.Object>();
            }
            
            UnityEngine.AndroidJavaObject val_4 = GetSocialSdk.Core.JniExtensionMethods.CallStaticAJO(ajo:  new UnityEngine.AndroidJavaClass(className:  "im.getsocial.sdk.promocodes.PromoCodeBuilder"), methodName:  val_15, args:  val_14);
            object[] val_5 = new object[1];
            val_5[0] = this._maxClaimCount;
            object[] val_7 = new object[1];
            val_7[0] = GetSocialSdk.Core.JniUtils.ToJavaHashMap<System.String, System.String>(dictionary:  this._data);
            object[] val_10 = new object[2];
            UnityEngine.AndroidJavaObject val_11 = val_10.DateToAjo(date:  new System.Nullable<System.DateTime>() {HasValue = this._startDate});
            if((val_11 != null) && (val_11 == null))
            {
                    val_16 = 0;
            }
            
            if(val_10.Length == 0)
            {
                    val_16 = 0;
            }
            
            val_10[0] = val_11;
            val_10[1] = val_11.DateToAjo(date:  new System.Nullable<System.DateTime>() {HasValue = this._endDate});
            UnityEngine.AndroidJavaObject val_13 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_4, methodName:  "withMaxClaimCount", args:  val_5), methodName:  "addData", args:  val_7), methodName:  "withTimeLimit", args:  val_10);
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.AndroidJavaObject DateToAjo(System.Nullable<System.DateTime> date)
        {
            UnityEngine.AndroidJavaObject val_6;
            var val_7;
            if(( & 1) != 0)
            {
                    object[] val_1 = new object[1];
                val_1[0] = "dd/MM/yyyy HH:mm:ss";
                UnityEngine.AndroidJavaObject val_2 = null;
                val_6 = val_2;
                val_2 = new UnityEngine.AndroidJavaObject(className:  "java.text.SimpleDateFormat", args:  val_1);
                object[] val_3 = new object[1];
                val_3[0] = GetSocialSdk.Core.PromoCodeBuilder.ConvertToTimestamp(value:  new System.DateTime() {});
                UnityEngine.AndroidJavaObject val_5 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "parse", args:  val_3);
                return (UnityEngine.AndroidJavaObject)val_7;
            }
            
            val_7 = 0;
            return (UnityEngine.AndroidJavaObject)val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string ConvertToTimestamp(System.DateTime value)
        {
            return -55600904;
        }
    
    }

}
