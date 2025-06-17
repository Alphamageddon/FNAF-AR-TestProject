using UnityEngine;

namespace Game.Store.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreDisplayData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string shortCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.StoreDomain.Data.DataDefinitions.StoreData storeData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string googlePlayProductId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string iosAppStoreProductId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Price;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.Currency.CurrencyType currency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Cost;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumPurchased;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreDisplayData(Game.StoreDomain.Data.DataDefinitions.StoreData data, Game.Store.Container.StoreContainer.VirtualGoodResponseData good)
        {
            var val_5;
            val_1 = new System.Object();
            this.shortCode = data.Id;
            this.storeData = data;
            if(val_1 != null)
            {
                    this.iosAppStoreProductId = good.IosAppStoreProductId;
                this.googlePlayProductId = good.GooglePlayProductId;
            }
            else
            {
                    this.iosAppStoreProductId = 69077560;
                this.googlePlayProductId = 0;
            }
            
            if((System.String.IsNullOrEmpty(value:  good.Currency)) != false)
            {
                    val_5 = 3;
            }
            
            this.currency = TheGame.Currency.GetTypeForString(currencyString:  good.Currency);
            this.Cost = good.Cost;
            this.Price = this.Cost.ToString();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetPrice(string price)
        {
            this.Price = price;
        }
    
    }

}
