using UnityEngine;

namespace GetSocialSdk.Core.Analytics
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public sealed class PurchaseData : IConvertableToNative
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _productId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _productTitle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GetSocialSdk.Core.Analytics.PurchaseData.ProductType _productType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _price;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _priceCurrency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.DateTime _purchaseDate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _purchaseId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private PurchaseData()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static GetSocialSdk.Core.Analytics.PurchaseData.Builder CreateBuilder()
        {
            return (Builder)new PurchaseData.Builder();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.AndroidJavaObject ToAjo()
        {
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "im.getsocial.sdk.iap.PurchaseData$Builder", args:  System.Array.Empty<System.Object>());
            object[] val_3 = new object[1];
            if(val_3 == null)
            {
                goto label_1;
            }
            
            if(this._productId != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(this._productId == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_3[0] = this._productId;
            UnityEngine.AndroidJavaObject val_4 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "withProductId", args:  val_3);
            object[] val_5 = new object[1];
            UnityEngine.AndroidJavaObject val_6 = GetSocialSdk.Core.EnumConversion.ToAndroidJavaObject(productType:  this._productType);
            if(val_5 == null)
            {
                goto label_7;
            }
            
            if(val_6 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(val_6 == null)
            {
                goto label_11;
            }
            
            label_8:
            label_11:
            val_5[0] = val_6;
            UnityEngine.AndroidJavaObject val_7 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "withProductType", args:  val_5);
            object[] val_8 = new object[1];
            if(val_8 == null)
            {
                goto label_13;
            }
            
            if(this._price != 0)
            {
                goto label_14;
            }
            
            goto label_17;
            label_13:
            if(this._price == 0)
            {
                goto label_17;
            }
            
            label_14:
            label_17:
            val_8[0] = this._price;
            UnityEngine.AndroidJavaObject val_9 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "withPrice", args:  val_8);
            object[] val_10 = new object[1];
            if(val_10 == null)
            {
                goto label_19;
            }
            
            if(this._priceCurrency != null)
            {
                goto label_20;
            }
            
            goto label_23;
            label_19:
            if(this._priceCurrency == null)
            {
                goto label_23;
            }
            
            label_20:
            label_23:
            val_10[0] = this._priceCurrency;
            UnityEngine.AndroidJavaObject val_11 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "withPriceCurrency", args:  val_10);
            System.DateTime val_12 = this._purchaseDate.ToUniversalTime();
            System.TimeSpan val_13 = val_12.dateData.Subtract(value:  new System.DateTime());
            object[] val_15 = new object[1];
            if(val_15 == null)
            {
                goto label_25;
            }
            
            if((long)val_13._ticks.TotalSeconds != 0)
            {
                goto label_26;
            }
            
            goto label_29;
            label_25:
            if((long)val_13._ticks.TotalSeconds == 0)
            {
                goto label_29;
            }
            
            label_26:
            label_29:
            val_15[0] = (long)val_13._ticks.TotalSeconds;
            UnityEngine.AndroidJavaObject val_16 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "withPurchaseDate", args:  val_15);
            object[] val_17 = new object[1];
            if(val_17 == null)
            {
                goto label_31;
            }
            
            if(this._productTitle != null)
            {
                goto label_32;
            }
            
            goto label_35;
            label_31:
            if(this._productTitle == null)
            {
                goto label_35;
            }
            
            label_32:
            label_35:
            val_17[0] = this._productTitle;
            UnityEngine.AndroidJavaObject val_18 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "withProductTitle", args:  val_17);
            object[] val_19 = new object[1];
            if(val_19 == null)
            {
                goto label_37;
            }
            
            if(this._purchaseId != null)
            {
                goto label_38;
            }
            
            goto label_41;
            label_37:
            if(this._purchaseId == null)
            {
                goto label_41;
            }
            
            label_38:
            label_41:
            val_19[0] = this._purchaseId;
            UnityEngine.AndroidJavaObject val_20 = GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "withPurchaseId", args:  val_19);
            return (UnityEngine.AndroidJavaObject)GetSocialSdk.Core.JniExtensionMethods.CallAJO(ajo:  val_2, methodName:  "build", args:  System.Array.Empty<System.Object>());
        }
    
    }

}
