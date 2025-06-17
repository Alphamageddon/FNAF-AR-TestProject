using UnityEngine;

namespace Game.Store.Container
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreContainer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string ENDOSKELETON_SLOT = "EndoskeletonSlot";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Game.Store.Data.StoreDisplayData> _displayItems;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, Game.StoreDomain.Data.DataDefinitions.StoreData> _rawStoreData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, int> _ownedItems;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Game.StoreDomain.Data.DataDefinitions.StoreSectionData> _sectionData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Store.Container.StoreContainer.StoreIdentificationData _storeId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _numOwnedChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action StoreDataUpdated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action VirtualGoodsIntegrated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action AppStoreProductsIntegrated;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action OwnedGoodsReceived;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.Store.Data.StoreDisplayData> DisplayItems { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.StoreDomain.Data.DataDefinitions.StoreData> RawStoreData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.StoreDomain.Data.DataDefinitions.StoreSectionData> SectionData { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.Store.Data.StoreDisplayData> get_DisplayItems()
        {
            return (System.Collections.Generic.Dictionary<System.String, Game.Store.Data.StoreDisplayData>)this._displayItems;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, Game.StoreDomain.Data.DataDefinitions.StoreData> get_RawStoreData()
        {
            return (System.Collections.Generic.Dictionary<System.String, Game.StoreDomain.Data.DataDefinitions.StoreData>)this._rawStoreData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Game.StoreDomain.Data.DataDefinitions.StoreSectionData> get_SectionData()
        {
            return (System.Collections.Generic.List<Game.StoreDomain.Data.DataDefinitions.StoreSectionData>)this._sectionData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreContainer()
        {
            this._rawStoreData = new System.Collections.Generic.Dictionary<System.String, Game.StoreDomain.Data.DataDefinitions.StoreData>();
            this._displayItems = new System.Collections.Generic.Dictionary<System.String, Game.Store.Data.StoreDisplayData>();
            this._ownedItems = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            this._sectionData = new System.Collections.Generic.List<Game.StoreDomain.Data.DataDefinitions.StoreSectionData>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadStoreSectionDataFromServer(ProtoData.STORESECTIONS_DATA data)
        {
            var val_10;
            var val_11;
            var val_13;
            this._sectionData.Clear();
            System.Collections.Generic.IEnumerator<T> val_2 = data.Entries.GetEnumerator();
            label_16:
            var val_10 = 0;
            val_10 = val_10 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            new Game.StoreDomain.Data.DataDefinitions.StoreSectionData() = new Game.StoreDomain.Data.DataDefinitions.StoreSectionData(entry:  val_2.Current);
            this._sectionData.Add(item:  new Game.StoreDomain.Data.DataDefinitions.StoreSectionData());
            goto label_16;
            label_9:
            val_10 = 0;
            val_11 = 69;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_2.Dispose();
            }
            
            val_13 = null;
            val_13 = null;
            if((StoreContainer.<>c.<>9__20_0) == null)
            {
                goto label_33;
            }
            
            label_38:
            this._sectionData.Sort(comparison:  StoreContainer.<>c.<>9__20_0);
            return;
            label_33:
            StoreContainer.<>c.<>9__20_0 = new System.Comparison<Game.StoreDomain.Data.DataDefinitions.StoreSectionData>(object:  StoreContainer.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 StoreContainer.<>c::<LoadStoreSectionDataFromServer>b__20_0(Game.StoreDomain.Data.DataDefinitions.StoreSectionData x, Game.StoreDomain.Data.DataDefinitions.StoreSectionData y));
            if(this._sectionData != null)
            {
                goto label_38;
            }
            
            goto label_38;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadStoreDataFromServer(ProtoData.STORE_DATA data)
        {
            var val_9;
            var val_10;
            this._rawStoreData.Clear();
            System.Collections.Generic.IEnumerator<T> val_2 = data.Entries.GetEnumerator();
            label_18:
            var val_9 = 0;
            val_9 = val_9 + 1;
            if(val_2.MoveNext() == false)
            {
                goto label_9;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            new Game.StoreDomain.Data.DataDefinitions.StoreData() = new Game.StoreDomain.Data.DataDefinitions.StoreData(entry:  val_2.Current);
            if((Game.StoreDomain.Data.DataDefinitions.StoreData)[1152921525141453840].Live == false)
            {
                goto label_18;
            }
            
            this._rawStoreData.Add(key:  (Game.StoreDomain.Data.DataDefinitions.StoreData)[1152921525141453840].Id, value:  new Game.StoreDomain.Data.DataDefinitions.StoreData());
            goto label_18;
            label_9:
            val_9 = 0;
            val_10 = 83;
            if(val_2 == null)
            {
                
            }
            else
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_2.Dispose();
            }
            
            if(this.StoreDataUpdated == null)
            {
                    return;
            }
            
            this.StoreDataUpdated.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool SameStoreId(Game.Store.Container.StoreContainer.StoreIdentificationData left, Game.Store.Container.StoreContainer.StoreIdentificationData right)
        {
            if(left == null)
            {
                    return (bool)0;
            }
            
            if(right == null)
            {
                    return (bool)0;
            }
            
            if((System.String.op_Equality(a:  left.CatalogId, b:  right.CatalogId)) != false)
            {
                    if((System.String.op_Equality(a:  left.StoreId, b:  right.StoreId)) != false)
            {
                    var val_3 = (left.version == right.version) ? 1 : 0;
                return (bool)0;
            }
            
            }
            
            0 = 0;
            return (bool)0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateVirtualGoodsCatalogue(Game.Store.Container.StoreContainer.StoreIdentificationData storeData, System.Collections.Generic.List<Game.Store.Container.StoreContainer.VirtualGoodResponseData> goods)
        {
            StoreIdentificationData val_7 = storeData;
            if((this.SameStoreId(left:  this._storeId, right:  val_7 = storeData)) != false)
            {
                    if(this._numOwnedChanged == false)
            {
                    return;
            }
            
            }
            
            this._numOwnedChanged = false;
            this._storeId = val_7;
            this._displayItems.Clear();
            val_7 = 0;
            goto label_4;
            label_11:
            if((this.ValidForDisplay(shortCode:  val_2.ShortCode)) != false)
            {
                    this._displayItems.Add(key:  val_2.ShortCode, value:  new Game.Store.Data.StoreDisplayData(data:  this._rawStoreData.Item[val_2.ShortCode], good:  goods.Item[0]));
            }
            
            val_7 = 1;
            label_4:
            if(val_7 < goods.Count)
            {
                goto label_11;
            }
            
            if(this.VirtualGoodsIntegrated == null)
            {
                    return;
            }
            
            this.VirtualGoodsIntegrated.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateAppStoreItems(UnityEngine.Purchasing.Product[] products)
        {
            UnityEngine.Purchasing.Product val_9;
            var val_10;
            string val_11;
            val_10 = 0;
            goto label_1;
            label_14:
            val_9 = products[0];
            val_11 = val_9.definition.id;
            if((this._displayItems.ContainsKey(key:  val_11)) != false)
            {
                    val_11 = val_9.definition.id;
                Game.Store.Data.StoreDisplayData val_6 = this._displayItems.Item[val_11];
                val_9 = val_9.metadata.localizedPriceString;
                val_6.Price = val_9;
            }
            
            val_10 = 1;
            label_1:
            if(val_10 < products.Length)
            {
                goto label_14;
            }
            
            if(this.AppStoreProductsIntegrated == null)
            {
                    return;
            }
            
            this.AppStoreProductsIntegrated.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ProcessOwnedGoods(System.Collections.Generic.Dictionary<string, int> goods)
        {
            this._ownedItems = goods;
            this._numOwnedChanged = true;
            if(this.OwnedGoodsReceived == null)
            {
                    return;
            }
            
            this.OwnedGoodsReceived.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumOwned(string shortcode)
        {
            if((this._ownedItems.ContainsKey(key:  shortcode)) == false)
            {
                    return 0;
            }
            
            if(this._ownedItems != null)
            {
                    return this._ownedItems.Item[shortcode];
            }
            
            return this._ownedItems.Item[shortcode];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Store.Data.StoreDisplayData GetNextAvailableEndoskeleton()
        {
            var val_4;
            var val_10;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = this._displayItems.Values.GetEnumerator();
            val_10 = 0;
            goto label_11;
            label_13:
            if((System.String.op_Equality(a:  val_5._serverGameUIDataModel.<currentStreakLeaderboard>k__BackingField, b:  "EndoskeletonSlot")) != false)
            {
                    if((0 & 2147483648) == 0)
            {
                    if((val_5._serverGameUIDataModel.<showUIBars>k__BackingField) >= 0)
            {
                goto label_11;
            }
            
            }
            
                if((this._ownedItems.ContainsKey(key:  val_5._masterDomain)) != true)
            {
                    val_10 = val_4.emailUIDataHandler;
            }
            
            }
            
            label_11:
            if(((-939180864) & 1) != 0)
            {
                goto label_13;
            }
            
            return (Game.Store.Data.StoreDisplayData)val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ValidForDisplay(string shortCode)
        {
            var val_4;
            if((this._rawStoreData.ContainsKey(key:  shortCode)) == false)
            {
                goto label_2;
            }
            
            Game.StoreDomain.Data.DataDefinitions.StoreData val_2 = this._rawStoreData.Item[shortCode];
            if((val_2.Repeatable == true) || ((this.NumOwned(shortcode:  val_2.Id)) <= 0))
            {
                goto label_6;
            }
            
            label_2:
            val_4 = 0;
            return (bool)val_4;
            label_6:
            val_4 = 1;
            return (bool)val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddOwnedItem(string shortCode, int amount)
        {
            var val_5;
            if((this._ownedItems.ContainsKey(key:  shortCode)) != true)
            {
                    this._ownedItems.Add(key:  shortCode, value:  0);
            }
            
            if(this._ownedItems != null)
            {
                    val_5 = this._ownedItems.Item[shortCode];
            }
            else
            {
                    val_5 = 0.Item[shortCode];
            }
            
            this._ownedItems.set_Item(key:  shortCode, value:  val_5 + amount);
        }
    
    }

}
