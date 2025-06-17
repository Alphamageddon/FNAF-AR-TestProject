using UnityEngine;

namespace Game.Store
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreDomain : AsyncInterfaceAccess<Game.Store.IStoreDomain>, IStoreDomain, IStoreListener
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string KEY_PURCHASE_SUCCESS_TITLE = "ui_store_purchase_thank_you_title";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string KEY_PURCHASE_SUCCESS_MESSAGE = "ui_store_purchase_thank_you_message";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string KEY_PURCHASE_SUCCESS_POSITIVE_BUTTON = "ui_store_purchase_thank_you_button_text";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Purchasing.IStoreController controller;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.StoreDomain.Data.MasterDataConnector _masterDataConnector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Purchasing.IExtensionProvider extensions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TheGame.CurrencyBank _bank;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.Store.Container.StoreContainer <StoreContainer>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<string> PurchaseErrorCallback;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action IconsLoaded;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Store.Container.StoreContainer StoreContainer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool IsReady { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.Store.IStoreDomain GetPublicInterface { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Store.Container.StoreContainer get_StoreContainer()
        {
            return (Game.Store.Container.StoreContainer)this.<StoreContainer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool get_IsReady()
        {
            Game.StoreDomain.Data.MasterDataConnector val_2;
            var val_3;
            val_2 = this;
            if((this._masterDataConnector.<HasStoreDataLoaded>k__BackingField) != false)
            {
                    val_2 = this._masterDataConnector;
                var val_1 = ((this._masterDataConnector.<HasStoreSectionDataLoaded>k__BackingField) == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.Store.IStoreDomain get_GetPublicInterface()
        {
            return (Game.Store.IStoreDomain)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowPurchaseConfirm()
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void Game.Store.StoreDomain::<ShowPurchaseConfirm>b__19_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreDomain(Game.MasterData.MasterDataDomain masterDataDomain, Game.Server.ServerDomain serverDomain, Master.EventExposer exposer, TheGame.CurrencyBank bank, Utilities.AsyncInterfaceAccess<Game.AssetManagement.Icons.IIconLookup> lookupAccess)
        {
            val_1 = new Utilities.AsyncInterfaceAccess<Game.Store.IStoreDomain>();
            this._eventExposer = exposer;
            this._serverDomain = serverDomain;
            this._bank = bank;
            Game.Store.Container.StoreContainer val_2 = new Game.Store.Container.StoreContainer();
            this.<StoreContainer>k__BackingField = val_2;
            this._masterDataConnector = new Game.StoreDomain.Data.MasterDataConnector(masterDataDomain:  masterDataDomain, storeContainer:  val_2, callback:  new System.Action(object:  this, method:  System.Void Utilities.AsyncInterfaceAccess<Game.Store.IStoreDomain>::TryToDispatchPublicInterface()));
            val_1.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void Game.Store.StoreDomain::IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)));
            this.SetupCallbacks();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupCallbacks()
        {
            System.Action val_10;
            System.Action val_11;
            System.Action val_12;
            val_10 = System.Delegate.Combine(a:  this.<StoreContainer>k__BackingField.StoreDataUpdated, b:  new System.Action(object:  this, method:  System.Void Game.Store.StoreDomain::GetOwnedGoods()));
            if((this.<StoreContainer>k__BackingField) == null)
            {
                goto label_2;
            }
            
            if(val_10 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_10 == null)
            {
                goto label_6;
            }
            
            label_3:
            if(null != null)
            {
                    val_10 = 0;
            }
            
            label_6:
            this.<StoreContainer>k__BackingField.StoreDataUpdated = val_10;
            val_11 = System.Delegate.Combine(a:  this.<StoreContainer>k__BackingField.OwnedGoodsReceived, b:  new System.Action(object:  this, method:  System.Void Game.Store.StoreDomain::RequestVirtualGoods()));
            if((this.<StoreContainer>k__BackingField) == null)
            {
                goto label_8;
            }
            
            if(val_11 != null)
            {
                goto label_9;
            }
            
            goto label_12;
            label_8:
            if(val_11 == null)
            {
                goto label_12;
            }
            
            label_9:
            if(null != null)
            {
                    val_11 = 0;
            }
            
            label_12:
            this.<StoreContainer>k__BackingField.OwnedGoodsReceived = val_11;
            val_12 = System.Delegate.Combine(a:  this.<StoreContainer>k__BackingField.VirtualGoodsIntegrated, b:  new System.Action(object:  this, method:  System.Void Game.Store.StoreDomain::InitializeIAPCatalog()));
            if((this.<StoreContainer>k__BackingField) == null)
            {
                goto label_14;
            }
            
            if(val_12 != null)
            {
                goto label_15;
            }
            
            goto label_18;
            label_14:
            if(val_12 == null)
            {
                goto label_18;
            }
            
            label_15:
            if(null != null)
            {
                    val_12 = 0;
            }
            
            label_18:
            this.<StoreContainer>k__BackingField.VirtualGoodsIntegrated = val_12;
            this._eventExposer.add_VirtualGoodsDataReceived(value:  new System.Action<StoreIdentificationData, System.Collections.Generic.List<VirtualGoodResponseData>>(object:  this.<StoreContainer>k__BackingField, method:  public System.Void Game.Store.Container.StoreContainer::UpdateVirtualGoodsCatalogue(Game.Store.Container.StoreContainer.StoreIdentificationData storeData, System.Collections.Generic.List<Game.Store.Container.StoreContainer.VirtualGoodResponseData> goods)));
            this._eventExposer.add_PlayerGoodsUpdated(value:  new System.Action<System.Collections.Generic.Dictionary<System.String, System.Int32>>(object:  this.<StoreContainer>k__BackingField, method:  public System.Void Game.Store.Container.StoreContainer::ProcessOwnedGoods(System.Collections.Generic.Dictionary<string, int> goods)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            this._iconLookup = iconLookup;
            if(this.IconsLoaded == null)
            {
                    return;
            }
            
            this.IconsLoaded.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetOwnedGoods()
        {
            this._serverDomain.getOwnedGoodsRequester.GetOwnedGoods();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RequestVirtualGoods()
        {
            this._serverDomain.virtualGoodsListRequester.RequestVirtualGoods();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void InitializeIAPCatalog()
        {
            var val_7;
            UnityEngine.Purchasing.ConfigurationBuilder val_15;
            var val_16;
            val_15 = UnityEngine.Purchasing.ConfigurationBuilder.Instance(first:  UnityEngine.Purchasing.StandardPurchasingModule.Instance(), rest:  System.Array.Empty<UnityEngine.Purchasing.Extension.IPurchasingModule>());
            val_16 = this.<StoreContainer>k__BackingField._displayItems.Values;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_5 = val_16.GetEnumerator();
            do
            {
                label_20:
                if(((-944372752) & 1) == 0)
            {
                goto label_31;
            }
            
                GameUI.EmailUIDataHandler val_8 = val_7.emailUIDataHandler;
            }
            while(val_8._itemDefinitions != 3);
            
            new UnityEngine.Purchasing.IDs() = new UnityEngine.Purchasing.IDs();
            string[] val_10 = new string[1];
            val_10[0] = "AppleAppStore";
            new UnityEngine.Purchasing.IDs().Add(id:  val_8._emailIdsToBeDeletedOnServer, stores:  val_10);
            string[] val_11 = new string[1];
            val_11[0] = "GooglePlay";
            new UnityEngine.Purchasing.IDs().Add(id:  val_8._emailDatas, stores:  val_11);
            UnityEngine.Purchasing.ConfigurationBuilder val_12 = val_15.AddProduct(id:  val_8._masterDomain, type:  0, storeIDs:  new UnityEngine.Purchasing.IDs());
            goto label_20;
            label_31:
            UnityEngine.Purchasing.UnityPurchasing.Initialize(listener:  this, builder:  val_15);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IconsReady()
        {
            return (bool)(this._iconLookup != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitiatePurchase(Game.Store.Data.StoreDisplayData data)
        {
            Currency.CurrencyType val_6 = data.currency;
            if(val_6 == 3)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
            }
            else
            {
                    if(this._serverDomain == null)
            {
                    val_6 = data.currency;
            }
            
                this._serverDomain.iapRequester.BuyVirtualGood(itemId:  data.shortCode, currency:  TheGame.Currency.GetCurrencyString(type:  val_6), cost:  data.Cost, successCallback:  new System.Action(object:  this, method:  public System.Void Game.Store.StoreDomain::OnPurchaseSuccess()), errorCallback:  new System.Action<System.String>(object:  this, method:  public System.Void Game.Store.StoreDomain::OnPurchaseError(string error)));
                return;
            }
            
            this.controller.InitiatePurchase(product:  this.GetProductForId(id:  data.shortCode));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Purchasing.Product GetProductForId(string id)
        {
            string val_10;
            var val_11;
            var val_13;
            UnityEngine.Purchasing.Product val_15;
            val_10 = id;
            val_11 = 0;
            goto label_1;
            label_20:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_13 = this.controller.products.all[0].definition;
            if((System.String.op_Equality(a:  val_13.id, b:  val_10)) == true)
            {
                goto label_12;
            }
            
            val_11 = 1;
            label_1:
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_13 = this.controller.products.all;
            if(val_11 < val_9.Length)
            {
                goto label_20;
            }
            
            val_15 = 0;
            return val_15;
            label_12:
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_10 = this.controller.products.all;
            val_15 = val_10[0];
            return val_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool CanAfford(Game.Store.Data.StoreDisplayData data)
        {
            if(data.currency == 3)
            {
                    return true;
            }
            
            if(this._bank != null)
            {
                    return this._bank.CanAfford(type:  data.currency, amount:  data.Cost);
            }
            
            return this._bank.CanAfford(type:  data.currency, amount:  data.Cost);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Sprite GetStoreIcon(string iconName)
        {
            string val_9;
            Game.AssetManagement.Icons.IIconLookup val_10;
            var val_12;
            val_9 = iconName;
            val_10 = this._iconLookup;
            if((System.String.IsNullOrWhiteSpace(value:  val_9)) != false)
            {
                    var val_3 = 0;
                val_12 = 1152921505280790536;
                val_3 = val_3 + 1;
                val_12 = 1152921505280790552;
            }
            else
            {
                    var val_4 = 0;
                val_12 = 1152921505280790536;
                val_4 = val_4 + 1;
                return val_10.GetIcon(group:  5, name:  val_9);
            }
            
            val_9 = ???;
            val_10 = ???;
            return val_10.GetDefaultIcon();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Sprite GetShopUIIcon(string iconName)
        {
            string val_9;
            Game.AssetManagement.Icons.IIconLookup val_10;
            var val_12;
            val_9 = iconName;
            val_10 = this._iconLookup;
            if((System.String.IsNullOrWhiteSpace(value:  val_9)) != false)
            {
                    var val_3 = 0;
                val_12 = 1152921505280790536;
                val_3 = val_3 + 1;
                val_12 = 1152921505280790552;
            }
            else
            {
                    var val_4 = 0;
                val_12 = 1152921505280790536;
                val_4 = val_4 + 1;
                return val_10.GetIcon(group:  7, name:  val_9);
            }
            
            val_9 = ???;
            val_10 = ???;
            return val_10.GetDefaultIcon();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions)
        {
            this.controller = controller;
            this.extensions = extensions;
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.<StoreContainer>k__BackingField.UpdateAppStoreItems(products:  controller.products.all);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error)
        {
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = error});
            ConsoleLogger.LogError(className:  "StoreDomain", functionName:  "OnInitializeFailed", logString:  "Failed to Initialize Store: "("Failed to Initialize Store: ") + error.ToString());
            this.<StoreContainer>k__BackingField.UpdateAppStoreItems(products:  new UnityEngine.Purchasing.Product[0]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
        {
            Game.Server.IAPRequester val_8;
            Game.Server.IAPRequester val_9;
            var val_10;
            val_8 = this;
            val_9 = e.purchasedProduct;
            if(val_9.hasReceipt == false)
            {
                goto label_3;
            }
            
            val_9 = 1152921505261957120;
            val_10 = null;
            val_10 = null;
            if(Game.Server.ServerDomain.CurrentServer == 2)
            {
                goto label_6;
            }
            
            if(Game.Server.ServerDomain.CurrentServer != 1)
            {
                    return 0;
            }
            
            val_8 = this._serverDomain.iapRequester;
            val_8.BuyGameSparksVirtualGoodWithReceipt(receiptJson:  e.purchasedProduct.receipt, errorCallback:  0);
            return 0;
            label_3:
            UnityEngine.Debug.LogError(message:  "No receipt found");
            return 0;
            label_6:
            val_9 = this._serverDomain.iapRequester;
            val_9.BuyPlayFabVirtualGoodWithReceipt(product:  e.purchasedProduct, successCallback:  new System.Action(object:  this, method:  public System.Void Game.Store.StoreDomain::OnPurchaseSuccess()), errorCallback:  new System.Action<System.String>(object:  this, method:  public System.Void Game.Store.StoreDomain::OnPurchaseError(string error)));
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPurchaseFailed(UnityEngine.Purchasing.Product i, UnityEngine.Purchasing.PurchaseFailureReason p)
        {
            UnityEngine.Purchasing.PurchaseFailureReason val_13 = p;
            string val_5 = "Failed to Purchase " + i.definition.storeSpecificId + ": "(": ") + p.ToString();
            ConsoleLogger.LogError(className:  "StoreDomain", functionName:  "OnPurchaseFailed", logString:  val_5);
            if((UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_13})) == 0)
            {
                    GameUI.GenericDialogData val_6 = null;
                val_13 = val_6;
                val_6 = new GameUI.GenericDialogData();
                Game.Localization.LocalizationDomain val_7 = Game.Localization.LocalizationDomain.Instance;
                var val_16 = 0;
                val_16 = val_16 + 1;
                .title = val_7.ILocalization.GetLocalizedString(localizedStringId:  "store_disable_IAP_dialog_heading", originalString:  "In-app Purchases Disabled");
                Game.Localization.LocalizationDomain val_10 = Game.Localization.LocalizationDomain.Instance;
                var val_17 = 0;
                val_17 = val_17 + 1;
                .message = val_10.ILocalization.GetLocalizedString(localizedStringId:  "store_disabled_IAP_dialog_body", originalString:  "In-app purchases have been disabled in your device settings. Please enable them to allow purchases.");
                Game.Localization.LocalizationDomain val_13 = Game.Localization.LocalizationDomain.Instance;
                var val_18 = 0;
                val_18 = val_18 + 1;
                .positiveButtonText = val_13.ILocalization.GetLocalizedString(localizedStringId:  "ui_generic_ok", originalString:  "OK");
                this._eventExposer.GenericDialogRequest(genericDialogData:  val_6);
            }
            
            this.OnPurchaseError(error:  val_5);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPurchaseSuccess()
        {
            this.GetOwnedGoods();
            this.ShowPurchaseConfirm();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPurchaseError(string error)
        {
            if(this.PurchaseErrorCallback == null)
            {
                    return;
            }
            
            this.PurchaseErrorCallback.Invoke(obj:  error);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumGoodsOwned(string id)
        {
            if((this.<StoreContainer>k__BackingField) != null)
            {
                    return this.<StoreContainer>k__BackingField.NumOwned(shortcode:  id);
            }
            
            return this.<StoreContainer>k__BackingField.NumOwned(shortcode:  id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <ShowPurchaseConfirm>b__19_0(Game.Localization.ILocalization localization)
        {
            var val_8 = 0;
            val_8 = val_8 + 1;
            string val_2 = localization.GetLocalizedString(localizedStringId:  "ui_store_purchase_thank_you_title", originalString:  "THANK YOU!");
            var val_9 = 0;
            val_9 = val_9 + 1;
            string val_4 = localization.GetLocalizedString(localizedStringId:  "ui_store_purchase_thank_you_message", originalString:  "We hope you enjoy your purchased items.");
            var val_10 = 0;
            val_10 = val_10 + 1;
            GameUI.GenericDialogData val_7 = new GameUI.GenericDialogData();
            if(val_7 != null)
            {
                    .title = val_2;
                .message = val_4;
            }
            else
            {
                    mem[16] = val_2;
                mem[24] = val_4;
            }
            
            .positiveButtonText = localization.GetLocalizedString(localizedStringId:  "ui_store_purchase_thank_you_button_text", originalString:  "OK");
            this._eventExposer.GenericDialogRequest(genericDialogData:  val_7);
        }
    
    }

}
