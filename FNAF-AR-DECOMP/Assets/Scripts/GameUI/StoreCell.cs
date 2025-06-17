using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreCell : MonoBehaviour, ICellInterface<GameUI.StoreCellData>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI TitleText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image ItemIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI NumItemText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button BuyButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI PriceText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject FazTokensIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject PartsIcon;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject BadgeParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image BadgeImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI BadgeText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Store.StoreDomain _storeDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreCellData _storeCellData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Action<GameUI.StoreCell> CellDisabled;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Store.Data.StoreDisplayData Data { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Store.Data.StoreDisplayData get_Data()
        {
            if(this._storeCellData != null)
            {
                    return (Game.Store.Data.StoreDisplayData)this._storeCellData.displayData;
            }
            
            return (Game.Store.Data.StoreDisplayData)this._storeCellData.displayData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProcessCurrencyDisplay()
        {
            if(this.NumItemText == 0)
            {
                    return;
            }
            
            if((Game.Store.Data.StoreSectionMapper.GetTypeForString(typeString:  this._storeCellData.displayData.storeData.StoreSection)) != 2)
            {
                    return;
            }
            
            if((this.GetFazCoinsFromItems(items:  this._storeCellData.displayData.storeData.Items)) == null)
            {
                    return;
            }
            
            this.NumItemText.text = "x" + val_3.Quantity;
            this = this.NumItemText.gameObject;
            this.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.StoreDomain.Data.DataDefinitions.StoreItem GetFazCoinsFromItems(System.Collections.Generic.List<Game.StoreDomain.Data.DataDefinitions.StoreItem> items)
        {
            var val_5;
            var val_6;
            val_5 = 0;
            goto label_1;
            label_6:
            Game.StoreDomain.Data.DataDefinitions.StoreItem val_1 = items.Item[0];
            if((Game.Store.Data.StoreSectionMapper.GetTypeForString(typeString:  val_1.Type)) == 2)
            {
                    return (Game.StoreDomain.Data.DataDefinitions.StoreItem)items.Item[0];
            }
            
            val_5 = 1;
            label_1:
            if(val_5 < items.Count)
            {
                goto label_6;
            }
            
            val_6 = 0;
            return (Game.StoreDomain.Data.DataDefinitions.StoreItem)items.Item[0];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnCellClicked()
        {
            if(this._storeCellData == null)
            {
                    return;
            }
            
            this._storeCellData.OnClickedDelegate.Invoke(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            this._iconLookup = iconLookup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(GameUI.StoreCellData data)
        {
            this._storeCellData = data;
            this.UpdateDisplay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetSprite(UnityEngine.Sprite sprite)
        {
            this.ItemIcon.overrideSprite = sprite;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateDisplay()
        {
            this.TitleText.text = this._storeCellData.displayData.storeData.Name;
            this.PriceText.text = this._storeCellData.displayData.Price;
            this.UpdateBadge(data:  this._storeCellData.displayData);
            this.FazTokensIcon.SetActive(value:  (this._storeCellData.displayData.currency == 0) ? 1 : 0);
            this.PartsIcon.SetActive(value:  (this._storeCellData.displayData.currency == 1) ? 1 : 0);
            this.ProcessCurrencyDisplay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateBadge(Game.Store.Data.StoreDisplayData data)
        {
            UnityEngine.Object val_14;
            StoreCell.<>c__DisplayClass23_0 val_1 = new StoreCell.<>c__DisplayClass23_0();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .data = data;
            mem[1152921524750881488] = this;
            if(data != null)
            {
                goto label_19;
            }
            
            label_20:
            label_19:
            if((((System.String.IsNullOrEmpty(value:  data.storeData.BadgeArtRef)) == true) || (this.BadgeImage == 0)) || (this.BadgeParent == 0))
            {
                goto label_10;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            goto label_18;
            label_1:
            mem[16] = this;
            mem[24] = data;
            if(mem[24] != 0)
            {
                goto label_19;
            }
            
            goto label_20;
            label_18:
            this.BadgeImage.overrideSprite = this._iconLookup.GetIcon(group:  5, name:  data.storeData.BadgeArtRef);
            if(this.BadgeImage != null)
            {
                    val_14 = this.BadgeImage.overrideSprite;
            }
            else
            {
                    val_14 = 0;
            }
            
            UnityEngine.Object val_15 = 0;
            val_15 = UnityEngine.Object.op_Inequality(x:  val_14, y:  val_15);
            this.BadgeParent.SetActive(value:  val_15);
            label_10:
            if((System.String.IsNullOrEmpty(value:  data.storeData.BadgeLocRef)) == true)
            {
                    return;
            }
            
            if(this.BadgeText == 0)
            {
                    return;
            }
            
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void StoreCell.<>c__DisplayClass23_0::<UpdateBadge>b__0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Disable()
        {
            this.gameObject.SetActive(value:  false);
            if(this.CellDisabled == null)
            {
                    return;
            }
            
            this.CellDisabled.Invoke(obj:  this);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GetAudioEventName()
        {
            var val_8;
            if((System.String.op_Equality(a:  this._storeCellData.displayData.storeData.Name, b:  "Roll of Faz-Coins")) != false)
            {
                    val_8 = "UIStoreFazCoinRollTapped";
                return (string)((System.String.op_Equality(a:  this._storeCellData.displayData.storeData.Name, b:  "Truck of Faz-Coins")) != true) ? "UIStoreFazCoinTruckTapped" : "UIStoreNonFazCoinTapped";
            }
            
            if((System.String.op_Equality(a:  this._storeCellData.displayData.storeData.Name, b:  "Stack of Faz-Coins")) != false)
            {
                    val_8 = "UIStoreFazCoinStackTapped";
                return (string)((System.String.op_Equality(a:  this._storeCellData.displayData.storeData.Name, b:  "Truck of Faz-Coins")) != true) ? "UIStoreFazCoinTruckTapped" : "UIStoreNonFazCoinTapped";
            }
            
            if((System.String.op_Equality(a:  this._storeCellData.displayData.storeData.Name, b:  "Cup of Faz-Coins")) != false)
            {
                    val_8 = "UIStoreFazCoinCupTapped";
                return (string)((System.String.op_Equality(a:  this._storeCellData.displayData.storeData.Name, b:  "Truck of Faz-Coins")) != true) ? "UIStoreFazCoinTruckTapped" : "UIStoreNonFazCoinTapped";
            }
            
            if((System.String.op_Equality(a:  this._storeCellData.displayData.storeData.Name, b:  "Tub of Faz-Coins")) != false)
            {
                    val_8 = "UIStoreFazCoinTubTapped";
                return (string)((System.String.op_Equality(a:  this._storeCellData.displayData.storeData.Name, b:  "Truck of Faz-Coins")) != true) ? "UIStoreFazCoinTruckTapped" : "UIStoreNonFazCoinTapped";
            }
            
            if((System.String.op_Equality(a:  this._storeCellData.displayData.storeData.Name, b:  "Sack of Faz-Coins")) == false)
            {
                    return (string)((System.String.op_Equality(a:  this._storeCellData.displayData.storeData.Name, b:  "Truck of Faz-Coins")) != true) ? "UIStoreFazCoinTruckTapped" : "UIStoreNonFazCoinTapped";
            }
            
            val_8 = "UIStoreFazCoinSackTapped";
            return (string)((System.String.op_Equality(a:  this._storeCellData.displayData.storeData.Name, b:  "Truck of Faz-Coins")) != true) ? "UIStoreFazCoinTruckTapped" : "UIStoreNonFazCoinTapped";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.BuyButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void GameUI.StoreCell::OnCellClicked()));
            Master.MasterDomain val_3 = Master.MasterDomain.GetDomain();
            val_3.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.StoreCell::IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this.BuyButton.onClick.RemoveAllListeners();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreCell()
        {
        
        }
    
    }

}
