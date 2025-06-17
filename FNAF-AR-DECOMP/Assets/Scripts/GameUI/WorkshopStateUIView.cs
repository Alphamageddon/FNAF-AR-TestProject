using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopStateUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int WORN_OUT = 0;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int FULL_HEALTH = 100;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.SendSelectDialog sendSelectDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopStateUIActions workshopStateUIActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform buttonsParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopAnimatronicButton workshopAnimatronicButtonPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopAnimatronicButton_Locked workshopAnimatronicButton_LockedPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button modifyButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button deployButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button wearTearButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject conditionWordDisplay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI deployButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI availableText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI animatronicNameDisplay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI wearTearPercentText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _maxScavengers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotDataModel workshopSlotDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotButtonHandler workshopSlotButtonHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.IItemDefinitionDomain _itemDefinitionDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup _iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string recallButtonName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string deployButtonName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string brokenButtonName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string animatronicStatus_Recalling;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string animatronicStatus_Available;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string animatronicStatus_Scavenging;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string animatronicStatus_Delivering;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string animatronicStatus_Attacking;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string animatronicStatus_Broken;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaxScavengers { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_MaxScavengers()
        {
            return (int)this._maxScavengers;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddSubcriptions()
        {
            this._masterDomain.eventExposer.add_EntityAddedEvent(value:  new System.Action<EntityAddedRemovedArgs>(object:  this, method:  System.Void GameUI.WorkshopStateUIView::EventExposer_OnEntityAddedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)));
            this._masterDomain.eventExposer.add_EntityStateChangedEvent(value:  new System.Action<EntityStateChangedArgs>(object:  this, method:  System.Void GameUI.WorkshopStateUIView::EventExposer_OnEntityStateChangedEvent(AnimatronicEntity.StateChooser.EntityStateChangedArgs e)));
            this._masterDomain.MasterDataDomain.GetAccessToData.GetConfigDataEntryAsync(returnConfigDataEntryCallback:  new GetAccessToData.ReturnConfigDataEntry(object:  this, method:  System.Void GameUI.WorkshopStateUIView::OnConfigDataLoaded(ProtoData.CONFIG_DATA.Types.ENTRY configDataEntry)));
            this._masterDomain.ItemDefinitionDomain.GetInterfaceAsync(callback:  new System.Action<Game.ItemDefinition.IItemDefinitionDomain>(object:  this, method:  System.Void GameUI.WorkshopStateUIView::ItemDefinitionsReady(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)));
            this._masterDomain.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.WorkshopStateUIView::IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveSubcriptions()
        {
            if(this._masterDomain.eventExposer == null)
            {
                    return;
            }
            
            this._masterDomain.eventExposer.remove_EntityAddedEvent(value:  new System.Action<EntityAddedRemovedArgs>(object:  this, method:  System.Void GameUI.WorkshopStateUIView::EventExposer_OnEntityAddedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)));
            this._masterDomain.eventExposer.remove_EntityStateChangedEvent(value:  new System.Action<EntityStateChangedArgs>(object:  this, method:  System.Void GameUI.WorkshopStateUIView::EventExposer_OnEntityStateChangedEvent(AnimatronicEntity.StateChooser.EntityStateChangedArgs e)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_OnEntityAddedEvent(AnimatronicEntity.Container.EntityAddedRemovedArgs e)
        {
            this.UpdateScreenState();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_OnEntityStateChangedEvent(AnimatronicEntity.StateChooser.EntityStateChangedArgs e)
        {
            this.UpdateScreenState();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ItemDefinitionsReady(Game.ItemDefinition.IItemDefinitionDomain itemDefinitionDomain)
        {
            this._itemDefinitionDomain = itemDefinitionDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IconCacheReady(Game.AssetManagement.Icons.IIconLookup iconLookup)
        {
            this._iconLookup = iconLookup;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnConfigDataLoaded(ProtoData.CONFIG_DATA.Types.ENTRY configDataEntry)
        {
            System.Action val_10;
            if(this.workshopSlotButtonHandler != null)
            {
                    this.workshopSlotButtonHandler.OnDestroy();
            }
            
            this.workshopSlotButtonHandler = 0;
            this._maxScavengers = (int)configDataEntry.Scavenging.MaxDeployed;
            GameUI.WorkshopSlotButtonHandler val_5 = new GameUI.WorkshopSlotButtonHandler(masterDomain:  this._masterDomain, pfab:  this.workshopAnimatronicButtonPrefab, workshopAnimatronicButton_LockedPrefab:  this.workshopAnimatronicButton_LockedPrefab, pTransform:  this.buttonsParent, UISelectButton:  new System.Action<GameUI.IWorkshopSlotButton>(object:  this, method:  public System.Void GameUI.WorkshopStateUIView::SelectWarehouseButton(GameUI.IWorkshopSlotButton workshopAnimatronicButton)), UISelectLockedButton:  new System.Action<GameUI.IWorkshopSlotButton>(object:  this, method:  public System.Void GameUI.WorkshopStateUIView::SelectLockedWarehouseButton(GameUI.IWorkshopSlotButton workshopAnimatronicButton)));
            this.workshopSlotButtonHandler = val_5;
            val_5.GenerateAnimatronicButtons(datas:  this.workshopSlotDataModel.workshopSlotDatas);
            val_10 = System.Delegate.Combine(a:  this.workshopStateUIActions.EndoSkeletonPurchased, b:  new System.Action(object:  this.workshopSlotButtonHandler, method:  public System.Void GameUI.WorkshopSlotButtonHandler::PurchaseEndoskeleton()));
            if(this.workshopStateUIActions == null)
            {
                goto label_7;
            }
            
            if(val_10 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(val_10 == null)
            {
                goto label_11;
            }
            
            label_8:
            if(null != null)
            {
                    val_10 = 0;
            }
            
            label_11:
            this.workshopStateUIActions.EndoSkeletonPurchased = val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAnimatronicWearAndTearPanelText()
        {
            TMPro.TextMeshProUGUI val_9;
            string val_10;
            GameUI.WorkshopSlotData val_1 = this.workshopSlotDataModel.GetSelectedSlotData();
            this.conditionWordDisplay.SetActive(value:  (val_1 != 0) ? 1 : 0);
            if(val_1 != null)
            {
                    GameUI.Domain val_3 = this._masterDomain.gameUIDomain;
                AnimatronicEntity.Data.WorkshopEntry val_6 = val_3.gameUIData.emailUIDataHandler.GetSelectedSlotData().ServerEntry;
                val_9 = this.wearTearPercentText;
                val_10 = val_6.health.ToString() + "%"("%");
            }
            else
            {
                    val_9 = System.String.alignConst;
                val_10 = val_9;
            }
            
            this.wearTearPercentText.text = val_10;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAnimatronicSelectedNameDisplayText()
        {
            if(this.workshopSlotDataModel.GetSelectedSlotData() == null)
            {
                goto label_2;
            }
            
            Game.ItemDefinition.Data.DataDefinitions.EndoskeletonData val_3 = this.workshopSlotDataModel.GetSelectedSlotData().DisplayEndoskeleton;
            if(this.animatronicNameDisplay != null)
            {
                goto label_11;
            }
            
            label_12:
            label_11:
            this.animatronicNameDisplay.text = this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetPlushSuitById(id:  val_3.plushSuit).AnimatronicName;
            return;
            label_2:
            if(this.animatronicNameDisplay != null)
            {
                goto label_11;
            }
            
            goto label_12;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateActionButtons()
        {
            UnityEngine.UI.Button val_14;
            var val_15;
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            GameUI.WorkshopSlotData val_3 = val_1.gameUIData.emailUIDataHandler.GetSelectedSlotData();
            if(val_3 != null)
            {
                    AnimatronicEntity.Data.WorkshopEntry val_4 = val_3.ServerEntry;
                AnimatronicEntity.Data.WorkshopEntry val_5 = val_3.ServerEntry;
                AnimatronicEntity.Data.WorkshopEntry val_6 = val_3.ServerEntry;
                var val_8 = (val_6.status == 0) ? 1 : 0;
                bool val_11 = (val_4.health != 100) ? 1 : 0;
                this.modifyButton.interactable = val_8 & ((val_5.health != 0) ? 1 : 0);
                val_11 = val_11 & val_8;
                var val_12 = (this.workshopSlotDataModel.GetSelectedSlotDataStatus() != 3) ? 1 : 0;
                this.wearTearButton.interactable = val_11;
                val_14 = this.deployButton;
                val_12 = val_12 & ((val_5.health != 0) ? 1 : 0);
                val_15 = val_12;
            }
            else
            {
                    this.modifyButton.interactable = false;
                this.wearTearButton.interactable = false;
                val_14 = this.deployButton;
                val_15 = 0;
            }
            
            val_14.interactable = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateAvailableDisplayText()
        {
            string val_10;
            TMPro.TextMeshProUGUI val_11;
            string val_12;
            GameUI.WorkshopSlotData val_1 = this.workshopSlotDataModel.GetSelectedSlotData();
            if(val_1 != null)
            {
                    AnimatronicEntity.Data.WorkshopEntry val_2 = val_1.ServerEntry;
                if(val_2.status > 4)
            {
                    return;
            }
            
                var val_10 = 52949252 + (val_2.status) << 2;
                val_10 = val_10 + 52949252;
            }
            else
            {
                    val_10 = this.availableText;
                val_10.text = System.String.alignConst;
                val_11 = this.deployButtonText;
                val_12 = System.String.alignConst;
                text = ;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateScreenState()
        {
            this.UpdateActionButtons();
            this.UpdateAvailableDisplayText();
            this.UpdateAnimatronicSelectedNameDisplayText();
            this.UpdateAnimatronicWearAndTearPanelText();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CleanUpWorkshopSlotButtonHandler()
        {
            if(this.workshopSlotButtonHandler != null)
            {
                    this.workshopSlotButtonHandler.OnDestroy();
            }
            
            this.workshopSlotButtonHandler = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FetchTextLocalization()
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.WorkshopStateUIView::<FetchTextLocalization>b__45_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ReenableSendSelect()
        {
            this.sendSelectDialog.ReenableSendSelect();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SelectWarehouseButton(GameUI.IWorkshopSlotButton workshopAnimatronicButton)
        {
            if(this.workshopSlotButtonHandler == null)
            {
                    return;
            }
            
            this.workshopSlotButtonHandler.SelectWarehouseButton(workshopAnimatronicButton:  workshopAnimatronicButton);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SelectLockedWarehouseButton(GameUI.IWorkshopSlotButton workshopAnimatronicButton)
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            Game.Store.Data.StoreDisplayData val_2 = workshopAnimatronicButton.GetStoreDisplayData();
            if(val_2 == null)
            {
                    return;
            }
            
            UnityEngine.Sprite val_3 = this._masterDomain.StoreDomain.GetStoreIcon(iconName:  val_2.storeData.ArtRef);
            this.workshopStateUIActions.dialogHandler_Workshop.ShowPurchaseDialog(data:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetupSendSelectDialog(System.Action<string> SendSelectedSlotToUserId)
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            this.sendSelectDialog.SetupSendSelectDialog(masterDomain:  this._masterDomain, sendSelectedSlotToUserId:  SendSelectedSlotToUserId, profileAvatarConfigs:  val_1.profileAvatarConfigs);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
            this._masterDomain = val_1;
            GameUI.Domain val_2 = val_1.gameUIDomain;
            this.workshopSlotDataModel = val_2.gameUIData.emailUIDataHandler;
            this.AddSubcriptions();
            this.FetchTextLocalization();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.UpdateScreenState();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.UpdateScreenState();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this.RemoveSubcriptions();
            if(this.workshopSlotButtonHandler != null)
            {
                    this.workshopSlotButtonHandler.OnDestroy();
            }
            
            this.workshopSlotButtonHandler = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopStateUIView()
        {
            this.recallButtonName = "RECALL";
            this.deployButtonName = "DEPLOY";
            this.brokenButtonName = "BROKEN";
            this.animatronicStatus_Recalling = "Recalling";
            this.animatronicStatus_Available = "Available";
            this.animatronicStatus_Scavenging = "Scavenging";
            this.animatronicStatus_Delivering = "Delivering";
            this.animatronicStatus_Attacking = "Attacking";
            this.animatronicStatus_Broken = "Broken";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchTextLocalization>b__45_0(Game.Localization.ILocalization localization)
        {
            Game.Localization.LocalizationDomain val_1 = Game.Localization.LocalizationDomain.Instance;
            var val_28 = 0;
            val_28 = val_28 + 1;
            this.brokenButtonName = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_broken_button_text", originalString:  this.brokenButtonName);
            Game.Localization.LocalizationDomain val_4 = Game.Localization.LocalizationDomain.Instance;
            var val_29 = 0;
            val_29 = val_29 + 1;
            this.recallButtonName = val_4.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_recall_button_text", originalString:  this.recallButtonName);
            Game.Localization.LocalizationDomain val_7 = Game.Localization.LocalizationDomain.Instance;
            var val_30 = 0;
            val_30 = val_30 + 1;
            this.deployButtonName = val_7.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_deploy_button_text", originalString:  this.deployButtonName);
            Game.Localization.LocalizationDomain val_10 = Game.Localization.LocalizationDomain.Instance;
            var val_31 = 0;
            val_31 = val_31 + 1;
            this.animatronicStatus_Recalling = val_10.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_recalling_text", originalString:  this.animatronicStatus_Recalling);
            Game.Localization.LocalizationDomain val_13 = Game.Localization.LocalizationDomain.Instance;
            var val_32 = 0;
            val_32 = val_32 + 1;
            this.animatronicStatus_Available = val_13.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_available_text", originalString:  this.animatronicStatus_Available);
            Game.Localization.LocalizationDomain val_16 = Game.Localization.LocalizationDomain.Instance;
            var val_33 = 0;
            val_33 = val_33 + 1;
            this.animatronicStatus_Scavenging = val_16.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_scavenging_text", originalString:  this.animatronicStatus_Scavenging);
            Game.Localization.LocalizationDomain val_19 = Game.Localization.LocalizationDomain.Instance;
            var val_34 = 0;
            val_34 = val_34 + 1;
            this.animatronicStatus_Delivering = val_19.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_delivering_text", originalString:  this.animatronicStatus_Delivering);
            Game.Localization.LocalizationDomain val_22 = Game.Localization.LocalizationDomain.Instance;
            var val_35 = 0;
            val_35 = val_35 + 1;
            this.animatronicStatus_Attacking = val_22.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_attacking_text", originalString:  this.animatronicStatus_Attacking);
            Game.Localization.LocalizationDomain val_25 = Game.Localization.LocalizationDomain.Instance;
            var val_36 = 0;
            val_36 = val_36 + 1;
            this.animatronicStatus_Broken = val_25.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_broken_text", originalString:  this.animatronicStatus_Broken);
        }
    
    }

}
