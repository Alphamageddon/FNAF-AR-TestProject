using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class WorkshopModifyStateUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_WorkshopModify _dialogHandler_WorkshopModify;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopModifyStateUIActions _workshopModifyStateUIActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.PlushSuitCell _plushSuitCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.CPUCell _cpuCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ModCell _modCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _plushSuitCellParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _cpuCellParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform _modCellParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _noModsLabel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.UI.Button> _modSelectionButtons;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> _modSelectionButtonsLockedIcons;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<TMPro.TextMeshProUGUI> _modUnlockTexts;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _modSlotNumberDisplayText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.UI.Image> _modButtonImages;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> _modButtonActiveImages;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> _modButtonEmptyImages;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _modsAvailableCountText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _modsTotalCountText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> _assembleTabs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image _plushSuitButtonImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Image _cpuButtonImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Slider _essenceSlider;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _essenceSlotTotalDisplayText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _essenceTotalText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _sliderValueText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _essenceCurrentText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button _addButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _topBarAnimatronicNameText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _topBarAnimatronicStatusText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotDataModel _workshopSlotDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.PlushSuitSelectionHandler _plushSuitSelectionHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.CPUSelectionHandler _cpuSelectionHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ModSelectionHandler _modSelectionHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.EssenceSliderData _essenceSliderData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.EssenceSliderHandler _essenceSliderHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.AssembleButtonsHandler _assembleButtonsHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ModifyTabHandler _tabHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string animatronicStatus_Recalling;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string animatronicStatus_Available;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string animatronicStatus_Unavailable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string animatronicStatus_Scavenging;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string animatronicStatus_Delivering;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string animatronicStatus_Attacking;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string animatronicStatus_Broken;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string mod1String;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string mod2String;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string mod3String;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string mod4String;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateTopBarDisplay()
        {
            string val_9;
            Game.ItemDefinition.Data.DataDefinitions.PlushSuitData val_2 = this._masterDomain.ItemDefinitionDomain.ItemDefinitions.GetPlushSuitById(id:  this._workshopSlotDataModel.selectedWorkshopSlotData.<ClientEndoskeleton>k__BackingField.plushSuit);
            if(val_2 != null)
            {
                    val_9 = val_2.AnimatronicName;
            }
            else
            {
                    val_9 = 0;
            }
            
            this._topBarAnimatronicNameText.text = val_9;
            if((this._workshopSlotDataModel.selectedWorkshopSlotData.<ServerEntry>k__BackingField.status) > 4)
            {
                    return;
            }
            
            var val_9 = 52946048 + (this._workshopSlotDataModel.selectedWorkshopSlotData.<ServerEntry>k__BackingField.status) << 2;
            val_9 = val_9 + 52946048;
            goto (52946048 + (this._workshopSlotDataModel.selectedWorkshopSlotData.<ServerEntry>k__BackingField.status) << 2 + 52946048);
            label_27:
            do
            {
                text = ;
                return;
            }
            while( != null);
            
            goto label_27;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FetchTextLocalization()
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.WorkshopModifyStateUIView::<FetchTextLocalization>b__50_0(Game.Localization.ILocalization localization)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void BuildData()
        {
            TMPro.TextMeshProUGUI val_4;
            GameUI.EssenceSliderData val_1 = new GameUI.EssenceSliderData();
            if(val_1 != null)
            {
                    .masterDomain = this._masterDomain;
                .essenceTotalText = this._essenceTotalText;
                .essenceSlider = this._essenceSlider;
                .sliderValueText = this._sliderValueText;
                val_4 = this._essenceCurrentText;
            }
            else
            {
                    mem[16] = this._masterDomain;
                mem[32] = this._essenceTotalText;
                mem[48] = this._essenceSlider;
                mem[40] = this._sliderValueText;
                val_4 = this._essenceCurrentText;
            }
            
            .essenceCurrentText = val_4;
            GameUI.Domain val_2 = this._masterDomain.gameUIDomain;
            .workshopSlotDataModel = val_2.gameUIData.emailUIDataHandler;
            .addButton = this._addButton;
            this._essenceSliderData = val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateModDropDownModDisplayNumber(int index)
        {
            if(index > 3)
            {
                    return;
            }
            
            var val_1 = 52946068 + (index) << 2;
            val_1 = val_1 + 52946068;
            goto (52946068 + (index) << 2 + 52946068);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SaveEndoskeletonConfigToServer()
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            GameUI.EmailUIDataHandler val_2 = val_1.gameUIData.emailUIDataHandler;
            if(val_2._serverGameUIDataModel._masterDomain == null)
            {
                    return;
            }
            
            mem2[0] = 1;
            this._masterDomain.serverDomain.endoskeletonConfigRequester.SetEndoskeletonConfig(slot:  val_2._emailDatas, endoskeleton:  val_2._serverGameUIDataModel.<modSlotUnlocks>k__BackingField);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowTab(GameUI.ModifyTabType tab)
        {
            if(tab == 2)
            {
                goto label_0;
            }
            
            if(tab == 1)
            {
                goto label_1;
            }
            
            if(tab != 0)
            {
                goto label_4;
            }
            
            this.PopulatePlushSuitSelection();
            goto label_4;
            label_0:
            this.InitializeEssenceSelection();
            goto label_4;
            label_1:
            this.PopulateCPUSelection();
            label_4:
            this._tabHandler.ShowTab(modifyTabType:  tab);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PopulatePlushSuitSelection()
        {
            this._plushSuitSelectionHandler.GeneratePlushSuitSelectionCells();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowMoreInfoCPU()
        {
            this._dialogHandler_WorkshopModify.ShowMoreInfoCPUDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowMoreInfoPlush()
        {
            this._dialogHandler_WorkshopModify.ShowMoreInfoPlushDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowMoreInfoRemnant()
        {
            this._dialogHandler_WorkshopModify.ShowMoreInfoRemnantDialog();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PopulateCPUSelection()
        {
            this._cpuSelectionHandler.GenerateCPUSelectionCells();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SellMod(GameUI.Actions.GatherModsForEquipping.ModContext modContext)
        {
            this._modSelectionHandler.SellModAndUpdateLocalData(modContext:  modContext);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void PopulateModSelection(int index)
        {
            this.UpdateModDropDownModDisplayNumber(index:  index);
            this._modSelectionHandler.SetSelectedModIndex(selectedModIndex:  index);
            this.ShowTab(tab:  3);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEssenceValueFromSlider()
        {
            this._essenceSliderHandler.SetEssenceValueFromSliderValue();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowSellModDialog(GameUI.ModCell modCell, System.Action<GameUI.ModCell> ConfirmSellMod)
        {
            this._dialogHandler_WorkshopModify.ShowSellModDialog(modCell:  modCell, ConfirmSellMod:  ConfirmSellMod);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void InitializeEssenceSelection()
        {
            this._essenceSliderHandler.InitializeSliderDisplay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsModSlotUnlocked(int index)
        {
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            return (bool)((val_1.gameUIData.<rewardDataModel>k__BackingField) > index) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
            this.BuildData();
            GameUI.Domain val_2 = this._masterDomain.gameUIDomain;
            this._workshopSlotDataModel = val_2.gameUIData.emailUIDataHandler;
            this._plushSuitSelectionHandler = new GameUI.PlushSuitSelectionHandler(masterDomain:  this._masterDomain, plushSuitCellPrefab:  this._plushSuitCellPrefab, plushSuitCellParent:  this._plushSuitCellParent);
            this._cpuSelectionHandler = new GameUI.CPUSelectionHandler(masterDomain:  this._masterDomain, cpuCellPrefab:  this._cpuCellPrefab, cpuCellParent:  this._cpuCellParent);
            this._modSelectionHandler = new GameUI.ModSelectionHandler(masterDomain:  this._masterDomain, cellPrefab:  this._modCellPrefab, plushSuitCellParent:  this._modCellParent, SellDialog:  new System.Action<GameUI.ModCell>(object:  this._workshopModifyStateUIActions, method:  System.Void GameUI.WorkshopModifyStateUIActions::DisplaySellMod(GameUI.ModCell modCell)), InvalidModCategoryDialog:  new System.Action(object:  this._dialogHandler_WorkshopModify, method:  public System.Void GameUI.DialogHandler_WorkshopModify::ShowInvalidModCategory()), noModsLabel:  this._noModsLabel, modCountText:  this._modsAvailableCountText, modsTotalCountText:  this._modsTotalCountText);
            this._essenceSliderHandler = new GameUI.EssenceSliderHandler(essenceSliderData:  this._essenceSliderData);
            this._assembleButtonsHandler = new GameUI.AssembleButtonsHandler(masterDomain:  this._masterDomain, workshopSlotDataModel:  this._workshopSlotDataModel, plushSuitButtonImage:  this._plushSuitButtonImage, cpuButtonImage:  this._cpuButtonImage, modSelectionButtons:  this._modSelectionButtons, modButtonActiveImages:  this._modButtonActiveImages, modButtonImages:  this._modButtonImages, modSelectionButtons_Highlight:  this._modSelectionButtonsLockedIcons, essenceSlotTotalDisplayText:  this._essenceSlotTotalDisplayText, modUnlockTexts:  this._modUnlockTexts, modButtonEmptyImages:  this._modButtonEmptyImages);
            this._tabHandler = new GameUI.ModifyTabHandler(masterDomain:  this._masterDomain, assembleTabs:  this._assembleTabs);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.FetchTextLocalization();
            this._masterDomain.gameUIDomain.WorkshopStage.SetWorkshopModifyCamPos();
            this._masterDomain.gameUIDomain.WorkshopStage.ResetCameraRotation();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.UpdateTopBarDisplay();
            this._essenceSliderHandler.Update();
            this._plushSuitSelectionHandler.Update();
            this._assembleButtonsHandler.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this._masterDomain.gameUIDomain.WorkshopStage.SetWorkshopCamPos();
            this._masterDomain.gameUIDomain.WorkshopStage.ResetCameraRotation();
            this._modSelectionHandler.TearDown();
            this._tabHandler.OnDisable();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            this.SaveEndoskeletonConfigToServer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnApplicationPause(bool pauseStatus)
        {
            if(pauseStatus == false)
            {
                    return;
            }
            
            this.SaveEndoskeletonConfigToServer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnApplicationFocus(bool hasFocus)
        {
            if(hasFocus != false)
            {
                    return;
            }
            
            this.SaveEndoskeletonConfigToServer();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public WorkshopModifyStateUIView()
        {
            this.animatronicStatus_Recalling = "Recalling";
            this.animatronicStatus_Available = "Available";
            this.animatronicStatus_Unavailable = "Unavailable";
            this.animatronicStatus_Scavenging = "Scavenging";
            this.animatronicStatus_Delivering = "Delivering";
            this.animatronicStatus_Attacking = "Attacking";
            this.animatronicStatus_Broken = "Broken";
            this.mod1String = "MOD 1";
            this.mod2String = "MOD 2";
            this.mod3String = "MOD 3";
            this.mod4String = "MOD 4";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <FetchTextLocalization>b__50_0(Game.Localization.ILocalization localization)
        {
            Game.Localization.LocalizationDomain val_1 = Game.Localization.LocalizationDomain.Instance;
            var val_30 = 0;
            val_30 = val_30 + 1;
            this.animatronicStatus_Recalling = val_1.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_recalling_text", originalString:  this.animatronicStatus_Recalling);
            Game.Localization.LocalizationDomain val_4 = Game.Localization.LocalizationDomain.Instance;
            var val_31 = 0;
            val_31 = val_31 + 1;
            this.animatronicStatus_Available = val_4.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_available_text", originalString:  this.animatronicStatus_Available);
            Game.Localization.LocalizationDomain val_7 = Game.Localization.LocalizationDomain.Instance;
            var val_32 = 0;
            val_32 = val_32 + 1;
            this.animatronicStatus_Unavailable = val_7.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_unavailable_text", originalString:  this.animatronicStatus_Unavailable);
            Game.Localization.LocalizationDomain val_10 = Game.Localization.LocalizationDomain.Instance;
            var val_33 = 0;
            val_33 = val_33 + 1;
            this.animatronicStatus_Scavenging = val_10.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_scavenging_text", originalString:  this.animatronicStatus_Scavenging);
            Game.Localization.LocalizationDomain val_13 = Game.Localization.LocalizationDomain.Instance;
            var val_34 = 0;
            val_34 = val_34 + 1;
            this.animatronicStatus_Delivering = val_13.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_delivering_text", originalString:  this.animatronicStatus_Delivering);
            Game.Localization.LocalizationDomain val_16 = Game.Localization.LocalizationDomain.Instance;
            var val_35 = 0;
            val_35 = val_35 + 1;
            this.animatronicStatus_Attacking = val_16.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_attacking_text", originalString:  this.animatronicStatus_Attacking);
            Game.Localization.LocalizationDomain val_19 = Game.Localization.LocalizationDomain.Instance;
            var val_36 = 0;
            val_36 = val_36 + 1;
            this.animatronicStatus_Broken = val_19.ILocalization.GetLocalizedString(localizedStringId:  "ui_workshop_main_page_interface_status_broken_text", originalString:  this.animatronicStatus_Broken);
            var val_37 = 0;
            val_37 = val_37 + 1;
            this.mod1String = localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_label_mod1", originalString:  this.mod1String);
            var val_38 = 0;
            val_38 = val_38 + 1;
            this.mod2String = localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_label_mod2", originalString:  this.mod2String);
            var val_39 = 0;
            val_39 = val_39 + 1;
            this.mod3String = localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_label_mod3", originalString:  this.mod3String);
            var val_40 = 0;
            val_40 = val_40 + 1;
            this.mod4String = localization.GetLocalizedString(localizedStringId:  "ui_workshop_modify_label_mod4", originalString:  this.mod4String);
        }
    
    }

}
