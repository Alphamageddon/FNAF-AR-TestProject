using UnityEngine;

namespace Game.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VirtualGoodsListResponseHandler : EventResponseHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string IOS_PRODUCT_ID = "iOSProductId";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string GOOGLE_PRODUCT_ID = "googlePlayProductId";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SERVER_STORE_DATA = "StoreItems";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string SERVER_STORE_ITEMS = "Store";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STORE_ID_CATALOG = "CatalogVersion";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STORE_ID_STORE = "StoreId";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STORE_ID_MARKETING = "MarketingData";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STORE_ID_METADATA = "Metadata";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STORE_ID_VERSION = "version";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STOREDATA_ITEMID = "ItemId";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STOREDATA_CUSTOMDATA = "CustomData";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STOREDATA_RMT_PRICES = "RealCurrencyPrices";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STOREDATA_VC_PRICES = "VirtualCurrencyPrices";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<Game.Store.Container.StoreContainer.StoreIdentificationData, System.Collections.Generic.List<Game.Store.Container.StoreContainer.VirtualGoodResponseData>> VirtualGoodsReceived;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(System.Action<Game.Store.Container.StoreContainer.StoreIdentificationData, System.Collections.Generic.List<Game.Store.Container.StoreContainer.VirtualGoodResponseData>> callback)
        {
            this.VirtualGoodsReceived = callback;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void TryHandleResponse(Systems.Server.ServerData data)
        {
            Systems.Server.ServerData val_1 = data.GetServerData(key:  "StoreItems");
            if(val_1 == null)
            {
                    return;
            }
            
            this.ProcessStoreData(data:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ProcessStoreData(Systems.Server.ServerData data)
        {
            .CatalogId = data.GetString(key:  "CatalogVersion");
            if(data != null)
            {
                    .StoreId = data.GetString(key:  "StoreId");
            }
            else
            {
                    .StoreId = 0.GetString(key:  "StoreId");
            }
            
            Systems.Server.ServerData val_5 = data.GetServerData(key:  "MarketingData");
            .version = val_5.GetVersionFromMarketingData(marketingData:  val_5);
            if(this.VirtualGoodsReceived == null)
            {
                    return;
            }
            
            this.VirtualGoodsReceived.Invoke(arg1:  new StoreContainer.StoreIdentificationData(), arg2:  this.GetStoreItemList(entries:  data.GetServerDataList(key:  "Store")));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int GetVersionFromMarketingData(Systems.Server.ServerData marketingData)
        {
            var val_4;
            if(marketingData != null)
            {
                    Systems.Server.ServerData val_1 = marketingData.GetServerData(key:  "Metadata");
                if(val_1 == null)
            {
                    return (int)val_4;
            }
            
                System.Nullable<System.Int32> val_2 = val_1.GetInt(key:  "version");
                if(((-887553672) & 1) != 0)
            {
                    UnityEngine.XR.ARCore.ARCoreFaceRegion val_3 = val_2.HasValue.region;
                return (int)val_4;
            }
            
            }
            
            val_4 = 0;
            return (int)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.Store.Container.StoreContainer.VirtualGoodResponseData> GetStoreItemList(System.Collections.Generic.List<Systems.Server.ServerData> entries)
        {
            int val_30;
            var val_31;
            var val_32;
            var val_33;
            string val_34;
            System.Collections.Generic.List<VirtualGoodResponseData> val_1 = new System.Collections.Generic.List<VirtualGoodResponseData>();
            if(entries == null)
            {
                    return val_1;
            }
            
            val_30 = entries.Count;
            if(val_30 < 1)
            {
                    return val_1;
            }
            
            var val_48 = 0;
            val_31 = 0;
            val_32 = 0;
            label_88:
            val_33 = entries.Item[0];
            string val_5 = val_33.GetString(key:  "ItemId");
            .ShortCode = val_5;
            if(val_33 != null)
            {
                    Systems.Server.ServerData val_6 = val_33.GetServerData(key:  "CustomData");
                string val_7 = val_6.GetCustomDataString(data:  val_6, key:  "iOSProductId", fallback:  val_5);
                .IosAppStoreProductId = val_7;
                .GooglePlayProductId = val_7.GetCustomDataString(data:  val_6, key:  "googlePlayProductId", fallback:  val_5);
            }
            else
            {
                    Systems.Server.ServerData val_9 = val_33.GetServerData(key:  "CustomData");
                string val_10 = val_9.GetCustomDataString(data:  val_9, key:  "iOSProductId", fallback:  val_5);
                .IosAppStoreProductId = val_10;
                .GooglePlayProductId = val_10.GetCustomDataString(data:  val_9, key:  "googlePlayProductId", fallback:  val_5);
            }
            
            val_34 = val_33.GetServerData(key:  "RealCurrencyPrices");
            if(val_34 == null)
            {
                goto label_53;
            }
            
            var val_38 = 0;
            val_38 = val_38 + 1;
            var val_39 = 0;
            val_39 = val_39 + 1;
            System.Collections.Generic.IEnumerator<T> val_17 = val_34.BaseData.Keys.GetEnumerator();
            var val_40 = 0;
            val_40 = val_40 + 1;
            if(val_17.MoveNext() != false)
            {
                    var val_41 = 0;
                val_41 = val_41 + 1;
                T val_21 = val_17.Current;
                .Currency = val_21;
                System.Nullable<System.Int32> val_22 = val_34.GetInt(key:  val_21);
                val_30 = val_30;
                .Cost = val_22.HasValue;
            }
            
            if(val_17 != null)
            {
                    var val_42 = 0;
                val_42 = val_42 + 1;
                val_17.Dispose();
            }
            
            if(((224 == 0) ? 224 : 224) != 224)
            {
                goto label_50;
            }
            
            val_32 = 0;
            if(val_33 != null)
            {
                goto label_54;
            }
            
            goto label_52;
            label_50:
            if(val_31 != 0)
            {
                    val_31 = 0;
            }
            
            label_53:
            if(val_33 != null)
            {
                goto label_54;
            }
            
            label_52:
            label_54:
            Systems.Server.ServerData val_25 = val_33.GetServerData(key:  "VirtualCurrencyPrices");
            if(val_25 == null)
            {
                goto label_86;
            }
            
            var val_43 = 0;
            val_43 = val_43 + 1;
            var val_44 = 0;
            val_44 = val_44 + 1;
            val_33 = val_25.BaseData.Keys.GetEnumerator();
            var val_45 = 0;
            val_45 = val_45 + 1;
            if(val_33.MoveNext() != false)
            {
                    var val_46 = 0;
                val_46 = val_46 + 1;
                val_34 = val_33.Current;
                .Currency = val_34;
                System.Nullable<System.Int32> val_35 = val_25.GetInt(key:  val_34);
                .Cost = val_35.HasValue;
            }
            
            if(val_33 != null)
            {
                    var val_47 = 0;
                val_47 = val_47 + 1;
                val_33.Dispose();
            }
            
            if(((331 == 0) ? 331 : 331) != 331)
            {
                goto label_83;
            }
            
            val_32 = 0;
            if(val_1 != null)
            {
                goto label_87;
            }
            
            goto label_85;
            label_83:
            label_86:
            if(val_1 != null)
            {
                goto label_87;
            }
            
            label_85:
            label_87:
            val_1.Add(item:  new StoreContainer.VirtualGoodResponseData());
            val_48 = val_48 + 1;
            if(val_48 < val_30)
            {
                goto label_88;
            }
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string GetCustomDataString(Systems.Server.ServerData data, string key, string fallback)
        {
            var val_4;
            if(data != null)
            {
                    string val_1 = data.GetString(key:  key);
                var val_3 = ((System.String.IsNullOrEmpty(value:  val_1)) != true) ? fallback : (val_1);
                return (string)val_4;
            }
            
            val_4 = fallback;
            return (string)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VirtualGoodsListResponseHandler()
        {
        
        }
    
    }

}
